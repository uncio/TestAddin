using Autodesk.Revit.DB;
using SampleProject.Properties;
using SampleProject.RevitLogic.Extensions;
using SampleProject.RevitLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.RevitLogic.Utils
{
    internal class OverridesUtils
    {
        public static SPOverrides GetOverridesProperties(View view, Element element)
        {
            var result = new SPOverrides();
            OverrideGraphicSettings overrides = null;
            var document = view.Document;

            //default value
            result.LinePatternName = string.Empty;
            result.HexIndexLines = string.Empty;
            result.ThicknessLines = -1;
            result.FillPatternName = string.Empty;
            result.HexIndexFill = string.Empty;
            result.FillVisibility = false;

            //top level - element override
            try
            {
                overrides = view.GetElementOverrides(element.Id);
            }
            catch
            {
            }

            var isFirst = true;
            if (overrides != null)
            {
                overrides.GetOverridesProperties(document, result, isFirst);
                isFirst = !result.IsElementOverwritten;
                overrides = null;
            }
            var elementColorOverride = result.HexIndexLines;

            // top level - filter overrides (higher level is element override (not in scope of the legenden tool, maybe to add to make more generic))
            List<ElementId> filters = view.GetOrderedFilters().ToList();
            //filters.Reverse();
            ParameterFilterElement currentFilter = null;

            foreach (ElementId filterId in filters)
            {
                try
                {
                    ParameterFilterElement filter = document.GetElement(filterId) as ParameterFilterElement;

                    if (!filter.GetCategories().Contains(element.Category.Id))
                    {
                        continue;
                    }
                    var filterCurrent = filter.GetElementFilter();
                    if (filterCurrent == null)
                    {
                        currentFilter = filter;
                        break;
                    }
                    var filterResult = (filterCurrent as ElementLogicalFilter).PassesFilter(element);

                    if (filterResult)
                    {
                        currentFilter = filter;
                        break;
                    }
                }
                catch
                {
                    //TODO: to add some feedback
                }
            }

            if (currentFilter != null && view.IsFilterApplied(currentFilter.Id))
            {
                overrides = view.GetFilterOverrides(currentFilter.Id);
            }

            if (overrides != null)
            {
                overrides.GetOverridesProperties(document, result, isFirst);

                if (String.IsNullOrEmpty(result.HexIndexFill))
                {
                    if (!String.IsNullOrEmpty(elementColorOverride))
                    {
                        result.HexIndexFill = elementColorOverride;
                    }
                    else if (result.HexIndexLines != "000000")
                    {
                        result.HexIndexFill = result.HexIndexLines;
                    }
                }

                isFirst = !result.IsElementOverwritten;
                overrides = null;
            }

            //phasing
            if (!result.IsElementOverwritten)
            {
                try
                {
                    var viewPhaseId = view.get_Parameter(BuiltInParameter.VIEW_PHASE).AsElementId();
                    var viewPhaseFilterId = view.get_Parameter(BuiltInParameter.VIEW_PHASE_FILTER).AsElementId();
                    var phaseFilter = document.GetElement(viewPhaseFilterId) as PhaseFilter;

                    var phaseStatus = element.GetPhaseStatus(viewPhaseId);
                    if (phaseStatus != ElementOnPhaseStatus.None)
                    {
                        var statusPresentation = phaseFilter.GetPhaseStatusPresentation(phaseStatus);

                        if (statusPresentation == PhaseStatusPresentation.ShowOverriden)
                        {
                            result.PhaseOverwritten = true;
                            result.PhaseOverride = phaseStatus.ToString();
                        }
                    }

                    if (result.IsElementOverwritten)
                        return result;
                }
                catch (Exception ex)
                {

                }
            }

            if (element is MEPCurve)
            {
                var mepSystem = (element as MEPCurve).MEPSystem;

                if (mepSystem != null)
                {
                    var mepSystemType = document.GetElement(mepSystem.GetTypeId()) as MEPSystemType;

                    //medium level - material override
                    var materialId = mepSystemType.get_Parameter(BuiltInParameter.MATERIAL_ID_PARAM)?.AsElementId();

                    if (materialId != null && materialId != ElementId.InvalidElementId
                        && (view.get_Parameter(BuiltInParameter.MODEL_GRAPHICS_STYLE).AsInteger() == 4
                            || view.get_Parameter(BuiltInParameter.MODEL_GRAPHICS_STYLE).AsInteger() == 7))
                    {
                        var material = document.GetElement(materialId) as Material;

                        if (isFirst || string.IsNullOrEmpty(result.HexIndexFill))
                        {
                            var color = material.Color;

                            if (color != Autodesk.Revit.DB.Color.InvalidColorValue)
                            {
                                result.HexIndexFill = color.GetHex();
                                result.IsElementOverwritten = true;
                            }

                            if (isFirst || result.Transparency == 0)
                            {
                                result.Transparency = material.Transparency;
                                if (result.Transparency != 0)
                                    result.IsElementOverwritten = true;
                            }
                        }

                        isFirst = !result.IsElementOverwritten;
                    }

                    // medium level - mechanical/plumbing system type override
                    if ((isFirst || string.IsNullOrEmpty(result.LinePatternName)) && mepSystemType.LinePatternId != ElementId.InvalidElementId)
                    {
                        if (mepSystemType.LinePatternId.IntegerValue > 0)
                        {
                            result.LinePatternName = document.GetElement(mepSystemType.LinePatternId).Name;
                            result.IsElementOverwritten = true;
                        }
                    }

                    if (isFirst || string.IsNullOrEmpty(result.HexIndexLines))
                    {
                        var color = mepSystemType.LineColor;

                        if (color.IsValid && color != Autodesk.Revit.DB.Color.InvalidColorValue)
                        {
                            result.HexIndexLines = color.GetHex();
                            result.IsElementOverwritten = true;
                        }
                    }

                    if (result.ThicknessLines == -1)
                    {
                        result.ThicknessLines = mepSystemType.LineWeight;
                        result.IsElementOverwritten = true;
                    }
                }
            }

            //next level - category override
            try
            {
                overrides = view.GetCategoryOverrides(element.Category.Id);
            }
            catch
            {
            }

            if (overrides != null)
            {
                overrides.GetOverridesProperties(document, result, isFirst);
                isFirst = !result.IsElementOverwritten;
            }

            //next level - objectStyle override
            view.GetObjectStyleOverrides(element, result, isFirst);

            if (string.IsNullOrEmpty(result.HexIndexLines))
            {
                result.HexIndexLines = "000000";
            }

            if (result.ThicknessLines == -1)
            {
                result.ThicknessLines = 1;
            }

            if (string.IsNullOrEmpty(result.HexIndexFill))
            {
                if (view.get_Parameter(BuiltInParameter.MODEL_GRAPHICS_STYLE).AsInteger() == 4
                            || view.get_Parameter(BuiltInParameter.MODEL_GRAPHICS_STYLE).AsInteger() == 7)
                {
                    result.HexIndexFill = "7F7F7F";
                }
                else
                {
                    result.HexIndexFill = "FFFFFF";
                }
            }

            if (result.FillPatternName == Resources.SolidFillName || String.IsNullOrEmpty(result.FillPatternName))
            {
                result.FillPatternName = "Solid";
            }

            return result;
        }




    }
}

using Autodesk.Revit.DB;
using SampleProject.RevitLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.RevitLogic.Extensions
{
    internal static class OverridesExtensions
    {
        public static void GetObjectStyleOverrides(this View view, Element element, SPOverrides result, bool isFirst = false)
        {
            var document = view.Document;
            var graphCategory = element.Category;

            var lineColor = graphCategory.LineColor;
            var lineWeight = graphCategory.GetLineWeight(GraphicsStyleType.Projection);
            var linePatternId = graphCategory.GetLinePatternId(GraphicsStyleType.Projection);

            if ((isFirst || string.IsNullOrEmpty(result.LinePatternName)) && linePatternId != ElementId.InvalidElementId
                && linePatternId.IntegerValue > 0)
            {
                result.LinePatternName = document.GetElement(linePatternId).Name;
                if (isFirst == true)
                    result.IsElementOverwritten = true;
            }

            if (isFirst || string.IsNullOrEmpty(result.HexIndexLines))
            {
                if (lineColor.IsValid && lineColor != Autodesk.Revit.DB.Color.InvalidColorValue)
                {
                    result.HexIndexLines = lineColor.GetHex();
                    if (isFirst == true)
                        result.IsElementOverwritten = true;
                }
            }

            if (isFirst || result.ThicknessLines == -1)
            {
                if (lineWeight != null)
                    result.ThicknessLines = (int)lineWeight;
                if (isFirst == true)
                    result.IsElementOverwritten = true;
            }
        }

        public static string GetHex
            (
                this Autodesk.Revit.DB.Color color
            )
        {
            var result = string.Empty;

            try
            {
                result = string.Format
                    (
                     "{0:X2}{1:X2}{2:X2}",
                     color.Red,
                     color.Green,
                     color.Blue
                    );
            }
            catch
            {
            }

            return result;
        }

        public static void GetOverridesProperties(this OverrideGraphicSettings overrides,
                            Document document,
                            SPOverrides result,
                            bool isFirst = false)
        {
            if ((isFirst || string.IsNullOrEmpty(result.LinePatternName)) && overrides.ProjectionLinePatternId != ElementId.InvalidElementId
                && overrides.ProjectionLinePatternId.IntegerValue > 0)
            {
                result.LinePatternName = document.GetElement(overrides.ProjectionLinePatternId).Name;
                //if (isFirst == true)
                result.IsElementOverwritten = true;
            }

            if (isFirst || string.IsNullOrEmpty(result.HexIndexLines))
            {
                var color = overrides.ProjectionLineColor;

                if (color.IsValid && color != Autodesk.Revit.DB.Color.InvalidColorValue)
                {
                    result.HexIndexLines = color.GetHex();
                    //if (isFirst == true)
                    result.IsElementOverwritten = true;
                }
            }

            if (isFirst || result.ThicknessLines == -1)
            {
                result.ThicknessLines = overrides.ProjectionLineWeight;
                if (/*isFirst == true &&*/ overrides.ProjectionLineWeight != -1)
                    result.IsElementOverwritten = true;
            }


            if ((isFirst || string.IsNullOrEmpty(result.FillPatternName)) && overrides.SurfaceForegroundPatternId != ElementId.InvalidElementId)
            {
                result.FillPatternName = document.GetElement(overrides.SurfaceForegroundPatternId).Name;
                //if (isFirst == true) 
                result.IsElementOverwritten = true;
            }

            if (isFirst || string.IsNullOrEmpty(result.HexIndexFill))
            {
                var color = overrides.SurfaceForegroundPatternColor;

                if (color != Autodesk.Revit.DB.Color.InvalidColorValue)
                {
                    result.HexIndexFill = color.GetHex();
                    //if (isFirst == true)
                    result.IsElementOverwritten = true;
                }
            }

            if (isFirst || !result.FillVisibility)
            {
                result.FillVisibility = overrides.IsSurfaceForegroundPatternVisible;
                if (!result.FillVisibility)
                    result.IsElementOverwritten = true;
            }

            if (isFirst || result.Transparency == 0)
            {
                if (result.Transparency == 0 && overrides.Transparency != 0)
                {
                    result.Transparency = overrides.Transparency;
                    result.IsElementOverwritten = true;
                }
            }

            if (isFirst || !result.Halftone)
            {
                result.Halftone = overrides.Halftone;
                if (overrides.Halftone)
                    result.IsElementOverwritten = true;
            }
        }
    }
}

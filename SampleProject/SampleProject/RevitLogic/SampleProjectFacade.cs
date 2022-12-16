using Autodesk.Revit.UI;
using SampleProject.RevitLogic.Models;
using SampleProject.RevitLogic.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.RevitLogic
{
    internal class SampleProjectFacade
    {
        private readonly UIApplication uiApplication;

        public SampleProjectFacade(UIApplication uiApplication)
        {
            this.uiApplication = uiApplication;
        }

        public SPOverrides SelectElementAndReadOverrides()
        {
            SPOverrides result = null;

            try
            {
                var element = SelectionUtils.GetElement(uiApplication);
                result = OverridesUtils.GetOverridesProperties(uiApplication.ActiveUIDocument.ActiveView, element);
            }
            catch (Autodesk.Revit.Exceptions.OperationCanceledException)
            {
            }
            catch
            {
            }

            return result;
        }
    }
}

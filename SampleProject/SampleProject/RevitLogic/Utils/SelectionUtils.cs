using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.RevitLogic.Utils
{
    internal class SelectionUtils
    {
        public static Element GetElement(UIApplication uIApplication)
        {
            var reference = uIApplication.ActiveUIDocument.Selection.PickObject(Autodesk.Revit.UI.Selection.ObjectType.Element);

            return uIApplication.ActiveUIDocument.Document.GetElement(reference.ElementId);
        }
    }
}

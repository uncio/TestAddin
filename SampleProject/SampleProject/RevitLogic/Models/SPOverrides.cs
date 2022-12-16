using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.RevitLogic.Models
{
    internal class SPOverrides
    {
        public string LinePatternName { get; set; }
        public string HexIndexLines { get; set; }
        public int ThicknessLines { get; set; }
        public string FillPatternName { get; set; }
        public string HexIndexFill { get; set; }
        public bool FillVisibility { get; set; }
        public int Transparency { get; set; }
        public bool IsElementOverwritten { get; set; }
        public bool Halftone { get; set; } = false;

        public bool PhaseOverwritten { get; set; } = false;
        public string PhaseOverride { get; set; }

        public SPOverrides()
        {
        }
    }
}

using SampleProject.Properties;
using SampleProject.RevitLogic.Models;
using System.Windows.Media;

namespace SampleProject.ViewModels.Models
{
    internal class SPOverridesVM: BaseVM
    {
        private string linePatternName;
        public string LinePatternName
        {
            get
            {
                return linePatternName;
            }
            set
            {
                linePatternName = value;
                OnPropertyChanged();
            }
        }

        private Color linesColor;
        public Color LinesColor
        {
            get
            {
                return linesColor;
            }
            set
            {
                linesColor = value;
                OnPropertyChanged();
            }
        }

        private int thicknessLines;
        public int ThicknessLines
        {
            get
            {
                return thicknessLines;
            }
            set
            {
                thicknessLines = value;
                OnPropertyChanged();
            }
        }

        private string fillPatternName;
        public string FillPatternName
        {
            get
            {
                return fillPatternName;
            }
            set
            {
                fillPatternName = value;
                OnPropertyChanged();
            }
        }

        private Color fillPatternColor;
        public Color FillPatternColor
        {
            get
            {
                return fillPatternColor;
            }
            set
            {
                fillPatternColor = value;
                OnPropertyChanged();
            }
        }

        private string fillVisibility;
        public string FillVisibility
        {
            get
            {
                return fillVisibility;
            }
            set
            {
                fillVisibility = value;
                OnPropertyChanged();
            }
        }

        private int transparency;
        public int Transparency
        {
            get
            {
                return transparency;
            }
            set
            {
                transparency = value;
                OnPropertyChanged();
            }
        }

        private string halftone;
        public string Halftone
        {
            get
            {
                return halftone;
            }
            set
            {
                halftone = value;
                OnPropertyChanged();
            }
        }

        public bool PhaseOverwritten { get; set; } = false;
        public string PhaseOverride { get; set; }

        public void AssignOverrides(SPOverrides sPOverrides)
        {
            LinePatternName = sPOverrides.LinePatternName;
            LinesColor = (Color)ColorConverter.ConvertFromString("#" + sPOverrides.HexIndexLines);
            ThicknessLines = sPOverrides.ThicknessLines;
            FillPatternName = sPOverrides.FillPatternName;
            FillPatternColor = (Color)ColorConverter.ConvertFromString("#" + sPOverrides.HexIndexFill);
            FillVisibility = sPOverrides.FillVisibility? Resources.Yes : Resources.No;
            Transparency = sPOverrides.Transparency;
            Halftone = sPOverrides.Halftone? Resources.Yes : Resources.No;
        }
    }
}

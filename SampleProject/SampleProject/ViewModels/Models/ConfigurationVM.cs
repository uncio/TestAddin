using SampleProject.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.ViewModels.Models
{
    internal class ConfigurationVM: BaseVM
    {
        private bool fillPatternNameChecked = Settings.Default.FillPatternName;
        public bool FillPatternNameChecked
        {
            get
            {
                return fillPatternNameChecked;
            }
            set
            {
                fillPatternNameChecked = value;
                Settings.Default.FillPatternName = value;
                Settings.Default.Save();
                OnPropertyChanged();
            }
        }

        private bool fillPatternColorChecked = Settings.Default.FillPatternColor;
        public bool FillPatternColorChecked
        {
            get
            {
                return fillPatternColorChecked;
            }
            set
            {
                fillPatternColorChecked = value;
                Settings.Default.FillPatternColor = value;
                Settings.Default.Save();
                OnPropertyChanged();
            }
        }

        private bool fillPatternVisibilityChecked = Settings.Default.FillPatternVisibility;
        public bool FillPatternVisibilityChecked
        {
            get
            {
                return fillPatternVisibilityChecked;
            }
            set
            {
                fillPatternVisibilityChecked = value;
                Settings.Default.FillPatternVisibility = value;
                Settings.Default.Save();
                OnPropertyChanged();
            }
        }

        private bool linePatternNameChecked = Settings.Default.LinePatternName;
        public bool LinePatternNameChecked
        {
            get
            {
                return linePatternNameChecked;
            }
            set
            {
                linePatternNameChecked = value;
                Settings.Default.LinePatternName = value;
                Settings.Default.Save();
                OnPropertyChanged();
            }
        }

        private bool linePatternColorChecked = Settings.Default.LinePatternColor;
        public bool LinePatternColorChecked
        {
            get
            {
                return linePatternColorChecked;
            }
            set
            {
                linePatternColorChecked = value;
                Settings.Default.LinePatternColor = value;
                Settings.Default.Save();
                OnPropertyChanged();
            }
        }

        private bool lineThicknessChecked = Settings.Default.LinePatternThickness;
        public bool LineThicknessChecked
        {
            get
            {
                return lineThicknessChecked;
            }
            set
            {
                lineThicknessChecked = value;
                Settings.Default.LinePatternThickness = value;
                Settings.Default.Save();
                OnPropertyChanged();
            }
        }

        private bool isHalftoneChecked = Settings.Default.Halftone;
        public bool IsHalftoneChecked
        {
            get
            {
                return isHalftoneChecked;
            }
            set
            {
                isHalftoneChecked = value;
                Settings.Default.Halftone = value;
                Settings.Default.Save();
                OnPropertyChanged();
            }
        }

        private bool transparencyChecked = Settings.Default.Transparency;
        public bool TransparencyChecked
        {
            get
            {
                return transparencyChecked;
            }
            set
            {
                transparencyChecked = value;
                Settings.Default.Transparency = value;
                Settings.Default.Save();
                OnPropertyChanged();
            }
        }


    }
}

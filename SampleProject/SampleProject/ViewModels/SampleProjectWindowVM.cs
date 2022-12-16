using Autodesk.Revit.UI;
using SampleProject.RevitLogic.Services;
using SampleProject.ViewModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject.ViewModels
{
    internal class SampleProjectWindowVM: BaseVM
    {
        private readonly UIApplication uIApplication;

        public SettingsPageVM SettingsPageVM { get; set; }
        public ResultsPageVM ResultsPageVM { get; set; }

        private ConfigurationVM configuration = new ConfigurationVM();
        private SPOverridesVM spOverridesVM = new SPOverridesVM();

        public SampleProjectWindowVM(UIApplication uIApplication)
        {
            this.uIApplication = uIApplication;

            SettingsPageVM = new SettingsPageVM(uIApplication, spOverridesVM, configuration);
            ResultsPageVM = new ResultsPageVM(uIApplication, spOverridesVM, configuration);
        }
    }
}

using Autodesk.Revit.UI;
using SampleProject.Properties;
using SampleProject.RevitLogic;
using SampleProject.RevitLogic.Models;
using SampleProject.ViewModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleProject.ViewModels
{
    internal class SettingsPageVM: BaseVM
    {
        private readonly UIApplication uIApplication;
        private SPOverridesVM spOverridesVM;

        public ConfigurationVM Configuration { get; set; }

        public ICommand SelectElementCommand { get; set; }

        public SettingsPageVM(UIApplication uIApplication, SPOverridesVM sPOverridesVM, ConfigurationVM configuration)
        {
            this.uIApplication = uIApplication;
            spOverridesVM = sPOverridesVM;
            Configuration = configuration;

            SelectElementCommand = new SimpleCommand(SelectElement);
        }

        private void SelectElement(object commandParameter)
        {
            var facade = new SampleProjectFacade(uIApplication);
            var overrides = facade.SelectElementAndReadOverrides();
            if(overrides != null)
                spOverridesVM.AssignOverrides(overrides);
        }
    }
}

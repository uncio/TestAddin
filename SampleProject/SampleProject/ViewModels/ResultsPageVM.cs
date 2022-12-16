using Autodesk.Revit.UI;
using SampleProject.RevitLogic.Models;
using SampleProject.RevitLogic;
using SampleProject.ViewModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleProject.ViewModels
{
    internal class ResultsPageVM: BaseVM
    {
        private readonly UIApplication uIApplication;

        public ICommand SelectElementCommand { get; set; }

        public SPOverridesVM SPOverridesVM { get; set; }

        public ConfigurationVM Configuration { get; set; }

        public ResultsPageVM(UIApplication uIApplication, SPOverridesVM sPOverridesVM, ConfigurationVM configuration)
        {
            this.uIApplication = uIApplication;
            SPOverridesVM = sPOverridesVM;
            Configuration = configuration;

            SelectElementCommand = new SimpleCommand(SelectElement);
        }

        private void SelectElement(object commandParameter)
        {
            var facade = new SampleProjectFacade(uIApplication);
            var overrides = facade.SelectElementAndReadOverrides();
            if (overrides != null)
                SPOverridesVM.AssignOverrides(overrides);
        }
    }
}

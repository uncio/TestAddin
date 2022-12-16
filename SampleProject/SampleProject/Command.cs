using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using SampleProject.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Interop;
using System.Windows;
using UIFramework;
using SampleProject.ViewModels;
using SampleProject.RevitLogic.Services;
using SampleProject.Views;
using Autodesk.Windows;

namespace SampleProject
{
    [Transaction(TransactionMode.Manual)]
    internal class Command : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            var source = HwndSource.FromHwnd(ComponentManager.ApplicationWindow);
            var vm = new SampleProjectWindowVM(commandData.Application);

            var mainWindow = new SampleProjectWindow
            {
                DataContext = vm,
                Owner = source.RootVisual as Window
            };

            mainWindow.Show();

            return Result.Succeeded;
        }
    }
}

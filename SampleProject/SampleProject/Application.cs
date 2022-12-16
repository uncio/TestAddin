using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.UI;
using Autodesk.Windows;
using SampleProject.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace SampleProject
{
    internal class Application : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            SetAddonCulture(application);
            SetUpRibbonPanel(application);

            return Result.Succeeded;
        }

        private static void SetAddonCulture(UIControlledApplication a)
        {
            var culture = Thread.CurrentThread.CurrentCulture;
            
            if (a.ControlledApplication.Language == LanguageType.Russian)
            {
                culture = CultureInfo.CreateSpecificCulture("ru");
            }
            else
            {
                culture = CultureInfo.CreateSpecificCulture("en");
            }

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        private void SetUpRibbonPanel(UIControlledApplication application)
        {
            application.CreateRibbonTab("Sample tab");
            var panel = application.CreateRibbonPanel("Sample tab", "Sample addin");

            var assembly = Assembly.GetExecutingAssembly();
            var pushButtonData1 = new PushButtonData(Resources.Title_SampleAddin, Resources.RibbonButtonName, assembly.Location, "SampleProject.Command");
            ApplyImageToButton(Properties.Resources.icon, pushButtonData1);
            panel.AddItem(pushButtonData1);
        }

        private void ApplyImageToButton(Bitmap ImagePath, PushButtonData pushButtonData)
        {
            BitmapImage Image = new BitmapImage();

            using (MemoryStream memory = new MemoryStream())
            {
                ImagePath.Save(memory, ImageFormat.Png);
                memory.Position = 0;

                Image = new BitmapImage();
                Image.BeginInit();
                Image.StreamSource = memory;
                Image.CacheOption = BitmapCacheOption.OnLoad;
                Image.EndInit();
                Image.Freeze();
            }
            pushButtonData.LargeImage = Image;
        }
    }
}

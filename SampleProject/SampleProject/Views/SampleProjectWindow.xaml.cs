using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SampleProject.Views
{
    /// <summary>
    /// Interaction logic for SampleProjectWindow.xaml
    /// </summary>
    public partial class SampleProjectWindow : Window
    {
        public static UserControl SettingsControl;
        public static UserControl ResultsControl;

        public SampleProjectWindow()
        {
            InitializeComponent();
            SettingsControl = Settings;
            ResultsControl = Results;
            ResultsControl.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Settings_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}

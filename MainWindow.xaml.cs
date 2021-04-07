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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MultipleStyleApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Properties.Settings.Default.CurrentTheme.Equals(ThemeSelectorCB.SelectedValue))
            {
                var app = (App) Application.Current;

                switch (ThemeSelectorCB.SelectedIndex)
                {
                    case 1:
                        //Change theme to Flat Style
                        app.ChangeTheme(new Uri("/styles/flatstyle.xaml", UriKind.RelativeOrAbsolute));
                        //and save to settings
                        Properties.Settings.Default.CurrentTheme = "Flat";
                        Properties.Settings.Default.Save();
                        break;

                    case 2:
                        //Change theme to Flat Style
                        app.ChangeTheme(new Uri("/styles/modernstyle.xaml", UriKind.RelativeOrAbsolute));
                        //and save to settings
                        Properties.Settings.Default.CurrentTheme = "Modern";
                        Properties.Settings.Default.Save();
                        break;

                    default:
                        //Change theme to Flat Style
                        app.ChangeTheme(new Uri("/styles/defaultstyle.xaml", UriKind.RelativeOrAbsolute));
                        //and save to settings
                        Properties.Settings.Default.CurrentTheme = "Default";
                        Properties.Settings.Default.Save();
                        break;
                }
            }
        }
    }
}

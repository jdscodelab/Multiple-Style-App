using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup.Localizer;
using MultipleStyleApp.Properties;

namespace MultipleStyleApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Selecting first dictionary
        private ResourceDictionary ThemeDictionary => Resources.MergedDictionaries[0];

        public App()
        {
            InitializeComponent();

            switch (Settings.Default.CurrentTheme)
            {
                case "Flat":
                    //Change theme to Flat Style
                    ChangeTheme(new Uri("/styles/flatstyle.xaml", UriKind.RelativeOrAbsolute));
                //and save to settings
                    Settings.Default.CurrentTheme = "Flat";
                    Settings.Default.Save();
                    break;

                case "Modern":
                    //Change theme to Flat Style
                    ChangeTheme(new Uri("/styles/modernstyle.xaml", UriKind.RelativeOrAbsolute));
                    //and save to settings
                    Settings.Default.CurrentTheme = "Modern";
                    Settings.Default.Save();
                    break;

                default:
                    //Change theme to Flat Style
                    ChangeTheme(new Uri("/styles/defaultstyle.xaml", UriKind.RelativeOrAbsolute));
                    //and save to settings
                    Settings.Default.CurrentTheme = "Default";
                    Settings.Default.Save();
                    break;
            }
        }

        public void ChangeTheme(Uri uri)
        {
            ThemeDictionary.MergedDictionaries.Clear();
            ThemeDictionary.MergedDictionaries.Add(new ResourceDictionary() {Source = uri});
        }
    }
}

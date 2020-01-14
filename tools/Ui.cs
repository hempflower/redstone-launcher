using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;


namespace RedstoneLauncher.tools
{
    /// <summary>
    /// UI相关，例如主题功能
    /// </summary>
    public class UI
    {
        public static void ChangeTheme(IBaseTheme theme,Color primary,Color secondary)
        {
            ResourceDictionaryExtensions.SetTheme(Application.Current.Resources, Theme.Create(theme, primary, secondary));
        }
    }
}

using RedstoneLauncher.tools;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RedstoneLauncher
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private static Logger logger { get; } = new Logger();
        protected override void OnStartup(StartupEventArgs e)
        {
            getLogger().Info("Redstone Launcher " + Useful.getLauncherVersion());
        }
        public static Logger getLogger()
        {
            return logger;
        }

    }
}

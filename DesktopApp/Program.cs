using System;
using WpfApp = System.Windows.Application;
using WinformApp = System.Windows.Forms.Application;
using System.Configuration;
namespace DesktopApp
{
    public class App : WpfApp
    {
        protected override void OnStartup(System.Windows.StartupEventArgs e)
        {
            base.OnStartup(e);
            new MainWindow().Show();
        }
    }

    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            WinformApp.EnableVisualStyles();
            WinformApp.SetCompatibleTextRenderingDefault(false);
            if (bool.TryParse(ConfigurationManager.AppSettings["WpfHost"], out var r) && r)
            {
                new App().Run();
            }
            else
            {
                WinformApp.Run(new Form1());
            }
        }
    }
}

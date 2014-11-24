using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using SYS_CHEF.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS_CHEF
{
    static class Program
    {
        public static DesktopForm desk = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Office 2013"); //Office 2013 //The Asphalt World

            //SplashForms.ShowWaitForm();
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(AssemblyInfo.AssemblyCulture);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(AssemblyInfo.AssemblyCulture);
            verefyProcesses();            
            LoginForm lf = new LoginForm();
            DialogResult rs = lf.ShowDialog();
            if (rs == DialogResult.OK)
            {
                desk.ShowDialog();
            }
            else
            {
                Exit(0);
            }

        }

        private static void verefyProcesses()
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                XtraMessageBox.Show("Já existe uma instância em execução, verifique!", "ATENÇÃO");
                Exit(0);
            }
        }

        static void Exit(int exit)
        {
            Environment.Exit(exit);
        }
    }
}

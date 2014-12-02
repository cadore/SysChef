using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using PetaPoco;
using SYS_CHEF.enums;
using SYS_CHEF.UI;
using SYS_CHEF.UI.Utils.SplashScreens;
using SYS_CHEF.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYS_CHEF
{
    static class Program
    {
        public static bool changeUser = false;
        public static Database db;
        public static TypeLogin typeLogin;
        public static user userLogin = null;
        public static string nameUserLogin = null;
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

            SplashScreenManager.ShowForm(null, typeof(SplashScreenForm), false, false, false);
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(AssemblyInfo.AssemblyCulture);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(AssemblyInfo.AssemblyCulture);
            verefyProcesses();
            openConnection();
            startApplication();
        }

        private static void openConnection()
        {
            try
            {
                db = new Database(SysChefRepo.ConnectionString, SysChefRepo.ProviderName);
                db.BeginTransaction();
            }
            catch (Exception)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um problema ao conectar com o banco de dados."));
                Exit(-1);
            }
        }

        private static void startApplication()
        {
            changeUser = false;
            LoginForm lf = new LoginForm();            
            SplashScreenManager.CloseForm(false); 
            DialogResult rs = lf.ShowDialog();
            if (rs == DialogResult.OK)
            {
                DesktopForm desk = new DesktopForm();
                desk.ShowDialog();
            }
            else
            {
                Exit(0);
            }
            if (changeUser)
                startApplication();
        }

        private static void verefyProcesses()
        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                XtraMessageBox.Show("Já existe uma instância em execução, verifique!", "Atenção");
                Exit(0);
            }
        }

        static void Exit(int exit)
        {
            Environment.Exit(exit);
        }

        public static DateTime getDateTime()
        {
            try
            {
                return db.ExecuteScalar<DateTime>("SELECT LOCALTIMESTAMP");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public static cashier getOpenCashier()
        {
            return CashierInit.getOpenCashier();
        }
    }
}

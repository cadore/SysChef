using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using SYS_CHEF.UI.Users;
using SYS_CHEF.Utils;
using SYS_CHEF.enums;
using DevExpress.XtraSplashScreen;
using SYS_CHEF.UI.Utils.SplashScreens;
using PetaPoco;
using SYS_CHEF.UI.Cashier;
using SYS_CHEF.UI.Products;

namespace SYS_CHEF.UI
{
    public partial class DesktopForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public user userLogin = null;
        public string nameUserLogin = null;
        public TypeLogin typeLogin;

        public DesktopForm()
        {
            SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
            InitializeComponent();            
        }

        private void DesktopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = XtraMessageBox.Show("Tem certeza que deseja sair?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
                e.Cancel = true;
            else
            {
                this.DialogResult = DialogResult.Cancel;
                e.Cancel = false;
            }
        }
        public void addControl(UserControl control)
        {
            try
            {
                SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
                this.pnControl.Controls.Clear();
                if (control != null)
                {
                    control.Visible = false;
                    this.pnControl.Controls.Add(control);
                    this.MinimumSize = control.Size + new Size(0, ribbon.Height) + new Size(20, 35);
                }
                else
                {
                    this.MinimumSize = new Size(900, 400);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Ocorreu um erro durante a solicitação.\n" + ex.Message);
            }
            finally
            {
                if (control != null)
                {
                    control.Visible = true;
                }
                //this.pnControl.Controls.Add(this.pnInformacoes);
                //this.pnInformacoes.Dock = System.Windows.Forms.DockStyle.Fill;
                SplashScreenManager.CloseForm(false);
            }
        }

        private void menuUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            SearchUsersForm suf = new SearchUsersForm() { desk = this };
            addControl(suf);
        }

        private void pnControl_ControlAdded(object sender, ControlEventArgs e)
        {
            Centraliza.centralizaControlsPainel((PanelControl)sender);
        }

        private void pnControl_SizeChanged(object sender, EventArgs e)
        {
            Centraliza.centralizaControlsPainel((PanelControl)sender);
        }

        private void DesktopForm_Shown(object sender, EventArgs e)
        {
            string usr = "";
            if (typeLogin == TypeLogin.Anonymous)
            {
                usr = nameUserLogin;
                XtraMessageBox.Show("Função desabilitada, em implantação.");
                Environment.Exit(0);
            }
            else
            {
                usr = userLogin.login;
            }
            this.Text = String.Format("{0} - {1} {2} - {3} {4} - Usuário: {5}", "", AssemblyInfo.AssemblyTitle,
                AssemblyInfo.AssemblyFileVersion, AssemblyInfo.AssemblyCopyright, AssemblyInfo.AssemblyCompany, usr);

            if (!userLogin.admin)
            {
                rpAdmin.Visible = false;
            }

            SplashScreenManager.CloseForm();
        }

        private void backstageChangeUser_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            Program.changeUser = true;
            this.Close();
        }

        private void backstageExit_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void menuOpenCashier_ItemClick(object sender, ItemClickEventArgs e)
        {
            int cashier_opened = Program.db.ExecuteScalar<int>("SELECT COUNT(id) FROM cashiers WHERE opened = TRUE");
            if (cashier_opened > 0)
            {
                XtraMessageBox.Show("Já existe um caixa aberto!");
                return;
            }

            InformValueOpenCashierForm ivocf = new InformValueOpenCashierForm();
            DialogResult rs = ivocf.ShowDialog();
            if (rs == DialogResult.Cancel)
                return;

            try
            {
                cashier cash = new cashier()
                {
                    apened_by = userLogin.id,
                    locked = false,
                    opened = true,
                    opened_at = Program.getDateTime(),
                    responsible = userLogin.id,
                    value_opening = ivocf.ValueOpening
                };
                cash.Insert();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro ao abrir o caixa!\n{0}\n\n{1}", ex.Message, ex.InnerException));
            }
            XtraMessageBox.Show("Caixa aberto com sucesso!", "Abertura de caixa");
        }

        private void menuCloseCashier_ItemClick(object sender, ItemClickEventArgs e)
        {
            int cashier_opened = Program.db.ExecuteScalar<int>("SELECT COUNT(id) FROM cashiers WHERE opened = TRUE");
            if (cashier_opened == 0)
            {
                XtraMessageBox.Show("Não existe um caixa aberto!");
                return;
            }
            CloseCashierForm ccf = new CloseCashierForm() { desk = this };
            if (ccf.ShowDialog() == DialogResult.OK)
            {
                XtraMessageBox.Show("Caixa fechado com sucesso!");
            }
        }

        private void menuProducts_ItemClick(object sender, ItemClickEventArgs e)
        {
            SearchProductsForm spf = new SearchProductsForm() { desk = this };
            addControl(spf);
        }
    }
}
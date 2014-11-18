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

namespace SYS_CHEF.UI
{
    public partial class DesktopForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DesktopForm()
        {
            InitializeComponent();
            this.Text = String.Format("{0} - {1} {2} - {3} {4} - Usuário: {5}", "", AssemblyInfo.AssemblyTitle, 
                AssemblyInfo.AssemblyFileVersion, AssemblyInfo.AssemblyCopyright, AssemblyInfo.AssemblyCompany, "");
        }

        private void DesktopForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rs = XtraMessageBox.Show("Tem certeza que deseja sair?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }
        public void addControl(UserControl control)
        {
            try
            {
                //SplashForms.ShowWaitForm(this);
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
                //SplashForms.CloseForm();
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
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using SYS_CHEF.UI.Utils.SplashScreens;

namespace SYS_CHEF.UI.Cashier
{
    public partial class CloseCashierForm : DevExpress.XtraEditors.XtraForm
    {
        cashier currentCashier = null;
        public DesktopForm desk = null;
        public CloseCashierForm()
        {
            SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
            InitializeComponent();
            getCurrentCashier();
            calcValueSystem();
            SplashScreenManager.CloseForm(false);
        }

        private void getCurrentCashier()
        {
            currentCashier = Program.getOpenCashier();
        }

        void calcValueSystem()
        {
            
        }

        void calcValueTotalCoin()
        {
            decimal d =
                Convert.ToDecimal(tfTotal005.Text.Replace("R$", "").Replace(" ", ""))
                + Convert.ToDecimal(tfTotal010.Text.Replace("R$", "").Replace(" ", ""))
                + Convert.ToDecimal(tfTotal025.Text.Replace("R$", "").Replace(" ", ""))
                + Convert.ToDecimal(tfTotal050.Text.Replace("R$", "").Replace(" ", ""))
                + Convert.ToDecimal(tfTotal100.Text.Replace("R$", "").Replace(" ", ""));
            tfTotalCoin.EditValue = String.Format("{0:c2}", d);
            calcValueTotal();
        }
        void calcValueTotalBanknote()
        {
            decimal d =
                Convert.ToDecimal(tfTotal200.Text.Replace("R$", "").Replace(" ", ""))
                + Convert.ToDecimal(tfTotal500.Text.Replace("R$", "").Replace(" ", ""))
                + Convert.ToDecimal(tfTotal1000.Text.Replace("R$", "").Replace(" ", ""))
                + Convert.ToDecimal(tfTotal2000.Text.Replace("R$", "").Replace(" ", ""))
                + Convert.ToDecimal(tfTotal5000.Text.Replace("R$", "").Replace(" ", ""))
                + Convert.ToDecimal(tfTotal10000.Text.Replace("R$", "").Replace(" ", ""));
            tfTotalBanknote.EditValue = String.Format("{0:c2}", d);
            calcValueTotal();
        }
        void calcValueTotal()
        {
            decimal d = 
                Convert.ToDecimal(tfTotalCoin.Text.Replace("R$", "").Replace(" ", ""))
                + Convert.ToDecimal(tfTotalBanknote.Text.Replace("R$", "").Replace(" ", ""));
            tfTotal.EditValue = String.Format("{0:c2}", d);
        }

        private void tfQnt005_EditValueChanged(object sender, EventArgs e)
        {
            tfTotal005.Text = String.Format("{0:c2}", Convert.ToDecimal(tfQnt005.EditValue) * Convert.ToDecimal(0.05));
            calcValueTotalCoin();
        }

        private void tfQnt010_EditValueChanged(object sender, EventArgs e)
        {
            tfTotal010.Text = String.Format("{0:c2}", Convert.ToDecimal(tfQnt010.EditValue) * Convert.ToDecimal(0.10));
            calcValueTotalCoin();
        }

        private void tfQnt025_EditValueChanged(object sender, EventArgs e)
        {
            tfTotal025.Text = String.Format("{0:c2}", Convert.ToDecimal(tfQnt025.EditValue) * Convert.ToDecimal(0.25));
            calcValueTotalCoin();
        }

        private void tfQnt050_EditValueChanged(object sender, EventArgs e)
        {
            tfTotal050.Text = String.Format("{0:c2}", Convert.ToDecimal(tfQnt050.EditValue) * Convert.ToDecimal(0.50));
            calcValueTotalCoin();
        }

        private void tfQnt100_EditValueChanged(object sender, EventArgs e)
        {
            tfTotal100.Text = String.Format("{0:c2}", Convert.ToDecimal(tfQnt100.EditValue) * Convert.ToDecimal(1.00));
            calcValueTotalCoin();
        }

        private void tfQnt200_EditValueChanged(object sender, EventArgs e)
        {
            tfTotal200.Text = String.Format("{0:c2}", Convert.ToDecimal(tfQnt200.EditValue) * Convert.ToDecimal(2.00));
            calcValueTotalBanknote();
        }

        private void tfQnt500_EditValueChanged(object sender, EventArgs e)
        {
            tfTotal500.Text = String.Format("{0:c2}", Convert.ToDecimal(tfQnt500.EditValue) * Convert.ToDecimal(5.00));
            calcValueTotalBanknote();
        }

        private void tfQnt1000_EditValueChanged(object sender, EventArgs e)
        {
            tfTotal1000.Text = String.Format("{0:c2}", Convert.ToDecimal(tfQnt1000.EditValue) * Convert.ToDecimal(10.00));
            calcValueTotalBanknote();
        }

        private void tfQnt2000_EditValueChanged(object sender, EventArgs e)
        {
            tfTotal2000.Text = String.Format("{0:c2}", Convert.ToDecimal(tfQnt2000.EditValue) * Convert.ToDecimal(20.00));
            calcValueTotalBanknote();
        }

        private void tfQnt5000_EditValueChanged(object sender, EventArgs e)
        {
            tfTotal5000.Text = String.Format("{0:c2}", Convert.ToDecimal(tfQnt5000.EditValue) * Convert.ToDecimal(50.00));
            calcValueTotalBanknote();
        }

        private void tfQnt10000_EditValueChanged(object sender, EventArgs e)
        {
            tfTotal10000.Text = String.Format("{0:c2}", Convert.ToDecimal(tfQnt10000.EditValue) * Convert.ToDecimal(100.00));
            calcValueTotalBanknote();
        }

        private void btnGetValueCountMoney_Click(object sender, EventArgs e)
        {
            if (tfTotal.EditValue != null && Convert.ToDecimal(tfTotal.Text.Replace("R$", "").Replace(" ", "")) > 0)
                tfValueInCashier.EditValue = tfTotal.EditValue;
        }
        
        private void tfValueInCashier_EditValueChanged(object sender, EventArgs e)
        {
            decimal ValueInCashier = 0;
            decimal ValueSystem = 0;
            decimal ValueTotal = 0;
            if (tfValueInCashier.EditValue != null)
                ValueInCashier = Convert.ToDecimal(tfValueInCashier.Text.Replace("R$", "").Replace(" ", ""));
            if (tfValueSystem.EditValue != null)
                ValueSystem = Convert.ToDecimal(tfValueSystem.Text.Replace("R$", "").Replace(" ", ""));
            ValueTotal = (ValueInCashier - ValueSystem);

            tfDifference.EditValue = String.Format("{0:c2}", ValueTotal);
            if (ValueTotal == 0)
                tfDifference.ForeColor = Color.Black;
            else if (ValueTotal > 0)
                tfDifference.ForeColor = Color.Green;
            else if (ValueTotal < 0)
                tfDifference.ForeColor = Color.Red;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCloseAndSaveCashier_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(tfValueInCashier.EditValue) == 0)
            {
                XtraMessageBox.Show("Informe o valor de fechamento do caixa!");
                return;
            }
            decimal difference = Convert.ToDecimal(tfDifference.Text.Replace("R$", "").Replace(" ", ""));
            if (difference != 0)
            {
                string s = "";
                if(difference > 0)
                {
                    s = "sobrando";
                }
                else if (difference < 0)
                {
                    s = "faltando";
                }
                DialogResult rs = XtraMessageBox.Show(String.Format("Está {0} {1:c2} no caixa, deseja continuar?",
                    s, difference),
                    "Confirmação de diferença de caixa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == DialogResult.No)
                    return;
            }
            DialogResult confirm = XtraMessageBox.Show("Confirma o fechamento do caixa?", "Confirmação de fechamento", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
                return;
            try
            {
                currentCashier.closed_at = Program.getDateTime();
                currentCashier.closed_by = Program.userLogin.id;
                currentCashier.opened = false;
                currentCashier.value_closing = Convert.ToDecimal(tfValueInCashier.Text.Replace("R$", "").Replace(" ", ""));
                currentCashier.Update();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Cancel;
                XtraMessageBox.Show(String.Format("Ocorreu um erro ao fechar o caixa.\n{0}\n\n{1}", 
                    ex.Message, ex.InnerException));                
            }
            finally
            {
                this.Close();
            }            
        }

        private void xtraTabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (xtraTabControl.SelectedTabPage.Name.Equals("tabPageClousing"))
                btnCloseAndSaveCashier.Visible = true;
            else
                btnCloseAndSaveCashier.Visible = false;
        }
    }
}
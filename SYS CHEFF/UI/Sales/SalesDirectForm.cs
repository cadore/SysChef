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

namespace SYS_CHEF.UI.Sales
{
    public partial class SalesDirectForm : DevExpress.XtraEditors.XtraForm
    {
        public SalesDirectForm()
        {
            InitializeComponent();
            getListProducts();
            SplashScreenManager.CloseForm();
        }

        private void getListProducts()
        {
            try
            {
                bdgProducts.DataSource = product.Fetch("ORDER BY description");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro na tentativa de obter a lista de produtos do estoque."
                + "\n{0}\n\n{1}", ex.Message, ex.InnerException));
            }
        }

        private void SalesDirectForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                this.lbCustomer_Click(sender, e);
            else if(e.KeyCode == Keys.Escape)
                this.btnCancel_Click(sender, e);
            else if(e.KeyCode == Keys.F2)
                this.btnSave_Click(sender, e);
            else if (e.KeyCode == Keys.F7)
            {
                this.tfDescription.Focus();
                this.tfDescription.SelectAll();
            }
            else if (e.KeyCode == Keys.F11)
            {
                this.tfDiscount.Focus();
                this.tfDiscount.SelectAll();
            }
            else if (e.KeyCode == Keys.F12)
            {
                this.tfReceived.Focus();
                this.tfReceived.SelectAll();
            }
        }

        private void lbCustomer_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Função de clientes e fornecedor ainda em implantação!");
            this.Focus();
        }

        void lbEnter(object sender, EventArgs e)
        {
            ((LabelControl)sender).ForeColor = Color.Blue;
        }

        void lbLeave(object sender, EventArgs e)
        {
            ((LabelControl)sender).ForeColor = Color.Black;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CalcValueUnit_EditValueChanged(object sender, EventArgs e)
        {
            decimal quantity = Convert.ToDecimal(tfQuantity.EditValue);
            decimal value_unity = Convert.ToDecimal(tfValueUnitary.EditValue);
            tfTotal.EditValue = String.Format("{0:c2}", (quantity * value_unity));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void cbProduct_EditValueChanged(object sender, EventArgs e)
        {
            if (cbProduct.EditValue != null)
            {
                product p = product.SingleOrDefault(cbProduct.EditValue);
                tfValueUnitary.EditValue = p.value_cost;

                if (p.alter_in_sale)
                    tfValueUnitary.Properties.ReadOnly = false;
                else
                    tfValueUnitary.Properties.ReadOnly = true;

                tfQuantity.Focus();
                tfQuantity.SelectAll();
            }
            else
            {
                tfQuantity.EditValue = null;
                tfValueUnitary.EditValue = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!validatorProducts.Validate())
                return;
            product p = product.SingleOrDefault(cbProduct.EditValue);
            bdgProductsSale.Add(new products_sale()
            {
                products_id = p.id,
                product_name = p.description,
                quantity = Convert.ToInt32(tfQuantity.EditValue),
                value_unitary = Convert.ToDecimal(tfValueUnitary.EditValue),
                value_total = Convert.ToDecimal(tfTotal.Text.Replace("R$", "").Replace(" ", ""))
            });
            cbProduct.EditValue = null;
            tfQuantity.EditValue = null;
            tfValueUnitary.EditValue = null;
            tfTotal.EditValue = null;
        }
    }
}
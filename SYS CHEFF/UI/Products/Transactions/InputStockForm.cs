using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SYS_CHEF.UI.Products.Transactions
{
    public partial class InputStockForm : DevExpress.XtraEditors.XtraUserControl
    {
        public DesktopForm desk = null;
        public InputStockForm()
        {
            InitializeComponent();
            bdgProducts.DataSource = product.Fetch("WHERE inactive=FALSE ORDER BY description");
            bdgProductsInput.DataSource = new List<products_input>();
        }

        private void CalcValueUnit_EditValueChanged(object sender, EventArgs e)
        {
            decimal quantity = Convert.ToDecimal(tfQuantity.EditValue);
            decimal value_unity = Convert.ToDecimal(tfValueUnity.EditValue);
            tfValueTotal.EditValue = String.Format("{0:c2}", (quantity * value_unity));
        }

        private void cbProduct_EditValueChanged(object sender, EventArgs e)
        {
            if (cbProduct.EditValue != null)
            {
                product p = product.SingleOrDefault(cbProduct.EditValue);
                tfValueUnity.EditValue = p.value_cost;
                tfQuantity.Focus();
                tfQuantity.SelectAll();
            }
            else
            {
                tfQuantity.EditValue = null;
                tfValueUnity.EditValue = null;
            }                
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!validatorProducts.Validate())
                return;
            product p = product.SingleOrDefault(cbProduct.EditValue);
            bdgProductsInput.Add(new products_input() 
            { 
                products_id = p.id, 
                name_product = p.description, 
                quantity = Convert.ToInt32(tfQuantity.EditValue), 
                value_unitary = Convert.ToDecimal(tfValueUnity.EditValue), 
                value_total = Convert.ToDecimal(tfValueTotal.Text.Replace("R$", "").Replace(" ", ""))
            });
            cbProduct.EditValue = null;
            tfQuantity.EditValue = null;
            tfValueUnity.EditValue = null;
            tfValueTotal.EditValue = null;
        }

        private void KeyEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAdd_Click(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.desk.addControl(null);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (bdgProductsInput.Current != null)
                bdgProductsInput.RemoveCurrent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bdgProductsInput.List.Count <= 0)
            {
                XtraMessageBox.Show("Informe no mínimo um produto para salvar!");
                return;
            }

            if (ckSaveInputOfSale.Checked)
            {
                if (XtraMessageBox.Show("Confirma salvar a entrada como uma compra?", 
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }
            else
            {
                if (XtraMessageBox.Show("Confirma salvar a entrada sem ser uma compra?", 
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }

            using (var scope = input_stock.repo.GetTransaction())
            {
                try
                {
                    input_stock ips = new input_stock() 
                    { 
                        cashier_id = Program.getOpenCashier().id, 
                        input_at = Program.getDateTime(), 
                        users_id = Program.userLogin.id, 
                        nf = Convert.ToInt32(tfNF.EditValue),
                        sale = ckSaveInputOfSale.Checked
                    };
                    ips.Insert();

                    foreach (products_input pi in bdgProductsInput.List)
                    {
                        product p = product.SingleOrDefault(pi.products_id);
                        p.current_stock += pi.quantity;
                        p.Update();

                        pi.input_stock_id = ips.id;
                        pi.Save();
                    }
                    scope.Complete();
                    XtraMessageBox.Show("Entrada salva com sucesso.");
                }
                catch (Exception ex)
                {
                    input_stock.repo.AbortTransaction();
                    XtraMessageBox.Show(String.Format("Ocorreu um erro ao salvar a entrada!\n{0}\n\n{1}", 
                        ex.Message, ex.InnerException));
                }
                finally
                {
                    this.desk.addControl(null);
                }
            }
        }       
    }
}

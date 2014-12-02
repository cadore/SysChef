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
    public partial class OutputStockForm : DevExpress.XtraEditors.XtraUserControl
    {
        public DesktopForm desk = null;
        public OutputStockForm()
        {
            InitializeComponent();
            bdgProductsOutput.DataSource = new List<products_output>();
            bdgProducts.DataSource = product.Fetch("ORDER BY description");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!validatorProduct.Validate())
                return;            

            foreach (products_output po in bdgProductsOutput.List)
            {
                if (po.products_id == Convert.ToInt64(cbProduct.EditValue))
                {
                    XtraMessageBox.Show("O produto já esta adicionado na lista!");
                    cbProduct.Focus();
                    return;
                }
            }
            product p = product.SingleOrDefault(cbProduct.EditValue);
            bdgProductsOutput.Add(new products_output()
            {
                name_product = p.description,
                products_id = p.id,
                quantity = Convert.ToInt32(tfQuantity.EditValue)
            });

            cbProduct.EditValue = null;
            tfQuantity.EditValue = null;
            cbProduct.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            desk.addControl(null);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bdgProductsOutput.Count <= 0)
            {
                XtraMessageBox.Show("Informe um produto para dar saida!");
                return;
            }
            if (!validatorOutput.Validate())
                return;
            try
            {
                foreach (products_output po in bdgProductsOutput.List)
                {
                    product p = product.SingleOrDefault(po.products_id);
                    if (po.quantity > p.current_stock)
                    {
                        XtraMessageBox.Show(String.Format("O produto {0} não tem estoque suficiente para salvar a saída.\n"
                            + "Quantidade informada {1}, estoque atual {2}.", p.description, po.quantity, p.current_stock));
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro ao verificar estoque de produtos\n{0}\n\n{1}",
                    ex.Message, ex.InnerException));
            }
            using (var scope = outputs_stock.repo.GetTransaction())
            {
                try
                {
                    outputs_stock os = new outputs_stock() 
                    {  
                        output_at = Program.getDateTime(), 
                        users_id = Program.userLogin.id, 
                        reason = tfReason.EditValue.ToString()
                    };
                    os.Save();

                    foreach (products_output po in bdgProductsOutput.List)
                    {
                        product p = product.SingleOrDefault(po.products_id);
                        p.current_stock -= po.quantity;
                        p.Update();

                        po.outputs_stock_id = os.id;
                        po.Save();
                    }
                    scope.Complete();
                    XtraMessageBox.Show("Saída salva com sucesso.");
                }
                catch (Exception ex)
                {
                    outputs_stock.repo.AbortTransaction();
                    XtraMessageBox.Show(String.Format("Ocorreu um erro ao salvar a saida de estoque\n{0}\n\n{1}", 
                        ex.Message, ex.InnerException));
                }
                finally
                {
                    this.desk.addControl(null);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (bdgProductsOutput.Current != null)
                bdgProductsOutput.RemoveCurrent();
        }

        private void KeyAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                this.btnAdd_Click(sender, e);
        }        
    }
}

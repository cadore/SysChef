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

namespace SYS_CHEF.UI.Products
{
    public partial class ProductsForm : DevExpress.XtraEditors.XtraUserControl
    {
        public DesktopForm desk = null;
        public ProductsForm(product p)
        {
            InitializeComponent();
            if (p == null)
            {
                p = new product();
            }
            else
            {
                tfInitialStock.Properties.ReadOnly = true;
            }
            bdgUnity.DataSource = unity_products.Fetch("");
            bdgCategory.DataSource = category_product.Fetch("");
            bdgProduct.DataSource = p;            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.desk.addControl(null);
        }

        private void ckGainInPercent_CheckedChanged(object sender, EventArgs e)
        {
            decimal ValueCost = Convert.ToDecimal(tfValueCost.EditValue);
            decimal Gain = Convert.ToDecimal(tfValueGain.EditValue);
            decimal ValueSale = 0;
            if (ckGainInPercent.Checked)
            {
                //this.tfLucro.Properties.Mask.EditMask = "n";
                decimal porCento = (ValueCost * Gain) / 100;
                ValueSale = ValueCost + porCento;
            }
            else
            {
                //this.tfLucro.Properties.Mask.EditMask = "c2";
                ValueSale = (ValueCost + Gain);
            }
            ((product)bdgProduct.Current).value_sale = ValueSale;
            tfValueSale.Text = String.Format("{0:c2}", ValueSale);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validator.Validate()  || !validatorStock.Validate())
                return;
            try
            {
                product p = (product)bdgProduct.Current;
                p.current_stock = p.initial_stock;
                p.provider_id = 0;
                p.joined_at = Program.getDateTime();
                p.inactive = false;
                p.Save();
                XtraMessageBox.Show("Produto salvo com sucesso!");
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(String.Format("Ocorreu um erro ao salvar o produto\n{0}\n\n{1}", ex.Message, ex.InnerException));
            }
            finally
            {
                this.desk.addControl(null);
            }
        }
    }
}

﻿using System;
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
using SYS_CHEF.UI.Customers;

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
            SelectCliForForm scff = new SelectCliForForm();
            //scff.ShowDialog();
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
            tfTotalProduct.EditValue = String.Format("{0:c2}", (quantity * value_unity));
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
                value_total = Convert.ToDecimal(tfTotalProduct.Text.Replace("R$", "").Replace(" ", ""))
            });
            cbProduct.EditValue = null;
            tfQuantity.EditValue = null;
            tfValueUnitary.EditValue = null;
            tfTotalProduct.EditValue = null;
            tfSubTotal.EditValue = colvalue_total.SummaryItem.SummaryValue;
            CalcValues(sender, e);
        }

        private void CalcValues(object sender, EventArgs e)
        {
            decimal subTotal = Convert.ToDecimal(tfSubTotal.EditValue);
            decimal discount = Convert.ToDecimal(tfDiscount.EditValue);

            tfTotalSale.EditValue = subTotal - discount;

            decimal total = Convert.ToDecimal(tfTotalSale.EditValue);

            /*if (tfReceived.EditValue == null || Convert.ToDecimal(tfReceived.EditValue) == 0)
            {
                tfReceived.EditValue = total;
            }*/

            decimal received = Convert.ToDecimal(tfReceived.EditValue);

            tfReturn.EditValue = received - total;

            decimal returnM = Convert.ToDecimal(tfReturn.EditValue);

            if (returnM > 0)
            {
                tfReturn.ForeColor = Color.Green;
                lbReturn.ForeColor = Color.Green;
                lbReturn.Text = "Troco";
            }
            else if (returnM < 0)
            {
                tfReturn.ForeColor = Color.Red;
                lbReturn.ForeColor = Color.Red;
                lbReturn.Text = "Debitar";
            }
            else
            {
                tfReturn.ForeColor = Color.Black;
                lbReturn.ForeColor = Color.Black;
                lbReturn.Text = "Troco";
            }
        }
    }
}
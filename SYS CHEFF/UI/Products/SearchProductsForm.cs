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
    public partial class SearchProductsForm : DevExpress.XtraEditors.XtraUserControl
    {
        public DesktopForm desk = null;
        public SearchProductsForm()
        {
            InitializeComponent();
        }

        void showFormProducts(product p)
        {
            ProductsForm pf = new ProductsForm(p) { desk = this.desk };
            this.desk.addControl(pf);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<product> listP = null;

            if (tfId.EditValue != null || Convert.ToInt64(tfId.EditValue) > 0)
            {
                listP = product.Fetch("WHERE id=@0", tfId.EditValue);
            }
            else if (tfDescription.EditValue != null)
            {
                listP = product.Fetch("WHERE description ILIKE @0 ORDER BY description", product.Concat(tfDescription.EditValue));
            }
            else
            {
                listP = product.Fetch("ORDER BY description");
            }
            bdgProducts.DataSource = listP;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.desk.addControl(null);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            showFormProducts(null);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(bdgProducts.Current != null)
                showFormProducts((product)bdgProducts.Current);
        }

        private void tfId_Enter(object sender, EventArgs e)
        {
            tfDescription.EditValue = null;
        }

        private void tfDescription_Enter(object sender, EventArgs e)
        {
            tfId.EditValue = null;
        }        
    }
}

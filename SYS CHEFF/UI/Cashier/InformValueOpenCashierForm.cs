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

namespace SYS_CHEF.UI.Cashier
{
    public partial class InformValueOpenCashierForm : DevExpress.XtraEditors.XtraForm
    {
        public decimal ValueOpening { get; set; }
        public InformValueOpenCashierForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ValueOpening = Convert.ToDecimal(tfValue.EditValue);
            DialogResult rs = XtraMessageBox.Show(String.Format("Confirma o valor de abertura em: {0:c2}?", ValueOpening), 
                "Abertura de caixa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
                return;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
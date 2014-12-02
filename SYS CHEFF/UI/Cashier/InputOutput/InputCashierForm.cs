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

namespace SYS_CHEF.UI.Cashier.InputOutput
{
    public partial class InputCashierForm : DevExpress.XtraEditors.XtraForm
    {
        public DesktopForm desk = null;
        public decimal Value { get; set; }
        public string Reason { get; set; }
        public InputCashierForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Value = Convert.ToDecimal(tfValue.EditValue);
            Reason = tfReason.EditValue.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
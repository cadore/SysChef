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

namespace SYS_CHEF.UI.Login
{
    public partial class ConfirmNumberUserForm : DevExpress.XtraEditors.XtraForm
    {
        user u = null;
        int attempts = 3;
        public ConfirmNumberUserForm(user _us)
        {
            u = _us;
            InitializeComponent();
            string[] p = u.phone.Split('-');
            this.lbPhone.Text = "Dica: (**)****-" + p[1];
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (!tfPhone.EditValue.ToString().Equals(u.phone))
            {
                attempts--;
                XtraMessageBox.Show("Numero incorreto, você tem mais " + attempts +" tentativa(s)!");
                tfPhone.Focus();
                tfPhone.SelectAll();
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            if (attempts == 0)
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }            
        }

        private void ConfirmNumberUserForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOk_Click(sender, e);
        }
    }
}
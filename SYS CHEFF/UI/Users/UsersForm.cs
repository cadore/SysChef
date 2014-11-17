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
using SecureApp;
using SYS_CHEF.Utils;

namespace SYS_CHEF.UI.Users
{
    public partial class UsersForm : DevExpress.XtraEditors.XtraUserControl
    {
        public DesktopForm desk = null;
        public string NewPassword { get; set; }
        public UsersForm(user us)
        {
            InitializeComponent();
            if (us == null)
                us = new user() { admitted_at = DateTime.Now };
            this.bdgUsers.DataSource = us;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            desk.addControl(null);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string cp = ((user)bdgUsers.Current).password;
            if (!String.IsNullOrEmpty(cp))
                cp = new DTICrypto().Decifrar(cp, Util.keyCrypto);
            ChangePasswordUserForm cpuf = new ChangePasswordUserForm(cp) { desk = this.desk };
            DialogResult rs = cpuf.ShowDialog();
            if (rs == DialogResult.OK)
                this.NewPassword = new DTICrypto().Cifrar(cpuf.NewPassword, Util.keyCrypto);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
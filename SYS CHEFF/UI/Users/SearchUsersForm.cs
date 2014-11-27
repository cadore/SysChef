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

namespace SYS_CHEF.UI.Users
{
    public partial class SearchUsersForm : DevExpress.XtraEditors.XtraUserControl
    {
        public DesktopForm desk = null;
        public SearchUsersForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tfId.EditValue != null)
            {
                bdgUsersList.DataSource = user.Fetch("WHERE id = @0", tfId.EditValue);
            }
            else if (tfFullName.EditValue != null)
            {
                bdgUsersList.DataSource = user.Fetch("WHERE full_name ILIKE @0 ORDER BY full_name", user.Concat(tfFullName.EditValue));
            }
            else
            {
                bdgUsersList.DataSource = user.Fetch("ORDER BY full_name");
            }
        }

        private void tf_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, e);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            showFormUsers(null);
        }

        private void tfId_EditValueChanged(object sender, EventArgs e)
        {
            tfFullName.EditValue = null;
        }

        private void tfFullName_EditValueChanged(object sender, EventArgs e)
        {
            tfId.EditValue = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            desk.addControl(null);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (bdgUsersList.Current != null)
            {
                showFormUsers((user)bdgUsersList.Current);
            }
        }
        void showFormUsers(user u)
        {
            UsersForm uf = new UsersForm(u) { desk = this.desk };
            desk.addControl(uf);
        }
    }
}

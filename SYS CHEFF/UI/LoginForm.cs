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
using SYS_CHEF.enums;

namespace SYS_CHEF.UI
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private user userLogin = null;
        private string nameUserLogin = null;
        TypeLogin typeLogin;
        public LoginForm()
        {
            InitializeComponent();
            typeLogin = TypeLogin.User;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;            
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            if (typeLogin == TypeLogin.User)
            {
            }
            else if (typeLogin == TypeLogin.Anonymous)
            {
                userLogin = null;
                nameUserLogin = tfLogin.EditValue.ToString();
                showDesktop();
            }
        }

        private void lbTypeLogin_Click(object sender, EventArgs e)
        {
            if (typeLogin == TypeLogin.User)
            {
                typeLogin = TypeLogin.Anonymous;
                lbTypeLogin.Text = "Tipo de Login: Anônimo";
                tfPassword.Enabled = false;
                tfPassword.EditValue = null;
                lbLogin.Text = "Nome Completo:";
            }
            else if (typeLogin == TypeLogin.Anonymous)
            {
                typeLogin = TypeLogin.User;
                lbTypeLogin.Text = "Tipo de Login: Usuário";
                tfPassword.Enabled = true;
                lbLogin.Text = "Login:";
            }
            tfLogin.Focus();
        }

        void showDesktop()
        {
            this.Close();
            DesktopForm desk = new DesktopForm();
            desk.typeLogin = this.typeLogin;
            desk.userLogin = this.userLogin;
            desk.nameUserLogin = this.nameUserLogin;
            desk.ShowDialog();
        }
    }
}
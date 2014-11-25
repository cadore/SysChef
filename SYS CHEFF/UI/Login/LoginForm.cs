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
using SecureApp;
using SYS_CHEF.Utils;
using SYS_CHEF.UI.Login;
using SYS_CHEF.UI.Users;
using DevExpress.XtraSplashScreen;
using SYS_CHEF.UI.Utils.SplashScreens;

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
            Text = "SysChef - Cadore Tecnologia - Alfa Beta 1";
            this.groupControl.Text = Text;
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!validator.Validate())
                return;
            if (typeLogin == TypeLogin.User)
            {
                SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
                user u = user.SingleOrDefault("WHERE login=@0 AND inactive=FALSE", tfLogin.EditValue);
                SplashScreenManager.CloseForm(false);
                if (u == null)
                    loginIncorrect();
                else
                {
                    Console.WriteLine(u.login);
                    Console.WriteLine(u.password);
                    Console.WriteLine(tfLogin.Text);
                    if (!string.IsNullOrEmpty(u.password))
                    {
                        if (u.password.Equals(new DTICrypto().Cifrar(tfPassword.Text, Util.keyCrypto)))
                        {
                            userLogin = u;
                            nameUserLogin = null;
                            showDesktop();
                        }
                        else
                            loginIncorrect();
                    }
                    else
                    {
                        DialogResult rs = XtraMessageBox.Show("O usuário esta sem senha, clique em OK para "
                            + "confirmar o numero do seu celular e informar a senha!", "Atenção", MessageBoxButtons.OKCancel, 
                            MessageBoxIcon.Information);
                        if (rs == DialogResult.Cancel)
                            return;
                        ConfirmNumberUserForm cnuf = new ConfirmNumberUserForm(u) { };
                        DialogResult drcnuf = cnuf.ShowDialog();
                        if (drcnuf == DialogResult.Abort || drcnuf == DialogResult.Cancel)
                        {
                            this.DialogResult = DialogResult.Cancel;
                            this.Close();
                        }
                        else if (drcnuf == DialogResult.OK)
                        {
                            ChangePasswordUserForm cpuf = new ChangePasswordUserForm("");
                            DialogResult drcpuf = cpuf.ShowDialog();
                            if (drcpuf == DialogResult.OK)
                            {
                                SplashScreenManager.ShowForm(null, typeof(PleaseWaitForm), false, false, false);
                                u.password = new DTICrypto().Cifrar(cpuf.NewPassword, Util.keyCrypto);
                                u.Update();
                                SplashScreenManager.CloseForm(false);
                                XtraMessageBox.Show("Senha definida com sucesso, por favor faça login no sistema!");
                                this.tfPassword.Focus();
                            }
                            else
                            {
                                this.DialogResult = DialogResult.Cancel;
                                this.Close();
                            }
                        }
                    }
                }                    
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
            DesktopForm desk = new DesktopForm();
            desk.typeLogin = this.typeLogin;
            desk.userLogin = this.userLogin;
            desk.nameUserLogin = this.nameUserLogin;
            Program.desk = desk;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        void loginIncorrect()
        {
            XtraMessageBox.Show("Login ou senha incorretos!");
            tfPassword.EditValue = null;
            tfLogin.Focus();
            tfLogin.SelectAll();
            return;
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.btnLogin_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
                this.btnCancelLogin_Click(sender, e);
        }
    }
}
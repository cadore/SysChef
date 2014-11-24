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
using DevExpress.XtraEditors.DXErrorProvider;

namespace SYS_CHEF.UI.Users
{
    public partial class UsersForm : DevExpress.XtraEditors.XtraUserControl
    {
        public DesktopForm desk = null;
        CustomValidationRuleSizeLogin cvrSL;
        public string NewPassword { get; set; }
        public UsersForm(user us)
        {
            InitializeComponent();
            if (us == null)
                us = new user() { admitted_at = DateTime.Now, dismissed_at = null, last_access_at = null };
            else
                if (us.dismissed_at > new DateTime(2014, 01, 01))
                    tfDismissedAt.Properties.ReadOnly = true;
            NewPassword = us.password;
            this.bdgUsers.DataSource = us;
            cvrSL = null;
            cvrSL = new CustomValidationRuleSizeLogin()
            {
                ErrorText = "Login deve ter no minimo 4 caracteres.",
                ErrorType = ErrorType.Critical
            };
            validator.SetValidationRule(tfLogin, cvrSL);            
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
            if (!validator.Validate())
                return;
            if (String.IsNullOrEmpty(NewPassword))
                if (XtraMessageBox.Show("Senha de acesso não informada!\nCaso não informe a senha do usuário ela será solicitada "
                    + "no primeiro acesso, deseja continuar?", "Confirmação", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                        return;

            user u = (user)bdgUsers.Current;
            if (!String.IsNullOrEmpty(NewPassword))
            {
                u.password = NewPassword;
            }
            if (u.dismissed_at > new DateTime(2014, 01, 01))
            {
                if (XtraMessageBox.Show("Você informou uma data de dimissão do Funcionário, confirma a demissão do Funcionário?",
                    "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    u.inactive = true;
                else
                    return;
            }
            u.Save();
            XtraMessageBox.Show("Usuário salvo com sucesso!");
            desk.addControl(null);
        }
    }

    public class CustomValidationRuleSizeLogin : ValidationRule
    {
        public override bool Validate(Control control, object value)
        {
            String str = value as String;
            if (str != null)
            {
                if (str.Trim().Length >= 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
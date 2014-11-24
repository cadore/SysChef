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
using DevExpress.XtraEditors.DXErrorProvider;

namespace SYS_CHEF.UI.Users
{
    public partial class ChangePasswordUserForm : DevExpress.XtraEditors.XtraForm
    {
        public DesktopForm desk = null;
        public string NewPassword { get; set; }
        public string CurrentPassword { get; set; }
        CustomValidationRuleSizePwd cvrSP;
        public ChangePasswordUserForm(string cp)
        {
            CurrentPassword = cp;
            InitializeComponent();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.tfCpNV.Visible = false;
            tfCpNV.Text = CurrentPassword;
            if (string.IsNullOrEmpty(CurrentPassword))
            {
                tfCurrentPassword.Enabled = false;
                validatorCurrentPwd.SetValidationRule(tfCurrentPassword, null);
            }                
            cvrSP = null;
            cvrSP = new CustomValidationRuleSizePwd() 
            { 
                ErrorText = "Senha deve ter no minimo 4 caracteres.", 
                ErrorType = ErrorType.Critical 
            };
            validatorNewPwd.SetValidationRule(tfNewPassword, cvrSP);
        }

        private void passwd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F12)
                ((TextEdit)sender).Properties.UseSystemPasswordChar = false;
        }

        private void passwd_KeyUp(object sender, KeyEventArgs e)
        {
            ((TextEdit)sender).Properties.UseSystemPasswordChar = true;
        }

        private void tfPasswd_FocusLeave(object sender, EventArgs e)
        {
            ((TextEdit)sender).Properties.UseSystemPasswordChar = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validatorCurrentPwd.Validate())
                return;
            if (!validatorNewPwd.Validate())
                return;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tfNewPassword_EditValueChanged(object sender, EventArgs e)
        {
            this.NewPassword = tfNewPassword.Text;
        }
    }
    public class CustomValidationRuleSizePwd : ValidationRule
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
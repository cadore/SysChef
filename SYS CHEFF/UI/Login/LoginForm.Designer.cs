using System.Windows.Forms;
namespace SYS_CHEF.UI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tfLogin = new DevExpress.XtraEditors.TextEdit();
            this.lbLogin = new DevExpress.XtraEditors.LabelControl();
            this.groupControl = new DevExpress.XtraEditors.GroupControl();
            this.lbTypeLogin = new DevExpress.XtraEditors.LabelControl();
            this.lbPassword = new DevExpress.XtraEditors.LabelControl();
            this.tfPassword = new DevExpress.XtraEditors.TextEdit();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.btnLogin = new SYS_CHEF.UI.Buttons.Win8.LoginButtons.ButtonLogin();
            this.btnCancelLogin = new SYS_CHEF.UI.Buttons.Win8.LoginButtons.ButtonCancelLogin();
            ((System.ComponentModel.ISupportInitialize)(this.tfLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).BeginInit();
            this.groupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            this.SuspendLayout();
            // 
            // tfLogin
            // 
            this.validator.SetIconAlignment(this.tfLogin, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.tfLogin.Location = new System.Drawing.Point(12, 43);
            this.tfLogin.Name = "tfLogin";
            this.tfLogin.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.tfLogin.Properties.Appearance.Options.UseForeColor = true;
            this.tfLogin.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.tfLogin.Size = new System.Drawing.Size(442, 22);
            this.tfLogin.TabIndex = 0;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Campo obrigatório para acessar o sistema!";
            this.validator.SetValidationRule(this.tfLogin, conditionValidationRule1);
            // 
            // lbLogin
            // 
            this.lbLogin.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.lbLogin.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lbLogin.Location = new System.Drawing.Point(12, 24);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(29, 13);
            this.lbLogin.TabIndex = 1;
            this.lbLogin.Tag = "o";
            this.lbLogin.Text = "Login:";
            // 
            // groupControl1
            // 
            this.groupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl.Appearance.Options.UseBackColor = true;
            this.groupControl.Controls.Add(this.btnLogin);
            this.groupControl.Controls.Add(this.btnCancelLogin);
            this.groupControl.Controls.Add(this.lbTypeLogin);
            this.groupControl.Controls.Add(this.lbPassword);
            this.groupControl.Controls.Add(this.tfPassword);
            this.groupControl.Controls.Add(this.lbLogin);
            this.groupControl.Controls.Add(this.tfLogin);
            this.groupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl.Location = new System.Drawing.Point(0, 0);
            this.groupControl.Name = "groupControl1";
            this.groupControl.Size = new System.Drawing.Size(465, 236);
            this.groupControl.TabIndex = 2;
            // 
            // lbTypeLogin
            // 
            this.lbTypeLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeLogin.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.lbTypeLogin.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lbTypeLogin.Location = new System.Drawing.Point(7, 140);
            this.lbTypeLogin.Name = "lbTypeLogin";
            this.lbTypeLogin.Size = new System.Drawing.Size(129, 16);
            this.lbTypeLogin.TabIndex = 1;
            this.lbTypeLogin.Text = "Tipo de Login: Usuário";
            this.lbTypeLogin.Click += new System.EventHandler(this.lbTypeLogin_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.lbPassword.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lbPassword.Location = new System.Drawing.Point(12, 82);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(34, 13);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Senha:";
            // 
            // tfPassword
            // 
            this.tfPassword.Location = new System.Drawing.Point(12, 101);
            this.tfPassword.Name = "tfPassword";
            this.tfPassword.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.tfPassword.Properties.Appearance.Options.UseForeColor = true;
            this.tfPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.tfPassword.Properties.UseSystemPasswordChar = true;
            this.tfPassword.Size = new System.Drawing.Size(442, 22);
            this.tfPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(12, 171);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(156, 53);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancelLogin
            // 
            this.btnCancelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(199)))));
            this.btnCancelLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLogin.ForeColor = System.Drawing.Color.White;
            this.btnCancelLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelLogin.Image")));
            this.btnCancelLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelLogin.Location = new System.Drawing.Point(297, 171);
            this.btnCancelLogin.Name = "btnCancelLogin";
            this.btnCancelLogin.Size = new System.Drawing.Size(157, 53);
            this.btnCancelLogin.TabIndex = 3;
            this.btnCancelLogin.Text = "Cancelar";
            this.btnCancelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelLogin.UseVisualStyleBackColor = false;
            this.btnCancelLogin.Click += new System.EventHandler(this.btnCancelLogin_Click);
            // 
            // LoginForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 236);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tfLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl)).EndInit();
            this.groupControl.ResumeLayout(false);
            this.groupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tfLogin;
        private DevExpress.XtraEditors.LabelControl lbLogin;
        private DevExpress.XtraEditors.GroupControl groupControl;
        private DevExpress.XtraEditors.LabelControl lbPassword;
        private DevExpress.XtraEditors.TextEdit tfPassword;
        private Buttons.Win8.LoginButtons.ButtonLogin btnLogin;
        private Buttons.Win8.LoginButtons.ButtonCancelLogin btnCancelLogin;
        private DevExpress.XtraEditors.LabelControl lbTypeLogin;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;

    }
}
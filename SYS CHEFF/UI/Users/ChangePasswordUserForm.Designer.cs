namespace SYS_CHEF.UI.Users
{
    partial class ChangePasswordUserForm
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
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule compareAgainstControlValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordUserForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tfCurrentPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tfNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tfConfirPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnExit = new SYS_CHEF.UI.Buttons.ButtonExit();
            this.btnSave = new SYS_CHEF.UI.Buttons.ButtonSave();
            this.validatorCurrentPwd = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.tfCpNV = new DevExpress.XtraEditors.TextEdit();
            this.validatorNewPwd = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tfCurrentPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfConfirPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorCurrentPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCpNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorNewPwd)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Senha atual:";
            // 
            // tfCurrentPassword
            // 
            this.tfCurrentPassword.Location = new System.Drawing.Point(101, 9);
            this.tfCurrentPassword.Name = "tfCurrentPassword";
            this.tfCurrentPassword.Properties.UseSystemPasswordChar = true;
            this.tfCurrentPassword.Size = new System.Drawing.Size(361, 20);
            this.tfCurrentPassword.TabIndex = 0;
            compareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.Equals;
            compareAgainstControlValidationRule1.Control = this.tfCpNV;
            compareAgainstControlValidationRule1.ErrorText = "Senha atual Incorreta, verifique!";
            this.validatorCurrentPwd.SetValidationRule(this.tfCurrentPassword, compareAgainstControlValidationRule1);
            this.tfCurrentPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwd_KeyDown);
            this.tfCurrentPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passwd_KeyUp);
            this.tfCurrentPassword.Leave += new System.EventHandler(this.tfPasswd_FocusLeave);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Nova senha:";
            // 
            // tfNewPassword
            // 
            this.tfNewPassword.Location = new System.Drawing.Point(101, 57);
            this.tfNewPassword.Name = "tfNewPassword";
            this.tfNewPassword.Properties.UseSystemPasswordChar = true;
            this.tfNewPassword.Size = new System.Drawing.Size(361, 20);
            this.tfNewPassword.TabIndex = 1;
            this.tfNewPassword.EditValueChanged += new System.EventHandler(this.tfNewPassword_EditValueChanged);
            this.tfNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwd_KeyDown);
            this.tfNewPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passwd_KeyUp);
            this.tfNewPassword.Leave += new System.EventHandler(this.tfPasswd_FocusLeave);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 86);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Confirmar senha:";
            // 
            // tfConfirPassword
            // 
            this.tfConfirPassword.Location = new System.Drawing.Point(101, 83);
            this.tfConfirPassword.Name = "tfConfirPassword";
            this.tfConfirPassword.Properties.UseSystemPasswordChar = true;
            this.tfConfirPassword.Size = new System.Drawing.Size(361, 20);
            this.tfConfirPassword.TabIndex = 2;
            compareAgainstControlValidationRule2.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.Equals;
            compareAgainstControlValidationRule2.Control = this.tfNewPassword;
            compareAgainstControlValidationRule2.ErrorText = "Senha não confere, verifique!";
            this.validatorNewPwd.SetValidationRule(this.tfConfirPassword, compareAgainstControlValidationRule2);
            this.tfConfirPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwd_KeyDown);
            this.tfConfirPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.passwd_KeyUp);
            this.tfConfirPassword.Leave += new System.EventHandler(this.tfPasswd_FocusLeave);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(367, 109);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Cancelar";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(266, 109);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Salvar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tfCpNV
            // 
            this.tfCpNV.Location = new System.Drawing.Point(101, 31);
            this.tfCpNV.Name = "tfCpNV";
            this.tfCpNV.Size = new System.Drawing.Size(100, 20);
            this.tfCpNV.TabIndex = 5;
            // 
            // ChangePasswordUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 143);
            this.ControlBox = false;
            this.Controls.Add(this.tfCpNV);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tfConfirPassword);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.tfNewPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.tfCurrentPassword);
            this.Controls.Add(this.labelControl1);
            this.Name = "ChangePasswordUserForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.tfCurrentPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfNewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfConfirPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorCurrentPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfCpNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorNewPwd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tfCurrentPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tfNewPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit tfConfirPassword;
        private Buttons.ButtonExit btnExit;
        private Buttons.ButtonSave btnSave;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validatorCurrentPwd;
        private DevExpress.XtraEditors.TextEdit tfCpNV;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validatorNewPwd;
    }
}
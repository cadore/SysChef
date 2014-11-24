using System.Drawing;
namespace SYS_CHEF.UI.Users
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSave = new SYS_CHEF.UI.Buttons.ButtonSave();
            this.btnExit = new SYS_CHEF.UI.Buttons.ButtonExit();
            this.btnChangePassword = new SYS_CHEF.UI.Buttons.ButtonEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.tfLastAccessFrom = new DevExpress.XtraEditors.TextEdit();
            this.bdgUsers = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tfLastAccessAt = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.ckInactive = new DevExpress.XtraEditors.CheckEdit();
            this.ckAdmin = new DevExpress.XtraEditors.CheckEdit();
            this.tfDismissedAt = new DevExpress.XtraEditors.DateEdit();
            this.tfAdmitedAt = new DevExpress.XtraEditors.DateEdit();
            this.tfId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tfLogin = new DevExpress.XtraEditors.TextEdit();
            this.tfFullName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.validator = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.tfPhone = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfLastAccessFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfLastAccessAt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckInactive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckAdmin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDismissedAt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDismissedAt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfAdmitedAt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfAdmitedAt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPhone.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tfPhone);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.btnExit);
            this.groupControl1.Controls.Add(this.btnChangePassword);
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.tfDismissedAt);
            this.groupControl1.Controls.Add(this.tfAdmitedAt);
            this.groupControl1.Controls.Add(this.tfId);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.tfLogin);
            this.groupControl1.Controls.Add(this.tfFullName);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(769, 285);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Cadastro de Funcionário";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(568, 249);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Salvar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(669, 249);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.Black;
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Location = new System.Drawing.Point(88, 109);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(184, 30);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Defenir senha do usuário";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.tfLastAccessFrom);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.tfLastAccessAt);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Location = new System.Drawing.Point(377, 144);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(389, 100);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Informações de Acesso";
            // 
            // tfLastAccessFrom
            // 
            this.tfLastAccessFrom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgUsers, "last_access_from", true));
            this.tfLastAccessFrom.Location = new System.Drawing.Point(100, 50);
            this.tfLastAccessFrom.Name = "tfLastAccessFrom";
            this.tfLastAccessFrom.Properties.ReadOnly = true;
            this.tfLastAccessFrom.Size = new System.Drawing.Size(284, 20);
            this.tfLastAccessFrom.TabIndex = 1;
            // 
            // bdgUsers
            // 
            this.bdgUsers.DataSource = typeof(SYS_CHEF.user);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(8, 53);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(84, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Ultimo acesso de:";
            // 
            // tfLastAccessAt
            // 
            this.tfLastAccessAt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgUsers, "last_access_at", true));
            this.tfLastAccessAt.Location = new System.Drawing.Point(100, 24);
            this.tfLastAccessAt.Name = "tfLastAccessAt";
            this.tfLastAccessAt.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.tfLastAccessAt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.tfLastAccessAt.Properties.ReadOnly = true;
            this.tfLastAccessAt.Size = new System.Drawing.Size(284, 20);
            this.tfLastAccessAt.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(8, 27);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Ultimo acesso em:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.ckInactive);
            this.groupControl2.Controls.Add(this.ckAdmin);
            this.groupControl2.Location = new System.Drawing.Point(5, 144);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(366, 100);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Permissões";
            // 
            // ckInactive
            // 
            this.ckInactive.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgUsers, "inactive", true));
            this.ckInactive.Location = new System.Drawing.Point(218, 29);
            this.ckInactive.Name = "ckInactive";
            this.ckInactive.Properties.Caption = "Acesso Inativo";
            this.ckInactive.Size = new System.Drawing.Size(106, 15);
            this.ckInactive.TabIndex = 0;
            // 
            // ckAdmin
            // 
            this.ckAdmin.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgUsers, "admin", true));
            this.ckAdmin.Location = new System.Drawing.Point(17, 29);
            this.ckAdmin.Name = "ckAdmin";
            this.ckAdmin.Properties.Caption = "Administrador";
            this.ckAdmin.Size = new System.Drawing.Size(106, 15);
            this.ckAdmin.TabIndex = 0;
            // 
            // tfDismissedAt
            // 
            this.tfDismissedAt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgUsers, "dismissed_at", true));
            this.tfDismissedAt.EditValue = null;
            this.tfDismissedAt.Location = new System.Drawing.Point(88, 83);
            this.tfDismissedAt.Name = "tfDismissedAt";
            this.tfDismissedAt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDismissedAt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfDismissedAt.Size = new System.Drawing.Size(100, 20);
            this.tfDismissedAt.TabIndex = 2;
            // 
            // tfAdmitedAt
            // 
            this.tfAdmitedAt.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgUsers, "admitted_at", true));
            this.tfAdmitedAt.EditValue = null;
            this.tfAdmitedAt.Location = new System.Drawing.Point(88, 57);
            this.tfAdmitedAt.Name = "tfAdmitedAt";
            this.tfAdmitedAt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfAdmitedAt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tfAdmitedAt.Size = new System.Drawing.Size(100, 20);
            this.tfAdmitedAt.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Informe a data de adimissão";
            this.validator.SetValidationRule(this.tfAdmitedAt, conditionValidationRule2);
            // 
            // tfId
            // 
            this.tfId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgUsers, "id", true));
            this.tfId.Location = new System.Drawing.Point(689, 24);
            this.tfId.Name = "tfId";
            this.tfId.Properties.ReadOnly = true;
            this.tfId.Size = new System.Drawing.Size(77, 20);
            this.tfId.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(656, 27);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Cod.:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 86);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(62, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Demitido em:";
            // 
            // tfLogin
            // 
            this.tfLogin.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgUsers, "login", true));
            this.tfLogin.Location = new System.Drawing.Point(514, 24);
            this.tfLogin.Name = "tfLogin";
            this.tfLogin.Size = new System.Drawing.Size(136, 20);
            this.tfLogin.TabIndex = 1;
            // 
            // tfFullName
            // 
            this.tfFullName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgUsers, "full_name", true));
            this.tfFullName.Location = new System.Drawing.Point(88, 24);
            this.tfFullName.Name = "tfFullName";
            this.tfFullName.Size = new System.Drawing.Size(381, 20);
            this.tfFullName.TabIndex = 1;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Informe o nome completo do usuário.";
            this.validator.SetValidationRule(this.tfFullName, conditionValidationRule3);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(479, 27);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(29, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Login:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 60);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Admitido em:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Nome completo:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(471, 60);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(37, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Celular:";
            // 
            // tfPhone
            // 
            this.tfPhone.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdgUsers, "phone", true));
            this.tfPhone.Location = new System.Drawing.Point(514, 57);
            this.tfPhone.Name = "tfPhone";
            this.tfPhone.Properties.Mask.EditMask = "(\\(11\\)[9][0-9]{4}-[0-9]{4})|(\\(1[2-9]\\) [5-9][0-9]{3}-[0-9]{4})|(\\([2-9][1-9]\\) " +
    "[5-9][0-9]{3}-[0-9]{4})";
            this.tfPhone.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tfPhone.Size = new System.Drawing.Size(136, 20);
            this.tfPhone.TabIndex = 8;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe o numero do telefone do usuário/funcionário!";
            this.validator.SetValidationRule(this.tfPhone, conditionValidationRule1);
            // 
            // UsersForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "UsersForm";
            this.Size = new System.Drawing.Size(769, 285);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfLastAccessFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfLastAccessAt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ckInactive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckAdmin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDismissedAt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDismissedAt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfAdmitedAt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfAdmitedAt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfPhone.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit tfId;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tfFullName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit tfDismissedAt;
        private DevExpress.XtraEditors.DateEdit tfAdmitedAt;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit tfLastAccessFrom;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit tfLastAccessAt;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.CheckEdit ckInactive;
        private DevExpress.XtraEditors.CheckEdit ckAdmin;
        private Buttons.ButtonEdit btnChangePassword;
        private Buttons.ButtonExit btnExit;
        private Buttons.ButtonSave btnSave;
        private System.Windows.Forms.BindingSource bdgUsers;
        private DevExpress.XtraEditors.TextEdit tfLogin;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validator;
        private DevExpress.XtraEditors.TextEdit tfPhone;
        private DevExpress.XtraEditors.LabelControl labelControl8;


    }
}
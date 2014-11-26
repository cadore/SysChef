namespace SYS_CHEF.UI
{
    partial class DesktopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesktopForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.backstageChangeUser = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.backstageViewItemSeparator1 = new DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator();
            this.backstageExit = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.menuUser = new DevExpress.XtraBars.BarButtonItem();
            this.menuOpenCashier = new DevExpress.XtraBars.BarButtonItem();
            this.menuCloseCashier = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpAdmin = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgUsers = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.pnControl = new DevExpress.XtraEditors.PanelControl();
            this.buttonAdd1 = new SYS_CHEF.UI.Buttons.ButtonAdd();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).BeginInit();
            this.pnControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.menuUser,
            this.menuOpenCashier,
            this.menuCloseCashier});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage1,
            this.rpAdmin});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbon.Size = new System.Drawing.Size(927, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Yellow;
            this.backstageViewControl1.Items.Add(this.backstageChangeUser);
            this.backstageViewControl1.Items.Add(this.backstageViewItemSeparator1);
            this.backstageViewControl1.Items.Add(this.backstageExit);
            this.backstageViewControl1.Location = new System.Drawing.Point(5, 5);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.Ribbon = this.ribbon;
            this.backstageViewControl1.SelectedTab = null;
            this.backstageViewControl1.Size = new System.Drawing.Size(917, 331);
            this.backstageViewControl1.TabIndex = 0;
            this.backstageViewControl1.Text = "backstageViewControl1";
            // 
            // backstageChangeUser
            // 
            this.backstageChangeUser.Caption = "Trocar usuário";
            this.backstageChangeUser.Glyph = ((System.Drawing.Image)(resources.GetObject("backstageChangeUser.Glyph")));
            this.backstageChangeUser.Name = "backstageChangeUser";
            this.backstageChangeUser.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.backstageChangeUser_ItemClick);
            // 
            // backstageViewItemSeparator1
            // 
            this.backstageViewItemSeparator1.Name = "backstageViewItemSeparator1";
            // 
            // backstageExit
            // 
            this.backstageExit.Caption = "Sair";
            this.backstageExit.Glyph = ((System.Drawing.Image)(resources.GetObject("backstageExit.Glyph")));
            this.backstageExit.Name = "backstageExit";
            this.backstageExit.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.backstageExit_ItemClick);
            // 
            // menuUser
            // 
            this.menuUser.Caption = "Usuários/Funcionários";
            this.menuUser.Id = 1;
            this.menuUser.Name = "menuUser";
            this.menuUser.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.menuUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuUsers_ItemClick);
            // 
            // menuOpenCashier
            // 
            this.menuOpenCashier.Caption = "Abrir Caixa";
            this.menuOpenCashier.Id = 2;
            this.menuOpenCashier.Name = "menuOpenCashier";
            this.menuOpenCashier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuOpenCashier_ItemClick);
            // 
            // menuCloseCashier
            // 
            this.menuCloseCashier.Caption = "Fechar Caixa";
            this.menuCloseCashier.Id = 3;
            this.menuCloseCashier.Name = "menuCloseCashier";
            this.menuCloseCashier.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuCloseCashier_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Atendimento";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Financeiro";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.menuOpenCashier);
            this.ribbonPageGroup1.ItemLinks.Add(this.menuCloseCashier);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Caixa";
            // 
            // rpAdmin
            // 
            this.rpAdmin.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgUsers});
            this.rpAdmin.Name = "rpAdmin";
            this.rpAdmin.Text = "Administrador";
            // 
            // rpgUsers
            // 
            this.rpgUsers.AllowTextClipping = false;
            this.rpgUsers.ItemLinks.Add(this.menuUser);
            this.rpgUsers.Name = "rpgUsers";
            this.rpgUsers.ShowCaptionButton = false;
            this.rpgUsers.Text = "Usuários";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 486);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(927, 31);
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.backstageViewControl1);
            this.pnControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnControl.Location = new System.Drawing.Point(0, 144);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(927, 342);
            this.pnControl.TabIndex = 2;
            this.pnControl.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnControl_ControlAdded);
            this.pnControl.Resize += new System.EventHandler(this.pnControl_SizeChanged);
            // 
            // buttonAdd1
            // 
            this.buttonAdd1.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd1.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd1.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd1.Image")));
            this.buttonAdd1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd1.Location = new System.Drawing.Point(150, 62);
            this.buttonAdd1.Name = "buttonAdd1";
            this.buttonAdd1.Size = new System.Drawing.Size(95, 30);
            this.buttonAdd1.TabIndex = 0;
            this.buttonAdd1.Text = "buttonAdd1";
            this.buttonAdd1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd1.UseVisualStyleBackColor = false;
            // 
            // DesktopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 517);
            this.Controls.Add(this.pnControl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "DesktopForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "DesktopForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DesktopForm_FormClosing);
            this.Shown += new System.EventHandler(this.DesktopForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnControl)).EndInit();
            this.pnControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpAdmin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgUsers;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem menuUser;
        private DevExpress.XtraEditors.PanelControl pnControl;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem backstageExit;
        private DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator backstageViewItemSeparator1;
        private Buttons.ButtonAdd buttonAdd1;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem backstageChangeUser;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem menuOpenCashier;
        private DevExpress.XtraBars.BarButtonItem menuCloseCashier;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}
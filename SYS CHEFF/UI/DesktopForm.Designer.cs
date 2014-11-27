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
            this.menuProducts = new DevExpress.XtraBars.BarButtonItem();
            this.menuInputStock = new DevExpress.XtraBars.BarButtonItem();
            this.menuOutputStock = new DevExpress.XtraBars.BarButtonItem();
            this.menuBuyProducts = new DevExpress.XtraBars.BarButtonItem();
            this.rpAttendance = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpFinancial = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgCashier = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpAdmin = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgUsers = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpStock = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgProducts = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgTransactions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.menuCloseCashier,
            this.menuProducts,
            this.menuInputStock,
            this.menuOutputStock,
            this.menuBuyProducts});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpAttendance,
            this.rpFinancial,
            this.rpAdmin,
            this.rpStock});
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
            // menuProducts
            // 
            this.menuProducts.Caption = "Produtos";
            this.menuProducts.Id = 4;
            this.menuProducts.Name = "menuProducts";
            this.menuProducts.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.menuProducts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuProducts_ItemClick);
            // 
            // menuInputStock
            // 
            this.menuInputStock.Caption = "Entrada de Estoque";
            this.menuInputStock.Id = 5;
            this.menuInputStock.Name = "menuInputStock";
            // 
            // menuOutputStock
            // 
            this.menuOutputStock.Caption = "Saida de Estoque";
            this.menuOutputStock.Id = 6;
            this.menuOutputStock.Name = "menuOutputStock";
            // 
            // menuBuyProducts
            // 
            this.menuBuyProducts.Caption = "Compra de Produtos";
            this.menuBuyProducts.Id = 7;
            this.menuBuyProducts.Name = "menuBuyProducts";
            // 
            // rpAttendance
            // 
            this.rpAttendance.Name = "rpAttendance";
            this.rpAttendance.Text = "Atendimento";
            // 
            // rpFinancial
            // 
            this.rpFinancial.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgCashier});
            this.rpFinancial.Name = "rpFinancial";
            this.rpFinancial.Text = "Financeiro";
            // 
            // rpgCashier
            // 
            this.rpgCashier.AllowTextClipping = false;
            this.rpgCashier.ItemLinks.Add(this.menuOpenCashier);
            this.rpgCashier.ItemLinks.Add(this.menuCloseCashier);
            this.rpgCashier.Name = "rpgCashier";
            this.rpgCashier.ShowCaptionButton = false;
            this.rpgCashier.Text = "Caixa";
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
            // rpStock
            // 
            this.rpStock.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgProducts,
            this.rpgTransactions});
            this.rpStock.Name = "rpStock";
            this.rpStock.Text = "Estoque";
            // 
            // rpgProducts
            // 
            this.rpgProducts.AllowTextClipping = false;
            this.rpgProducts.ItemLinks.Add(this.menuProducts);
            this.rpgProducts.Name = "rpgProducts";
            this.rpgProducts.ShowCaptionButton = false;
            this.rpgProducts.Text = "Produtos";
            // 
            // rpgTransactions
            // 
            this.rpgTransactions.AllowTextClipping = false;
            this.rpgTransactions.ItemLinks.Add(this.menuInputStock);
            this.rpgTransactions.ItemLinks.Add(this.menuOutputStock);
            this.rpgTransactions.Name = "rpgTransactions";
            this.rpgTransactions.ShowCaptionButton = false;
            this.rpgTransactions.Text = "Transações de Estoque";
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
        private DevExpress.XtraBars.Ribbon.RibbonPage rpAttendance;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpFinancial;
        private DevExpress.XtraBars.BarButtonItem menuOpenCashier;
        private DevExpress.XtraBars.BarButtonItem menuCloseCashier;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgCashier;
        private DevExpress.XtraBars.BarButtonItem menuProducts;
        private DevExpress.XtraBars.BarButtonItem menuInputStock;
        private DevExpress.XtraBars.BarButtonItem menuOutputStock;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpStock;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgProducts;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTransactions;
        private DevExpress.XtraBars.BarButtonItem menuBuyProducts;
    }
}
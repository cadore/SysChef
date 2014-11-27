namespace SYS_CHEF.UI.Products
{
    partial class SearchProductsForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchProductsForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnSelect = new SYS_CHEF.UI.Buttons.ButtonSelect();
            this.btnNew = new SYS_CHEF.UI.Buttons.ButtonNew();
            this.btnExit = new SYS_CHEF.UI.Buttons.ButtonExit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.productGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdgProducts = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmax_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmin_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcurrent_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinitial_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalter_in_sale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalue_cost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalue_sale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalue_gain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgain_in_percent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coljoined_at = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcategory_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprovider_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinactive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSearch = new SYS_CHEF.UI.Buttons.ButtonSearch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tfId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tfDescription = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDescription.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl3);
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(886, 435);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Pesquisa de Produtos";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnSelect);
            this.panelControl3.Controls.Add(this.btnNew);
            this.panelControl3.Controls.Add(this.btnExit);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(2, 394);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(882, 39);
            this.panelControl3.TabIndex = 3;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.Black;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(683, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(95, 30);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Selecionar";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(5, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(95, 30);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Novo";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(784, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.productGridControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 62);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(882, 371);
            this.panelControl2.TabIndex = 2;
            // 
            // productGridControl
            // 
            this.productGridControl.DataSource = this.bdgProducts;
            this.productGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productGridControl.Location = new System.Drawing.Point(2, 2);
            this.productGridControl.MainView = this.gridView1;
            this.productGridControl.Name = "productGridControl";
            this.productGridControl.Size = new System.Drawing.Size(878, 367);
            this.productGridControl.TabIndex = 0;
            this.productGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.productGridControl.DoubleClick += new System.EventHandler(this.btnSelect_Click);
            // 
            // bdgProducts
            // 
            this.bdgProducts.DataSource = typeof(SYS_CHEF.product);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldescription,
            this.colmax_stock,
            this.colmin_stock,
            this.colcurrent_stock,
            this.colinitial_stock,
            this.colalter_in_sale,
            this.colvalue_cost,
            this.colvalue_sale,
            this.colvalue_gain,
            this.colgain_in_percent,
            this.coljoined_at,
            this.colcategory_id,
            this.colprovider_id,
            this.colinactive});
            this.gridView1.GridControl = this.productGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.Caption = "Cod.";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 39;
            // 
            // coldescription
            // 
            this.coldescription.Caption = "Descrição";
            this.coldescription.FieldName = "description";
            this.coldescription.Name = "coldescription";
            this.coldescription.OptionsColumn.AllowEdit = false;
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 1;
            this.coldescription.Width = 440;
            // 
            // colmax_stock
            // 
            this.colmax_stock.Caption = "Máximo";
            this.colmax_stock.FieldName = "max_stock";
            this.colmax_stock.Name = "colmax_stock";
            this.colmax_stock.OptionsColumn.AllowEdit = false;
            this.colmax_stock.Visible = true;
            this.colmax_stock.VisibleIndex = 2;
            this.colmax_stock.Width = 58;
            // 
            // colmin_stock
            // 
            this.colmin_stock.Caption = "Mínimo";
            this.colmin_stock.FieldName = "min_stock";
            this.colmin_stock.Name = "colmin_stock";
            this.colmin_stock.OptionsColumn.AllowEdit = false;
            this.colmin_stock.Visible = true;
            this.colmin_stock.VisibleIndex = 3;
            this.colmin_stock.Width = 53;
            // 
            // colcurrent_stock
            // 
            this.colcurrent_stock.Caption = "Atual";
            this.colcurrent_stock.FieldName = "current_stock";
            this.colcurrent_stock.Name = "colcurrent_stock";
            this.colcurrent_stock.OptionsColumn.AllowEdit = false;
            this.colcurrent_stock.Visible = true;
            this.colcurrent_stock.VisibleIndex = 4;
            this.colcurrent_stock.Width = 85;
            // 
            // colinitial_stock
            // 
            this.colinitial_stock.FieldName = "initial_stock";
            this.colinitial_stock.Name = "colinitial_stock";
            this.colinitial_stock.OptionsColumn.AllowEdit = false;
            this.colinitial_stock.Width = 67;
            // 
            // colalter_in_sale
            // 
            this.colalter_in_sale.FieldName = "alter_in_sale";
            this.colalter_in_sale.Name = "colalter_in_sale";
            this.colalter_in_sale.OptionsColumn.AllowEdit = false;
            this.colalter_in_sale.Width = 67;
            // 
            // colvalue_cost
            // 
            this.colvalue_cost.Caption = "Valor de Custo";
            this.colvalue_cost.DisplayFormat.FormatString = "c2";
            this.colvalue_cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalue_cost.FieldName = "value_cost";
            this.colvalue_cost.Name = "colvalue_cost";
            this.colvalue_cost.OptionsColumn.AllowEdit = false;
            this.colvalue_cost.Visible = true;
            this.colvalue_cost.VisibleIndex = 5;
            this.colvalue_cost.Width = 84;
            // 
            // colvalue_sale
            // 
            this.colvalue_sale.Caption = "Valor de Venda";
            this.colvalue_sale.DisplayFormat.FormatString = "c2";
            this.colvalue_sale.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colvalue_sale.FieldName = "value_sale";
            this.colvalue_sale.Name = "colvalue_sale";
            this.colvalue_sale.OptionsColumn.AllowEdit = false;
            this.colvalue_sale.Visible = true;
            this.colvalue_sale.VisibleIndex = 6;
            this.colvalue_sale.Width = 101;
            // 
            // colvalue_gain
            // 
            this.colvalue_gain.FieldName = "value_gain";
            this.colvalue_gain.Name = "colvalue_gain";
            this.colvalue_gain.OptionsColumn.AllowEdit = false;
            this.colvalue_gain.Width = 67;
            // 
            // colgain_in_percent
            // 
            this.colgain_in_percent.FieldName = "gain_in_percent";
            this.colgain_in_percent.Name = "colgain_in_percent";
            this.colgain_in_percent.OptionsColumn.AllowEdit = false;
            this.colgain_in_percent.Width = 67;
            // 
            // coljoined_at
            // 
            this.coljoined_at.FieldName = "joined_at";
            this.coljoined_at.Name = "coljoined_at";
            this.coljoined_at.OptionsColumn.AllowEdit = false;
            this.coljoined_at.Width = 67;
            // 
            // colcategory_id
            // 
            this.colcategory_id.FieldName = "category_id";
            this.colcategory_id.Name = "colcategory_id";
            this.colcategory_id.OptionsColumn.AllowEdit = false;
            this.colcategory_id.Width = 67;
            // 
            // colprovider_id
            // 
            this.colprovider_id.FieldName = "provider_id";
            this.colprovider_id.Name = "colprovider_id";
            this.colprovider_id.OptionsColumn.AllowEdit = false;
            this.colprovider_id.Width = 67;
            // 
            // colinactive
            // 
            this.colinactive.FieldName = "inactive";
            this.colinactive.Name = "colinactive";
            this.colinactive.OptionsColumn.AllowEdit = false;
            this.colinactive.Width = 87;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tfDescription);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.tfId);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(882, 41);
            this.panelControl1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(784, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 30);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Cod.:";
            // 
            // tfId
            // 
            this.tfId.Location = new System.Drawing.Point(38, 9);
            this.tfId.Name = "tfId";
            this.tfId.Properties.Mask.EditMask = "d";
            this.tfId.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfId.Size = new System.Drawing.Size(69, 20);
            this.tfId.TabIndex = 2;
            this.tfId.Enter += new System.EventHandler(this.tfId_Enter);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(110, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Descrição:";
            // 
            // tfDescription
            // 
            this.tfDescription.Location = new System.Drawing.Point(166, 9);
            this.tfDescription.Name = "tfDescription";
            this.tfDescription.Size = new System.Drawing.Size(612, 20);
            this.tfDescription.TabIndex = 2;
            this.tfDescription.Enter += new System.EventHandler(this.tfDescription_Enter);
            // 
            // SearchProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "SearchProductsForm";
            this.Size = new System.Drawing.Size(886, 435);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tfDescription.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private Buttons.ButtonSelect btnSelect;
        private Buttons.ButtonNew btnNew;
        private Buttons.ButtonExit btnExit;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl productGridControl;
        private System.Windows.Forms.BindingSource bdgProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private DevExpress.XtraGrid.Columns.GridColumn colmax_stock;
        private DevExpress.XtraGrid.Columns.GridColumn colmin_stock;
        private DevExpress.XtraGrid.Columns.GridColumn colcurrent_stock;
        private DevExpress.XtraGrid.Columns.GridColumn colinitial_stock;
        private DevExpress.XtraGrid.Columns.GridColumn colalter_in_sale;
        private DevExpress.XtraGrid.Columns.GridColumn colvalue_cost;
        private DevExpress.XtraGrid.Columns.GridColumn colvalue_sale;
        private DevExpress.XtraGrid.Columns.GridColumn colvalue_gain;
        private DevExpress.XtraGrid.Columns.GridColumn colgain_in_percent;
        private DevExpress.XtraGrid.Columns.GridColumn coljoined_at;
        private DevExpress.XtraGrid.Columns.GridColumn colcategory_id;
        private DevExpress.XtraGrid.Columns.GridColumn colprovider_id;
        private DevExpress.XtraGrid.Columns.GridColumn colinactive;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Buttons.ButtonSearch btnSearch;
        private DevExpress.XtraEditors.TextEdit tfDescription;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tfId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

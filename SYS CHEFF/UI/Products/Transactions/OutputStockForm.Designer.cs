namespace SYS_CHEF.UI.Products.Transactions
{
    partial class OutputStockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutputStockForm));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdgProductsOutput = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname_product = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colquantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnRemove = new SYS_CHEF.UI.Buttons.ButtonRemove();
            this.btnSave = new SYS_CHEF.UI.Buttons.ButtonSave();
            this.btnExit = new SYS_CHEF.UI.Buttons.ButtonExit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.tfQuantity = new DevExpress.XtraEditors.TextEdit();
            this.cbProduct = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.bdgProducts = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.colunity_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprovider_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colinactive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdd = new SYS_CHEF.UI.Buttons.ButtonAdd();
            this.validatorProduct = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tfReason = new DevExpress.XtraEditors.TextEdit();
            this.validatorOutput = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgProductsOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfReason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorOutput)).BeginInit();
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
            this.groupControl1.Size = new System.Drawing.Size(925, 470);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Saída de Estoque";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl4);
            this.panelControl3.Controls.Add(this.gridControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 60);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(921, 368);
            this.panelControl3.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdgProductsOutput;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(917, 320);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdgProductsOutput
            // 
            this.bdgProductsOutput.DataSource = typeof(SYS_CHEF.products_output);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname_product,
            this.colquantity});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colname_product
            // 
            this.colname_product.Caption = "Produto";
            this.colname_product.FieldName = "name_product";
            this.colname_product.Name = "colname_product";
            this.colname_product.OptionsColumn.AllowEdit = false;
            this.colname_product.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "name_product", "Total de produtos: {0:d}")});
            this.colname_product.Visible = true;
            this.colname_product.VisibleIndex = 0;
            this.colname_product.Width = 731;
            // 
            // colquantity
            // 
            this.colquantity.Caption = "Quantidade";
            this.colquantity.FieldName = "quantity";
            this.colquantity.Name = "colquantity";
            this.colquantity.OptionsColumn.AllowEdit = false;
            this.colquantity.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "quantity", "Total: {0}")});
            this.colquantity.Visible = true;
            this.colquantity.VisibleIndex = 1;
            this.colquantity.Width = 168;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnRemove);
            this.panelControl2.Controls.Add(this.btnSave);
            this.panelControl2.Controls.Add(this.btnExit);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 428);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(921, 40);
            this.panelControl2.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(5, 5);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(95, 30);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remover";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(720, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Salvar";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(821, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.tfQuantity);
            this.panelControl1.Controls.Add(this.cbProduct);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(921, 39);
            this.panelControl1.TabIndex = 0;
            // 
            // tfQuantity
            // 
            this.tfQuantity.Location = new System.Drawing.Point(435, 10);
            this.tfQuantity.Name = "tfQuantity";
            this.tfQuantity.Properties.Mask.EditMask = "d";
            this.tfQuantity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.tfQuantity.Size = new System.Drawing.Size(72, 20);
            this.tfQuantity.TabIndex = 3;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule2.ErrorText = "Informe a quantidade";
            conditionValidationRule2.Value1 = ((long)(0));
            this.validatorProduct.SetValidationRule(this.tfQuantity, conditionValidationRule2);
            this.tfQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyAdd_KeyDown);
            // 
            // cbProduct
            // 
            this.cbProduct.Location = new System.Drawing.Point(53, 10);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbProduct.Properties.DataSource = this.bdgProducts;
            this.cbProduct.Properties.DisplayMember = "description";
            this.cbProduct.Properties.NullText = "";
            this.cbProduct.Properties.ValueMember = "id";
            this.cbProduct.Properties.View = this.searchLookUpEdit1View;
            this.cbProduct.Size = new System.Drawing.Size(300, 20);
            this.cbProduct.TabIndex = 2;
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.Greater;
            conditionValidationRule3.ErrorText = "Infome o produto";
            conditionValidationRule3.Value1 = ((long)(0));
            this.validatorProduct.SetValidationRule(this.cbProduct, conditionValidationRule3);
            this.cbProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyAdd_KeyDown);
            // 
            // bdgProducts
            // 
            this.bdgProducts.DataSource = typeof(SYS_CHEF.product);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.colunity_id,
            this.colprovider_id,
            this.colinactive});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colid
            // 
            this.colid.Caption = "Cod.";
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.AllowEdit = false;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 141;
            // 
            // coldescription
            // 
            this.coldescription.Caption = "Descrição";
            this.coldescription.FieldName = "description";
            this.coldescription.Name = "coldescription";
            this.coldescription.OptionsColumn.AllowEdit = false;
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 1;
            this.coldescription.Width = 648;
            // 
            // colmax_stock
            // 
            this.colmax_stock.FieldName = "max_stock";
            this.colmax_stock.Name = "colmax_stock";
            this.colmax_stock.OptionsColumn.AllowEdit = false;
            // 
            // colmin_stock
            // 
            this.colmin_stock.FieldName = "min_stock";
            this.colmin_stock.Name = "colmin_stock";
            this.colmin_stock.OptionsColumn.AllowEdit = false;
            // 
            // colcurrent_stock
            // 
            this.colcurrent_stock.Caption = "Estoque atual";
            this.colcurrent_stock.FieldName = "current_stock";
            this.colcurrent_stock.Name = "colcurrent_stock";
            this.colcurrent_stock.OptionsColumn.AllowEdit = false;
            this.colcurrent_stock.Visible = true;
            this.colcurrent_stock.VisibleIndex = 2;
            this.colcurrent_stock.Width = 289;
            // 
            // colinitial_stock
            // 
            this.colinitial_stock.FieldName = "initial_stock";
            this.colinitial_stock.Name = "colinitial_stock";
            this.colinitial_stock.OptionsColumn.AllowEdit = false;
            // 
            // colalter_in_sale
            // 
            this.colalter_in_sale.FieldName = "alter_in_sale";
            this.colalter_in_sale.Name = "colalter_in_sale";
            this.colalter_in_sale.OptionsColumn.AllowEdit = false;
            // 
            // colvalue_cost
            // 
            this.colvalue_cost.FieldName = "value_cost";
            this.colvalue_cost.Name = "colvalue_cost";
            this.colvalue_cost.OptionsColumn.AllowEdit = false;
            // 
            // colvalue_sale
            // 
            this.colvalue_sale.FieldName = "value_sale";
            this.colvalue_sale.Name = "colvalue_sale";
            this.colvalue_sale.OptionsColumn.AllowEdit = false;
            // 
            // colvalue_gain
            // 
            this.colvalue_gain.FieldName = "value_gain";
            this.colvalue_gain.Name = "colvalue_gain";
            this.colvalue_gain.OptionsColumn.AllowEdit = false;
            // 
            // colgain_in_percent
            // 
            this.colgain_in_percent.FieldName = "gain_in_percent";
            this.colgain_in_percent.Name = "colgain_in_percent";
            this.colgain_in_percent.OptionsColumn.AllowEdit = false;
            // 
            // coljoined_at
            // 
            this.coljoined_at.FieldName = "joined_at";
            this.coljoined_at.Name = "coljoined_at";
            this.coljoined_at.OptionsColumn.AllowEdit = false;
            // 
            // colcategory_id
            // 
            this.colcategory_id.FieldName = "category_id";
            this.colcategory_id.Name = "colcategory_id";
            this.colcategory_id.OptionsColumn.AllowEdit = false;
            // 
            // colunity_id
            // 
            this.colunity_id.FieldName = "unity_id";
            this.colunity_id.Name = "colunity_id";
            this.colunity_id.OptionsColumn.AllowEdit = false;
            // 
            // colprovider_id
            // 
            this.colprovider_id.FieldName = "provider_id";
            this.colprovider_id.Name = "colprovider_id";
            this.colprovider_id.OptionsColumn.AllowEdit = false;
            // 
            // colinactive
            // 
            this.colinactive.FieldName = "inactive";
            this.colinactive.Name = "colinactive";
            this.colinactive.OptionsColumn.AllowEdit = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(369, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Quantidade:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Produto:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(823, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.tfReason);
            this.panelControl4.Controls.Add(this.labelControl3);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl4.Location = new System.Drawing.Point(2, 328);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(917, 38);
            this.panelControl4.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Motivo:";
            // 
            // tfReason
            // 
            this.tfReason.Location = new System.Drawing.Point(47, 9);
            this.tfReason.Name = "tfReason";
            this.tfReason.Size = new System.Drawing.Size(865, 20);
            this.tfReason.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Informe o motivo da saída.";
            this.validatorOutput.SetValidationRule(this.tfReason, conditionValidationRule1);
            // 
            // OutputStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "OutputStockForm";
            this.Size = new System.Drawing.Size(925, 470);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgProductsOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tfReason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validatorOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private Buttons.ButtonRemove btnRemove;
        private Buttons.ButtonSave btnSave;
        private Buttons.ButtonExit btnExit;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Buttons.ButtonAdd btnAdd;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bdgProductsOutput;
        private DevExpress.XtraGrid.Columns.GridColumn colname_product;
        private DevExpress.XtraGrid.Columns.GridColumn colquantity;
        private DevExpress.XtraEditors.TextEdit tfQuantity;
        private DevExpress.XtraEditors.SearchLookUpEdit cbProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validatorProduct;
        private System.Windows.Forms.BindingSource bdgProducts;
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
        private DevExpress.XtraGrid.Columns.GridColumn colunity_id;
        private DevExpress.XtraGrid.Columns.GridColumn colprovider_id;
        private DevExpress.XtraGrid.Columns.GridColumn colinactive;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.TextEdit tfReason;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider validatorOutput;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}

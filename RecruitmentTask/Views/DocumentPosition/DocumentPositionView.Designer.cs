namespace RecruitmentTask.Views.DocumentPositionView {
    partial class DocumentPositionView {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		 #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.ProductNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.documentPositionViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuantityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.NetPriceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.GrossPriceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.DocumentHeadLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.DocumentHeadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DocumentHeadLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForProductName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForQuantity = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForNetPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForGrossPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDocumentHeadId = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReset = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiClose = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSaveLayout = new DevExpress.XtraBars.BarButtonItem();
            this.bbiResetLayout = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiCustomize = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupLayout = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentPositionViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetPriceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrossPriceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentHeadLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentHeadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentHeadLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNetPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGrossPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocumentHeadId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.ProductNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.QuantityTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NetPriceTextEdit);
            this.dataLayoutControl1.Controls.Add(this.GrossPriceTextEdit);
            this.dataLayoutControl1.Controls.Add(this.DocumentHeadLookUpEdit);
            this.dataLayoutControl1.DataSource = this.documentPositionViewBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 132);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1024, 636);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // ProductNameTextEdit
            // 
            this.ProductNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.documentPositionViewBindingSource, "ProductName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ProductNameTextEdit.Location = new System.Drawing.Point(113, 12);
            this.ProductNameTextEdit.Name = "ProductNameTextEdit";
            this.ProductNameTextEdit.Size = new System.Drawing.Size(899, 20);
            this.ProductNameTextEdit.StyleController = this.dataLayoutControl1;
            this.ProductNameTextEdit.TabIndex = 5;
            // 
            // documentPositionViewBindingSource
            // 
            this.documentPositionViewBindingSource.DataSource = typeof(RecruitmentTask.DocumentPosition);
            // 
            // QuantityTextEdit
            // 
            this.QuantityTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.documentPositionViewBindingSource, "Quantity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.QuantityTextEdit.Location = new System.Drawing.Point(113, 36);
            this.QuantityTextEdit.Name = "QuantityTextEdit";
            this.QuantityTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.QuantityTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.QuantityTextEdit.Properties.Mask.EditMask = "N0";
            this.QuantityTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.QuantityTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.QuantityTextEdit.Size = new System.Drawing.Size(899, 20);
            this.QuantityTextEdit.StyleController = this.dataLayoutControl1;
            this.QuantityTextEdit.TabIndex = 6;
            // 
            // NetPriceTextEdit
            // 
            this.NetPriceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.documentPositionViewBindingSource, "NetPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NetPriceTextEdit.Location = new System.Drawing.Point(113, 60);
            this.NetPriceTextEdit.Name = "NetPriceTextEdit";
            this.NetPriceTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.NetPriceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.NetPriceTextEdit.Properties.Mask.EditMask = "G";
            this.NetPriceTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.NetPriceTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.NetPriceTextEdit.Size = new System.Drawing.Size(899, 20);
            this.NetPriceTextEdit.StyleController = this.dataLayoutControl1;
            this.NetPriceTextEdit.TabIndex = 7;
            // 
            // GrossPriceTextEdit
            // 
            this.GrossPriceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.documentPositionViewBindingSource, "GrossPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.GrossPriceTextEdit.Location = new System.Drawing.Point(113, 84);
            this.GrossPriceTextEdit.Name = "GrossPriceTextEdit";
            this.GrossPriceTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.GrossPriceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.GrossPriceTextEdit.Properties.Mask.EditMask = "G";
            this.GrossPriceTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.GrossPriceTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.GrossPriceTextEdit.Size = new System.Drawing.Size(899, 20);
            this.GrossPriceTextEdit.StyleController = this.dataLayoutControl1;
            this.GrossPriceTextEdit.TabIndex = 8;
            // 
            // DocumentHeadLookUpEdit
            // 
            this.DocumentHeadLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.documentPositionViewBindingSource, "DocumentHeadId", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DocumentHeadLookUpEdit.Location = new System.Drawing.Point(113, 108);
            this.DocumentHeadLookUpEdit.Name = "DocumentHeadLookUpEdit";
            this.DocumentHeadLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DocumentHeadLookUpEdit.Properties.DataSource = this.DocumentHeadBindingSource;
            this.DocumentHeadLookUpEdit.Properties.DisplayMember = "Name";
            this.DocumentHeadLookUpEdit.Properties.PopupView = this.DocumentHeadLookUpEditView;
            this.DocumentHeadLookUpEdit.Properties.ReadOnly = true;
            this.DocumentHeadLookUpEdit.Properties.ValueMember = "Id";
            this.DocumentHeadLookUpEdit.Size = new System.Drawing.Size(899, 20);
            this.DocumentHeadLookUpEdit.StyleController = this.dataLayoutControl1;
            this.DocumentHeadLookUpEdit.TabIndex = 9;
            // 
            // DocumentHeadBindingSource
            // 
            this.DocumentHeadBindingSource.DataSource = typeof(RecruitmentTask.DocumentHead);
            // 
            // DocumentHeadLookUpEditView
            // 
            this.DocumentHeadLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.DocumentHeadLookUpEditView.Name = "DocumentHeadLookUpEditView";
            this.DocumentHeadLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.DocumentHeadLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1024, 636);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForProductName,
            this.ItemForQuantity,
            this.ItemForNetPrice,
            this.ItemForGrossPrice,
            this.ItemForDocumentHeadId});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(1004, 616);
            // 
            // ItemForProductName
            // 
            this.ItemForProductName.Control = this.ProductNameTextEdit;
            this.ItemForProductName.Location = new System.Drawing.Point(0, 0);
            this.ItemForProductName.Name = "ItemForProductName";
            this.ItemForProductName.Size = new System.Drawing.Size(1004, 24);
            this.ItemForProductName.Text = "Product Name";
            this.ItemForProductName.TextSize = new System.Drawing.Size(89, 13);
            // 
            // ItemForQuantity
            // 
            this.ItemForQuantity.Control = this.QuantityTextEdit;
            this.ItemForQuantity.Location = new System.Drawing.Point(0, 24);
            this.ItemForQuantity.Name = "ItemForQuantity";
            this.ItemForQuantity.Size = new System.Drawing.Size(1004, 24);
            this.ItemForQuantity.Text = "Quantity";
            this.ItemForQuantity.TextSize = new System.Drawing.Size(89, 13);
            // 
            // ItemForNetPrice
            // 
            this.ItemForNetPrice.Control = this.NetPriceTextEdit;
            this.ItemForNetPrice.Location = new System.Drawing.Point(0, 48);
            this.ItemForNetPrice.Name = "ItemForNetPrice";
            this.ItemForNetPrice.Size = new System.Drawing.Size(1004, 24);
            this.ItemForNetPrice.Text = "Net Price";
            this.ItemForNetPrice.TextSize = new System.Drawing.Size(89, 13);
            // 
            // ItemForGrossPrice
            // 
            this.ItemForGrossPrice.Control = this.GrossPriceTextEdit;
            this.ItemForGrossPrice.Location = new System.Drawing.Point(0, 72);
            this.ItemForGrossPrice.Name = "ItemForGrossPrice";
            this.ItemForGrossPrice.Size = new System.Drawing.Size(1004, 24);
            this.ItemForGrossPrice.Text = "Gross Price";
            this.ItemForGrossPrice.TextSize = new System.Drawing.Size(89, 13);
            // 
            // ItemForDocumentHeadId
            // 
            this.ItemForDocumentHeadId.Control = this.DocumentHeadLookUpEdit;
            this.ItemForDocumentHeadId.Location = new System.Drawing.Point(0, 96);
            this.ItemForDocumentHeadId.Name = "ItemForDocumentHeadId";
            this.ItemForDocumentHeadId.Size = new System.Drawing.Size(1004, 520);
            this.ItemForDocumentHeadId.Text = "Document Head Id";
            this.ItemForDocumentHeadId.TextSize = new System.Drawing.Size(89, 13);
            // 
            // mvvmContext
            // 
            this.mvvmContext.BindingExpressions.AddRange(new DevExpress.Utils.MVVM.BindingExpression[] {
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(RecruitmentTask.ViewModels.DocumentPositionViewModel), "Save", this.bbiSave),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(RecruitmentTask.ViewModels.DocumentPositionViewModel), "SaveAndClose", this.bbiSaveAndClose),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(RecruitmentTask.ViewModels.DocumentPositionViewModel), "SaveAndNew", this.bbiSaveAndNew),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(RecruitmentTask.ViewModels.DocumentPositionViewModel), "Reset", this.bbiReset),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(RecruitmentTask.ViewModels.DocumentPositionViewModel), "Delete", this.bbiDelete),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(RecruitmentTask.ViewModels.DocumentPositionViewModel), "Close", this.bbiClose),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(RecruitmentTask.ViewModels.DocumentPositionViewModel), "SaveLayout", this.bbiSaveLayout),
            DevExpress.Utils.MVVM.BindingExpression.CreateCommandBinding(typeof(RecruitmentTask.ViewModels.DocumentPositionViewModel), "ResetLayout", this.bbiResetLayout)});
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.RegistrationExpressions.AddRange(new DevExpress.Utils.MVVM.RegistrationExpression[] {
            DevExpress.Utils.MVVM.RegistrationExpression.RegisterLayoutSerializationService(null, false, DevExpress.Utils.DefaultBoolean.True, this.dataLayoutControl1)});
            this.mvvmContext.ViewModelType = typeof(RecruitmentTask.ViewModels.DocumentPositionViewModel);
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 2;
            this.bbiSave.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSave.Name = "bbiSave";
            // 
            // bbiSaveAndClose
            // 
            this.bbiSaveAndClose.Caption = "Save And Close";
            this.bbiSaveAndClose.Id = 3;
            this.bbiSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bbiSaveAndClose.Name = "bbiSaveAndClose";
            // 
            // bbiSaveAndNew
            // 
            this.bbiSaveAndNew.Caption = "Save And New";
            this.bbiSaveAndNew.Id = 4;
            this.bbiSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bbiSaveAndNew.Name = "bbiSaveAndNew";
            // 
            // bbiReset
            // 
            this.bbiReset.Caption = "Reset Changes";
            this.bbiReset.Id = 5;
            this.bbiReset.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiReset.Name = "bbiReset";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 6;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiClose
            // 
            this.bbiClose.Caption = "Close";
            this.bbiClose.Id = 7;
            this.bbiClose.ImageOptions.ImageUri.Uri = "Close";
            this.bbiClose.Name = "bbiClose";
            // 
            // bbiSaveLayout
            // 
            this.bbiSaveLayout.Caption = "Save Layout";
            this.bbiSaveLayout.Id = 8;
            this.bbiSaveLayout.ImageOptions.ImageUri.Uri = "Save";
            this.bbiSaveLayout.Name = "bbiSaveLayout";
            // 
            // bbiResetLayout
            // 
            this.bbiResetLayout.Caption = "Reset Layout";
            this.bbiResetLayout.Id = 9;
            this.bbiResetLayout.ImageOptions.ImageUri.Uri = "Reset";
            this.bbiResetLayout.Name = "bbiResetLayout";
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.mainRibbonControl.SearchEditItem,
            this.bbiCustomize,
            this.bbiSave,
            this.bbiSaveAndClose,
            this.bbiSaveAndNew,
            this.bbiReset,
            this.bbiDelete,
            this.bbiClose,
            this.bbiSaveLayout,
            this.bbiResetLayout});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 10;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.Size = new System.Drawing.Size(1024, 132);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiCustomize
            // 
            this.bbiCustomize.Caption = "Customize";
            this.bbiCustomize.Id = 1;
            this.bbiCustomize.ImageOptions.ImageUri.Uri = "Customization";
            this.bbiCustomize.Name = "bbiCustomize";
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup,
            this.ribbonPageGroupLayout});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Home";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSave);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSaveAndClose);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiSaveAndNew);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiReset);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiDelete);
            this.mainRibbonPageGroup.ItemLinks.Add(this.bbiClose);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.Text = "DocumentPosition Tasks";
            // 
            // ribbonPageGroupLayout
            // 
            this.ribbonPageGroupLayout.AllowTextClipping = false;
            this.ribbonPageGroupLayout.ItemLinks.Add(this.bbiCustomize);
            this.ribbonPageGroupLayout.ItemLinks.Add(this.bbiSaveLayout);
            this.ribbonPageGroupLayout.ItemLinks.Add(this.bbiResetLayout);
            this.ribbonPageGroupLayout.Name = "ribbonPageGroupLayout";
            this.ribbonPageGroupLayout.Text = "Layout";
            // 
            // DocumentPositionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "DocumentPositionView";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentPositionViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetPriceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrossPriceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentHeadLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentHeadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentHeadLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForProductName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForNetPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForGrossPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocumentHeadId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
        #endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
		private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
		private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
		private DevExpress.XtraBars.BarButtonItem bbiCustomize;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupLayout;
		private System.Windows.Forms.BindingSource documentPositionViewBindingSource;
						private DevExpress.XtraEditors.GridLookUpEdit DocumentHeadLookUpEdit;
		private System.Windows.Forms.BindingSource DocumentHeadBindingSource;
        private DevExpress.XtraEditors.TextEdit ProductNameTextEdit;
        private DevExpress.XtraEditors.TextEdit QuantityTextEdit;
        private DevExpress.XtraEditors.TextEdit NetPriceTextEdit;
        private DevExpress.XtraEditors.TextEdit GrossPriceTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView DocumentHeadLookUpEditView;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForProductName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForQuantity;
        private DevExpress.XtraLayout.LayoutControlItem ItemForNetPrice;
        private DevExpress.XtraLayout.LayoutControlItem ItemForGrossPrice;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDocumentHeadId;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveAndNew;
        private DevExpress.XtraBars.BarButtonItem bbiReset;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiClose;
        private DevExpress.XtraBars.BarButtonItem bbiSaveLayout;
        private DevExpress.XtraBars.BarButtonItem bbiResetLayout;
    }
}

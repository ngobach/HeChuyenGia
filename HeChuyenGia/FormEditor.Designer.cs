namespace HeChuyenGia
{
    partial class FormEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditor));
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnOpen = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnSave = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnExport = new DevExpress.XtraBars.BarButtonItem();
            this.btnPreview = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaQuanHe = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddQuanHe = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddTrieuChung = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddBenh = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdit = new DevExpress.XtraEditors.TextEdit();
            this.gridQuanHe = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lstTrieuChung = new DevExpress.XtraEditors.ListBoxControl();
            this.lstBenh = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuanHe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTrieuChung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstBenh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.barBtnOpen,
            this.barBtnSave,
            this.barBtnExport,
            this.btnPreview});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 5;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageHome});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(821, 146);
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barBtnOpen
            // 
            this.barBtnOpen.Caption = "Open";
            this.barBtnOpen.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnOpen.Glyph")));
            this.barBtnOpen.Id = 1;
            this.barBtnOpen.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnOpen.LargeGlyph")));
            this.barBtnOpen.Name = "barBtnOpen";
            this.barBtnOpen.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnOpen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnOpen_ItemClick);
            // 
            // barBtnSave
            // 
            this.barBtnSave.Caption = "Save";
            this.barBtnSave.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnSave.Glyph")));
            this.barBtnSave.Id = 2;
            this.barBtnSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnSave.LargeGlyph")));
            this.barBtnSave.Name = "barBtnSave";
            this.barBtnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnSave_ItemClick);
            // 
            // barBtnExport
            // 
            this.barBtnExport.Caption = "Prolog file";
            this.barBtnExport.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnExport.Glyph")));
            this.barBtnExport.Id = 3;
            this.barBtnExport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnExport.LargeGlyph")));
            this.barBtnExport.Name = "barBtnExport";
            this.barBtnExport.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnExport_ItemClick);
            // 
            // btnPreview
            // 
            this.btnPreview.Caption = "Xem trước";
            this.btnPreview.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPreview.Glyph")));
            this.btnPreview.Id = 4;
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPreview_ItemClick);
            // 
            // ribbonPageHome
            // 
            this.ribbonPageHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPageHome.Name = "ribbonPageHome";
            this.ribbonPageHome.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnOpen);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnSave);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "File";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnExport);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPreview);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Xuất ra";
            // 
            // tabFormDefaultManager1
            // 
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
            this.tabFormDefaultManager1.Form = this;
            this.tabFormDefaultManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(821, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 624);
            this.barDockControlBottom.Size = new System.Drawing.Size(821, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 624);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(821, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 624);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.groupControl1);
            this.layoutControl1.Controls.Add(this.gridQuanHe);
            this.layoutControl1.Controls.Add(this.lstTrieuChung);
            this.layoutControl1.Controls.Add(this.lstBenh);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 146);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(778, 378, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(821, 478);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.btnDelete);
            this.groupControl1.Controls.Add(this.btnXoaQuanHe);
            this.groupControl1.Controls.Add(this.btnAddQuanHe);
            this.groupControl1.Controls.Add(this.btnAddTrieuChung);
            this.groupControl1.Controls.Add(this.btnAddBenh);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtEdit);
            this.groupControl1.Location = new System.Drawing.Point(12, 383);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(797, 83);
            this.groupControl1.TabIndex = 7;
            this.groupControl1.Text = "Thêm mới";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnUpdate.Location = new System.Drawing.Point(331, 24);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(47, 45);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnDelete.Location = new System.Drawing.Point(278, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(47, 45);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnXoaQuanHe
            // 
            this.btnXoaQuanHe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaQuanHe.Location = new System.Drawing.Point(558, 24);
            this.btnXoaQuanHe.Name = "btnXoaQuanHe";
            this.btnXoaQuanHe.Size = new System.Drawing.Size(114, 45);
            this.btnXoaQuanHe.TabIndex = 5;
            this.btnXoaQuanHe.Text = "Xóa quan hệ";
            this.btnXoaQuanHe.Click += new System.EventHandler(this.btnXoaQuanHe_Click);
            // 
            // btnAddQuanHe
            // 
            this.btnAddQuanHe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddQuanHe.Location = new System.Drawing.Point(678, 24);
            this.btnAddQuanHe.Name = "btnAddQuanHe";
            this.btnAddQuanHe.Size = new System.Drawing.Size(114, 45);
            this.btnAddQuanHe.TabIndex = 5;
            this.btnAddQuanHe.Text = "Thêm quan hệ";
            this.btnAddQuanHe.Click += new System.EventHandler(this.btnAddQuanHe_Click);
            // 
            // btnAddTrieuChung
            // 
            this.btnAddTrieuChung.Location = new System.Drawing.Point(149, 46);
            this.btnAddTrieuChung.Name = "btnAddTrieuChung";
            this.btnAddTrieuChung.Size = new System.Drawing.Size(123, 23);
            this.btnAddTrieuChung.TabIndex = 4;
            this.btnAddTrieuChung.Text = "Thêm triệu chứng";
            this.btnAddTrieuChung.Click += new System.EventHandler(this.btnAddTrieuChung_Click);
            // 
            // btnAddBenh
            // 
            this.btnAddBenh.Location = new System.Drawing.Point(35, 46);
            this.btnAddBenh.Name = "btnAddBenh";
            this.btnAddBenh.Size = new System.Drawing.Size(108, 23);
            this.btnAddBenh.TabIndex = 4;
            this.btnAddBenh.Text = "Thêm bệnh";
            this.btnAddBenh.Click += new System.EventHandler(this.btnAddBenh_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(18, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Tên";
            // 
            // txtEdit
            // 
            this.txtEdit.Location = new System.Drawing.Point(35, 24);
            this.txtEdit.MenuManager = this.ribbonControl;
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(237, 20);
            this.txtEdit.TabIndex = 0;
            // 
            // gridQuanHe
            // 
            this.gridQuanHe.Location = new System.Drawing.Point(468, 28);
            this.gridQuanHe.MainView = this.gridView;
            this.gridQuanHe.Name = "gridQuanHe";
            this.gridQuanHe.Size = new System.Drawing.Size(341, 351);
            this.gridQuanHe.TabIndex = 6;
            this.gridQuanHe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView.GridControl = this.gridQuanHe;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên Bệnh";
            this.gridColumn1.FieldName = "Benh";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Triệu chứng";
            this.gridColumn2.FieldName = "TrieuChung";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // lstTrieuChung
            // 
            this.lstTrieuChung.Location = new System.Drawing.Point(226, 28);
            this.lstTrieuChung.Name = "lstTrieuChung";
            this.lstTrieuChung.Size = new System.Drawing.Size(238, 351);
            this.lstTrieuChung.StyleController = this.layoutControl1;
            this.lstTrieuChung.TabIndex = 5;
            this.lstTrieuChung.Click += new System.EventHandler(this.lstBenh_Click);
            // 
            // lstBenh
            // 
            this.lstBenh.Location = new System.Drawing.Point(12, 28);
            this.lstBenh.Name = "lstBenh";
            this.lstBenh.Size = new System.Drawing.Size(210, 351);
            this.lstBenh.StyleController = this.layoutControl1;
            this.lstBenh.TabIndex = 4;
            this.lstBenh.Click += new System.EventHandler(this.lstBenh_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(821, 478);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lstBenh;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(214, 371);
            this.layoutControlItem1.Text = "Bệnh";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lstTrieuChung;
            this.layoutControlItem2.Location = new System.Drawing.Point(214, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(242, 371);
            this.layoutControlItem2.Text = "Triệu chứng";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridQuanHe;
            this.layoutControlItem3.Location = new System.Drawing.Point(456, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(345, 371);
            this.layoutControlItem3.Text = "Quan hệ";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(57, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.groupControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 371);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(0, 87);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(5, 87);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(801, 87);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // FormEditor
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 624);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.MinimumSize = new System.Drawing.Size(811, 596);
            this.Name = "FormEditor";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Biên tập tri thức";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditor_FormClosed);
            this.Load += new System.EventHandler(this.FormEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuanHe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstTrieuChung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstBenh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHome;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.TabFormDefaultManager tabFormDefaultManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtnOpen;
        private DevExpress.XtraBars.BarButtonItem barBtnSave;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ListBoxControl lstBenh;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.ListBoxControl lstTrieuChung;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl gridQuanHe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEdit;
        private DevExpress.XtraEditors.SimpleButton btnAddTrieuChung;
        private DevExpress.XtraEditors.SimpleButton btnAddBenh;
        private DevExpress.XtraEditors.SimpleButton btnAddQuanHe;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraBars.BarButtonItem barBtnExport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.SimpleButton btnXoaQuanHe;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnPreview;
    }
}
namespace HeChuyenGia
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnUnLoad = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnInfo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.status = new DevExpress.XtraBars.BarStaticItem();
            this.btnEditor = new DevExpress.XtraBars.BarButtonItem();
            this.result = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lstBenh = new DevExpress.XtraEditors.ListBoxControl();
            this.lstDauHieu = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.listBoxControl2 = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstBenh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDauHieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2013";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chuẩn đoán";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLoad);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUnLoad);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Prolog Engine";
            // 
            // btnLoad
            // 
            this.btnLoad.Caption = "Load file";
            this.btnLoad.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLoad.Glyph")));
            this.btnLoad.Id = 1;
            this.btnLoad.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLoad.LargeGlyph")));
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoad_ItemClick);
            // 
            // btnUnLoad
            // 
            this.btnUnLoad.Caption = "Unload Engine";
            this.btnUnLoad.Glyph = ((System.Drawing.Image)(resources.GetObject("btnUnLoad.Glyph")));
            this.btnUnLoad.Id = 1;
            this.btnUnLoad.Name = "btnUnLoad";
            this.btnUnLoad.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnUnLoad.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUnLoad_ItemClick);
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnInfo);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Hỗ trợ";
            // 
            // btnInfo
            // 
            this.btnInfo.Caption = "Thông tin";
            this.btnInfo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnInfo.Glyph")));
            this.btnInfo.Id = 3;
            this.btnInfo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnInfo.LargeGlyph")));
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInfo_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Chuẩn đoán";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btnLoad,
            this.btnInfo,
            this.status,
            this.btnEditor,
            this.btnUnLoad,
            this.barButtonItem1,
            this.result});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 4;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.PageHeaderItemLinks.Add(this.btnInfo);
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(812, 147);
            this.ribbonControl.StatusBar = this.statusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // status
            // 
            this.status.Caption = "Awesome project!";
            this.status.Id = 9;
            this.status.Name = "status";
            this.status.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnEditor
            // 
            this.btnEditor.Caption = "Biên tập";
            this.btnEditor.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEditor.Glyph")));
            this.btnEditor.Id = 10;
            this.btnEditor.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEditor.LargeGlyph")));
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnEditor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditor_ItemClick);
            // 
            // result
            // 
            this.result.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.result.Caption = "Kết quả";
            this.result.Id = 3;
            this.result.ImageUri.Uri = "Show";
            this.result.ItemAppearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.result.ItemAppearance.Normal.Options.UseFont = true;
            this.result.Name = "result";
            this.result.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Tập luật";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.btnEditor);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            // 
            // statusBar
            // 
            this.statusBar.ItemLinks.Add(this.status);
            this.statusBar.ItemLinks.Add(this.result);
            this.statusBar.Location = new System.Drawing.Point(0, 656);
            this.statusBar.Name = "statusBar";
            this.statusBar.Ribbon = this.ribbonControl;
            this.statusBar.Size = new System.Drawing.Size(812, 23);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lstBenh);
            this.layoutControl1.Controls.Add(this.lstDauHieu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(601, 417, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(794, 464);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lstBenh
            // 
            this.lstBenh.Location = new System.Drawing.Point(399, 28);
            this.lstBenh.Name = "lstBenh";
            this.lstBenh.Size = new System.Drawing.Size(383, 424);
            this.lstBenh.StyleController = this.layoutControl1;
            this.lstBenh.TabIndex = 5;
            // 
            // lstDauHieu
            // 
            this.lstDauHieu.Location = new System.Drawing.Point(12, 28);
            this.lstDauHieu.Name = "lstDauHieu";
            this.lstDauHieu.Size = new System.Drawing.Size(383, 424);
            this.lstDauHieu.StyleController = this.layoutControl1;
            this.lstDauHieu.TabIndex = 4;
            this.lstDauHieu.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(this.lstDauHieu_ItemCheck);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 50D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 50D;
            this.layoutControlGroup1.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 100D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup1.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1});
            this.layoutControlGroup1.Size = new System.Drawing.Size(794, 464);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lstDauHieu;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(387, 444);
            this.layoutControlItem1.Text = "Tập dấu hiệu";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(87, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lstBenh;
            this.layoutControlItem2.Location = new System.Drawing.Point(387, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem2.Size = new System.Drawing.Size(387, 444);
            this.layoutControlItem2.Text = "Các bệnh phù hợp";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(87, 13);
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 147);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(812, 509);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(812, 509);
            this.tabPane1.TabIndex = 5;
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("tabNavigationPage1.Appearance.Image")));
            this.tabNavigationPage1.Appearance.Options.UseImage = true;
            this.tabNavigationPage1.Caption = "Tập tri thức";
            this.tabNavigationPage1.Controls.Add(this.layoutControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(794, 464);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Thông tin bệnh";
            this.tabNavigationPage2.Controls.Add(this.layoutControl2);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(794, 464);
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Chuẩn đoán bệnh";
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(794, 464);
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(12, 28);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(383, 424);
            this.listBoxControl1.StyleController = this.layoutControl2;
            this.listBoxControl1.TabIndex = 0;
            this.listBoxControl1.Click += new System.EventHandler(this.listBoxControl1_Click);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.listBoxControl2);
            this.layoutControl2.Controls.Add(this.listBoxControl1);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(621, 386, 693, 483);
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(794, 464);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup2.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "Root";
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition3.Width = 50D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition4.Width = 50D;
            this.layoutControlGroup2.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition3,
            columnDefinition4});
            rowDefinition2.Height = 100D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            this.layoutControlGroup2.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition2});
            this.layoutControlGroup2.Size = new System.Drawing.Size(794, 464);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.listBoxControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(387, 444);
            this.layoutControlItem3.Text = "Vui lòng chọn bệnh muốn xem";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(142, 13);
            // 
            // listBoxControl2
            // 
            this.listBoxControl2.Location = new System.Drawing.Point(399, 28);
            this.listBoxControl2.Name = "listBoxControl2";
            this.listBoxControl2.Size = new System.Drawing.Size(383, 424);
            this.listBoxControl2.StyleController = this.layoutControl2;
            this.listBoxControl2.TabIndex = 4;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.listBoxControl2;
            this.layoutControlItem4.Location = new System.Drawing.Point(387, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.OptionsTableLayoutItem.ColumnIndex = 1;
            this.layoutControlItem4.Size = new System.Drawing.Size(387, 444);
            this.layoutControlItem4.Text = "Các dấu hiệu";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(142, 13);
            // 
            // FormMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 679);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.ribbonControl);
            this.MinimumSize = new System.Drawing.Size(800, 680);
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.statusBar;
            this.Text = "Hệ chuyên gia - Chuẩn đoán bệnh viêm phổi";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstBenh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDauHieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem btnLoad;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnInfo;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar statusBar;
        private DevExpress.XtraBars.BarStaticItem status;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnEditor;
        private DevExpress.XtraBars.BarButtonItem btnUnLoad;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.CheckedListBoxControl lstDauHieu;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.ListBoxControl lstBenh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarStaticItem result;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}


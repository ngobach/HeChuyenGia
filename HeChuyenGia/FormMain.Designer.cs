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
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnUnLoad = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnPrint = new DevExpress.XtraBars.BarButtonItem();
            this.btnSavePDF = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveTXT = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnInfo = new DevExpress.XtraBars.BarButtonItem();
            this.btnHelp = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.status = new DevExpress.XtraBars.BarStaticItem();
            this.btnEditor = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lstBenh = new DevExpress.XtraEditors.ListBoxControl();
            this.lstDauHieu = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstBenh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDauHieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
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
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPrint);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSavePDF);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSaveTXT);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Kết quả";
            // 
            // btnPrint
            // 
            this.btnPrint.Caption = "In ra";
            this.btnPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("btnPrint.Glyph")));
            this.btnPrint.Id = 2;
            this.btnPrint.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnPrint.LargeGlyph")));
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnSavePDF
            // 
            this.btnSavePDF.Caption = "Lưu PDF";
            this.btnSavePDF.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSavePDF.Glyph")));
            this.btnSavePDF.Id = 3;
            this.btnSavePDF.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSavePDF.LargeGlyph")));
            this.btnSavePDF.Name = "btnSavePDF";
            this.btnSavePDF.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // btnSaveTXT
            // 
            this.btnSaveTXT.Caption = "Lưu TXT";
            this.btnSaveTXT.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSaveTXT.Glyph")));
            this.btnSaveTXT.Id = 4;
            this.btnSaveTXT.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSaveTXT.LargeGlyph")));
            this.btnSaveTXT.Name = "btnSaveTXT";
            this.btnSaveTXT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnInfo);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnHelp);
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
            // btnHelp
            // 
            this.btnHelp.Caption = "Hướng dẫn";
            this.btnHelp.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHelp.Glyph")));
            this.btnHelp.Id = 2;
            this.btnHelp.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnHelp.LargeGlyph")));
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.btnLoad,
            this.btnHelp,
            this.btnInfo,
            this.btnPrint,
            this.btnSavePDF,
            this.btnSaveTXT,
            this.status,
            this.btnEditor,
            this.btnUnLoad});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 2;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(810, 146);
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
            this.statusBar.ItemLinks.Add(this.btnInfo);
            this.statusBar.ItemLinks.Add(this.status);
            this.statusBar.Location = new System.Drawing.Point(0, 658);
            this.statusBar.Name = "statusBar";
            this.statusBar.Ribbon = this.ribbonControl;
            this.statusBar.Size = new System.Drawing.Size(810, 21);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lstBenh);
            this.layoutControl1.Controls.Add(this.lstDauHieu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 146);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(810, 512);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lstBenh
            // 
            this.lstBenh.Location = new System.Drawing.Point(407, 28);
            this.lstBenh.Name = "lstBenh";
            this.lstBenh.Size = new System.Drawing.Size(391, 472);
            this.lstBenh.StyleController = this.layoutControl1;
            this.lstBenh.TabIndex = 5;
            // 
            // lstDauHieu
            // 
            this.lstDauHieu.Location = new System.Drawing.Point(12, 28);
            this.lstDauHieu.Name = "lstDauHieu";
            this.lstDauHieu.Size = new System.Drawing.Size(391, 472);
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
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(810, 512);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lstDauHieu;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(395, 492);
            this.layoutControlItem1.Text = "Tập dấu hiệu";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(87, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lstBenh;
            this.layoutControlItem2.Location = new System.Drawing.Point(395, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(395, 492);
            this.layoutControlItem2.Text = "Các bệnh phù hợp";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(87, 13);
            // 
            // FormMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 679);
            this.Controls.Add(this.layoutControl1);
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
        private DevExpress.XtraBars.BarButtonItem btnHelp;
        private DevExpress.XtraBars.BarButtonItem btnInfo;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnSavePDF;
        private DevExpress.XtraBars.BarButtonItem btnSaveTXT;
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
    }
}


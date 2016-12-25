using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SbsSW.SwiPlCs;

namespace HeChuyenGia
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void PlInit(string file)
        {
            if (PlEngine.IsInitialized)
            {
                if (XtraMessageBox.Show(this, "Cần unload PlEngine trước khi load file khác?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
                PlEngine.PlCleanup();
            }
            string[] args = { "-q" , "-f", file };
            PlEngine.Initialize(args);
            status.Caption = "Load thành công: " + file;
            XtraMessageBox.Show(this, "Load thành công: " + file, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Hàm xử lý sau khi Prolog đc load thành công
        /// </summary>
        private void PlInitialized()
        {
            GiaoTiep.DocVao();
            lstDauHieu.DataSource = GiaoTiep.TapDauHieu();
            listBoxControl1.DataSource = GiaoTiep.TapBenh();
            tabPane1.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"C:\Program Files (x86)\swipl");
            Environment.SetEnvironmentVariable("Path", Environment.GetEnvironmentVariable("Path") + @";C:\Program Files (x86)\swipl\bin");
            status.Caption = "Sẵn sàng";
            tabPane1.Enabled = false;
        }

        private void btnEditor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            (new FormEditor()).ShowDialog(this);
        }

        private void btnInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraMessageBox.Show(
                this, 
                "<color=red><size=14>Hệ chuyên gia chuẩn đoán bệnh viêm phổi.</size></color>\n\n" + 
                "<size=9>"+
                "Thực hiện bởi nhóm sinh viên:\n" + 
                "<b>Ngô Xuân Bách & Đinh Viết Nam</b>\n" + 
                "Giảng viên hướng dẫn: \n" + 
                "<b>ThS Nguyễn Thị Thanh Tân</b>" + 
                "</size>",
                
                "Giới thiệu",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                DevExpress.Utils.DefaultBoolean.True
            );
        }

        private void btnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dlg = new OpenFileDialog { Filter = "Prolog file (*.pl)|*.pl" };
            if (dlg.ShowDialog(this) != DialogResult.OK) return;
            try { 
                PlInit(dlg.FileName);
                PlInitialized();
            }
            catch (Exception exc)
            {
                XtraMessageBox.Show(this, exc.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw exc;
            }
        }

        private void btnUnLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!PlEngine.IsInitialized) return;
            PlEngine.PlCleanup();
            XtraMessageBox.Show(this, "Unload thành công!", "Unload", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            status.Caption = "PlEngine unloaded!";
        }

        private void lstDauHieu_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
        {
            List<string> dauhieu = lstDauHieu.DataSource as List<string>;
            List<string> query = new List<string>();
            for (int i = 0; i < dauhieu.Count; i++)
            {
                if (lstDauHieu.GetItemChecked(i))
                {
                    query.Add(dauhieu[i]);
                }
            }

            if (query.Count == 0)
            {
                lstBenh.DataSource = null;
                return;
            }
            IList<string> result = GiaoTiep.TapBenh(query);
            lstBenh.DataSource = result;
            if (result.Count == 0)
            {
                this.result.Caption = "Không có kết quả";
            }
            else
            {
                this.result.Caption = string.Format("Tìm thấy {0} bệnh phù hợp", result.Count);
            }
        }

        private void listBoxControl1_Click(object sender, EventArgs e)
        {
            if (listBoxControl1.SelectedItem == null) return;
            string s = listBoxControl1.SelectedItem as string;
            listBoxControl2.DataSource = GiaoTiep.TapDauHieu(s);
        }
    }
}

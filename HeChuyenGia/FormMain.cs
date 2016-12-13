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
            List<string> dauhieu = new List<string>();
            HashSet<string> hs = new HashSet<string>();
            using (var query = new PlQuery("dinh_nghia(Benh, DauHieu)."))
            {
                foreach (var sol in query.SolutionVariables)
                {
                    string s = sol["DauHieu"].ToString();
                    if (!hs.Contains(s))
                    {
                        dauhieu.Add(sol["DauHieu"].ToString());
                        hs.Add(s);
                    }
                }
            }
            lstDauHieu.DataSource = dauhieu;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"C:\Program Files (x86)\swipl");
            Environment.SetEnvironmentVariable("Path", Environment.GetEnvironmentVariable("Path") + @";C:\Program Files (x86)\swipl\bin");

            status.Caption = "Sẵn sàng";
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
            List<string> result = new List<string>();
            HashSet<string> hs = new HashSet<string>();
            string str = string.Join(",", query.Select(x => string.Format("dinh_nghia(Benh, '{0}')", x))) + ".";
            using (var q = new PlQuery(str))
            {
                foreach (var sol in q.SolutionVariables)
                {
                    string s = sol["Benh"].ToString();
                    if (!hs.Contains(s))
                    {
                        hs.Add(s);
                        result.Add(s);
                    }
                }
            }
            lstBenh.DataSource = result;
            if (result.Count == 0)
            {
                XtraMessageBox.Show(this, "Hệ thống không thể chuẩn đoán bệnh với những dấu hiệu này", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (result.Count == 1)
            {
                XtraMessageBox.Show(this, "Các dấu hiệu phù hợp với bệnh\n" + result[0], "Chuẩn đoán", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

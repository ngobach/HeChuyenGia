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
        private List<string> queryCo = new List<string>();
        private List<string> queryKhong = new List<string>();

        public FormMain()
        {
            InitializeComponent();
        }

        private void PlInit(string file)
        {
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

            DoReset();
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
                if (PlEngine.IsInitialized)
                {
                    if (XtraMessageBox.Show(this, "Cần unload PlEngine trước khi load file khác?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                        return;
                    PlEngine.PlCleanup();
                }
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
            tabPane1.Enabled = false;
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
                this.result.Caption = "Sẵn sàng";
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            DoReset();
        }

        private void DoReset()
        {
            btnCo.Enabled = btnKhong.Enabled = true;
            queryCo = new List<string>();
            queryKhong = new List<string>();
            labelQueries.Text = "";
            labelResult.Text  = "";
            pictureBox.Image = Properties.Resources.ic_computer;
            DoSuggest();
        }

        private void DoSuggest()
        {
            IList<string> kq, cauhoi;
            GiaoTiep.Suggest(queryCo, queryKhong, out cauhoi, out kq);
            if (cauhoi.Count() == 0)
            {
                if (kq.Count() == 0)
                {
                    // Không có kết quả phù hợp
                    labelResult.Text = "Không có kết quả phù hợp";
                    pictureBox.Image = Properties.Resources.ic_error;
                }
                else
                {
                    // Tìm thấy kết quả phù hợp
                    labelResult.Text = "Kết quả phù hợp\n" + string.Join("\n", kq);
                    pictureBox.Image = Properties.Resources.ic_ok;
                }
                btnCo.Enabled = btnKhong.Enabled = false;
            }
            else
            {
                lblCauHoi.Text = cauhoi[0];
            }
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            labelQueries.Text += "<size=13><b>[?] " + lblCauHoi.Text + "</b></size>\n<size=11><color=green>Trả lời Có</color></size>\n";
            queryCo.Add(lblCauHoi.Text);
            DoSuggest();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            labelQueries.Text += "<size=13><b>[?] " + lblCauHoi.Text + "</b></size>\n<size=11><color=red>Trả lời Không</color></size>\n";
            queryKhong.Add(lblCauHoi.Text);
            DoSuggest();
        }
    }
}

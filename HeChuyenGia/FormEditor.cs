using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using DevExpress.XtraEditors;

namespace HeChuyenGia
{
    public partial class FormEditor : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private List<string> benh, trieuchung;
        private List<QuanHe> quanhe;
        ListBoxControl lastFocus = null;

        public FormEditor()
        {
            benh = new List<string>();
            trieuchung = new List<string>();
            quanhe = new List<QuanHe>();
            InitializeComponent();
            gridQuanHe.DataSource = quanhe;
            UpdateControls();
        }

        private string DefaultFile
        {
            get
            {
                return Path.Combine(Directory.GetCurrentDirectory(), "default.xml");
            }
        }

        private void SaveToFile(string filename = null)
        {
            if (filename == null) filename = DefaultFile;
            var serializer = new XmlSerializer(typeof(Container));
            var obj = new Container { Benh = benh, QuanHe = quanhe, TrieuChung = trieuchung };
            using (var writer = new StreamWriter(filename))
            {
                serializer.Serialize(writer, obj);
            }
        }

        private void LoadFromFile(string filename = null)
        {
            if (filename == null) filename = DefaultFile;
            if (!File.Exists(filename)) return;
            var serializer = new XmlSerializer(typeof(Container));
            using (var reader = new StreamReader(filename))
            {
                var obj = serializer.Deserialize(reader) as Container;
                benh = obj.Benh;
                trieuchung = obj.TrieuChung;
                quanhe = obj.QuanHe;
                gridQuanHe.DataSource = quanhe;
                UpdateControls();
            }
        }


        private void btnAddBenh_Click(object sender, EventArgs e)
        {
            string s = txtEdit.Text;
            if (s.Length == 0 || benh.Any(x => x == s)) return;
            benh.Add(s);
            UpdateControls();
        }

        private void btnAddTrieuChung_Click(object sender, EventArgs e)
        {
            string s = txtEdit.Text;
            if (s.Length == 0 || trieuchung.Any(x => x == s)) return;
            trieuchung.Add(s);
            UpdateControls();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<string> target = null;
            if (lastFocus == lstBenh)
            {
                target = benh;
            }
            if (lastFocus == lstTrieuChung)
            {
                target = trieuchung;
            }
            if (target == null || lastFocus.SelectedValue == null) return;
            target.Remove(target.Find(s => s == lastFocus.SelectedValue.ToString()));
            UpdateControls();
        }

        private void lstBenh_Click(object sender, EventArgs e)
        {
            lastFocus = sender as ListBoxControl;
        }

        private void btnAddQuanHe_Click(object sender, EventArgs e)
        {
            if (lstBenh.SelectedValue == null || lstTrieuChung.SelectedValue == null) return;
            var tmp = new QuanHe { Benh = lstBenh.SelectedValue.ToString(), TrieuChung = lstTrieuChung.SelectedValue.ToString() };
            if (quanhe.Any(x => x.Benh.Equals(tmp.Benh) && x.TrieuChung.Equals(tmp.TrieuChung))) return;
            quanhe.Add(tmp);
            UpdateControls();
        }

        private void btnXoaQuanHe_Click(object sender, EventArgs e)
        {
            if (gridView.GetFocusedRow() != null)
            {
                quanhe.Remove(gridView.GetFocusedRow() as QuanHe);
                UpdateControls();
            }
        }

        private void barBtnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dlg = new SaveFileDialog { Filter = "XML File (*.xml)|*.xml" };
            if (dlg.ShowDialog() != DialogResult.OK) return;
            SaveToFile(dlg.FileName);
        }

        private void FormEditor_Load(object sender, EventArgs e)
        {
            LoadFromFile();
        }

        private void FormEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveToFile();
        }

        private void barBtnOpen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dlg = new OpenFileDialog { Title = "Mở file ...", Filter = "XML file (*.xml)|*.xml" };
            if (dlg.ShowDialog() != DialogResult.OK) return;
            LoadFromFile(dlg.FileName);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string str = txtEdit.Text;
            if (str.Length == 0 || benh.Any(x => x == str)) return;
            List<string> target = null;
            if (lastFocus == lstBenh)
            {
                target = benh;
            }
            if (lastFocus == lstTrieuChung)
            {
                target = trieuchung;
            }
            if (target == null || lastFocus.SelectedValue == null) return;
            target[target.FindIndex(s => s == lastFocus.SelectedValue.ToString())] = str;
            UpdateControls();
        }

        private void barBtnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dlg = new SaveFileDialog { Filter = "Prolog file (*.pl)|*.pl" };
            if (dlg.ShowDialog() != DialogResult.OK) return;
            using (var writer = new StreamWriter(dlg.FileName))
                ExportTo(writer);
            MessageBox.Show(this, "Xuất thành công tới file " + dlg.FileName, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExportTo(TextWriter writer)
        {
            writer.WriteLine("% Dinh Nghia Cac Luat");
            writer.WriteLine("% Cu phap: dinh_nghia(su_kien, dau_hieu).");
            writer.WriteLine("% (c) Ngo Xuan Bach & Dinh Viet Nam.");
            writer.WriteLine("\n\n%%% BEGIN");
            foreach (var luat in quanhe)
            {
                writer.WriteLine("dinh_nghia('{0}','{1}').", luat.Benh, luat.TrieuChung);
            }
            writer.WriteLine("%%% END");
        }

        private void btnPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string s;
            using (var writer = new StringWriter())
            {
                ExportTo(writer);
                s = writer.GetStringBuilder().ToString();
            }
            new FormPreview(s).ShowDialog(this);
        }

        private void UpdateControls()
        {
            lstBenh.DataSource = benh;
            lstTrieuChung.DataSource = trieuchung;
            lstBenh.Refresh();
            lstTrieuChung.Refresh();
            gridQuanHe.RefreshDataSource();
        }
    }
    public class QuanHe
    {
        public string Benh { get; set; }
        public string TrieuChung { get; set; }
        
    }

    public class Container
    {
        public List<string> Benh { get; set; }
        public List<string> TrieuChung { get; set; }
        public List<QuanHe> QuanHe { get; set; }
    }
}
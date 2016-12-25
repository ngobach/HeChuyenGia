using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace HeChuyenGia
{
    public partial class FormPreview : DevExpress.XtraEditors.XtraForm
    {
        public FormPreview(string s)
        {
            InitializeComponent();
            edit.Text = s;
        }
    }
}
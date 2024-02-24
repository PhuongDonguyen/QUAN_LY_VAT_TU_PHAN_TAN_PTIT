using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatTuPhanTan
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private Form checkFormOpen(Type formType)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == formType) return f;
            }
            return null;
        }

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = checkFormOpen(typeof(FormLogin));
            if (f != null) f.Activate();
            else
            {
FormLogin login = new FormLogin();
            login.Show();
            }

        }
    }
}
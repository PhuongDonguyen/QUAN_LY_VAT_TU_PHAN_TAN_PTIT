using DevExpress.XtraEditors;
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
    public partial class FormPhieuXuat : DevExpress.XtraEditors.XtraForm
    {
        public FormPhieuXuat()
        {
            InitializeComponent();
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhieuXuat.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormPhieuXuat_Load(object sender, EventArgs e)
        {
            this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
            this.chiTietPhieuXuatTableAdapter.Fill(this.dS.CTPX);

        }
    }
}
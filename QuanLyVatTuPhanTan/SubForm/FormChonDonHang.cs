using System;
using System.Data;

namespace QuanLyVatTuPhanTan.SubForm
{
    public partial class formChonDonHang : DevExpress.XtraEditors.XtraForm
    {
        public formChonDonHang()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDatHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void formChonDonHang_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.FillDdhChuaCoPN(this.dS.DatHang);
        }

        private void btnCHON_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(bdsDatHang.Current));
            string maDonHang = drv["MasoDDH"].ToString().Trim();
            string maKho = drv["MaKho"].ToString().Trim();

            Program.chonDdhPN = maDonHang;
            Program.chonKhoPN = maKho;
            this.Close();

        }
    }
}
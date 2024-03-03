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
    public partial class FormKho : DevExpress.XtraEditors.XtraForm
    {
        String macn = "";
        public FormKho()
        {
            InitializeComponent();
        }

        private void FormKho_Load(object sender, EventArgs e)
        {
            //Tắt kiểm tra khóa ngoại
            dS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.dS.Kho);

            // TODO: This line of code loads data into the 'dS.PhieuXuat' table. You can move, or remove it, as needed.
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);

            // TODO: This line of code loads data into the 'dS.DatHang' table. You can move, or remove it, as needed.
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.dS.DatHang);

            // TODO: This line of code loads data into the 'dS.PhieuNhap' table. You can move, or remove it, as needed.
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);

            macn = ((DataRowView)bdsKho[0])["MACN"].ToString();
            // Sao chép binding source đã load ở form đăng nhập
            cmbChiNhanh.DataSource = Program.bds_dspm;

            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.chiNhanh;

            /* Nhóm CONGTY chỉ được quyền xem dữ liệu */
            if (Program.role == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;

                this.btnThem.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnGhi.Enabled = false;

                this.btnHoanTac.Enabled = false;
                this.btnLamMoi.Enabled = true;
                this.btnThoat.Enabled = true;

                this.panelInput.Enabled = false;
            }
        }
    }
}
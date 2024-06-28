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

namespace QuanLyVatTuPhanTan.SubForm
{
    public partial class FormChonHDNhanVien : DevExpress.XtraEditors.XtraForm
    {
        string tenCN;
        public FormChonHDNhanVien()
        {
            InitializeComponent();
        }

        private void FormChonNhanVien_Load(object sender, EventArgs e)
        {
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.chiNhanh;
            DataRowView selectedRow = (DataRowView)cmbChiNhanh.SelectedItem;
            if (Program.role == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;

            }
            else
            {
                cmbChiNhanh.Enabled = false;
            }
            String tenCNN = selectedRow["TENCN"].ToString().ToLower();
            tenCN = tenCNN.Contains("chi nhánh 1") ? "Chi nhánh 1" : tenCNN.Contains("chi nhánh 2") ? "Chi nhánh 2" : "";
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            if (cmbChiNhanh.SelectedIndex != Program.chiNhanh)
            {
                Program.loginName = Program.remoteLogin;
                Program.loginPass = Program.remotePassword;
            }
            else
            {
                Program.loginName = Program.currentLogin;
                Program.loginPass = Program.currentPass;
            }
            if (Program.Connect() == false)
            {
                XtraMessageBox.Show("Không thể kết nối đến server");
                return;
            }
            else
            {
                DataRowView selectedRow = (DataRowView)cmbChiNhanh.SelectedItem;
                String tenCNN = selectedRow["TENCN"].ToString().ToLower();
                tenCN = tenCNN.Contains("chi nhánh 1") ? "Chi nhánh 1" : tenCNN.Contains("chi nhánh 2") ? "Chi nhánh 2" : "";
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            }
        }

        private void btnCHON_Click(object sender, EventArgs e)
        {
            DataRowView drv = ((DataRowView)(bdsNhanVien.Current));
            string maNhanVien = drv["MANV"].ToString().Trim();
            string ho = drv["HO"].ToString().Trim();
            string ten = drv["TEN"].ToString().Trim();
            string hoTen = ho + " " + ten;

            Program.hdMaNV = maNhanVien;
            Program.hdHoTen = hoTen;
            this.Close();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
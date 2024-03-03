using DevExpress.XtraEditors;
using QuanLyVatTuPhanTan.DSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatTuPhanTan
{
    public partial class FormKho : DevExpress.XtraEditors.XtraForm
    {
        /* Vị trí của con trỏ hiện tại */
        int viTri = 0;
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

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.dS.DatHang);

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

                this.btnThem.Enabled = this.btnXoa.Enabled 
                                     = this.btnGhi.Enabled 
                                     = this.btnHoanTac.Enabled 
                                     = this.panelInput.Enabled = false;
            } else
            {
                cmbChiNhanh.Enabled = false;
                this.btnThem.Enabled = this.btnXoa.Enabled
                                     = this.btnGhi.Enabled
                                     = this.btnHoanTac.Enabled
                                     = this.panelInput.Enabled = true;
            }
        }

        private bool KiemTraLoiInput()
        {
            /*kiem tra txtMAKHO*/
            if (txtMaKho.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã kho hàng", "Thông báo", MessageBoxButtons.OK);
                txtMaKho.Focus();
                return false;
            }
            else if (Regex.IsMatch(txtMaKho.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã kho chỉ chấp nhận chữ và số", "Thông báo", MessageBoxButtons.OK);
                txtMaKho.Focus();
                return false;
            }
            else if (txtMaKho.Text.Length > 4)
            {
                MessageBox.Show("Mã kho không thể lớn hơn 4 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMaKho.Focus();
                return false;
            }

            /*kiem tra txtTenKho*/
            if (txtTenKho.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên kho hàng", "Thông báo", MessageBoxButtons.OK);
                txtTenKho.Focus();
                return false;
            }
            else if (Regex.IsMatch(txtTenKho.Text, @"^[\p{L}0-9\s]+$") == false)
            {
                MessageBox.Show("Tên kho chỉ chấp nhận chữ cái, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtTenKho.Focus();
                return false;
            }
            else if (txtTenKho.Text.Length > 30)
            {
                MessageBox.Show("Tên kho không thể quá 30 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTenKho.Focus();
                return false;
            }

            /*kiem tra txtDiaChi*/
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Không bỏ trống địa chỉ kho hàng", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }
            else if (Regex.IsMatch(txtDiaChi.Text, @"^[\p{L}0-9\s.,]+$") == false)
            {
                MessageBox.Show("Địa chỉ chỉ gồm chữ cái, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }
            else if (txtDiaChi.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ không quá 100 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Step 1: Lấy vị trí hiện tại của con trỏ
        /// Step 2: AddNew tự động nhảy xuống cuối thêm 1 dòng mới
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 1*/
            viTri = bdsKho.Position;
            this.panelInput.Enabled = true;

            /*Step 2*/
            bdsKho.AddNew();
            txtMaCN.Text = macn;

            /*Step 3*/
            this.txtMaKho.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnGhi.Enabled = true;

            this.btnHoanTac.Enabled = true;
            this.btnLamMoi.Enabled = false;
            this.btnThoat.Enabled = false;


            this.khoGridControl.Enabled = false;
            this.panelInput.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!KiemTraLoiInput()) return;

            try
            {
                bdsKho.EndEdit();
                bdsKho.ResetCurrentItem();
                khoTableAdapter.Connection.ConnectionString = Program.connstr;
                khoTableAdapter.Update(dS.Kho);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi khi ghi Kho \n" + ex.Message, "", MessageBoxButtons.OK);

                return;
            }
            khoGridControl.Enabled = true;
            panelInput.Enabled = false;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnHoanTac.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnHoanTac.Enabled = false;
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKho.CancelEdit();
            if (btnThem.Enabled == false)
            {
                bdsKho.Position = viTri;
            }
            khoGridControl.Enabled = true;
            cmbChiNhanh.Enabled = btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
            btnHoanTac.Enabled = btnGhi.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsKho.Position;
            khoGridControl.Enabled = cmbChiNhanh.Enabled 
                                   = btnThem.Enabled 
                                   = btnXoa.Enabled 
                                   = btnThem.Enabled = false;
            btnHoanTac.Enabled = btnGhi.Enabled 
                               = btnLamMoi.Enabled 
                               = panelInput.Enabled = true;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                khoTableAdapter.Fill(this.dS.Kho);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi reload + " + ex.Message, "Error");
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 maKho = 0;
            if (bdsPhieuNhap.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa kho vì đã nằm trong phiếu nhập", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsPhieuXuat.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa kho vì đã nằm trong phiếu xuất", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsDatHang.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa kho vì đã nằm trong phiếu đặt hàng", "", MessageBoxButtons.OK);
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc chắc muốn xóa Kho này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    maKho = int.Parse(((DataRowView)(bdsKho[bdsKho.Position]))["MAKHO"].ToString());
                    Console.WriteLine($"Ma kho: " + maKho);
                    bdsKho.RemoveCurrent();
                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    khoTableAdapter.Update(this.dS.Kho);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi khi xóa Kho. Hãy thử lại\n" + ex.Message + "" + MessageBoxButtons.OK);
                    this.khoTableAdapter.Fill(this.dS.Kho);
                    bdsKho.Position = bdsKho.Find("MAKHO", maKho);
                    return;
                }
            }
            if (bdsKho.Count == 0)
            {
                btnXoa.Enabled = false;
            };
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
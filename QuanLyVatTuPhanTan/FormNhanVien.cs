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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QuanLyVatTuPhanTan
{
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }
        String maChiNhanh = "";
        int vitri = 0;

        public void KiemTraLoiKhiGhi()
        {
            //Check ma nhan vien trung
            String queryStr = $"DECLARE @return_value int " +
                $"EXEC @return_value = [dbo].[SP_KiemTraNhanVienTonTai] '{txtMaNV.Text}' " +
                $"SELECT 'value' = @return_value";
            Console.WriteLine(queryStr);
            Program.myReader = Program.ExecSqlDataReader(queryStr);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            int result = (Program.myReader.GetInt32(0));
            Program.myReader.Close();
            if (result > 0)
            {
                XtraMessageBox.Show($"Mã nhân viên đã được sử dụng", "", MessageBoxButtons.OK);
                return;
            }
            Program.checkText(txtDiaChi, "Địa chỉ", 0, 100);
            Program.checkText(txtHo, "Họ", 0, 20);
            Program.checkText(txtTen, "Ten", 0, 10);
            Program.checkText(txtCMND, "CMND", 0, 20);
            if (seLuong.Value < 4000)
            {
                XtraMessageBox.Show($"Lương phải >= 4000", "", MessageBoxButtons.OK);
                seLuong.Focus();
                return;
            }
            if (CalculateAge(dteNgaySinh.DateTime) < 18)
            {
                XtraMessageBox.Show($"Nhân viên chưa đủ 18 tuổi", "", MessageBoxButtons.OK);
                dteNgaySinh.Focus();
                return;
            }
        }
        public int CalculateAge(DateTime birthday)
        {
            int age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.DayOfYear < birthday.DayOfYear)
                age = age - 1;
            return age;
        }
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // cái này đẻ lấy data hiện tại để kết nối, nếu dòng dưới nó sẻ lấy dS
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.DatHang' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.dS.DatHang);
            
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
            // còn phát sinh lỗi
            maChiNhanh = ((DataRowView)bdsNhanVien[0])["MACN"].ToString();
            Console.WriteLine("CHi nhanh " + maChiNhanh);
            cmbChiNhanh.DataSource = Program.bds_dspm; 
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            if (Program.role =="CONGTY")
            {
                cmbChiNhanh.Enabled = btnThem.Enabled  = btnXoa.Enabled = true;
                this.panelNhapLieu.Enabled = false;
                panelNhapLieu.Enabled = btnSua.Enabled=btnGhi.Enabled = btnHoanTac.Enabled = false;
            }
            else
            {
                btnThem.Enabled =  btnHoanTac.Enabled = btnXoa.Enabled = true;
                panelNhapLieu.Enabled =btnGhi.Enabled = cmbChiNhanh.Enabled = false;
            }
            if (bdsNhanVien.Count == 0)
            {
                btnXoa.Enabled = false;
            };

        }

        private void txtTEN_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtHO_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelNhapLieu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KiemTraLoiKhiGhi();

            try
            {
                bdsNhanVien.EndEdit();
                bdsNhanVien.ResetCurrentItem();
                nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                nhanVienTableAdapter.Update(dS.NhanVien);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi khi ghi nhân viên \n"+ ex.Message, "", MessageBoxButtons.OK);

                return;
            }
            gcNhanVien.Enabled = true;
            panelNhapLieu.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnGhi.Enabled = btnHoanTac.Enabled = false;
        }

        private void nhanVienGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNhanVien.Position;
            this.panelNhapLieu.Enabled = true;
            btnSua.Enabled= btnLamMoi.Enabled =cmbChiNhanh.Enabled = btnThem.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            btnHoanTac.Enabled = true;
            bdsNhanVien.AddNew();
            txtMaCN.Text = maChiNhanh;
            dteNgaySinh.EditValue = "2003-05-01";
            seLuong.Value = 4000000;
            txtCMND.Text = "123456789";
            txtDiaChi.Text = "HCM";
            cbTrangThaiXoa.Checked = false;

            gcNhanVien.Enabled = false;
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNhanVien.CancelEdit();
            if(btnThem.Enabled  == false)
            {
                bdsNhanVien.Position = vitri;
            }
            gcNhanVien.Enabled = true;
            cmbChiNhanh.Enabled = btnThem.Enabled = btnXoa.Enabled = btnThem.Enabled= true;
            btnHoanTac.Enabled =btnGhi.Enabled= false;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                nhanVienTableAdapter.Fill(this.dS.NhanVien);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi reload + "+ex.Message,"Error");
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int manv = 0;
            Console.WriteLine($"{bdsPhieuNhap.Count} \n {bdsPhieuXuat.Count}\n{bdsDatHang.Count}");
            if (bdsPhieuNhap.Count > 0)
            {
                XtraMessageBox.Show("Cann't remove PHIEU NHAP ( > 0 ) ","", MessageBoxButtons.OK);
                return;
            }
            if (bdsPhieuXuat.Count > 0)
            {
                XtraMessageBox.Show("Cann't remove PHIEU XUAT ( > 0 ) ", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsDatHang.Count > 0)
            {
                XtraMessageBox.Show("Cann't remove DAT HANG ( > 0 ) ", "", MessageBoxButtons.OK);
                return;
            }
            if (XtraMessageBox.Show("Do you want to remove","",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                try
                {
                    manv = int.Parse(((DataRowView)(bdsNhanVien[bdsNhanVien.Position]))["MANV"].ToString());
                    bdsNhanVien.RemoveCurrent();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    nhanVienTableAdapter.Update(this.dS.NhanVien);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("An error occurred while deleting\n" + ex.Message);
                    nhanVienTableAdapter.Fill(this.dS.NhanVien);
                    bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                    return;
                }
            }
            if (bdsNhanVien.Count == 0)
            {
                btnXoa.Enabled = false;
            };

        }

        private void txtCMND_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void nGAYSINHDateEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void nGAYSINHLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNhanVien.Position;
            gcNhanVien.Enabled = false;
            cmbChiNhanh.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnHoanTac.Enabled = true;
            btnGhi.Enabled = true;
            btnLamMoi.Enabled = false;
            panelNhapLieu.Enabled = true;

        }
    }
}
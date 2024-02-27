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
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }
        String maChiNhanh = "";
        int vitri = 0;
        public int CalculateAge(DateTime date)
        {
            int age = DateTime.Now.Year - date.Year;
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
            this.datHangTableAdapter.Fill(this.dS.DatHang);
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            // còn phát sinh lỗi
            maChiNhanh = ((DataRowView)bdsNhanVien[0])["MACN"].ToString();
            cmbChiNhanh.DataSource = Program.bds_dspm; 
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            if (Program.role =="CONGTY")
            {
                cmbChiNhanh.Enabled = btnThem.Enabled = btnGhi.Enabled =  btnXoa.Enabled = true;
                this.panelNhapLieu.Enabled = false;
                btnHoanTac.Enabled = false;
            }
            else
            {
                btnThem.Enabled = btnGhi.Enabled = btnHoanTac.Enabled = btnXoa.Enabled = true;
                cmbChiNhanh.Enabled = false;
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
            Program.checkText(txtDIACHI, "Địa chỉ", 0,100);
            Program.checkText(txtHO, "Họ", 0,20);
            Program.checkText(txtTEN, "Ten", 0,10);
            Program.checkText(txtCMND, "CMND",0, 20);
            Program.checkText(txtLUONG, "Lương", 4000, 9999999);
            if(CalculateAge(dteNGAYSINH.DateTime) < 18)
            {

            }

        }

        private void nhanVienGridControl_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNhanVien.Position;
            this.panelNhapLieu.Enabled = true;
            cmbChiNhanh.Enabled = btnThem.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            btnHoanTac.Enabled = true;
            bdsNhanVien.AddNew();
            txtMACN.Text = maChiNhanh;
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
            if (BdsDatHang.Count > 0)
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
    }
}
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace QuanLyVatTuPhanTan.SubForm
{
    public partial class FormChonNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public FormChonNhanVien()
        {
            InitializeComponent();
        }

        private void FormChonNhanVien_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);

            cmbCHINHANH.DataSource = Program.bds_dspm;/*sao chep bingding source tu form dang nhap*/
            cmbCHINHANH.DisplayMember = "TENCN";
            cmbCHINHANH.ValueMember = "TENSERVER";
            cmbCHINHANH.SelectedIndex = Program.chiNhanh;

            if (Program.role == "CONGTY")
            {
                cmbCHINHANH.Enabled = true;
            }

        }
        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            /*Neu combobox khong co so lieu thi ket thuc luon*/
            if (cmbCHINHANH.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            //Console.WriteLine(Program.conn);
            Program.servername = cmbCHINHANH.SelectedValue.ToString();

            /*Neu chon sang chi nhanh khac voi chi nhanh hien tai*/
            if (cmbCHINHANH.SelectedIndex != Program.chiNhanh)
            {
                Program.loginName = Program.remoteLogin;
                Program.loginPass = Program.remotePassword;
                
            }
            /*Neu chon trung voi chi nhanh dang dang nhap o formDangNhap*/
            else
            {
                Program.loginName = Program.currentLogin;
                Program.loginPass = Program.currentPass;
            }

            if (Program.Connect() == false)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);
            }
        }

        private void btnCHON_Click(object sender, EventArgs e)
        {

            DataRowView drv = ((DataRowView)(nhanVienBindingSource.Current));
            string maNhanVien = drv["MANV"].ToString().Trim();
            String ho = drv["HO"].ToString().Trim();
            String ten = drv["TEN"].ToString().Trim();
            
            String hoTen = ho + " " + ten;
            
            string ngaySinh = ((DateTime)drv["NGAYSINH"]).ToString("dd-MM-yyyy");
            string diaChi = drv["DIACHI"].ToString().Trim();

            Program.maNhanVienDuocChon = maNhanVien;
            Program.hoTen = hoTen;
            Console.WriteLine(Program.hoTen);
            Program.ngaySinh = ngaySinh;
            Program.diaChi = diaChi;

            this.Close();
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
   
    }
}
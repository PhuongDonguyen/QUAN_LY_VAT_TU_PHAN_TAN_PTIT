using QuanLyVatTuPhanTan.SubForm;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyVatTuPhanTan
{
    public partial class FormTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        private string taiKhoan = "";
        private string matKhau = "";
        private string maNhanVien = "";
        private string vaiTro = "";
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnChonNhanVien_Click(object sender, EventArgs e)
        {
            FormChonNhanVien form = new FormChonNhanVien();
            form.ShowDialog();

            txtMaNhanVien.Text = Program.maNhanVienDuocChon;
        }
        private bool kiemTraDuLieuDauVao()
        {
            if (txtMaNhanVien.Text == "")
            {
                MessageBox.Show("Thiếu mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Thiếu mật khẩu", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtXacNhanMatKhau.Text == "")
            {
                MessageBox.Show("Thiếu mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu không khớp với mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false) return;

            taiKhoan = Program.hoTen;
            matKhau = txtMatKhau.Text;
            maNhanVien = Program.maNhanVienDuocChon;
            vaiTro = (rdChiNhanh.Checked == true) ? "CHINHANH" : "USER";

            if (Program.role == "CONGTY")
            {
                vaiTro = "CONGTY";
            }

            //Console.WriteLine(taiKhoan);
            //Console.WriteLine(matKhau);
            //Console.WriteLine(maNhanVien);
            //Console.WriteLine(vaiTro);

            /*declare @returnedResult int
             exec @returnedResult = sp_TraCuu_KiemTraMaNhanVien '20'
             select @returnedResult*/
            String cauTruyVan =
                    "EXEC sp_TaoTaiKhoan N'" + taiKhoan + "' , N'" + matKhau + "', N'"
                    + maNhanVien + "', N'" + vaiTro + "'";
            Console.WriteLine(Program.conn);
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return;
                }

                MessageBox.Show("Đăng kí tài khoản thành công\n\nTài khoản: " + taiKhoan + "\nMật khẩu: " + matKhau + "\n Mã Nhân Viên: " + maNhanVien + "\n Vai Trò: " + vaiTro, "Thông Báo", MessageBoxButtons.OK);
                Program.myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }

        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            if (Program.role == "CONGTY")
            {
                rdChiNhanh.Enabled = false;
                rdUser.Enabled = false;
            }
            else
            {
                rdChiNhanh.Enabled = true;
                rdUser.Enabled = true;
            }

        }

    }
}
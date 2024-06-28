using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyVatTuPhanTan
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        public static SqlConnection conn_publisher = new SqlConnection();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            usernameInput.Text = "LT";
            pwdInput.Text = "123";
            //pwdInput.Text = "12";

            if (!ConnectToMainServer()) return;
            LayDanhSachPhanManh("Select * from [dbo].[V_DS_PHANMANH]");
            cmbChiNhanh.SelectedIndex = 1;
            cmbChiNhanh.SelectedIndex = 0;
            //Login();
            //this.Close();
        }

        /// <summary>
        /// Kết nối tới database gốc
        /// </summary>
        /// <returns>Trả về true nếu kết nối thành công và ngược lại</returns>
        public bool ConnectToMainServer()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open) conn_publisher.Close();
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not connect to the main server", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void LayDanhSachPhanManh(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_publisher.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            try
            {
                da.Fill(dt);
                conn_publisher.Close();
                Program.bds_dspm.DataSource = dt;
                cmbChiNhanh.DataSource = Program.bds_dspm; // nhận 1 table
                cmbChiNhanh.DisplayMember = "TENCN"; // cột hiện thị
                cmbChiNhanh.ValueMember = "TENSERVER"; // Giá trị trả về
            }
            catch (SqlException ex)
            {
                conn_publisher.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
        }


        private void Login()
        {
            // Kiểm tra input username và password có để trống hay không
            if (pwdInput.Text.Trim() == "" || usernameInput.Text.Trim() == "")
            {
                MessageBox.Show("Error", "Username hoac password khong the trong!");
                return;
            }

            // Gán username và mật khẩu được đăng nhập vào loginName và loginPass
            Program.loginName = usernameInput.Text.Trim();
            Program.loginPass = pwdInput.Text.Trim();

            Console.WriteLine(Program.servername);
            if (!Program.Connect()) return;

            // Cập nhật chi nhánh hiện tại
            Program.chiNhanh = cmbChiNhanh.SelectedIndex;
            DataRowView selectedRow = (DataRowView)cmbChiNhanh.SelectedItem;
            String tenCN = selectedRow["TENCN"].ToString().ToLower();
            Program.maChiNhanhHienTai = tenCN.Contains("chi nhánh 1") ? "CN1" : tenCN.Contains("chi nhánh 2") ? "CN2" : "";
            // Cập nhật currentLogin & currentPassword
            Program.currentLogin = Program.loginName;
            Program.currentPass = Program.loginPass;

            // Chạy SP để lấy ra thông tin của user
            string queryStr = "exec [SP_LayThongTinNhanVien] N'" + Program.loginName + "'";
            Program.myReader = Program.ExecSqlDataReader(queryStr);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            // Hiển thị mã NV, họ tên và vai trò ở góc dưới màn hình
            Program.userID = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.userID))
            {
                MessageBox.Show("Bạn không có quyền truy cập dữ liệu, xem lại phân quyền hoặc thử lại với tài khoản khác");
                return;
            }
            Program.hoTen = Program.myReader.GetString(1);
            Program.role = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();

            Program.formMain.MANHANVIEN.Text = "MÃ NHÂN VIÊN: " + Program.userID;
            Program.formMain.HOTEN.Text = "HỌ TÊN: " + Program.hoTen.ToUpper();
            Program.formMain.NHOM.Text = "VAI TRÒ: " + (Program.role == "CONGTY" ? "CÔNG TY" : "CHI NHÁNH");

            this.Hide();
            Program.formMain.enableButtons();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pwdInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyVatTuPhanTan
{
    internal static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        //public static String connstr_publisher = "Data Source=PHUONG-HPLAP;Initial Catalog=QLVT;Integrated Security=True";
       public static String connstr_publisher = "Data Source=NHAT-PC\\SERVER01;Initial Catalog=QLVT;Integrated Security=True";
        //public static String connstr_publisher = "Data Source=MSI\\LONG;Initial Catalog=QLVT_DATHANG;Integrated Security=True";
        public static SqlConnection conn_publisher = new SqlConnection();

        public static SqlDataReader myReader;
        // server chuyen chi nhanh toi
        public static String servernameTranfer = "";
        public static String servername = "";
        public static String userID = "";
        public static String loginName = "";
        public static String loginPass = "";

       public static String database = "QLVT";
       // public static String database = "QLVT_DATHANG";


        public static String currentLogin = "";
        public static String currentPass = "";

        public static int chiNhanh = 0;
        public static String maChiNhanhHienTai;
        //Hoat dong nhan vien
        public static string hdMaNV;
        public static string hdHoTen;
        //Kho
        public static String chonKhoPN = "";
        //Phieu Nhap
        public static String chonDdhPN = "";


        public static string hoTen = "";
        public static string role = "";
        public static string remoteLogin = "HTKN";
        public static string remotePassword = "12";
      // public static string remotePassword = "123";
        //public static string remotePassword = "123456";
        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập



        public static string hoTen1 = "";
        public static string maKhoDuocChon = "";
        public static string maVatTuDuocChon = "";
        public static int soLuongVatTu = 0;

        public static string maNhanVienDuocChon = "";
        public static string diaChi = "";
        public static string ngaySinh = "";

        /// <summary>
        /// Biến toàn cục của các form sẽ được viết dưới đây
        /// </summary>
        //public static FormLogin formLogin;
        public static FormMain formMain;
        public static bool checkText(TextEdit txtEdit, String value, int min = 0, int max = 0)
        {
            if (txtEdit.Text.Trim() == "")
            {
                XtraMessageBox.Show($"{value} không được đẻ trống", "", MessageBoxButtons.OK);
                txtEdit.Focus();
                return false;
            }
            if (txtEdit.Text.Length > max)
            {
                XtraMessageBox.Show($"{value} phải <= {max} kí tự", "", MessageBoxButtons.OK);
                txtEdit.Focus();
                return false;
            }
            if (txtEdit.Text.Length < min)
            {
                XtraMessageBox.Show($"{value} phải >= {min} kí tự", "", MessageBoxButtons.OK);
                txtEdit.Focus();
                return false;
            }
            return true;
        }
        public static bool ConnectToMainServer()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();
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
        public static bool Connect()
        {
            // Đóng server nếu server đã được open trước đó
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
            {
                Program.conn.Close();
            }

            try
            {
                Program.connstr = "Data Source=" + Program.servername + "; Initial Catalog=" +
                  Program.database + ";User ID=" + Program.loginName + ";password=" + Program.loginPass;

                Console.WriteLine("Connect:  " + connstr);
                Program.conn.ConnectionString = connstr;
                Program.conn.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return false;
            }
        }
        public static SqlDataReader ExecSqlDataReader(string str)
        {
            SqlDataReader myReader;
            SqlCommand sqlCmd = new SqlCommand(str, Program.conn);
            sqlCmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myReader = sqlCmd.ExecuteReader();
                return myReader;
            }
            catch (Exception e)
            {
                Program.conn.Close();
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static DataTable ExecDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn);
            try
            {
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static int ExceSqlNoneQuery(string str)
        {
            SqlCommand sqlCmd = new SqlCommand(str, Program.conn);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                sqlCmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                conn.Close();
                return -1;
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.formMain = new FormMain();
            Application.Run(formMain);
        }
    }
}

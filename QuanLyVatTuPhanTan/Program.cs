using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraEditors;

namespace QuanLyVatTuPhanTan
{
    internal static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        //public static String connstr_publisher = "Data Source=PHUONG-HPLAP;Initial Catalog=QLVT_DATHANG;Integrated Security=True";
        public static String connstr_publisher = "Data Source=NHAT-PC\\SERVER01;Initial Catalog=QLVT;Integrated Security=True";



        public static SqlDataReader myReader;

        public static String servername = "";
        public static String userID = "";
        public static String loginName = "";
        public static String loginPass = "";

        public static String database = "QLVT";

        public static String mloginDN = "";
        public static String passwordDN = "";

        public static int chiNhanh = 0;

        public static string hoTen = "";
        public static string role = "";
        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập

        /// <summary>
        /// Biến toàn cục của các form sẽ được viết dưới đây
        /// </summary>
        public static FormLogin formLogin;
        public static FormMain formMain;
        public static void checkText(TextEdit txtEdit, String value, int min = 0, int max=0)
        {
            if (txtEdit.Text.Trim() == "")
            {
                XtraMessageBox.Show($"{value} không được đẻ trống", "", MessageBoxButtons.OK);
                txtEdit.Focus();
                return;
            }
            if (txtEdit.Text.Length > max)
            {
                XtraMessageBox.Show($"{value} phải bé hơn {max} kí tự", "", MessageBoxButtons.OK);
                txtEdit.Focus();
                return;
            }
            if (txtEdit.Text.Length < min)
            {
                XtraMessageBox.Show($"{value} phải lớn hơn {min} kí tự", "", MessageBoxButtons.OK);
                txtEdit.Focus();
                return;
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
                Console.WriteLine(connstr);
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
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
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

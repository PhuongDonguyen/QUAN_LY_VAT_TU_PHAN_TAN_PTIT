﻿using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace QuanLyVatTuPhanTan.ReportForm
{
    public partial class FormDonHangKhongPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection connPublisher = new SqlConnection();
        private string chiNhanh = "";
        public FormDonHangKhongPhieuNhap()
        {
            InitializeComponent();
        }
        private void layDanhSachPhanManh(String cmd)
        {
            if (connPublisher.State == ConnectionState.Closed)
            {
                connPublisher.Open();
            }
            DataTable dt = new DataTable();
            // adapter dùng để đưa dữ liệu từ view sang database
            SqlDataAdapter da = new SqlDataAdapter(cmd, connPublisher);
            // dùng adapter thì mới đổ vào data table được
            da.Fill(dt);


            connPublisher.Close();
            Program.bds_dspm.DataSource = dt;


            cmbCHINHANH.DataSource = Program.bds_dspm;
            cmbCHINHANH.DisplayMember = "TENCN";
            cmbCHINHANH.ValueMember = "TENSERVER";

        }



        /******************************************************************
         * mở kết nối tới server 
         * @return trả về 1 nếu thành công
         *         trả về 0 nếu thất bại
         ******************************************************************/
        private int KetNoiDatabaseGoc()
        {
            if (connPublisher != null && connPublisher.State == ConnectionState.Open)
                connPublisher.Close();
            try
            {
                connPublisher.ConnectionString = Program.connstr_publisher;
                connPublisher.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            /*Neu combobox khong co so lieu thi ket thuc luon*/
            if (cmbCHINHANH.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

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

                this.sp_DonHangKhongPhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sp_DonHangKhongPhieuNhapTableAdapter.Fill(this.dataSet.sp_DonHangKhongPhieuNhap);
            }

        }

        private void FormDonHangKhongPhieuNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.sp_DonHangKhongPhieuNhap' table. You can move, or remove it, as needed.
            dataSet.EnforceConstraints = false;
            this.sp_DonHangKhongPhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_DonHangKhongPhieuNhapTableAdapter.Fill(this.dataSet.sp_DonHangKhongPhieuNhap);

            if (Program.role == "CONGTY")
            {
                this.cmbCHINHANH.Enabled = true;
            }

            if (KetNoiDatabaseGoc() == 0) //
                return;
            layDanhSachPhanManh("Select top 2 * from [dbo].[V_DS_PHANMANH]");
            //cmbCHINHANH.SelectedIndex = 1;
            //cmbCHINHANH.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDonHangKhongPhieuNhap report = new ReportDonHangKhongPhieuNhap();
            /*GAN TEN CHI NHANH CHO BAO CAO*/
            chiNhanh = this.cmbCHINHANH.SelectedValue.ToString().Contains("1") ? "Chi nhánh 1" : "Chi nhánh 2";
            report.txtChiNhanh.Text = chiNhanh.ToUpper();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ReportDonHangKhongPhieuNhap report = new ReportDonHangKhongPhieuNhap();
                /*GAN TEN CHI NHANH CHO BAO CAO*/
                report.txtChiNhanh.Text = chiNhanh.ToUpper();
                if (File.Exists(@"D:\ReportDonHangKhongPhieuNhap.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File ReportDonHangKhongPhieuNhap.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(@"D:\ReportDonHangKhongPhieuNhap.pdf");
                        MessageBox.Show("File ReportDSNhanVien.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    report.ExportToPdf(@"D:\ReportDonHangKhongPhieuNhap.pdf");
                    MessageBox.Show("File ReportDonHangKhongPhieuNhap.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file ReportDonHangKhongPhieuNhap.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }

}
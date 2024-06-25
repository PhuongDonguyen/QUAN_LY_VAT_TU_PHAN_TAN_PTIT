using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace QuanLyVatTuPhanTan.ReportForm
{
    public partial class ReportDonHangKhongPhieuNhap : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDonHangKhongPhieuNhap()
        {
            InitializeComponent();
            dataSet1.EnforceConstraints = false;
            this.sp_DonHangKhongPhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_DonHangKhongPhieuNhapTableAdapter.Fill(this.dataSet1.sp_DonHangKhongPhieuNhap);
            //this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            //this.sqlDataSource1.Fill();
        }

    }
}

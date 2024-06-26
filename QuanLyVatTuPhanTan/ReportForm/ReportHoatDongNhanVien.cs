using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QuanLyVatTuPhanTan.ReportForm
{
    public partial class ReportHoatDongNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportHoatDongNhanVien(int maNhanVien, DateTime tuNgay, DateTime toiNgay)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maNhanVien;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = tuNgay;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = toiNgay;

            this.sqlDataSource1.Fill();

        }

    }
}

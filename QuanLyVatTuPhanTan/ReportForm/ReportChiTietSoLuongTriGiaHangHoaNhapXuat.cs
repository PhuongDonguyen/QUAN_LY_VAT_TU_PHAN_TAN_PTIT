using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QuanLyVatTuPhanTan.ReportForm
{
    public partial class ReportChiTietSoLuongTriGiaHangHoaNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportChiTietSoLuongTriGiaHangHoaNhapXuat()
        {
            InitializeComponent();
        }

        public ReportChiTietSoLuongTriGiaHangHoaNhapXuat(string vaiTro, string loaiPhieu, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            this.sqlDataSource2.Connection.ConnectionString = Program.connstr;

            // Ensure that the parameters are correctly assigned and their types are appropriate.
            this.sqlDataSource2.Queries[0].Parameters[0].Type = typeof(string);
            this.sqlDataSource2.Queries[0].Parameters[0].Value = vaiTro;

            this.sqlDataSource2.Queries[0].Parameters[1].Type = typeof(string);
            this.sqlDataSource2.Queries[0].Parameters[1].Value = loaiPhieu;

            this.sqlDataSource2.Queries[0].Parameters[2].Type = typeof(DateTime);
            this.sqlDataSource2.Queries[0].Parameters[2].Value = fromDate;

            this.sqlDataSource2.Queries[0].Parameters[3].Type = typeof(DateTime);
            this.sqlDataSource2.Queries[0].Parameters[3].Value = toDate;

            this.sqlDataSource2.Fill();
        }
    }
}

namespace QuanLyVatTuPhanTan.ReportForm
{
    public partial class ReportDanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDanhSachNhanVien()
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Fill();
            //this.sqlDataSource2.Connection.ConnectionString = Program.connstr;
            //this.sqlDataSource2.Fill();
        }

    }
}

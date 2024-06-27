using DevExpress.XtraReports.UI;
using System;
using System.IO;
using System.Windows.Forms;

namespace QuanLyVatTuPhanTan.ReportForm
{
    public partial class FormDanhSachVatTu : DevExpress.XtraEditors.XtraForm
    {
        public FormDanhSachVatTu()
        {
            InitializeComponent();
        }

        private void FormDanhSachVatTu_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dataSet.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr_publisher;
            this.vattuTableAdapter.Fill(this.dataSet.Vattu);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDanhSachVatTu report = new ReportDanhSachVatTu();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReportDanhSachVatTu report = new ReportDanhSachVatTu();
            try
            {
                if (File.Exists(@"D:\ReportDanhSachVatTu.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File ReportDanhSachVatTu.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(@"D:\ReportDanhSachVatTu.pdf");
                        MessageBox.Show("File ReportDanhSachVatTu.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    report.ExportToPdf(@"D:\ReportDanhSachVatTu.pdf");
                    MessageBox.Show("File ReportDanhSachVatTu.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file ReportDanhSachVatTu.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QuanLyVatTuPhanTan.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatTuPhanTan.ReportForm
{
    public partial class FormHoatDongNhanVien : DevExpress.XtraEditors.XtraForm
    {
     
        public FormHoatDongNhanVien()
        {
            InitializeComponent();
        }

        private void FormHoatDongNhanVien_Load(object sender, EventArgs e)
        {
            dteTuNgay.EditValue = "01-05-2019";
            dteToiNgay.EditValue = DateTime.Today.ToString("dd-MM-yyyy");
        }

        private void btnChonNhanVien_Click(object sender, EventArgs e)
        {
            FormChonHDNhanVien form = new FormChonHDNhanVien();
            form.ShowDialog();
            txtHoVaTen.Text = Program.hdHoTen;
            txtMaNhanVien.Text = Program.hdMaNV;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime fromDateText = dteTuNgay.DateTime;
            DateTime toDateText = dteToiNgay.DateTime;
            DateTime fromDate = DateTime.ParseExact(fromDateText.ToString("dd-MM-yyyy"), "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime toDate = DateTime.ParseExact(toDateText.ToString("dd-MM-yyyy"), "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            ReportHoatDongNhanVien report = new ReportHoatDongNhanVien(int.Parse(Program.hdMaNV), fromDate, toDate);
            /*GAN TEN CHI NHANH CHO BAO CAO*/
            report.txtHoTenNV.Text = txtHoVaTen.Text;
            report.txtTuNgay.Text = dteTuNgay.EditValue.ToString();
            report.txtDenNgay.Text = dteToiNgay.EditValue.ToString();
            report.tbTongCong.Text = report.tbTongCong.Text + " " + "đồng";
            Console.WriteLine(report.tbTongCong.Text);

            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
           
               
                DateTime fromDate = dteTuNgay.DateTime;
                DateTime toDate = dteToiNgay.DateTime;

                ReportHoatDongNhanVien report = new ReportHoatDongNhanVien(int.Parse(Program.hdMaNV), fromDate, toDate);


                report.txtHoTenNV.Text = txtHoVaTen.Text;
                report.txtTuNgay.Text = dteTuNgay.EditValue.ToString();
                report.txtDenNgay.Text = dteToiNgay.EditValue.ToString();

                if (File.Exists(@"D:\ReportHoatDongNhanVien.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File ReportHoatDongNhanVien.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(@"D:\ReportHoatDongNhanVien.pdf");
                        MessageBox.Show("File ReportHoatDongNhanVien.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    report.ExportToPdf(@"D:\ReportHoatDongNhanVien.pdf");
                    MessageBox.Show("File ReportHoatDongNhanVien.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file ReportHoatDongNhanVien.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
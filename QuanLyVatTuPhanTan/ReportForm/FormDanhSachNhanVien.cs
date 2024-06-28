using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace QuanLyVatTuPhanTan.ReportForm
{
    public partial class FormDanhSachNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public string tenCN = "";
        public FormDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void FormDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.chiNhanh;
            DataRowView selectedRow = (DataRowView)cmbChiNhanh.SelectedItem;
            String tenCNN = selectedRow["TENCN"].ToString().ToLower();
            tenCN = tenCNN.Contains("chi nhánh 1") ? "Chi nhánh 1" : tenCNN.Contains("chi nhánh 2") ? "Chi nhánh 2" : "";
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

        }

        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            if (cmbChiNhanh.SelectedIndex != Program.chiNhanh)
            {
                Program.loginName = Program.remoteLogin;
                Program.loginPass = Program.remotePassword;
            }
            else
            {
                Program.loginName = Program.currentLogin;
                Program.loginPass = Program.currentPass;
            }
            if (Program.Connect() == false)
            {
                XtraMessageBox.Show("Không thể kết nối đến server");
                return;
            }
            else
            {
                DataRowView selectedRow = (DataRowView)cmbChiNhanh.SelectedItem;
                String tenCNN = selectedRow["TENCN"].ToString().ToLower();
                tenCN = tenCNN.Contains("chi nhánh 1") ? "Chi nhánh 1" : tenCNN.Contains("chi nhánh 2") ? "Chi nhánh 2" : "";
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                // bi chay vao khi o nhan vien dang xuat zo dang nhap lai
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDanhSachNhanVien report = new ReportDanhSachNhanVien();
            tenCN = tenCN.Contains("chi nhánh 1") ? "Chi nhánh 1" : tenCN.Contains("chi nhánh 2") ? "Chi nhánh 2" :
            report.txtChiNhanh.Text = tenCN;
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ReportDanhSachNhanVien report = new ReportDanhSachNhanVien();
                /*GAN TEN CHI NHANH CHO BAO CAO*/
                report.txtChiNhanh.Text = tenCN;
                if (File.Exists(@"D:\ReportDanhSachNhanVien.pdf"))
                {
                    DialogResult dr = MessageBox.Show("File ReportDSNhanVien.pdf tại ổ D đã có!\nBạn có muốn tạo lại?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        report.ExportToPdf(@"D:\ReportDSNhanVien.pdf");
                        MessageBox.Show("File ReportDSNhanVien.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    report.ExportToPdf(@"D:\ReportDanhSachNhanVien.pdf");
                    MessageBox.Show("File ReportDSNhanVien.pdf đã được ghi thành công tại ổ D",
                "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Vui lòng đóng file ReportDSNhanVien.pdf",
                    "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
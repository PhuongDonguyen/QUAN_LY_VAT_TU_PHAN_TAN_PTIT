using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyVatTuPhanTan.SubForm
{
    public partial class FormChuyenChiNhanh : DevExpress.XtraEditors.XtraForm
    {
        public FormChuyenChiNhanh()
        {
            InitializeComponent();
        }
        public delegate void MyDelegate(string chiNhanh);
        public MyDelegate chuyenChiNhanh;
        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void LayDanhSachChiNhanh(String cmd)
        {
            DataTable dt = new DataTable();
            if (!Program.ConnectToMainServer()) return;
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.connstr_publisher);
            try
            {
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    // Create and set up the BindingSource
                    BindingSource bds_ds = new BindingSource();
                    bds_ds.DataSource = dt;
                    Program.conn_publisher.Close();
                    // Bind the ComboBox to the BindingSource
                    cmbChiNhanh.DataSource = bds_ds;
                    cmbChiNhanh.DisplayMember = "TENCN";
                    cmbChiNhanh.ValueMember = "TENSERVER";

                    // Set the default selected index to the first item if there are items in the ComboBox
                    if (cmbChiNhanh.Items.Count > 0)
                    {
                        cmbChiNhanh.SelectedIndex = 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Program.conn_publisher.Close();
            }
        }
        private void FormChuyenChiNhanh_Load(object sender, EventArgs e)
        {

            String cmd = $"EXEC sp_LayCacChiNhanhConLai @ten_server =N'{Program.servername}'";
            LayDanhSachChiNhanh(cmd);


        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cmbChiNhanh.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng chọn chi nhánh", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            /*Step 2*/
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn chuyển nhân viên này đi ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                DataRowView selectedRow = (DataRowView)cmbChiNhanh.SelectedItem;
                String tenCN = selectedRow["TENCN"].ToString().ToLower();
                String maChiNhanhMoi = tenCN.Contains("chi nhánh 1") ? "CN1" : tenCN.Contains("chi nhánh 2") ? "CN2" : "";
                Program.servernameTranfer = cmbChiNhanh.SelectedValue.ToString();
                chuyenChiNhanh(maChiNhanhMoi);

            }

            this.Dispose();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
using DevExpress.XtraEditors;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyVatTuPhanTan
{
    public partial class FormKho : DevExpress.XtraEditors.XtraForm
    {
        /* Vị trí của con trỏ hiện tại */
        int viTri = 0;
        String macn = "";

        /* Biến phục vụ cho tác vụ Undo */
        Stack undoList = new Stack();
        bool dangThem = false;
        bool dangSua = false;

        public FormKho()
        {
            InitializeComponent();
        }

        private void FormKho_Load(object sender, EventArgs e)
        {
            //Tắt kiểm tra khóa ngoại
            dS.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.dS.Kho);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.dS.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);

            macn = ((DataRowView)bdsKho[0])["MACN"].ToString();
            // Sao chép binding source đã load ở form đăng nhập
            cmbChiNhanh.DataSource = Program.bds_dspm;

            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.chiNhanh;

            /* Nhóm CONGTY chỉ được quyền xem dữ liệu */
            if (Program.role == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;

                this.btnThem.Enabled = this.btnXoa.Enabled
                                     = this.btnGhi.Enabled
                                     = this.btnHoanTac.Enabled
                                     = this.btnSua.Enabled = false;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
                this.btnGhi.Enabled = false;
                this.btnThem.Enabled = this.btnXoa.Enabled
                                     = this.btnHoanTac.Enabled
                                     = this.btnLamMoi.Enabled
                                     = this.btnThoat.Enabled
                                     = this.btnSua.Enabled = true;
            }

            this.panelInput.Enabled = false;
        }

        private bool KiemTraLoiInput()
        {
            /*kiem tra txtMAKHO*/
            if (txtMaKho.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã kho hàng", "Thông báo", MessageBoxButtons.OK);
                txtMaKho.Focus();
                return false;
            }
            else if (Regex.IsMatch(txtMaKho.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã kho chỉ chấp nhận chữ và số", "Thông báo", MessageBoxButtons.OK);
                txtMaKho.Focus();
                return false;
            }
            else if (txtMaKho.Text.Length > 4)
            {
                MessageBox.Show("Mã kho không thể lớn hơn 4 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMaKho.Focus();
                return false;
            }

            /*kiem tra txtTenKho*/
            if (txtTenKho.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên kho hàng", "Thông báo", MessageBoxButtons.OK);
                txtTenKho.Focus();
                return false;
            }
            else if (Regex.IsMatch(txtTenKho.Text, @"^[\p{L}0-9\s]+$") == false)
            {
                MessageBox.Show("Tên kho chỉ chấp nhận chữ cái, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtTenKho.Focus();
                return false;
            }
            else if (txtTenKho.Text.Length > 30)
            {
                MessageBox.Show("Tên kho không thể quá 30 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtTenKho.Focus();
                return false;
            }

            /*kiem tra txtDiaChi*/
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Không bỏ trống địa chỉ kho hàng", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }
            else if (Regex.IsMatch(txtDiaChi.Text, @"^[\p{L}0-9\s.,]+$") == false)
            {
                MessageBox.Show("Địa chỉ chỉ gồm chữ cái, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }
            else if (txtDiaChi.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ không quá 100 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Step 1: Lấy vị trí hiện tại của con trỏ + toggle biến dangThem
        /// Step 2: AddNew tự động nhảy xuống cuối thêm 1 dòng mới
        /// Step 3: Bật tắt các chức năng khi btnThem clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 1*/
            viTri = bdsKho.Position;
            Console.WriteLine("bdsKho Position: " + bdsKho.Position);
            this.panelInput.Enabled = true;
            dangThem = true;

            /*Step 2*/
            bdsKho.AddNew();
            txtMaCN.Text = macn;

            /*Step 3*/
            this.txtMaCN.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnLamMoi.Enabled = false;

            this.btnGhi.Enabled = true;
            this.btnHoanTac.Enabled = true;
            this.btnThoat.Enabled = true;


            this.khoGridControl.Enabled = false;
            this.panelInput.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsKho.Position;
            /* Bước 1: Kiểm tra dữ liệu đầu vào của input */
            if (!KiemTraLoiInput()) return;

            /* Bước 2: Lấy dữ liệu mã kho */
            String maKho = txtMaKho.Text.Trim();
            /* Lấy ra tên kho & địa chỉ từ dataRowView */
            DataRowView drv = ((DataRowView)bdsKho[bdsKho.Position]);
            String tenKhoHang =(drv["TENKHO"].ToString());
            String diaChi = (drv["DIACHI"].ToString());

            String sqlKiemTraTonTai =
                    "DECLARE @result nchar(4) " +
                    "EXEC @result = SP_KiemTraKhoTonTai '" +
                    maKho + "' " +
                    "SELECT 'Value' = @result";

            SqlCommand sqlCommand = new SqlCommand(sqlKiemTraTonTai, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(sqlKiemTraTonTai);
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi Stored Procedure thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }

            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();

            /* Bước 2: Lấy vị trí con trỏ hiện tại và tìm con trỏ của maKho đang xử lí */
            int viTriConTro = bdsKho.Position;
            int viTriMaKho = bdsKho.Find("MAKHO", txtMaKho.Text);

            // Chỉ khi đang thêm mới Kho mới cho xuất hiện lỗi này nếu mã kho bị trùng
            if (result == 1 && viTriConTro != viTriMaKho)
            {
                MessageBox.Show("Mã kho hàng này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn GHI dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        /* Tạo câu truy vấn hoàn tác */
                        String cauTruyVanHoanTac = "";

                        if (dangThem == true)   // Câu truy vấn xóa kho nếu người dùng đang xử lí [Thêm]
                        {
                            cauTruyVanHoanTac = "" +
                                "DELETE DBO.KHO " +
                                "WHERE MAKHO = '" + txtMaKho.Text.Trim() + "'";
                        }
                        else   // Câu truy vấn update kho nếu người dùng đang xử lí [Sửa]
                        {
                            cauTruyVanHoanTac =
                                "UPDATE DBO.KHO " +
                                "SET " +
                                "TENKHO = N'" + tenKhoHang + "'," +
                                "DIACHI = N'" + diaChi + "'" +
                                "WHERE MAKHO = '" + maKho + "'";
                        }

                        /* Đẩy câu truy vấn vào trong stack undoList */
                        undoList.Push(cauTruyVanHoanTac);
                        dangThem = false;
                        dangSua = false;

                        bdsKho.EndEdit();   // Kết thúc quá trình hiệu chỉnh
                        bdsKho.ResetCurrentItem();  // Đưa thông tin lên lưới
                        this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.khoTableAdapter.Update(dS.Kho);

                        // bật tắt các buttons sau khi Ghi thành công
                        khoGridControl.Enabled = true;
                        panelInput.Enabled = false;

                        btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnHoanTac.Enabled = btnLamMoi.Enabled = btnThoat.Enabled = true;
                        btnGhi.Enabled = false;

                        // hiển thị thông báo ghi thành công
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show($"Lỗi khi ghi Kho \n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            Console.WriteLine("Vi tri: " + viTri);
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ((dangThem && btnThem.Enabled == false) || dangSua)
            {
                Console.WriteLine("ON this");
                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnHoanTac.Enabled = true;
                this.btnLamMoi.Enabled = true;
                this.btnThoat.Enabled = true;

                this.btnGhi.Enabled = false;


                this.khoGridControl.Enabled = true;
                this.panelInput.Enabled = false;

                bdsKho.CancelEdit();
                /*xoa dong hien tai*/
                if (dangThem) bdsKho.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                bdsKho.Position = viTri;

                dangThem = false;
                dangSua = false;

                return;
            }

            /*Bước 1*/
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnHoanTac.Enabled = false;
                return;
            }

            /*Bước 2*/
            Console.WriteLine("Vi tri:" + viTri);
            bdsKho.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();
            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExceSqlNoneQuery(cauTruyVanHoanTac);
            this.khoTableAdapter.Fill(this.dS.Kho);
            bdsKho.Position = viTri;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangSua = true;
            viTri = bdsKho.Position;
            khoGridControl.Enabled = cmbChiNhanh.Enabled
                                   = btnThem.Enabled
                                   = btnXoa.Enabled
                                   = btnSua.Enabled
                                   = btnLamMoi.Enabled
                                   = btnThem.Enabled = false;
            btnHoanTac.Enabled = btnGhi.Enabled
                               = panelInput.Enabled = true;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khoTableAdapter.Fill(this.dS.Kho);
                this.khoGridControl.Enabled = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi reload + " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Lưu lại địa chỉ để phục vụ Hoàn tác */
            String maKho = txtMaKho.Text;
            String tenKho = txtTenKho.Text;
            String diaChi = txtDiaChi.Text;
            String maCN = txtMaCN.Text.Trim();

            if (bdsPhieuNhap.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa kho vì đã nằm trong phiếu nhập", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsPhieuXuat.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa kho vì đã nằm trong phiếu xuất", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsDatHang.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa kho vì đã nằm trong phiếu đặt hàng", "", MessageBoxButtons.OK);
                return;
            }
            if (XtraMessageBox.Show("Bạn có chắc chắc muốn xóa Kho này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsKho.RemoveCurrent();
                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    khoTableAdapter.Update(this.dS.Kho);

                    MessageBox.Show("Xóa kho thành công!", "Thông báo", MessageBoxButtons.OK);
                    string cauTruyVanHoanTac =
                        "INSERT INTO DBO.KHO( MAKHO,TENKHO,DIACHI,MACN) " +
                        " VALUES( '" + maKho + "','" +
                        tenKho + "','" +
                        diaChi + "', '" +
                        maCN + "' ) ";

                    Console.WriteLine(cauTruyVanHoanTac);
                    undoList.Push(cauTruyVanHoanTac);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi khi xóa Kho. Hãy thử lại\n" + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    this.khoTableAdapter.Fill(this.dS.Kho);
                    bdsKho.Position = bdsKho.Find("MAKHO", maKho);
                    return;
                }
            }
            if (bdsKho.Count == 0)
            {
                btnXoa.Enabled = false;
            };
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("In the formKho SelectedIndexChanged");
            // Return trong trường hợp combobox không có dữ liệu
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

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

            if (Program.Connect() == false) // Kết nối thất bại
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.dS.Kho);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);

                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.dS.DatHang);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
            }
        }
    }
}
using DevExpress.XtraGrid;
using QuanLyVatTuPhanTan.SubForm;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyVatTuPhanTan
{
    public partial class FormPhieuXuat : DevExpress.XtraEditors.XtraForm
    {
        /* Thông tin vị trí con trỏ trên Grid View */
        int viTri = 0;

        /* Thông tin Binding source - GridControl hiện tại */
        BindingSource bds = null;
        GridControl gc = null;

        /* Biến phục vụ quá trình undo */
        bool dangThem = false;
        Stack undoList = new Stack();
        public FormPhieuXuat()
        {
            InitializeComponent();
        }

        private void FormPhieuXuat_Load(object sender, EventArgs e)
        {
            /* Tắt kiểm tra khóa ngoại */
            DSP.EnforceConstraints = false;
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.FillBy(this.DSP.PhieuXuat);
            this.chiTietPhieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.chiTietPhieuXuatTableAdapter.Fill(this.DSP.CTPX);

            /* Sao chép binding source đã lấy ở form đăng nhập */
            cmbChiNhanh.DataSource = Program.bds_dspm;

            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.chiNhanh;
        }

        /// <summary>
        /// Bước 1: Set BindingSource - GridControl hiện tại đang làm việc
        /// Bước 2: Bật - tắt các chức năng khi làm việc với PHIEU XUAT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCDPhieuXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnMenu.Links[0].Caption = "Phiếu xuất";

            /* Bước 1 */
            bds = bdsPhieuXuat;
            gc = gcPhieuXuat;

            /* Bước 2 */
            txtMaPhieuXuat.Enabled = false;
            dteNgay.Enabled = false;
            txtTenKhachHang.Enabled = true;
            txtMaNhanVien.Enabled = false;
            txtMaKho.Enabled = false;
            btnChonKhoHang.Enabled = false;

            txtMaVatTuChiTietPhieuXuat.Enabled = false;
            txtSoLuongChiTietPhieuXuat.Enabled = false;
            txtDonGiaChiTietPhieuXuat.Enabled = false;

            gcPhieuXuat.Enabled = true;
            gcChiTietPhieuXuat.Enabled = true;

            if (Program.role == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHoanTac.Enabled = false;
                btnLamMoi.Enabled = btnMenu.Enabled = btnThoat.Enabled = true;

                this.groupBoxPhieuNhap.Enabled = false;
            }
            else /* Role CHINHANH || USER */
            {
                cmbChiNhanh.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHoanTac.Enabled
                                = btnLamMoi.Enabled = btnMenu.Enabled = btnThoat.Enabled = true;
            }
        }

        /// <summary>
        /// Bước 1: Set BindingSource - GridControl hiện tại đang làm việc
        /// Bước 2: Bật - tắt các chức năng khi làm việc với CHITIETPHIEUXUAT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCDCTPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnMenu.Links[0].Caption = "Chi tiết phiếu xuất";
            /* Bước 1 */
            bds = bdsChiTietPhieuXuat;
            gc = gcChiTietPhieuXuat;

            /* Bước 2 */
            /* Tắt chức năng nhập liệu Phiếu xuất */
            txtMaPhieuXuat.Enabled = false;
            dteNgay.Enabled = false;
            txtTenKhachHang.Enabled = false;
            txtMaNhanVien.Enabled = false;
            txtMaKho.Enabled = false;
            btnChonKhoHang.Enabled = false;

            /* Tắt chức năng nhập liệu của CT Phiếu xuất */
            txtMaVatTuChiTietPhieuXuat.Enabled = false;
            txtSoLuongChiTietPhieuXuat.Enabled = false;
            txtDonGiaChiTietPhieuXuat.Enabled = false;

            gcPhieuXuat.Enabled = true;
            gcChiTietPhieuXuat.Enabled = true;

            if (Program.role == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
                btnThem.Enabled = btnXoa.Enabled = btnGhi.Enabled = btnHoanTac.Enabled = false;
                btnLamMoi.Enabled = btnMenu.Enabled = btnThoat.Enabled = true;

                this.groupBoxPhieuNhap.Enabled = false;
            }
            else /* Role CHINHANH || USER */
            {
                cmbChiNhanh.Enabled = btnXoa.Enabled = false;
                btnThem.Enabled = btnGhi.Enabled = btnHoanTac.Enabled
                                = btnLamMoi.Enabled = btnMenu.Enabled = btnThoat.Enabled = true;
            }
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.FillBy(this.DSP.PhieuXuat);

                this.chiTietPhieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.chiTietPhieuXuatTableAdapter.Fill(this.DSP.CTPX);
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.FillBy(this.DSP.PhieuXuat);
                this.chiTietPhieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.chiTietPhieuXuatTableAdapter.Fill(this.DSP.CTPX);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi refresh trang: \n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }
        private string taoCauTruyVanHoanTac(string cheDo)
        {
            String cauTruyVan = "";
            DataRowView drv;

            /*TH1: dang sua phieu xuat*/
            if (cheDo == "Phiếu xuất" && dangThem == false)
            {
                drv = ((DataRowView)(bdsPhieuXuat.Current));
                DateTime ngay = (DateTime)drv["NGAY"];


                cauTruyVan = "UPDATE DBO.PHIEUXUAT " +
                    "SET " +
                    "NGAY = CAST('" + ngay.ToString("yyyy-MM-dd") + "' AS DATETIME), " +
                    "HOTENKH = '" + drv["HOTENKH"].ToString().Trim() + "', " +
                    "MANV = '" + drv["MANV"].ToString().Trim() + "', " +
                    "MAKHO = '" + drv["MAKHO"].ToString().Trim() + "' " +
                    "WHERE MAPX = '" + drv["MAPX"].ToString().Trim() + "' ";
            }

            /*TH2: dang sua chi tiet phieu xuat*/
            if (cheDo == "Chi tiết phiếu xuất" && dangThem == false)
            {
                drv = ((DataRowView)(bdsChiTietPhieuXuat.Current));
                int soLuong = int.Parse(drv["SOLUONG"].ToString().Trim());
                float donGia = float.Parse(drv["DONGIA"].ToString().Trim());
                String maPhieuXuat = drv["MAPX"].ToString().Trim();
                String maVatTu = drv["MAVT"].ToString().Trim();

                cauTruyVan = "UPDATE DBO.CTPX " +
                    "SET " +
                    "SOLUONG = " + soLuong + " " +
                    "DOGIA = " + donGia + " " +
                    "WHERE MAPX = '" + maPhieuXuat + "' " +
                    "AND MAVT = '" + maVatTu + "' ";
            }

            return cauTruyVan;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Lấy vị trí con trỏ hiện tại */
            viTri = bds.Position;
            dangThem = true;

            /* Tạo dòng mới khi thêm */
            bds.AddNew();

            if (btnMenu.Links[0].Caption == "Phiếu xuất")
            {
                groupBoxVatTu.Visible = false;
                txtMaPhieuXuat.Enabled = true;
                txtTenKhachHang.Enabled = true;
                this.dteNgay.EditValue = DateTime.Now;
                this.dteNgay.Enabled = false;
                this.txtTenKhachHang.Enabled = true;
                this.txtMaNhanVien.Text = Program.userID;

                this.btnChonKhoHang.Enabled = true;
                this.txtMaKho.Text = Program.maKhoDuocChon;

                this.txtMaVatTuChiTietPhieuXuat.Enabled = false;
                this.btnChonVatTu.Enabled = false;
                this.txtSoLuongChiTietPhieuXuat.Enabled = false;
                this.txtDonGiaChiTietPhieuXuat.Enabled = false;

                ((DataRowView)(bdsPhieuXuat.Current))["MANV"] = Program.userID;
                ((DataRowView)(bdsPhieuXuat.Current))["NGAY"] = DateTime.Now;
                ((DataRowView)(bdsPhieuXuat.Current))["MAKHO"] = Program.maKhoDuocChon;
            }

            if (btnMenu.Links[0].Caption == "Chi tiết phiếu xuất")
            {
                ((DataRowView)(bdsChiTietPhieuXuat.Current))["MAPX"] = ((DataRowView)(bdsPhieuXuat.Current))["MAPX"].ToString();
                DataRowView drv = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position]);
                String maNV = drv["MANV"].ToString();   /* Kiết xuất ra mã nhân viên từ dataRowView hiện tại */
                if (Program.userID != maNV)
                {
                    MessageBox.Show("Bạn chỉ được phép thêm chi tiết trên phiếu xuất do mình lập!", "Thông báo", MessageBoxButtons.OK);
                    bds.RemoveCurrent();
                    return;
                }

                groupBoxVatTu.Visible = true;
                this.txtMaVatTuChiTietPhieuXuat.Enabled = false;
                this.btnChonVatTu.Enabled = true;

                this.txtSoLuongChiTietPhieuXuat.Enabled = true;
                this.txtSoLuongChiTietPhieuXuat.EditValue = 1;  /* Cho số lượng vật tư mặc định -> 1 */

                this.txtDonGiaChiTietPhieuXuat.Enabled = true;
                this.txtDonGiaChiTietPhieuXuat.EditValue = 1;   /* Cho đơn giá mặc định -> 1 */
            }

            /* Bật tắc các nút thao tác (Thêm, sửa, xóa, v.v...) */
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnGhi.Enabled = true;

            this.btnHoanTac.Enabled = true;
            this.btnLamMoi.Enabled = false;
            this.btnMenu.Enabled = false;
            this.btnThoat.Enabled = false;

            /* Disable gridControl */
            gcPhieuXuat.Enabled = false;
            gcChiTietPhieuXuat.Enabled = false;
        }
        private bool kiemTraDuLieuDauVao(string cheDo)
        {
            if (cheDo == "Phiếu xuất")
            {
                DataRowView drv = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position]);
                String maNhanVien = drv["MANV"].ToString();
                Console.WriteLine("Ma nv: " + maNhanVien);
                if (Program.userID != maNhanVien)
                {
                    MessageBox.Show("Không thể sửa phiếu xuất do người khác tạo", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

                if (txtMaPhieuXuat.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã phiếu nhập !", "Thông báo", MessageBoxButtons.OK);
                    txtMaPhieuXuat.Focus();
                    return false;
                }

                if (txtMaPhieuXuat.Text.Length > 8)
                {
                    MessageBox.Show("Mã phiếu xuất không thể quá 8 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    txtMaPhieuXuat.Focus();
                    return false;
                }

                if (txtTenKhachHang.Text == "")
                {
                    MessageBox.Show("Không bỏ trống tên khách hàng !", "Thông báo", MessageBoxButtons.OK);
                    txtTenKhachHang.Focus();
                    return false;
                }

                if (txtTenKhachHang.Text.Length > 100)
                {
                    MessageBox.Show("Tên khách hàng không quá 100 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    txtTenKhachHang.Focus();
                    return false;
                }

                if (txtMaKho.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã kho !", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

            }

            if (cheDo == "Chi tiết phiếu xuất")
            {
                Console.WriteLine("Checking...");
                DataRowView drv = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userID != maNhanVien)
                {
                    MessageBox.Show("Không thể thêm chi tiết phiếu xuất với phiếu xuất do người khác tạo !", "Thông báo", MessageBoxButtons.OK);
                    bdsChiTietPhieuXuat.RemoveCurrent();
                    return false;
                }

                if (txtMaPhieuXuat.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã phiếu nhập !", "Thông báo", MessageBoxButtons.OK);
                    txtMaPhieuXuat.Focus();
                    return false;
                }

                if (txtMaPhieuXuat.Text.Length > 8)
                {
                    MessageBox.Show("Mã phiếu xuất không thể quá 8 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    txtMaPhieuXuat.Focus();
                    return false;
                }

                if (txtMaVatTuChiTietPhieuXuat.Text == "")
                {
                    MessageBox.Show("Thiếu mã vật tư !", "Thông báo", MessageBoxButtons.OK);
                    txtMaVatTuChiTietPhieuXuat.Focus();
                    return false;
                }

                if (txtMaVatTuChiTietPhieuXuat.Text.Length > 4)
                {
                    MessageBox.Show("Mã vật tư không quá 4 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    txtMaVatTuChiTietPhieuXuat.Focus();
                    return false;
                }

                if (txtSoLuongChiTietPhieuXuat.Value <= 0)
                {
                    MessageBox.Show("Vui lòng chọn số lượng vật tư > 0", "Thông báo", MessageBoxButtons.OK);
                    txtSoLuongChiTietPhieuXuat.Focus();
                    return false;
                }

                if (txtSoLuongChiTietPhieuXuat.Value > Program.soLuongVatTu)
                {
                    MessageBox.Show("Số lượng vât tư tồn kho không đủ, vui lòng thay đổi số lượng vật tư nhỏ hơn!", "Thông báo", MessageBoxButtons.OK);
                    txtSoLuongChiTietPhieuXuat.Focus();
                    return false;
                }

                if (txtDonGiaChiTietPhieuXuat.Value < 0)
                {
                    MessageBox.Show("Đơn giá không thể bé hơn 0 VND !", "Thông báo", MessageBoxButtons.OK);
                    txtDonGiaChiTietPhieuXuat.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnChonKhoHang_Click(object sender, EventArgs e)
        {
            FormChonKho form = new FormChonKho();
            form.ShowDialog();
            this.txtMaKho.Text = Program.maKhoDuocChon;
        }

        private void capNhatSoLuongVatTu(string maVatTu, string soLuong)
        {
            string cauTruyVan = "EXEC SP_CapNhatSoLuongVatTu 'XUAT','" + maVatTu + "', " + soLuong;


            int n = Program.ExceSqlNoneQuery(cauTruyVan);
        }

        /// <summary>
        /// Bước 1: Kiểm tra dữ liệu input đầu vào
        /// Bước 2: 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Bước 1: */
            String cheDo = (btnMenu.Links[0].Caption == "Phiếu xuất") ? "Phiếu xuất" : "Chi tiết phiếu xuất"; /* Kiểm tra xem đang GHI ở chế độ nào */
            if (!kiemTraDuLieuDauVao(cheDo)) return;

            /* Tạo câu truy vấn hoàn tác */
            string cauTruyVanHoanTac = taoCauTruyVanHoanTac(cheDo);

            String maPhieuXuat = txtMaPhieuXuat.Text.Trim();
            //Console.WriteLine(maPhieuNhap);
            String cauTruyVan =
                    "DECLARE	@result nchar(8) " +
                    "EXEC @result = SP_KiemTraPhieuXuatTonTai '" +
                    maPhieuXuat + "' " +
                    "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Console.WriteLine("result try van PX: " + result);
            Program.myReader.Close();

            int viTriConTro = bdsPhieuXuat.Position;
            int viTriMaPhieuXuat = bdsPhieuXuat.Find("MAPX", maPhieuXuat);

            Console.WriteLine("Vi tri con tro: " + viTriConTro + ", viTriMaPX: " + viTriMaPhieuXuat);

            /*Dang them moi phieu nhap*/
            if (cheDo == "Phiếu xuất" && (result == 1 && viTriMaPhieuXuat != viTriConTro))
            {
                MessageBox.Show("Mã phiếu xuất đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                txtMaPhieuXuat.Focus();
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        if (cheDo == "Phiếu xuất" && dangThem == true)
                        {
                            cauTruyVanHoanTac =
                                "DELETE FROM DBO.PHIEUXUAT " +
                                "WHERE MAPX = '" + maPhieuXuat + "'";
                        }

                        /*TH2: them moi chi tiet don hang*/
                        if (cheDo == "Chi tiết phiếu xuất" && dangThem == true)
                        {
                            cauTruyVanHoanTac =
                                "DELETE FROM DBO.CTPX " +
                                "WHERE MAPX = '" + maPhieuXuat + "' " +
                                "AND MAVT = '" + Program.maVatTuDuocChon + "'";

                            string maVatTu = txtMaVatTuChiTietPhieuXuat.Text.Trim();
                            string soLuong = txtSoLuongChiTietPhieuXuat.Text.Trim();

                            capNhatSoLuongVatTu(maVatTu, soLuong);
                        }

                        undoList.Push(cauTruyVanHoanTac);
                        this.bdsPhieuXuat.EndEdit();
                        this.bdsChiTietPhieuXuat.EndEdit();
                        this.phieuXuatTableAdapter.Update(this.DSP.PhieuXuat);
                        this.chiTietPhieuXuatTableAdapter.Update(this.DSP.CTPX);

                        this.txtMaPhieuXuat.Enabled = false;

                        this.btnThem.Enabled = true;
                        this.btnXoa.Enabled = true;
                        this.btnGhi.Enabled = true;

                        this.btnHoanTac.Enabled = true;
                        this.btnLamMoi.Enabled = true;
                        this.btnMenu.Enabled = true;
                        this.btnThoat.Enabled = true;

                        this.gcPhieuXuat.Enabled = true;
                        this.gcChiTietPhieuXuat.Enabled = true;

                        dangThem = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        bds.RemoveCurrent();
                        MessageBox.Show("Đã xảy ra lỗi!\n\n" + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void btnChonVatTu_Click(object sender, EventArgs e)
        {
            FormChonVatTu form = new FormChonVatTu();
            form.ShowDialog();
            this.txtMaVatTuChiTietPhieuXuat.Text = Program.maVatTuDuocChon;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv;
            string cheDo = (btnMenu.Links[0].Caption == "Phiếu xuất") ? "Phiếu xuất" : "Chi tiết phiếu xuất";

            if (cheDo == "Phiếu xuất")
            {
                drv = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userID != maNhanVien)
                {
                    MessageBox.Show("Không xóa chi tiết phiếu xuất không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (bdsChiTietPhieuXuat.Count > 0)
                {
                    MessageBox.Show("Không thể xóa vì có chi tiết phiếu xuất", "Thông báo", MessageBoxButtons.OK);
                    return;
                }


                DateTime ngay = ((DateTime)drv["NGAY"]);
            }

            if (cheDo == "Chi tiết phiếu xuất")
            {
                drv = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userID != maNhanVien)
                {
                    MessageBox.Show("Bạn không xóa chi tiết phiếu xuất không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    return;
                }


                drv = ((DataRowView)bdsChiTietPhieuXuat[bdsChiTietPhieuXuat.Position]);
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    viTri = bds.Position;
                    if (cheDo == "Phiếu xuất")
                    {
                        bdsPhieuXuat.RemoveCurrent();
                    }
                    if (cheDo == "Chi tiết phiếu xuất")
                    {
                        bdsChiTietPhieuXuat.RemoveCurrent();
                    }


                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Update(this.DSP.PhieuXuat);

                    this.chiTietPhieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.chiTietPhieuXuatTableAdapter.Update(this.DSP.CTPX);

                    dangThem = false;
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnHoanTac.Enabled = true;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa chi tiết. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Update(this.DSP.PhieuXuat);

                    this.chiTietPhieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.chiTietPhieuXuatTableAdapter.Update(this.DSP.CTPX);
                    bds.Position = viTri;
                    return;
                }
            }
            else
            {
                // xoa cau truy van hoan tac di
                undoList.Pop();
            }
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThem == true && this.btnThem.Enabled == false)
            {
                dangThem = false;

                if (btnMenu.Links[0].Caption == "Phiếu xuất")
                {
                    this.txtMaPhieuXuat.Enabled = false;
                    this.dteNgay.Enabled = false;
                    this.txtTenKhachHang.Enabled = true;

                    this.txtMaNhanVien.Enabled = false;

                    this.txtMaKho.Enabled = false;
                    this.btnChonKhoHang.Enabled = true;
                    bds.CancelEdit();
                }

                if (btnMenu.Links[0].Caption == "Chi tiết phiếu xuất")
                {
                    this.txtMaPhieuXuat.Enabled = false;
                    this.txtMaVatTuChiTietPhieuXuat.Enabled = false;
                    this.btnChonVatTu.Enabled = false;

                    this.txtSoLuongChiTietPhieuXuat.Enabled = true;
                    this.txtDonGiaChiTietPhieuXuat.Enabled = true;
                    bds.CancelEdit();
                }

                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnGhi.Enabled = true;

                this.btnLamMoi.Enabled = true;
                this.btnMenu.Enabled = true;
                this.btnThoat.Enabled = true;

                this.gcPhieuXuat.Enabled = true;
                this.gcChiTietPhieuXuat.Enabled = true;


                Console.WriteLine("Vi tri hien tai: " + bds.Position);
                //bds.RemoveCurrent();

                bds.Position = viTri;
                return;
            }

            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnHoanTac.Enabled = false;
                return;
            }

            bds.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();

            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExceSqlNoneQuery(cauTruyVanHoanTac);

            this.phieuXuatTableAdapter.Fill(this.DSP.PhieuXuat);
            this.chiTietPhieuXuatTableAdapter.Fill(this.DSP.CTPX);

            bdsPhieuXuat.Position = viTri;
        }
    }
}
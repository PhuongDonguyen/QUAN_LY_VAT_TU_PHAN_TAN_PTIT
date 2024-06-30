using DevExpress.XtraEditors;
using QuanLyVatTuPhanTan.SubForm;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyVatTuPhanTan
{
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {

        String maChiNhanh = "";
        Boolean dangThemMoi = false;
        Boolean dangSua = false;
        int vitriNhanVien = 0;
        Stack undoList = new Stack();
        // dung để đưa con trỏ chuột về vị trí khi undo
        Stack listMaNV = new Stack();
        public FormNhanVien()
        {
            InitializeComponent();

        }

        public void chuyenChiNhanh(String maChiNhanhMoi)
        {
            int viTriHienTai = bdsNhanVien.Position;
            String maNV = ((DataRowView)bdsNhanVien[viTriHienTai])["MANV"].ToString();
            String cauTruyVan = $@"DECLARE @return_value int; 
                 EXEC @return_value =  sp_ChuyenChiNhanh {maNV} , '{ maChiNhanhMoi}' , 0 
                 SELECT 'value' = @return_value ";

            Console.WriteLine("Cau Truy Van: " + cauTruyVan);
            if (Program.Connect() == false)
            { return; }
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                if (Program.myReader == null)
                {
                    MessageBox.Show("Không có dữ liệu trả về trong khi chuyển chi nhánh", "thông báo", MessageBoxButtons.OK);
                    return;
                };
                Program.myReader.Read();
                int maNvMoi = Program.myReader.GetInt32(0);
                Program.myReader.Close();
                MessageBox.Show("Chuyển chi nhánh thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                String cauTruyVanHoanTac = "EXEC sp_ChuyenChiNhanh " + maNvMoi + ",'" + Program.maChiNhanhHienTai + "' , 1 " ;
                undoList.Push(cauTruyVanHoanTac);
                listMaNV.Push(maNV);
                btnHoanTac.Enabled=true;
                nhanVienTableAdapter.Fill(this.dS.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("thực thi database thất bại!\n\n" + ex.Message, "thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
        }


        public bool KiemTraLoiKhiGhi()
        {
            int viTriConTro = bdsNhanVien.Position;
            //Check ma nhan vien trung
            String queryStr = $"DECLARE @return_value int " +
                $"EXEC @return_value = [dbo].[SP_KiemTraNhanVienTonTai] '{txtMaNV.Text.Trim()}' " +
                $"SELECT 'value' = @return_value";
            Program.myReader = Program.ExecSqlDataReader(queryStr);
            if (Program.myReader == null) return false;
            Program.myReader.Read();
            int result = (Program.myReader.GetInt32(0));
            Program.myReader.Close();

            if (result > 0 && viTriConTro != vitriNhanVien)
            {
                XtraMessageBox.Show($"Mã nhân viên đã được sử dụng", "", MessageBoxButtons.OK);
                return false;
            }
            String ktCMND = $"DECLARE @return_value int " +
            $"EXEC @return_value = [dbo].[SP_KiemTraCMNDTonTai] '{txtCMND.Text.Trim()}' " +
            $"SELECT 'value' = @return_value";
            Program.myReader = Program.ExecSqlDataReader(ktCMND);
            if (Program.myReader == null) return false;
            Program.myReader.Read();
            int res = (Program.myReader.GetInt32(0));
            Program.myReader.Close();

            if (res > 0 && viTriConTro != vitriNhanVien)
            {
                XtraMessageBox.Show($"Số CMND đã tồn tại", "", MessageBoxButtons.OK);
                return false;
            }
            bool check;
            txtDiaChi.Text = txtDiaChi.Text.Trim();
            check = Program.checkText(txtDiaChi, "Địa chỉ", 0, 100);
            if (!check) return false;
            check = Program.checkText(txtHo, "Họ", 0, 20);
            if (!check) return false;
            check = Program.checkText(txtTen, "Ten", 0, 10);
 
            if (!check) return false;
            txtMaNV.Text = txtMaNV.Text.Trim();
            if (!Regex.IsMatch(txtMaNV.Text, @"^[0-9]+$"))
            {
                XtraMessageBox.Show($"Mã nhân viên chỉ nhận số", "", MessageBoxButtons.OK);
                txtMaNV.Focus();
                return false;
            }
            txtHo.Text = txtHo.Text.Trim();
            if (!Regex.IsMatch(txtHo.Text, @"^[a-zA-ZÀ-ỹà-ỹ\s]+$"))
            {
                XtraMessageBox.Show($"Họ chỉ nhận chữ cái", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return false;
            }
            txtTen.Text = txtTen.Text.Trim();
            if (!Regex.IsMatch(txtTen.Text, @"^[a-zA-ZÀ-ỹà-ỹ]+$"))
            {
                XtraMessageBox.Show($"Tên chỉ nhận chữ cái và k nhận khoảng trắng", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return false;
            }

            if (CalculateAge(dteNgaySinh.DateTime) < 18)
            {
                XtraMessageBox.Show($"Nhân viên chưa đủ 18 tuổi", "", MessageBoxButtons.OK);
                dteNgaySinh.Focus();
                return false;
            }
            txtCMND.Text = txtCMND.Text.Trim();
            if (!Regex.IsMatch(txtCMND.Text, @"^[0-9]+$"))
            {
                XtraMessageBox.Show($"CMND chỉ nhận số", "", MessageBoxButtons.OK);
                txtCMND.Focus();
                return false;
            }
            txtCMND.Text = txtCMND.Text.Trim();
            if (txtCMND.Text.Length != 12)
            {

                XtraMessageBox.Show($"CMND phaỉ có 12 số", "", MessageBoxButtons.OK);
                txtCMND.Focus();
                return false;
            }
            if (soLuong.Value < 1000000)
            {
                XtraMessageBox.Show($"Lương phải >= 1000000", "", MessageBoxButtons.OK);
                soLuong.Focus();
                return false;
            }

            return true;
        }
        public int CalculateAge(DateTime birthday)
        {
            int age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.DayOfYear < birthday.DayOfYear)
                age = age - 1;
            return age;
        }
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Load form nhan vien");
            dS.EnforceConstraints = false;
            // cái này đẻ lấy data hiện tại để kết nối, nếu dòng dưới nó sẻ lấy dS
            // TODO: This line of code loads data into the 'dS.DatHang' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.dS.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
            
         
            //
            cmbChiNhanhNV.DataSource = Program.bds_dspm;
            cmbChiNhanhNV.DisplayMember = "TENCN";
            cmbChiNhanhNV.ValueMember = "TENSERVER";
            cmbChiNhanhNV.SelectedIndex = Program.chiNhanh;
            if (Program.role == "CONGTY")
            {

                this.panelNhapLieu.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = false;
                panelNhapLieu.Enabled = btnSua.Enabled = btnGhi.Enabled = btnHoanTac.Enabled = false;
                cmbChiNhanhNV.Enabled = true;

            }
            else if (Program.role == "CHINHANH")
            {
                btnThem.Enabled =  btnXoa.Enabled = btnSua.Enabled = true;
                btnHoanTac.Enabled = panelNhapLieu.Enabled = btnGhi.Enabled = false;
                cmbChiNhanhNV.Enabled = false;
            }
            else
            { //User
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                btnHoanTac.Enabled = panelNhapLieu.Enabled = btnGhi.Enabled = false;
                cmbChiNhanhNV.Enabled = false;
            }
            btnGhi.Enabled = false;
            if (bdsNhanVien.Count == 0)
            {
                btnXoa.Enabled = false;
            };


        }


        private void panelNhapLieu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView nv = (DataRowView)bdsNhanVien[bdsNhanVien.Position];
            String ho = "";
            String ten = "";
            int maNv = -1;
            String cmnd = "";
            String diaChi = "";
            DateTime ns;
            string ngaySinh = "";
            String luong = "";
            String maCn = "";
            String ttx = "";

            if (dangSua)
            {
                maNv = int.Parse(nv["MANV"].ToString());
                ho = nv["HO"].ToString();
                ten = nv["TEN"].ToString();
                cmnd = nv["SOCMND"].ToString();
                diaChi = nv["DIACHI"].ToString();
                ns = Convert.ToDateTime(nv["NGAYSINH"].ToString());
                ngaySinh = ns.ToString("yyyy-MM-dd");
                luong = nv["LUONG"].ToString();
                maCn = nv["MACN"].ToString().Trim();
                ttx = nv["TrangThaiXoa"].ToString();
            }
            bool check = KiemTraLoiKhiGhi();
            if (!check) return;

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    bdsNhanVien.EndEdit();
                    bdsNhanVien.ResetCurrentItem();
                    nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;

                    nhanVienTableAdapter.Update(dS.NhanVien);
                    String truyVanHoanTac = "";
                    // Them nv
                    if (dangThemMoi)
                    {
                        truyVanHoanTac = $"Delete NhanVien where MANV = '{txtMaNV.Text.Trim()}'";
                        listMaNV.Push(txtMaNV.Text.Trim());
                    }
                    else // Sua nv
                    {
                        truyVanHoanTac =
                  $"UPDATE DBO.NHANVIEN SET  HO =N'{ho}',TEN =N'{ten}',SOCMND ={cmnd},DIACHI =N'{diaChi}',NGAYSINH ='{ngaySinh}',LUONG ={luong},MACN ='{maCn}',TrangThaiXoa='{ttx}' where MANV = {maNv}";
                        listMaNV.Push(maNv);
                    }
                    Console.WriteLine("ht them sua: " + truyVanHoanTac);
                    undoList.Push(truyVanHoanTac);
                    gcNhanVien.Enabled = true;
                    panelNhapLieu.Enabled = false;
                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnLamMoi.Enabled = true;
                    dangThemMoi = false;
                    dangSua = false;
                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show($"Lỗi khi ghi nhân viên \n" + ex.Message, "", MessageBoxButtons.OK);

                    return;
                }
            }

        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThemMoi = true;
            vitriNhanVien = bdsNhanVien.Position;
            this.panelNhapLieu.Enabled = true;
            btnSua.Enabled = btnLamMoi.Enabled = cmbChiNhanhNV.Enabled = btnThem.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            btnHoanTac.Enabled = true;
            gcNhanVien.Enabled = false;
            bdsNhanVien.AddNew();
            dteNgaySinh.EditValue = "01-05-2003";
            txtMaCN.Text = maChiNhanh;
            soLuong.Value = 4000000;
            txtDiaChi.Text = "HCM";
            cbTrangThaiXoa.Checked = false;

        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int manv;
            if ((dangThemMoi == true && btnThem.Enabled == false) || (dangSua == true && btnSua.Enabled == false))
            {
                dangSua = false;
                dangThemMoi = false;

                bdsNhanVien.CancelEdit();
                gcNhanVien.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnThem.Enabled = true;
                btnLamMoi.Enabled = true;
                if (undoList.Count == 0)
                {

                    btnHoanTac.Enabled = btnGhi.Enabled = false;
                }
                else
                {
                    btnHoanTac.Enabled = btnGhi.Enabled = true;
                }
                bdsNhanVien.Position = vitriNhanVien;
                nhanVienTableAdapter.Fill(this.dS.NhanVien);
                return;
            }
            String truyVanHoanTac = undoList.Pop().ToString();
            Console.WriteLine("truy vấn hoàn tác: " + truyVanHoanTac);
            if (truyVanHoanTac.Contains("sp_ChuyenChiNhanh"))
            {

                // server chi nhanh chuyen toi
                String chiNhanhHienTai = Program.servername;
                Program.servername = Program.servernameTranfer;
                Program.loginName = Program.remoteLogin;
                Program.loginPass = Program.remotePassword;
                if (undoList.Count == 0)
                {
                    btnHoanTac.Enabled = btnGhi.Enabled = false;
                }
                if (!Program.Connect())
                {
                    return;
                }
                Program.ExceSqlNoneQuery(truyVanHoanTac);
                Program.servername = chiNhanhHienTai;
                Program.loginName = Program.currentLogin;
                Program.loginPass = Program.currentPass;
                nhanVienTableAdapter.Fill(this.dS.NhanVien);
                manv = int.Parse(listMaNV.Pop().ToString());
                if (manv >= 0)
                {
                    bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                }
                MessageBox.Show("Chuyển nhân viên trở lại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!Program.Connect())
                {
                    MessageBox.Show($"Không thể kết nối đến server {Program.servername}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                return;
            }
            else
            {

                if (!Program.Connect())
                {
                    return;
                }
                Program.ExceSqlNoneQuery(truyVanHoanTac);


            }
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
             manv = int.Parse(listMaNV.Pop().ToString());
            if (manv >= 0)
            {
                bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);

            }
            if (undoList.Count == 0)
            {
                btnHoanTac.Enabled = btnGhi.Enabled = false;
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                nhanVienTableAdapter.Fill(this.dS.NhanVien);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi reload + " + ex.Message, "Error");
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int manv = 0;
            manv = int.Parse(((DataRowView)(bdsNhanVien[bdsNhanVien.Position]))["MANV"].ToString());
            if (manv == int.Parse(Program.userID))
            {
                XtraMessageBox.Show("Không thể xoá chính mình", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (bdsPhieuNhap.Count > 0)
            {
                XtraMessageBox.Show("Không thể xoá vì nhân viên này đang có phiếu nhập ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (bdsPhieuXuat.Count > 0)
            {
                XtraMessageBox.Show("Không thể xoá vì nhân viên này đang có phiếu xuất ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (bdsDatHang.Count > 0)
            {
                XtraMessageBox.Show("Không thể xoá vì nhân viên này đang có đơn đặt hàng ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (XtraMessageBox.Show("Bạn có muốn xoá không ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    DateTime dateValue = Convert.ToDateTime(dteNgaySinh.EditValue);
                    string formattedDate = dateValue.ToString("yyyy-MM-dd");
                    string cauTruyVanHoanTac =
                        $"INSERT INTO DBO.NHANVIEN( MANV,HO,TEN,SOCMND,DIACHI,NGAYSINH,LUONG,MACN,TrangThaiXoa) VALUES({txtMaNV.Text},N'{txtHo.Text}',N'{txtTen.Text}','{txtCMND.Text}',N'{txtDiaChi.Text}',CAST({formattedDate} AS DATETIME), {soLuong.Value},'{txtMaCN.Text.Trim()}','{cbTrangThaiXoa.Checked}')";

                    undoList.Push(cauTruyVanHoanTac);
                    listMaNV.Push(txtMaNV.Text);
                    bdsNhanVien.RemoveCurrent();
                    btnHoanTac.Enabled = true;
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    nhanVienTableAdapter.Update(this.dS.NhanVien);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Xảy ra lỗi khi xoá \n" + ex.Message);
                    nhanVienTableAdapter.Fill(this.dS.NhanVien);
                    bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                    return;
                }
            }
            if (bdsNhanVien.Count == 0)
            {
                btnXoa.Enabled = false;
            };

        }
        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangSua = true;
            vitriNhanVien = bdsNhanVien.Position;
            gcNhanVien.Enabled = false;
            cmbChiNhanhNV.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLamMoi.Enabled = false;
            btnHoanTac.Enabled = true;
            btnGhi.Enabled = true;
            panelNhapLieu.Enabled = true;

        }

        private void cmbChiNhanhNV_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            if (cmbChiNhanhNV.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChiNhanhNV.SelectedValue.ToString();
            if (cmbChiNhanhNV.SelectedIndex != Program.chiNhanh)
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
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.dS.DatHang);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.dS.PhieuXuat);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);

                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
                // bi loi khi o nhan vien dang xuat zo dang nhap lai
                /*      maChiNhanh = ((DataRowView)bdsNhanVien[0])["MACN"].ToString();*/
            }

        }

        private void sOCMNDLabel_Click(object sender, EventArgs e)
        {

        }

        private void gcNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int viTriHienTai = bdsNhanVien.Position;
            int trangThaiXoa = ((DataRowView)bdsNhanVien[viTriHienTai])["TrangThaiXoa"].ToString() == "True" ? 1 : 0;
            String maNV = ((DataRowView)bdsNhanVien[viTriHienTai])["MANV"].ToString();
            if (trangThaiXoa == 1)
            {
                MessageBox.Show("Nhân viên này đã bị xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (maNV == Program.userID)
            {
                MessageBox.Show("Không thể tự chuyển chính mình", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormChuyenChiNhanh frmCN = new FormChuyenChiNhanh();
            frmCN.chuyenChiNhanh = new FormChuyenChiNhanh.MyDelegate(chuyenChiNhanh);
            frmCN.Show();

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}
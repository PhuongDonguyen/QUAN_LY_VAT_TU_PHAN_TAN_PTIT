using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using QuanLyVatTuPhanTan.DSTableAdapters;
using QuanLyVatTuPhanTan.SubForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatTuPhanTan
{
    public partial class FormPhieuNhap : DevExpress.XtraEditors.XtraForm
    {
        BindingSource bds = null;
        GridControl gc = null;
        string type = "";
        bool dangThemMoi = false;
        bool dangSuaCTPN = false;
        string makho = "";
        int vitriContro = 0; // de luu pn or ctpn
        int vitriContro1 = 0;// de luu ctpn
        // khi xoa xong undo lai là trả về vị trí đã xoá
        Stack undoListPN = new Stack();
        Stack vtHoanTacPN = new Stack();

        Stack undoListCTPN = new Stack();
        Stack vtHoanTacCTPN = new Stack();
        Stack vtHoantacPN_CTPN = new Stack();


        public FormPhieuNhap()
        {
            InitializeComponent();
        }
        public bool KiemTraDulieuDauVaoPN()
        {

            if (txtMaPN.Text.Trim().Length == 0)
            {
      
                MessageBox.Show("Không được để mã trống mã phiéu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string ktPnTonTai = $@"
                DECLARE	@return_value int
                EXEC	@return_value = [dbo].[SP_KiemTraNhanPHieuNhapTonTai]
		                @X = '{txtMaPN.Text}'
                SELECT	'res' = @return_value";
            Program.myReader = Program.ExecSqlDataReader(ktPnTonTai);
            if (Program.myReader == null) return false;
            Program.myReader.Read();
            int result = (Program.myReader.GetInt32(0));
            Console.WriteLine(result);
            Program.myReader.Close();
            if (result == 1)
            {
                MessageBox.Show("Mã phiếu nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtMaDdh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Không được để mã trống đơn đặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public bool KiemTraDulieuDauVaoCTPN()
        {
            if (int.Parse(seSoLuongCTPN.Value.ToString()) < 1)
            {
                MessageBox.Show("Số lượng phải > 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (int.Parse(seGia.Value.ToString()) < 1)
            {
                MessageBox.Show("Giá phải > 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
        public void saoChepCTDDHVaoCTPN(string mapn, string maddh)
        {
            string str = $@"EXEC   [dbo].[sp_SaoChepCTDDHVaoCTPN] @MAPN = '{mapn}', @MaSoDDH = '{maddh}'";
            Console.WriteLine(str);
            Program.ExceSqlNoneQuery(str);
        }
        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {

            dS.EnforceConstraints = false;
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.FillPN(this.dS.PhieuNhap);
            this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
            this.CTPNTableAdapter.FillBy(this.dS.CTPN);
            cmbChiNhanh.DataSource = Program.bds_dspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.chiNhanh;
            gbPN.Enabled = false;
            gbCTPN.Enabled = false;
            cmbChiNhanh.Enabled = true;
            this.btnLamMoi.Enabled = false;
            this.cmbChiNhanh.Enabled = false;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnGhi.Enabled = false;
            this.btnHoanTac.Enabled = false;
            this.btnChonCheDo.Enabled = true;
            this.btnThoat.Enabled = true;
        }



        private void gcPN_Click(object sender, EventArgs e)
        {

        }

        private void btnPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 0*/
            btnChonCheDo.Links[0].Caption = "Phiếu Nhập";
            Console.WriteLine("count " + undoListPN.Count.ToString());
           
            /*Step 1*/
            bds = bdsPN;
            gc = gcPN;

            /*Step 2*/
            /*Bat chuc nang cua phieu nhap*/
            gbPN.Enabled = true;
            gbCTPN.Enabled = true;

            /*Bat cac grid control len*/
            gcPN.Enabled = true;
            gcChiTietPhieuNhap.Enabled = true;

            /*Step 3*/
            /*CONG TY chi xem du lieu*/
            if (Program.role == "CONGTY")
            {

                cmbChiNhanh.Enabled = true;

                this.btnThem.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnGhi.Enabled = false;

             
                this.btnLamMoi.Enabled = true;
                this.btnChonCheDo.Enabled = true;
                this.btnThoat.Enabled = true;

                this.gbPN.Enabled = false;


            }
            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbChiNhanh.Enabled = false;
                this.btnThem.Enabled = true;
                bool turnOn = (bdsPN.Count > 0) ? true : false;
                this.btnXoa.Enabled = turnOn;
                this.btnGhi.Enabled = true;
                this.btnSua.Enabled = false;

                this.btnLamMoi.Enabled = true;
                this.btnChonCheDo.Enabled = true;
                this.btnThoat.Enabled = true;
                if (undoListPN.Count == 0)
                {
                    this.btnHoanTac.Enabled = false;
                }
                else
                {
                    this.btnHoanTac.Enabled = true;
                }
            }
        }

        private void btnCTPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 0*/
            btnChonCheDo.Links[0].Caption = "Chi Tiết Phiếu Nhập";
            Console.WriteLine("count " + undoListCTPN.Count.ToString());

            /*Step 2*/
            /*Bat chuc nang cua phieu nhap*/
            gbPN.Enabled = true;
            gbCTPN.Enabled = true;

            /*Bat cac grid control len*/
            gcPN.Enabled = true;
            gcChiTietPhieuNhap.Enabled = true;


            /*Step 3*/
            /*CONG TY chi xem du lieu*/
            if (Program.role == "CONGTY")
            {

                cmbChiNhanh.Enabled = false;

                this.btnThem.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnGhi.Enabled = false;

                this.btnHoanTac.Enabled = false;
                this.btnLamMoi.Enabled = true;
                this.btnChonCheDo.Enabled = true;
                this.btnThoat.Enabled = true;

                this.gbPN.Enabled = false;


            }
            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbChiNhanh.Enabled = false;
                this.btnThem.Enabled = false;
                this.btnXoa.Enabled = true;
                this.btnGhi.Enabled = false;
                this.btnLamMoi.Enabled = true;
                this.btnChonCheDo.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnThoat.Enabled = true;
                if (undoListCTPN.Count == 0)
                {
                    this.btnHoanTac.Enabled = false;
                }
                else
                {
                    this.btnHoanTac.Enabled = true;
                }
            }
        }


        private void gcChiTietPhieuNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitriContro = bdsPN.Position;
            txtMaPN.Enabled = true;
            dangThemMoi = true;
            gbPN.Enabled = true;
            btnChonDonHang.Enabled = true;
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnLamMoi.Enabled = false;
            this.btnGhi.Enabled = true;
            this.btnHoanTac.Enabled = true;
            this.btnChonCheDo.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnThoat.Enabled = false;

            bdsPN.AddNew();
            txtMaNV.Text = Program.userID;
            dteNgayLap.EditValue = DateTime.Now;

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string truyVanHoanTac = "";
            String cheDo = (btnChonCheDo.Links[0].Caption == "Phiếu Nhập") ? "PN" : "CTPN";
            bool res = false;
            if (cheDo == "PN" && dangThemMoi)
            {
                Console.WriteLine("Check pn");
                res = KiemTraDulieuDauVaoPN();
            }
            if (cheDo == "CTPN" && dangSuaCTPN)
            {
                Console.WriteLine("check ctpn");
                res = KiemTraDulieuDauVaoCTPN();
            }
            Console.WriteLine( cheDo == "Phiếu Nhập" );
            if (!res) return;
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                      MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)

            {
                try
                {
                    txtMaPN.Text = txtMaPN.Text.Trim();
                    if (cheDo == "PN" && dangThemMoi)
                    {
                        truyVanHoanTac = $@"
                            
                           exec [dbo].[sp_HoanTacKhiThemPN] '{txtMaPN.Text}'
                         
                         ";
                        undoListPN.Push(truyVanHoanTac);
                        vtHoanTacPN.Push(bdsPN.Position);
                        this.bdsPN.EndEdit();
                        bdsPN.ResetCurrentItem();
                        this.phieuNhapTableAdapter.Update(this.dS.PhieuNhap);
                        saoChepCTDDHVaoCTPN(txtMaPN.Text, txtMaDdh.Text);
                        this.btnSua.Enabled = false;
                    }
                    if (cheDo == "CTPN" && dangSuaCTPN)
                    {
                        DataRowView ctpn = (DataRowView)bdsCTPN[bdsCTPN.Position];
                        String MAPN = ctpn["MAPN"].ToString().Trim();
                        String MAVT = ctpn["MAVT"].ToString().Trim();
                        String sl = ctpn["SOLUONG"].ToString().Trim();
                        String gia = ctpn["DONGIA"].ToString().Trim();
                        int capNhatSLVTDaSua = int.Parse(seSoLuongCTPN.Value.ToString()) - int.Parse(sl) ;
                        string capNhatVT = $" EXEC sp_CapNhatSoLuongVatTu 'IMPORT' , {txtMaVtCTPN.Text} , {capNhatSLVTDaSua}";
                        truyVanHoanTac =
                        $@"UPDATE DBO.CTPN 
                        SET  MAPN ='{MAPN}',MAVT ='{MAVT}',SOLUONG={sl},DONGIA ={gia} where MAPN = '{MAPN}' AND MAVT= '{MAVT}'
                        
                        EXEC sp_CapNhatSoLuongVatTu 'EXPORT' , {txtMaVtCTPN.Text} , {capNhatSLVTDaSua}
                        ";
                        if (!Program.Connect())
                        {
                            return;
                        }
                        // cập nhật số lượng vậtt tư khi thêm
                        Program.ExceSqlNoneQuery(capNhatVT);
                        undoListCTPN.Push(truyVanHoanTac);
                        vtHoanTacCTPN.Push(bdsCTPN.Position);
                     
                        vitriContro = bdsPN.Position;
                        vitriContro1 = bdsCTPN.Position;

                        this.bdsCTPN.EndEdit();
                        bdsCTPN.ResetCurrentItem();
                        this.CTPNTableAdapter.Update(this.dS.CTPN);
                        this.btnSua.Enabled = true;
                        gcChiTietPhieuNhap.Enabled = true;
                        gcPN.Enabled = true;
                           
                      
                    }
                    this.btnThem.Enabled = true;
                    this.btnXoa.Enabled = true;
                    this.btnGhi.Enabled = true;
                    btnChonDonHang.Enabled = false;
                    this.btnHoanTac.Enabled = true;
                    this.btnLamMoi.Enabled = true;
                    this.btnChonCheDo.Enabled = true;
                    this.btnThoat.Enabled = true;
                    this.txtMaPN.Enabled = false;
                    this.seGia.Enabled = false;
                    this.seSoLuongCTPN.Enabled = false;
                    this.phieuNhapTableAdapter.FillPN(this.dS.PhieuNhap);
                    this.CTPNTableAdapter.FillBy(this.dS.CTPN);
                    if(cheDo == "PN")
                    {
                        bdsPN.Position = bdsPN.Count;
                    }
                    else
                    {
                        bdsPN.Position = vitriContro;
                        bdsCTPN.Position = vitriContro1;
                    }
                    dangThemMoi = false;
                    dangSuaCTPN = false;
                    MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                catch (Exception ex)
                {
                  
                    MessageBox.Show("Da xay ra loi !\n\n" + ex.Message, "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }

        private void masoDDHTextEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnChonDonHang_Click(object sender, EventArgs e)
        {
            formChonDonHang form = new formChonDonHang();
            form.ShowDialog();
            txtMaDdh.Text = Program.chonDdhPN;
            txtMaKho.Text = Program.chonKhoPN;
        }


        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                vitriContro = bdsPN.Position;
                vitriContro1 = bdsCTPN.Position;
                this.phieuNhapTableAdapter.FillPN(this.dS.PhieuNhap);
                this.CTPNTableAdapter.FillBy(this.dS.CTPN);
                bdsPN.Position = vitriContro;
                bdsCTPN.Position= vitriContro1;
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi reload + " + ex.Message, "Error");
            }
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String cheDo = (btnChonCheDo.Links[0].Caption == "Phiếu Nhập") ? "PN" : "CTPN";
            if (cheDo == "PN")
            {
                if (dangThemMoi == true && btnThem.Enabled == false)
                {
                    dangThemMoi = false;
                    bdsPN.CancelEdit();
                
                    txtMaPN.Enabled = false;
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnThem.Enabled = true;
                    btnLamMoi.Enabled = true;
                    btnChonDonHang.Enabled = false;
                    if (undoListPN.Count == 0)
                    {

                        btnHoanTac.Enabled = btnGhi.Enabled = false;
                    }
                    else
                    {
                        btnHoanTac.Enabled = btnGhi.Enabled = true;
                    }
                    this.phieuNhapTableAdapter.FillPN(this.dS.PhieuNhap);
                    bdsPN.Position = vitriContro;
                    return;
                }
                String truyVanHoanTac = undoListPN.Pop().ToString();
                int vt = int.Parse(vtHoanTacPN.Pop().ToString());
                Console.WriteLine(vt);
                if (!Program.Connect())
                {
                    return;
                }
                Console.WriteLine(truyVanHoanTac);
                Program.ExceSqlNoneQuery(truyVanHoanTac);
                this.phieuNhapTableAdapter.FillPN(this.dS.PhieuNhap);
                bdsPN.Position = vt;
                if (undoListPN.Count == 0)
                {
                    btnHoanTac.Enabled = btnGhi.Enabled = false;
                }

            }
            else
            {

                if (dangSuaCTPN == true && btnSua.Enabled == false)
                {
                    dangSuaCTPN = false;
                   
                    bdsCTPN.CancelEdit();
                    btnThem.Enabled = false;
                    btnXoa.Enabled = true;
                    btnLamMoi.Enabled = true;
                    seSoLuongCTPN.Enabled = false;
                    seGia.Enabled = false;
                    gcPN.Enabled = true;
                    gcChiTietPhieuNhap.Enabled = true;
                    btnSua.Enabled = true;
                    if (undoListPN.Count == 0)
                    {

                        btnHoanTac.Enabled = btnGhi.Enabled = false;
                    }
                    else
                    {
                        btnHoanTac.Enabled = btnGhi.Enabled = true;
                    }
                    this.CTPNTableAdapter.FillBy(this.dS.CTPN);
                    bdsCTPN.Position = vitriContro;
                    return;
                }
                String truyVanHoanTac = undoListCTPN.Pop().ToString();
                int vtCTPN = int.Parse(vtHoanTacCTPN.Pop().ToString());
            
                if (!Program.Connect())
                {
                    return;
                }
                Console.WriteLine(truyVanHoanTac);
                Program.ExceSqlNoneQuery(truyVanHoanTac);
                this.CTPNTableAdapter.FillBy(this.dS.CTPN);
                bdsCTPN.Position = vtCTPN;
                if (undoListPN.Count == 0)
                {
                    btnHoanTac.Enabled = btnGhi.Enabled = false;
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String cheDo = (btnChonCheDo.Links[0].Caption == "Phiếu Nhập") ? "Phiếu Nhập" : "Chi Tiết Phiếu Nhập";
            int controCu = 0;
            if (cheDo == "Phiếu Nhập")
            {
                if (bdsCTPN.Count > 0)
                {
                    MessageBox.Show("Không thể xoá phiếu nhập khi có chi tiết phiếu nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xoá phiếu nhập này ?", "Thông báo",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {

                    try
                    {
                        controCu = bdsPN.Position;
                        DateTime dateValue = Convert.ToDateTime(dteNgayLap.EditValue);
                        string formattedDate = dateValue.ToString("yyyy-MM-dd");
                        string cauTruyVanHoanTac =
                            $@"INSERT INTO DBO.PHIEUNHAP(MAPN,NGAY,MasoDDH,MANV,MAKHO) 
                           VALUES('{txtMaPN.Text}','{formattedDate}','{txtMaDdh.Text}','{txtMaNV.Text}','{txtMaKho.Text}')
                        ";
                        
                        bdsPN.RemoveCurrent();
                        vtHoanTacPN.Push(controCu);
                        undoListPN.Push(cauTruyVanHoanTac);
                        btnHoanTac.Enabled = true;
                        this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                        phieuNhapTableAdapter.Update(this.dS.PhieuNhap);
                        phieuNhapTableAdapter.FillPN(this.dS.PhieuNhap);
                        MessageBox.Show("Xoá phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Xảy ra lỗi khi xoá \n" + ex.Message);
                        phieuNhapTableAdapter.FillPN(this.dS.PhieuNhap);
                        return;
                    }
                }

            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xoá chi tiết phiếu nhập này ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        controCu = bdsCTPN.Position ;
                        string capNhatVT = $"EXEC sp_CapNhatSoLuongVatTu 'EXPORT' , {txtMaVtCTPN.Text} , {seSoLuongCTPN.Value}";
                        string cauTruyVanHoanTac =
                          $@"INSERT INTO DBO.CTPN(MAPN,MAVT,SOLUONG,DONGIA) 
                           VALUES('{txtMaPN.Text}','{txtMaVtCTPN.Text}','{seSoLuongCTPN.EditValue}','{seGia.EditValue}')
                            
                           EXEC sp_CapNhatSoLuongVatTu 'IMPORT' , {txtMaVtCTPN.Text} , {seSoLuongCTPN.Value}
                           ";
                        if (!Program.Connect())
                        {
                            return;
                        }
                        Program.ExceSqlNoneQuery(capNhatVT);
                        undoListCTPN.Push(cauTruyVanHoanTac);
                        vtHoanTacCTPN.Push(controCu);                        bdsCTPN.RemoveCurrent();
                        this.CTPNTableAdapter.Connection.ConnectionString = Program.connstr;
                        CTPNTableAdapter.Update(this.dS.CTPN);
                        CTPNTableAdapter.FillBy(this.dS.CTPN);
                        MessageBox.Show("Xoá chi tiết phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnHoanTac.Enabled = true;
                        this.btnSua.Enabled = true;
                        return;
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Xảy ra lỗi khi xoá \n" + ex.Message);
                        CTPNTableAdapter.FillBy(this.dS.CTPN);
                        return;
                    }
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangSuaCTPN = true;
            vitriContro = bdsCTPN.Position;
            gcPN.Enabled = false;
            gcChiTietPhieuNhap.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLamMoi.Enabled = false;
            btnHoanTac.Enabled = true;
            btnGhi.Enabled = true;
            seSoLuongCTPN.Enabled = true;
            seGia.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}

namespace QuanLyVatTuPhanTan
{
    partial class FormPhieuXuat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label dONGIALabel1;
            System.Windows.Forms.Label sOLUONGLabel1;
            System.Windows.Forms.Label mAVTLabel1;
            System.Windows.Forms.Label hOTENKHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieuXuat));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnMenu = new DevExpress.XtraBars.BarSubItem();
            this.btnCDPhieuXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnCDCTPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcDDH = new DevExpress.XtraEditors.GroupControl();
            this.gcChiTietPhieuXuat = new DevExpress.XtraGrid.GridControl();
            this.bdsChiTietPhieuXuat = new System.Windows.Forms.BindingSource(this.components);
            this.bdsPhieuXuat = new System.Windows.Forms.BindingSource(this.components);
            this.DSP = new QuanLyVatTuPhanTan.DataSet_Phuong();
            this.gvCTDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxPhieuNhap = new System.Windows.Forms.GroupBox();
            this.groupBoxVatTu = new System.Windows.Forms.GroupBox();
            this.btnChonVatTu = new System.Windows.Forms.Button();
            this.txtMaVatTuChiTietPhieuXuat = new DevExpress.XtraEditors.TextEdit();
            this.txtSoLuongChiTietPhieuXuat = new DevExpress.XtraEditors.SpinEdit();
            this.txtDonGiaChiTietPhieuXuat = new DevExpress.XtraEditors.SpinEdit();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.txtMaKho = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.dteNgay = new DevExpress.XtraEditors.DateEdit();
            this.txtMaPhieuXuat = new DevExpress.XtraEditors.TextEdit();
            this.btnChonKhoHang = new System.Windows.Forms.Button();
            this.gcPhieuXuat = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phieuXuatTableAdapter = new QuanLyVatTuPhanTan.DataSet_PhuongTableAdapters.PhieuXuatTableAdapter();
            this.tableAdapterManager = new QuanLyVatTuPhanTan.DataSet_PhuongTableAdapters.TableAdapterManager();
            this.chiTietPhieuXuatTableAdapter = new QuanLyVatTuPhanTan.DataSet_PhuongTableAdapters.CTPXTableAdapter();
            dONGIALabel1 = new System.Windows.Forms.Label();
            sOLUONGLabel1 = new System.Windows.Forms.Label();
            mAVTLabel1 = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            mAPNLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).BeginInit();
            this.gcDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).BeginInit();
            this.groupBoxPhieuNhap.SuspendLayout();
            this.groupBoxVatTu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVatTuChiTietPhieuXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongChiTietPhieuXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGiaChiTietPhieuXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieuXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dONGIALabel1
            // 
            dONGIALabel1.AutoSize = true;
            dONGIALabel1.Location = new System.Drawing.Point(68, 128);
            dONGIALabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dONGIALabel1.Name = "dONGIALabel1";
            dONGIALabel1.Size = new System.Drawing.Size(51, 16);
            dONGIALabel1.TabIndex = 35;
            dONGIALabel1.Text = "Đơn giá";
            // 
            // sOLUONGLabel1
            // 
            sOLUONGLabel1.AutoSize = true;
            sOLUONGLabel1.Location = new System.Drawing.Point(68, 86);
            sOLUONGLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sOLUONGLabel1.Name = "sOLUONGLabel1";
            sOLUONGLabel1.Size = new System.Drawing.Size(58, 16);
            sOLUONGLabel1.TabIndex = 34;
            sOLUONGLabel1.Text = "Số lượng";
            // 
            // mAVTLabel1
            // 
            mAVTLabel1.AutoSize = true;
            mAVTLabel1.Location = new System.Drawing.Point(68, 39);
            mAVTLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            mAVTLabel1.Name = "mAVTLabel1";
            mAVTLabel1.Size = new System.Drawing.Size(67, 16);
            mAVTLabel1.TabIndex = 33;
            mAVTLabel1.Text = "Mã Vật Tư";
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(10, 85);
            hOTENKHLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(100, 16);
            hOTENKHLabel.TabIndex = 30;
            hOTENKHLabel.Text = "Tên Khách Hàng";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(10, 135);
            mANVLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(86, 16);
            mANVLabel.TabIndex = 25;
            mANVLabel.Text = "Mã Nhân Viên";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(287, 39);
            nGAYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(35, 16);
            nGAYLabel.TabIndex = 19;
            nGAYLabel.Text = "Ngày";
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(10, 39);
            mAPNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(89, 16);
            mAPNLabel.TabIndex = 18;
            mAPNLabel.Text = "Mã Phiếu Xuất";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(10, 183);
            mAKHOLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(49, 16);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "Mã Kho";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnGhi,
            this.btnHoanTac,
            this.btnLamMoi,
            this.btnMenu,
            this.btnThoat,
            this.btnCDPhieuXuat,
            this.btnCDCTPX});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHoanTac, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMenu),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Enabled = false;
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Enabled = false;
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 2;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Caption = "Hoàn tác";
            this.btnHoanTac.Enabled = false;
            this.btnHoanTac.Id = 3;
            this.btnHoanTac.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHoanTac.ImageOptions.SvgImage")));
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoanTac_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Enabled = false;
            this.btnLamMoi.Id = 4;
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.LargeImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // btnMenu
            // 
            this.btnMenu.Caption = "Chọn chế độ";
            this.btnMenu.Id = 5;
            this.btnMenu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMenu.ImageOptions.SvgImage")));
            this.btnMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCDPhieuXuat),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCDCTPX)});
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnCDPhieuXuat
            // 
            this.btnCDPhieuXuat.Caption = "Phiếu xuất";
            this.btnCDPhieuXuat.Id = 7;
            this.btnCDPhieuXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCDPhieuXuat.ImageOptions.SvgImage")));
            this.btnCDPhieuXuat.Name = "btnCDPhieuXuat";
            this.btnCDPhieuXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCDPhieuXuat_ItemClick);
            // 
            // btnCDCTPX
            // 
            this.btnCDCTPX.Caption = "Chi tiết phiếu xuất";
            this.btnCDCTPX.Id = 8;
            this.btnCDCTPX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCDCTPX.ImageOptions.SvgImage")));
            this.btnCDCTPX.Name = "btnCDCTPX";
            this.btnCDCTPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCDCTPX_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1256, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1062);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1256, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1032);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1256, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1032);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.Enabled = false;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(197, 20);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(2);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(247, 24);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1256, 63);
            this.panelControl1.TabIndex = 12;
            // 
            // gcDDH
            // 
            this.gcDDH.Controls.Add(this.gcChiTietPhieuXuat);
            this.gcDDH.Controls.Add(this.groupBoxPhieuNhap);
            this.gcDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDDH.Location = new System.Drawing.Point(0, 315);
            this.gcDDH.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gcDDH.Name = "gcDDH";
            this.gcDDH.Size = new System.Drawing.Size(1256, 747);
            this.gcDDH.TabIndex = 39;
            this.gcDDH.Text = "Xuất hàng hóa";
            // 
            // gcChiTietPhieuXuat
            // 
            this.gcChiTietPhieuXuat.DataSource = this.bdsChiTietPhieuXuat;
            this.gcChiTietPhieuXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChiTietPhieuXuat.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gcChiTietPhieuXuat.Enabled = false;
            this.gcChiTietPhieuXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridLevelNode1.RelationName = "Level1";
            this.gcChiTietPhieuXuat.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcChiTietPhieuXuat.Location = new System.Drawing.Point(506, 28);
            this.gcChiTietPhieuXuat.MainView = this.gvCTDDH;
            this.gcChiTietPhieuXuat.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gcChiTietPhieuXuat.MenuManager = this.barManager1;
            this.gcChiTietPhieuXuat.Name = "gcChiTietPhieuXuat";
            this.gcChiTietPhieuXuat.Size = new System.Drawing.Size(748, 717);
            this.gcChiTietPhieuXuat.TabIndex = 1;
            this.gcChiTietPhieuXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTDDH});
            // 
            // bdsChiTietPhieuXuat
            // 
            this.bdsChiTietPhieuXuat.DataMember = "FK_CTPX_PX";
            this.bdsChiTietPhieuXuat.DataSource = this.bdsPhieuXuat;
            // 
            // bdsPhieuXuat
            // 
            this.bdsPhieuXuat.DataMember = "PhieuXuat";
            this.bdsPhieuXuat.DataSource = this.DSP;
            // 
            // DSP
            // 
            this.DSP.DataSetName = "DataSet_Phuong";
            this.DSP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvCTDDH
            // 
            this.gvCTDDH.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gvCTDDH.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gvCTDDH.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gvCTDDH.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvCTDDH.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvCTDDH.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.gvCTDDH.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.gvCTDDH.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gvCTDDH.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvCTDDH.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvCTDDH.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gvCTDDH.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.gvCTDDH.Appearance.Empty.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.gvCTDDH.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvCTDDH.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvCTDDH.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gvCTDDH.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gvCTDDH.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gvCTDDH.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvCTDDH.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvCTDDH.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gvCTDDH.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gvCTDDH.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gvCTDDH.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvCTDDH.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.gvCTDDH.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvCTDDH.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvCTDDH.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvCTDDH.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gvCTDDH.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvCTDDH.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvCTDDH.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gvCTDDH.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gvCTDDH.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gvCTDDH.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvCTDDH.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvCTDDH.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gvCTDDH.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gvCTDDH.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gvCTDDH.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvCTDDH.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvCTDDH.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.gvCTDDH.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.gvCTDDH.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gvCTDDH.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvCTDDH.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvCTDDH.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gvCTDDH.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvCTDDH.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gvCTDDH.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvCTDDH.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.gvCTDDH.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.gvCTDDH.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gvCTDDH.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvCTDDH.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvCTDDH.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.gvCTDDH.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.gvCTDDH.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gvCTDDH.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvCTDDH.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvCTDDH.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(153)))), ((int)(((byte)(195)))));
            this.gvCTDDH.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gvCTDDH.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvCTDDH.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.gvCTDDH.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.gvCTDDH.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvCTDDH.Appearance.OddRow.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.OddRow.Options.UseForeColor = true;
            this.gvCTDDH.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.gvCTDDH.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gvCTDDH.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gvCTDDH.Appearance.Preview.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.Preview.Options.UseFont = true;
            this.gvCTDDH.Appearance.Preview.Options.UseForeColor = true;
            this.gvCTDDH.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.gvCTDDH.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvCTDDH.Appearance.Row.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.Row.Options.UseForeColor = true;
            this.gvCTDDH.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gvCTDDH.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gvCTDDH.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(133)))), ((int)(((byte)(179)))));
            this.gvCTDDH.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gvCTDDH.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvCTDDH.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gvCTDDH.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gvCTDDH.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.gvCTDDH.Appearance.VertLine.Options.UseBackColor = true;
            this.gvCTDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gvCTDDH.DetailHeight = 682;
            this.gvCTDDH.GridControl = this.gcChiTietPhieuXuat;
            this.gvCTDDH.Name = "gvCTDDH";
            this.gvCTDDH.OptionsBehavior.Editable = false;
            this.gvCTDDH.OptionsView.EnableAppearanceEvenRow = true;
            this.gvCTDDH.OptionsView.EnableAppearanceOddRow = true;
            this.gvCTDDH.OptionsView.ShowGroupPanel = false;
            this.gvCTDDH.OptionsView.ShowViewCaption = true;
            this.gvCTDDH.PaintStyleName = "MixedXP";
            this.gvCTDDH.ViewCaption = "Chi Tiết Phiếu Xuất";
            // 
            // colMAPX1
            // 
            this.colMAPX1.Caption = "Mã Phiếu Xuất";
            this.colMAPX1.FieldName = "MAPX";
            this.colMAPX1.MinWidth = 22;
            this.colMAPX1.Name = "colMAPX1";
            this.colMAPX1.Visible = true;
            this.colMAPX1.VisibleIndex = 0;
            this.colMAPX1.Width = 82;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã Vật Tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 22;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 82;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Sô Lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 22;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 82;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn Giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 22;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 82;
            // 
            // groupBoxPhieuNhap
            // 
            this.groupBoxPhieuNhap.Controls.Add(this.groupBoxVatTu);
            this.groupBoxPhieuNhap.Controls.Add(this.separatorControl1);
            this.groupBoxPhieuNhap.Controls.Add(this.txtMaKho);
            this.groupBoxPhieuNhap.Controls.Add(this.txtMaNhanVien);
            this.groupBoxPhieuNhap.Controls.Add(hOTENKHLabel);
            this.groupBoxPhieuNhap.Controls.Add(this.txtTenKhachHang);
            this.groupBoxPhieuNhap.Controls.Add(this.dteNgay);
            this.groupBoxPhieuNhap.Controls.Add(this.txtMaPhieuXuat);
            this.groupBoxPhieuNhap.Controls.Add(mANVLabel);
            this.groupBoxPhieuNhap.Controls.Add(this.btnChonKhoHang);
            this.groupBoxPhieuNhap.Controls.Add(nGAYLabel);
            this.groupBoxPhieuNhap.Controls.Add(mAPNLabel);
            this.groupBoxPhieuNhap.Controls.Add(mAKHOLabel);
            this.groupBoxPhieuNhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxPhieuNhap.Location = new System.Drawing.Point(2, 28);
            this.groupBoxPhieuNhap.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBoxPhieuNhap.Name = "groupBoxPhieuNhap";
            this.groupBoxPhieuNhap.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBoxPhieuNhap.Size = new System.Drawing.Size(504, 717);
            this.groupBoxPhieuNhap.TabIndex = 0;
            this.groupBoxPhieuNhap.TabStop = false;
            this.groupBoxPhieuNhap.Text = "Thông Tin";
            // 
            // groupBoxVatTu
            // 
            this.groupBoxVatTu.Controls.Add(this.btnChonVatTu);
            this.groupBoxVatTu.Controls.Add(this.txtMaVatTuChiTietPhieuXuat);
            this.groupBoxVatTu.Controls.Add(mAVTLabel1);
            this.groupBoxVatTu.Controls.Add(dONGIALabel1);
            this.groupBoxVatTu.Controls.Add(this.txtSoLuongChiTietPhieuXuat);
            this.groupBoxVatTu.Controls.Add(this.txtDonGiaChiTietPhieuXuat);
            this.groupBoxVatTu.Controls.Add(sOLUONGLabel1);
            this.groupBoxVatTu.Location = new System.Drawing.Point(-57, 244);
            this.groupBoxVatTu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxVatTu.Name = "groupBoxVatTu";
            this.groupBoxVatTu.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxVatTu.Size = new System.Drawing.Size(561, 554);
            this.groupBoxVatTu.TabIndex = 39;
            this.groupBoxVatTu.TabStop = false;
            this.groupBoxVatTu.Text = "fawef";
            // 
            // btnChonVatTu
            // 
            this.btnChonVatTu.Enabled = false;
            this.btnChonVatTu.Location = new System.Drawing.Point(328, 33);
            this.btnChonVatTu.Margin = new System.Windows.Forms.Padding(2);
            this.btnChonVatTu.Name = "btnChonVatTu";
            this.btnChonVatTu.Size = new System.Drawing.Size(184, 46);
            this.btnChonVatTu.TabIndex = 37;
            this.btnChonVatTu.Text = "Chọn Vật Tư";
            this.btnChonVatTu.UseVisualStyleBackColor = true;
            this.btnChonVatTu.Click += new System.EventHandler(this.btnChonVatTu_Click);
            // 
            // txtMaVatTuChiTietPhieuXuat
            // 
            this.txtMaVatTuChiTietPhieuXuat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsChiTietPhieuXuat, "MAVT", true));
            this.txtMaVatTuChiTietPhieuXuat.Enabled = false;
            this.txtMaVatTuChiTietPhieuXuat.Location = new System.Drawing.Point(189, 36);
            this.txtMaVatTuChiTietPhieuXuat.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaVatTuChiTietPhieuXuat.MenuManager = this.barManager1;
            this.txtMaVatTuChiTietPhieuXuat.Name = "txtMaVatTuChiTietPhieuXuat";
            this.txtMaVatTuChiTietPhieuXuat.Size = new System.Drawing.Size(110, 22);
            this.txtMaVatTuChiTietPhieuXuat.TabIndex = 34;
            // 
            // txtSoLuongChiTietPhieuXuat
            // 
            this.txtSoLuongChiTietPhieuXuat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsChiTietPhieuXuat, "SOLUONG", true));
            this.txtSoLuongChiTietPhieuXuat.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoLuongChiTietPhieuXuat.Enabled = false;
            this.txtSoLuongChiTietPhieuXuat.Location = new System.Drawing.Point(189, 84);
            this.txtSoLuongChiTietPhieuXuat.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoLuongChiTietPhieuXuat.MenuManager = this.barManager1;
            this.txtSoLuongChiTietPhieuXuat.Name = "txtSoLuongChiTietPhieuXuat";
            this.txtSoLuongChiTietPhieuXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoLuongChiTietPhieuXuat.Size = new System.Drawing.Size(110, 24);
            this.txtSoLuongChiTietPhieuXuat.TabIndex = 35;
            // 
            // txtDonGiaChiTietPhieuXuat
            // 
            this.txtDonGiaChiTietPhieuXuat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsChiTietPhieuXuat, "DONGIA", true));
            this.txtDonGiaChiTietPhieuXuat.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtDonGiaChiTietPhieuXuat.Enabled = false;
            this.txtDonGiaChiTietPhieuXuat.Location = new System.Drawing.Point(189, 127);
            this.txtDonGiaChiTietPhieuXuat.Margin = new System.Windows.Forms.Padding(2);
            this.txtDonGiaChiTietPhieuXuat.MenuManager = this.barManager1;
            this.txtDonGiaChiTietPhieuXuat.Name = "txtDonGiaChiTietPhieuXuat";
            this.txtDonGiaChiTietPhieuXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDonGiaChiTietPhieuXuat.Size = new System.Drawing.Size(110, 24);
            this.txtDonGiaChiTietPhieuXuat.TabIndex = 36;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(-18, 225);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(2);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.separatorControl1.Size = new System.Drawing.Size(536, 25);
            this.separatorControl1.TabIndex = 38;
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuXuat, "MAKHO", true));
            this.txtMaKho.Enabled = false;
            this.txtMaKho.Location = new System.Drawing.Point(132, 182);
            this.txtMaKho.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKho.MenuManager = this.barManager1;
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(110, 22);
            this.txtMaKho.TabIndex = 33;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuXuat, "MANV", true));
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Location = new System.Drawing.Point(132, 134);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNhanVien.MenuManager = this.barManager1;
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(110, 22);
            this.txtMaNhanVien.TabIndex = 32;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuXuat, "HOTENKH", true));
            this.txtTenKhachHang.Enabled = false;
            this.txtTenKhachHang.Location = new System.Drawing.Point(132, 84);
            this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKhachHang.MenuManager = this.barManager1;
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(164, 22);
            this.txtTenKhachHang.TabIndex = 31;
            // 
            // dteNgay
            // 
            this.dteNgay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuXuat, "NGAY", true));
            this.dteNgay.EditValue = null;
            this.dteNgay.Enabled = false;
            this.dteNgay.Location = new System.Drawing.Point(328, 34);
            this.dteNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dteNgay.MenuManager = this.barManager1;
            this.dteNgay.Name = "dteNgay";
            this.dteNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgay.Size = new System.Drawing.Size(139, 22);
            this.dteNgay.TabIndex = 30;
            // 
            // txtMaPhieuXuat
            // 
            this.txtMaPhieuXuat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuXuat, "MAPX", true));
            this.txtMaPhieuXuat.Enabled = false;
            this.txtMaPhieuXuat.Location = new System.Drawing.Point(132, 36);
            this.txtMaPhieuXuat.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPhieuXuat.MenuManager = this.barManager1;
            this.txtMaPhieuXuat.Name = "txtMaPhieuXuat";
            this.txtMaPhieuXuat.Size = new System.Drawing.Size(110, 22);
            this.txtMaPhieuXuat.TabIndex = 29;
            // 
            // btnChonKhoHang
            // 
            this.btnChonKhoHang.Enabled = false;
            this.btnChonKhoHang.Location = new System.Drawing.Point(271, 159);
            this.btnChonKhoHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChonKhoHang.Name = "btnChonKhoHang";
            this.btnChonKhoHang.Size = new System.Drawing.Size(184, 48);
            this.btnChonKhoHang.TabIndex = 22;
            this.btnChonKhoHang.Text = "Chọn Kho Hàng";
            this.btnChonKhoHang.UseVisualStyleBackColor = true;
            this.btnChonKhoHang.Click += new System.EventHandler(this.btnChonKhoHang_Click);
            // 
            // gcPhieuXuat
            // 
            this.gcPhieuXuat.DataSource = this.bdsPhieuXuat;
            this.gcPhieuXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPhieuXuat.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcPhieuXuat.Enabled = false;
            this.gcPhieuXuat.Location = new System.Drawing.Point(0, 93);
            this.gcPhieuXuat.MainView = this.gridView1;
            this.gcPhieuXuat.Margin = new System.Windows.Forms.Padding(2);
            this.gcPhieuXuat.MenuManager = this.barManager1;
            this.gcPhieuXuat.Name = "gcPhieuXuat";
            this.gcPhieuXuat.Size = new System.Drawing.Size(1256, 222);
            this.gcPhieuXuat.TabIndex = 38;
            this.gcPhieuXuat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gridView1.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.Empty.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.gridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Appearance.EvenRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gridView1.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gridView1.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.gridView1.Appearance.FixedLine.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gridView1.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gridView1.Appearance.GroupButton.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupButton.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.gridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.gridView1.Appearance.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gridView1.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gridView1.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.gridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gridView1.Appearance.GroupRow.Options.UseBackColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.GroupRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.gridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(158)))));
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gridView1.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(153)))), ((int)(((byte)(195)))));
            this.gridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gridView1.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gridView1.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.gridView1.Appearance.HorzLine.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.gridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.OddRow.Options.UseBackColor = true;
            this.gridView1.Appearance.OddRow.Options.UseForeColor = true;
            this.gridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(248)))));
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Verdana", 7.5F);
            this.gridView1.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(87)))), ((int)(((byte)(138)))));
            this.gridView1.Appearance.Preview.Options.UseBackColor = true;
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Preview.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White;
            this.gridView1.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(133)))), ((int)(((byte)(179)))));
            this.gridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(235)))), ((int)(((byte)(220)))));
            this.gridView1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White;
            this.gridView1.Appearance.TopNewRow.Options.UseBackColor = true;
            this.gridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(178)))), ((int)(((byte)(185)))));
            this.gridView1.Appearance.VertLine.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY,
            this.colHOTENKH,
            this.colHOTEN,
            this.colMAKHO});
            this.gridView1.GridControl = this.gcPhieuXuat;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.PaintStyleName = "MixedXP";
            // 
            // colMAPX
            // 
            this.colMAPX.Caption = "Mã Phiếu Xuất";
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.MinWidth = 22;
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.OptionsColumn.AllowEdit = false;
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
            this.colMAPX.Width = 82;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày lập";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 22;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.OptionsColumn.AllowEdit = false;
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 82;
            // 
            // colHOTENKH
            // 
            this.colHOTENKH.Caption = "Họ Tên Khách Hàng";
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.MinWidth = 22;
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.OptionsColumn.AllowEdit = false;
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 2;
            this.colHOTENKH.Width = 82;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Caption = "Người lập phiếu";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 22;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.OptionsColumn.AllowEdit = false;
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 3;
            this.colHOTEN.Width = 82;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã Kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 22;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 82;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.phieuXuatTableAdapter;
            this.tableAdapterManager.UpdateOrder = QuanLyVatTuPhanTan.DataSet_PhuongTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // chiTietPhieuXuatTableAdapter
            // 
            this.chiTietPhieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // FormPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 1062);
            this.Controls.Add(this.gcDDH);
            this.Controls.Add(this.gcPhieuXuat);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPhieuXuat";
            this.Text = "Phiếu xuất";
            this.Load += new System.EventHandler(this.FormPhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).EndInit();
            this.gcDDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).EndInit();
            this.groupBoxPhieuNhap.ResumeLayout(false);
            this.groupBoxPhieuNhap.PerformLayout();
            this.groupBoxVatTu.ResumeLayout(false);
            this.groupBoxVatTu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVatTuChiTietPhieuXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongChiTietPhieuXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGiaChiTietPhieuXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPhieuXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHoanTac;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarSubItem btnMenu;
        private DevExpress.XtraBars.BarButtonItem btnCDPhieuXuat;
        private DevExpress.XtraBars.BarButtonItem btnCDCTPX;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl gcDDH;
        private DevExpress.XtraGrid.GridControl gcChiTietPhieuXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.GroupBox groupBoxPhieuNhap;
        private System.Windows.Forms.Button btnChonVatTu;
        private DevExpress.XtraEditors.SpinEdit txtDonGiaChiTietPhieuXuat;
        private DevExpress.XtraEditors.SpinEdit txtSoLuongChiTietPhieuXuat;
        private DevExpress.XtraEditors.TextEdit txtMaVatTuChiTietPhieuXuat;
        private DevExpress.XtraEditors.TextEdit txtMaKho;
        private DevExpress.XtraEditors.TextEdit txtMaNhanVien;
        private DevExpress.XtraEditors.TextEdit txtTenKhachHang;
        private DevExpress.XtraEditors.DateEdit dteNgay;
        private DevExpress.XtraEditors.TextEdit txtMaPhieuXuat;
        private System.Windows.Forms.Button btnChonKhoHang;
        private DevExpress.XtraGrid.GridControl gcPhieuXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DataSet_Phuong DSP;
        private System.Windows.Forms.BindingSource bdsPhieuXuat;
        private DataSet_PhuongTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private DataSet_PhuongTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsChiTietPhieuXuat;
        private DataSet_PhuongTableAdapters.CTPXTableAdapter chiTietPhieuXuatTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxVatTu;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
    }
}
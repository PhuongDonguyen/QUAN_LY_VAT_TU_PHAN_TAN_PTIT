namespace QuanLyVatTuPhanTan
{
    partial class FormPhieuNhap
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
            System.Windows.Forms.Label maPN;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label masoDDHLabel2;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieuNhap));
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleDateOccuring formatConditionRuleDateOccuring1 = new DevExpress.XtraEditors.FormatConditionRuleDateOccuring();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barMan = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnChonCheDo = new DevExpress.XtraBars.BarSubItem();
            this.btnPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnCTPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.bar7 = new DevExpress.XtraBars.Bar();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dS = new QuanLyVatTuPhanTan.DS();
            this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QuanLyVatTuPhanTan.DSTableAdapters.PhieuNhapTableAdapter();
            this.gcPN = new DevExpress.XtraGrid.GridControl();
            this.gvPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcThongTinPN = new DevExpress.XtraEditors.GroupControl();
            this.gcChiTietPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.gvCTPN = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbForm = new System.Windows.Forms.GroupBox();
            this.gbCTPN = new System.Windows.Forms.GroupBox();
            this.seGia = new DevExpress.XtraEditors.SpinEdit();
            this.seSoLuongCTPN = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaVtCTPN = new DevExpress.XtraEditors.TextEdit();
            this.txtMaDdh = new DevExpress.XtraEditors.TextEdit();
            this.gbPN = new System.Windows.Forms.GroupBox();
            this.btnChonDonHang = new System.Windows.Forms.Button();
            this.txtMaKho = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.dteNgayLap = new DevExpress.XtraEditors.DateEdit();
            this.txtMaPN = new DevExpress.XtraEditors.TextEdit();
            this.bdsDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.tableAdapterManager = new QuanLyVatTuPhanTan.DSTableAdapters.TableAdapterManager();
            this.CTPNTableAdapter = new QuanLyVatTuPhanTan.DSTableAdapters.CTPNTableAdapter();
            maPN = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            masoDDHLabel2 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTinPN)).BeginInit();
            this.gcThongTinPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPN)).BeginInit();
            this.gbForm.SuspendLayout();
            this.gbCTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSoLuongCTPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVtCTPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDdh.Properties)).BeginInit();
            this.gbPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayLap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // maPN
            // 
            maPN.AutoSize = true;
            maPN.Location = new System.Drawing.Point(7, 38);
            maPN.Name = "maPN";
            maPN.Size = new System.Drawing.Size(101, 16);
            maPN.TabIndex = 0;
            maPN.Text = "Mã phiếu nhập";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(289, 38);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(62, 16);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày lập";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(6, 83);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(93, 16);
            mANVLabel.TabIndex = 4;
            mANVLabel.Text = "Mã nhân viên";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(7, 129);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(53, 16);
            mAKHOLabel.TabIndex = 6;
            mAKHOLabel.Text = "Mã kho";
            // 
            // masoDDHLabel2
            // 
            masoDDHLabel2.AutoSize = true;
            masoDDHLabel2.Location = new System.Drawing.Point(6, 42);
            masoDDHLabel2.Name = "masoDDHLabel2";
            masoDDHLabel2.Size = new System.Drawing.Size(116, 16);
            masoDDHLabel2.TabIndex = 23;
            masoDDHLabel2.Text = "Mã đơn đặt hàng";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(13, 97);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(71, 16);
            mAVTLabel.TabIndex = 24;
            mAVTLabel.Text = "Mã vật tư";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(289, 42);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(63, 16);
            sOLUONGLabel.TabIndex = 25;
            sOLUONGLabel.Text = "Số lượng";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(289, 97);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(26, 16);
            dONGIALabel.TabIndex = 26;
            dONGIALabel.Text = "Giá";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barMan});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnThem,
            this.btnXoa,
            this.btnHoanTac,
            this.barButtonItem6,
            this.btnChonCheDo,
            this.btnPN,
            this.btnCTPN,
            this.btnThoat,
            this.btnGhi,
            this.btnLamMoi,
            this.btnSua});
            this.barManager1.MainMenu = this.barMan;
            this.barManager1.MaxItemId = 14;
            // 
            // barMan
            // 
            this.barMan.BarName = "Main menu";
            this.barMan.DockCol = 0;
            this.barMan.DockRow = 0;
            this.barMan.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMan.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnLamMoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHoanTac, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnChonCheDo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barMan.OptionsBar.MultiLine = true;
            this.barMan.OptionsBar.UseWholeRow = true;
            this.barMan.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xoá";
            this.btnXoa.Id = 2;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Enabled = false;
            this.btnSua.Id = 13;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Id = 11;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Id = 12;
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.LargeImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Caption = "Hoàn tác";
            this.btnHoanTac.Id = 3;
            this.btnHoanTac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.Image")));
            this.btnHoanTac.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.LargeImage")));
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoanTac_ItemClick);
            // 
            // btnChonCheDo
            // 
            this.btnChonCheDo.Caption = "Chọn chế độ";
            this.btnChonCheDo.Id = 6;
            this.btnChonCheDo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChonCheDo.ImageOptions.Image")));
            this.btnChonCheDo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChonCheDo.ImageOptions.LargeImage")));
            this.btnChonCheDo.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCTPN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.btnChonCheDo.Name = "btnChonCheDo";
            // 
            // btnPN
            // 
            this.btnPN.Caption = "Phiếu nhập";
            this.btnPN.Id = 7;
            this.btnPN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPN.ImageOptions.Image")));
            this.btnPN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPN.ImageOptions.LargeImage")));
            this.btnPN.Name = "btnPN";
            this.btnPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPN_ItemClick);
            // 
            // btnCTPN
            // 
            this.btnCTPN.Caption = "Chi tiết phiếu nhập";
            this.btnCTPN.Id = 8;
            this.btnCTPN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCTPN.ImageOptions.Image")));
            this.btnCTPN.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCTPN.ImageOptions.LargeImage")));
            this.btnCTPN.Name = "btnCTPN";
            this.btnCTPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCTPN_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 9;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1308, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 796);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1308, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 766);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1308, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 766);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Chọn chế độ";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // bar5
            // 
            this.bar5.BarName = "Main menu";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.OptionsBar.MultiLine = true;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Main menu";
            // 
            // bar6
            // 
            this.bar6.BarName = "Main menu";
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar6.OptionsBar.MultiLine = true;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Main menu";
            // 
            // bar7
            // 
            this.bar7.BarName = "Main menu";
            this.bar7.DockCol = 0;
            this.bar7.DockRow = 0;
            this.bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar7.OptionsBar.MultiLine = true;
            this.bar7.OptionsBar.UseWholeRow = true;
            this.bar7.Text = "Main menu";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1308, 63);
            this.panelControl1.TabIndex = 11;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.Enabled = false;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(256, 19);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(247, 24);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi Nhánh";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPN
            // 
            this.bdsPN.DataMember = "PhieuNhap";
            this.bdsPN.DataSource = this.dS;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // gcPN
            // 
            this.gcPN.DataSource = this.bdsPN;
            this.gcPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPN.Enabled = false;
            this.gcPN.Location = new System.Drawing.Point(0, 93);
            this.gcPN.MainView = this.gvPN;
            this.gcPN.MenuManager = this.barManager1;
            this.gcPN.Name = "gcPN";
            this.gcPN.Size = new System.Drawing.Size(1308, 220);
            this.gcPN.TabIndex = 16;
            this.gcPN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPN});
            this.gcPN.Click += new System.EventHandler(this.gcPN_Click);
            // 
            // gvPN
            // 
            this.gvPN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY,
            this.colMasoDDH,
            this.colMANV,
            this.colTENNV,
            this.colMAKHO,
            this.colTENKHO});
            gridFormatRule1.Name = "Format0";
            gridFormatRule1.Rule = formatConditionRuleDateOccuring1;
            gridFormatRule1.Tag = true;
            this.gvPN.FormatRules.Add(gridFormatRule1);
            this.gvPN.GridControl = this.gcPN;
            this.gvPN.Name = "gvPN";
            this.gvPN.OptionsBehavior.Editable = false;
            // 
            // colMAPN
            // 
            this.colMAPN.Caption = "Mã phiếu nhập";
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.MinWidth = 25;
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            this.colMAPN.Width = 94;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Ngày";
            this.colNGAY.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.colNGAY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 94;
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Mã đơn đặt hàng";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 25;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 2;
            this.colMasoDDH.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 94;
            // 
            // colTENNV
            // 
            this.colTENNV.Caption = "Tên nhân viên";
            this.colTENNV.FieldName = "TENNV";
            this.colTENNV.MinWidth = 25;
            this.colTENNV.Name = "colTENNV";
            this.colTENNV.Visible = true;
            this.colTENNV.VisibleIndex = 4;
            this.colTENNV.Width = 94;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Mã kho";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 25;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 5;
            this.colMAKHO.Width = 94;
            // 
            // colTENKHO
            // 
            this.colTENKHO.Caption = "Tên kho";
            this.colTENKHO.FieldName = "TENKHO";
            this.colTENKHO.MinWidth = 25;
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.Visible = true;
            this.colTENKHO.VisibleIndex = 6;
            this.colTENKHO.Width = 94;
            // 
            // gcThongTinPN
            // 
            this.gcThongTinPN.Controls.Add(this.gcChiTietPhieuNhap);
            this.gcThongTinPN.Controls.Add(this.gbForm);
            this.gcThongTinPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcThongTinPN.Location = new System.Drawing.Point(0, 313);
            this.gcThongTinPN.Name = "gcThongTinPN";
            this.gcThongTinPN.Size = new System.Drawing.Size(1308, 483);
            this.gcThongTinPN.TabIndex = 18;
            this.gcThongTinPN.Text = "Thông tin";
            // 
            // gcChiTietPhieuNhap
            // 
            this.gcChiTietPhieuNhap.DataSource = this.bdsCTPN;
            this.gcChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChiTietPhieuNhap.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gcChiTietPhieuNhap.Enabled = false;
            this.gcChiTietPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcChiTietPhieuNhap.Location = new System.Drawing.Point(586, 28);
            this.gcChiTietPhieuNhap.MainView = this.gvCTPN;
            this.gcChiTietPhieuNhap.Margin = new System.Windows.Forms.Padding(6);
            this.gcChiTietPhieuNhap.MenuManager = this.barManager1;
            this.gcChiTietPhieuNhap.Name = "gcChiTietPhieuNhap";
            this.gcChiTietPhieuNhap.Size = new System.Drawing.Size(720, 453);
            this.gcChiTietPhieuNhap.TabIndex = 2;
            this.gcChiTietPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTPN});
            this.gcChiTietPhieuNhap.Click += new System.EventHandler(this.gcChiTietPhieuNhap_Click);
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_PhieuNhap";
            this.bdsCTPN.DataSource = this.bdsPN;
            // 
            // gvCTPN
            // 
            this.gvCTPN.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN1,
            this.colMAVT,
            this.colTENVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gvCTPN.DetailHeight = 682;
            this.gvCTPN.GridControl = this.gcChiTietPhieuNhap;
            this.gvCTPN.Name = "gvCTPN";
            this.gvCTPN.OptionsBehavior.Editable = false;
            this.gvCTPN.OptionsView.ShowGroupPanel = false;
            this.gvCTPN.OptionsView.ShowViewCaption = true;
            this.gvCTPN.ViewCaption = "Chi Tiết Phiếu Nhập";
            // 
            // colMAPN1
            // 
            this.colMAPN1.Caption = "Mã phiếu nhập";
            this.colMAPN1.FieldName = "MAPN";
            this.colMAPN1.MinWidth = 25;
            this.colMAPN1.Name = "colMAPN1";
            this.colMAPN1.Visible = true;
            this.colMAPN1.VisibleIndex = 0;
            this.colMAPN1.Width = 94;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Mã vật tư";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 94;
            // 
            // colTENVT
            // 
            this.colTENVT.Caption = "Tên vật tư";
            this.colTENVT.FieldName = "TENVT";
            this.colTENVT.MinWidth = 25;
            this.colTENVT.Name = "colTENVT";
            this.colTENVT.Visible = true;
            this.colTENVT.VisibleIndex = 2;
            this.colTENVT.Width = 94;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Số lượng";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 3;
            this.colSOLUONG.Width = 94;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Đơn giá";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 4;
            this.colDONGIA.Width = 94;
            // 
            // gbForm
            // 
            this.gbForm.Controls.Add(this.gbCTPN);
            this.gbForm.Controls.Add(this.gbPN);
            this.gbForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbForm.Location = new System.Drawing.Point(2, 28);
            this.gbForm.Name = "gbForm";
            this.gbForm.Size = new System.Drawing.Size(584, 453);
            this.gbForm.TabIndex = 0;
            this.gbForm.TabStop = false;
            // 
            // gbCTPN
            // 
            this.gbCTPN.Controls.Add(dONGIALabel);
            this.gbCTPN.Controls.Add(this.seGia);
            this.gbCTPN.Controls.Add(sOLUONGLabel);
            this.gbCTPN.Controls.Add(this.seSoLuongCTPN);
            this.gbCTPN.Controls.Add(mAVTLabel);
            this.gbCTPN.Controls.Add(this.txtMaVtCTPN);
            this.gbCTPN.Controls.Add(masoDDHLabel2);
            this.gbCTPN.Controls.Add(this.txtMaDdh);
            this.gbCTPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCTPN.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gbCTPN.Location = new System.Drawing.Point(3, 240);
            this.gbCTPN.Name = "gbCTPN";
            this.gbCTPN.Size = new System.Drawing.Size(578, 210);
            this.gbCTPN.TabIndex = 1;
            this.gbCTPN.TabStop = false;
            this.gbCTPN.Text = "Chi tiết phiếu nhập";
            // 
            // seGia
            // 
            this.seGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPN, "DONGIA", true));
            this.seGia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seGia.Enabled = false;
            this.seGia.Location = new System.Drawing.Point(357, 97);
            this.seGia.MenuManager = this.barManager1;
            this.seGia.Name = "seGia";
            this.seGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seGia.Properties.DisplayFormat.FormatString = "n0";
            this.seGia.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seGia.Properties.EditFormat.FormatString = "n0";
            this.seGia.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seGia.Properties.IsFloatValue = false;
            this.seGia.Properties.MaskSettings.Set("mask", "N00");
            this.seGia.Size = new System.Drawing.Size(125, 24);
            this.seGia.TabIndex = 27;
            // 
            // seSoLuongCTPN
            // 
            this.seSoLuongCTPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPN, "SOLUONG", true));
            this.seSoLuongCTPN.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seSoLuongCTPN.Enabled = false;
            this.seSoLuongCTPN.Location = new System.Drawing.Point(357, 38);
            this.seSoLuongCTPN.MenuManager = this.barManager1;
            this.seSoLuongCTPN.Name = "seSoLuongCTPN";
            this.seSoLuongCTPN.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seSoLuongCTPN.Properties.DisplayFormat.FormatString = "n0";
            this.seSoLuongCTPN.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seSoLuongCTPN.Properties.EditFormat.FormatString = "n0";
            this.seSoLuongCTPN.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seSoLuongCTPN.Properties.IsFloatValue = false;
            this.seSoLuongCTPN.Properties.MaskSettings.Set("mask", "N00");
            this.seSoLuongCTPN.Size = new System.Drawing.Size(125, 24);
            this.seSoLuongCTPN.TabIndex = 26;
            // 
            // txtMaVtCTPN
            // 
            this.txtMaVtCTPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPN, "MAVT", true));
            this.txtMaVtCTPN.Enabled = false;
            this.txtMaVtCTPN.Location = new System.Drawing.Point(134, 97);
            this.txtMaVtCTPN.MenuManager = this.barManager1;
            this.txtMaVtCTPN.Name = "txtMaVtCTPN";
            this.txtMaVtCTPN.Size = new System.Drawing.Size(125, 22);
            this.txtMaVtCTPN.TabIndex = 25;
            // 
            // txtMaDdh
            // 
            this.txtMaDdh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MasoDDH", true));
            this.txtMaDdh.Enabled = false;
            this.txtMaDdh.Location = new System.Drawing.Point(134, 36);
            this.txtMaDdh.MenuManager = this.barManager1;
            this.txtMaDdh.Name = "txtMaDdh";
            this.txtMaDdh.Size = new System.Drawing.Size(125, 22);
            this.txtMaDdh.TabIndex = 24;
            this.txtMaDdh.EditValueChanged += new System.EventHandler(this.masoDDHTextEdit2_EditValueChanged);
            // 
            // gbPN
            // 
            this.gbPN.Controls.Add(this.btnChonDonHang);
            this.gbPN.Controls.Add(mAKHOLabel);
            this.gbPN.Controls.Add(this.txtMaKho);
            this.gbPN.Controls.Add(mANVLabel);
            this.gbPN.Controls.Add(this.txtMaNV);
            this.gbPN.Controls.Add(nGAYLabel);
            this.gbPN.Controls.Add(this.dteNgayLap);
            this.gbPN.Controls.Add(maPN);
            this.gbPN.Controls.Add(this.txtMaPN);
            this.gbPN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPN.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.gbPN.Location = new System.Drawing.Point(3, 19);
            this.gbPN.Name = "gbPN";
            this.gbPN.Size = new System.Drawing.Size(578, 221);
            this.gbPN.TabIndex = 0;
            this.gbPN.TabStop = false;
            this.gbPN.Text = "Phiếu Nhập";
            // 
            // btnChonDonHang
            // 
            this.btnChonDonHang.Enabled = false;
            this.btnChonDonHang.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnChonDonHang.Location = new System.Drawing.Point(287, 99);
            this.btnChonDonHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnChonDonHang.Name = "btnChonDonHang";
            this.btnChonDonHang.Size = new System.Drawing.Size(211, 49);
            this.btnChonDonHang.TabIndex = 23;
            this.btnChonDonHang.Text = "Chọn đơn hàng";
            this.btnChonDonHang.UseVisualStyleBackColor = true;
            this.btnChonDonHang.Click += new System.EventHandler(this.btnChonDonHang_Click);
            // 
            // txtMaKho
            // 
            this.txtMaKho.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MAKHO", true));
            this.txtMaKho.Enabled = false;
            this.txtMaKho.Location = new System.Drawing.Point(134, 126);
            this.txtMaKho.MenuManager = this.barManager1;
            this.txtMaKho.Name = "txtMaKho";
            this.txtMaKho.Size = new System.Drawing.Size(125, 22);
            this.txtMaKho.TabIndex = 7;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MANV", true));
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(134, 80);
            this.txtMaNV.MenuManager = this.barManager1;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(125, 22);
            this.txtMaNV.TabIndex = 5;
            // 
            // dteNgayLap
            // 
            this.dteNgayLap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "NGAY", true));
            this.dteNgayLap.EditValue = null;
            this.dteNgayLap.Enabled = false;
            this.dteNgayLap.Location = new System.Drawing.Point(357, 32);
            this.dteNgayLap.MenuManager = this.barManager1;
            this.dteNgayLap.Name = "dteNgayLap";
            this.dteNgayLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgayLap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteNgayLap.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.dteNgayLap.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteNgayLap.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.dteNgayLap.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteNgayLap.Size = new System.Drawing.Size(141, 22);
            this.dteNgayLap.TabIndex = 3;
            // 
            // txtMaPN
            // 
            this.txtMaPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MAPN", true));
            this.txtMaPN.Enabled = false;
            this.txtMaPN.Location = new System.Drawing.Point(134, 35);
            this.txtMaPN.MenuManager = this.barManager1;
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(125, 22);
            this.txtMaPN.TabIndex = 1;
            // 
            // bdsDatHang
            // 
            this.bdsDatHang.DataMember = "DatHang";
            this.bdsDatHang.DataSource = this.dS;
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl2.Location = new System.Drawing.Point(0, 30);
            this.barDockControl2.Manager = null;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.barDockControl2.Size = new System.Drawing.Size(1308, 0);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 30);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControl1.Size = new System.Drawing.Size(1308, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl3.Location = new System.Drawing.Point(0, 30);
            this.barDockControl3.Manager = null;
            this.barDockControl3.Size = new System.Drawing.Size(1308, 0);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLyVatTuPhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // CTPNTableAdapter
            // 
            this.CTPNTableAdapter.ClearBeforeFill = true;
            // 
            // FormPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 796);
            this.Controls.Add(this.gcThongTinPN);
            this.Controls.Add(this.gcPN);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormPhieuNhap";
            this.Text = "Phiếu Nhập";
            this.Load += new System.EventHandler(this.FormPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTinPN)).EndInit();
            this.gcThongTinPN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTPN)).EndInit();
            this.gbForm.ResumeLayout(false);
            this.gbCTPN.ResumeLayout(false);
            this.gbCTPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSoLuongCTPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVtCTPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaDdh.Properties)).EndInit();
            this.gbPN.ResumeLayout(false);
            this.gbPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayLap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barMan;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.Bar bar7;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsPN;
        private DS dS;
        private DSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private DevExpress.XtraGrid.GridControl gcPN;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnHoanTac;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraEditors.GroupControl gcThongTinPN;
        private System.Windows.Forms.GroupBox gbForm;
        private System.Windows.Forms.GroupBox gbPN;
        private System.Windows.Forms.GroupBox gbCTPN;
        private DevExpress.XtraEditors.TextEdit txtMaKho;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.DateEdit dteNgayLap;
        private DevExpress.XtraEditors.TextEdit txtMaPN;
        private System.Windows.Forms.Button btnChonDonHang;
        private System.Windows.Forms.BindingSource bdsDatHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTENNV;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraGrid.GridControl gcChiTietPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTPN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DevExpress.XtraGrid.Columns.GridColumn colTENVT;
        private DevExpress.XtraBars.BarSubItem btnChonCheDo;
        private DevExpress.XtraBars.BarButtonItem btnPN;
        private DevExpress.XtraBars.BarButtonItem btnCTPN;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraEditors.TextEdit txtMaDdh;
        private DSTableAdapters.CTPNTableAdapter CTPNTableAdapter;
        private DevExpress.XtraEditors.SpinEdit seSoLuongCTPN;
        private DevExpress.XtraEditors.TextEdit txtMaVtCTPN;
        private DevExpress.XtraEditors.SpinEdit seGia;
        private DevExpress.XtraBars.BarButtonItem btnSua;
    }
}
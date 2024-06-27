namespace QuanLyVatTuPhanTan.ReportForm
{
    partial class ReportHoatDongNhanVien
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportHoatDongNhanVien));
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.GroupHeader2 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.table2 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.table3 = new DevExpress.XtraReports.UI.XRTable();
            this.tableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.tableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupFooterBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.GroupFooter2 = new DevExpress.XtraReports.UI.GroupFooterBand();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 164.5833F;
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
            this.BottomMargin.Name = "BottomMargin";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1});
            this.ReportHeader.HeightF = 60F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // GroupHeader2
            // 
            this.GroupHeader2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
            this.GroupHeader2.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeader2.HeightF = 28F;
            this.GroupHeader2.Level = 1;
            this.GroupHeader2.Name = "GroupHeader2";
            // 
            // Detail
            // 
            this.Detail.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table3});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            this.Detail.StylePriority.UseBorders = false;
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(325F, 23F);
            this.pageInfo1.StyleName = "PageInfo";
            // 
            // pageInfo2
            // 
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(325F, 0F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.SizeF = new System.Drawing.SizeF(325F, 23F);
            this.pageInfo2.StyleName = "PageInfo";
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.pageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // label1
            // 
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(650F, 24.19433F);
            this.label1.StyleName = "Title";
            this.label1.Text = "HOAT DONG NHAN VIEN";
            // 
            // table2
            // 
            this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table2.Name = "table2";
            this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow2});
            this.table2.SizeF = new System.Drawing.SizeF(650F, 28F);
            // 
            // tableRow2
            // 
            this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell3,
            this.tableCell4,
            this.tableCell5,
            this.tableCell6,
            this.tableCell7,
            this.tableCell8});
            this.tableRow2.Name = "tableRow2";
            this.tableRow2.Weight = 1D;
            // 
            // tableCell3
            // 
            this.tableCell3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.tableCell3.Name = "tableCell3";
            this.tableCell3.StyleName = "DetailCaption1";
            this.tableCell3.StylePriority.UseBorders = false;
            this.tableCell3.Text = "NGAY";
            this.tableCell3.Weight = 0.12484728299654448D;
            // 
            // tableCell4
            // 
            this.tableCell4.Name = "tableCell4";
            this.tableCell4.StyleName = "DetailCaption1";
            this.tableCell4.Text = "LOAIPHIEU";
            this.tableCell4.Weight = 0.20232327974759615D;
            // 
            // tableCell5
            // 
            this.tableCell5.Name = "tableCell5";
            this.tableCell5.StyleName = "DetailCaption1";
            this.tableCell5.Text = "HOTENKH";
            this.tableCell5.Weight = 0.18715077326847956D;
            // 
            // tableCell6
            // 
            this.tableCell6.Name = "tableCell6";
            this.tableCell6.StyleName = "DetailCaption1";
            this.tableCell6.Text = "TENVT";
            this.tableCell6.Weight = 0.13663003774789664D;
            // 
            // tableCell7
            // 
            this.tableCell7.Name = "tableCell7";
            this.tableCell7.StyleName = "DetailCaption1";
            this.tableCell7.StylePriority.UseTextAlignment = false;
            this.tableCell7.Text = "SOLUONG";
            this.tableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell7.Weight = 0.19052573570838341D;
            // 
            // tableCell8
            // 
            this.tableCell8.Name = "tableCell8";
            this.tableCell8.StyleName = "DetailCaption1";
            this.tableCell8.StylePriority.UseTextAlignment = false;
            this.tableCell8.Text = "DONGIA";
            this.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell8.Weight = 0.15852285531850963D;
            // 
            // table3
            // 
            this.table3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.table3.Name = "table3";
            this.table3.OddStyleName = "DetailData3_Odd";
            this.table3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow3});
            this.table3.SizeF = new System.Drawing.SizeF(650F, 25F);
            // 
            // tableRow3
            // 
            this.tableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell9,
            this.tableCell10,
            this.tableCell11,
            this.tableCell12,
            this.tableCell13,
            this.tableCell14});
            this.tableRow3.Name = "tableRow3";
            this.tableRow3.Weight = 11.5D;
            // 
            // tableCell9
            // 
            this.tableCell9.BorderColor = System.Drawing.Color.Black;
            this.tableCell9.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.tableCell9.BorderWidth = 1F;
            this.tableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NGAY]")});
            this.tableCell9.Name = "tableCell9";
            this.tableCell9.StyleName = "DetailData1";
            this.tableCell9.StylePriority.UseBorderColor = false;
            this.tableCell9.StylePriority.UseBorders = false;
            this.tableCell9.StylePriority.UseBorderWidth = false;
            this.tableCell9.TextFormatString = "{0:dd/MM/yyyy}";
            this.tableCell9.Weight = 0.12484728299654448D;
            // 
            // tableCell10
            // 
            this.tableCell10.BorderColor = System.Drawing.Color.Black;
            this.tableCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.tableCell10.BorderWidth = 1F;
            this.tableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[LOAIPHIEU]")});
            this.tableCell10.Name = "tableCell10";
            this.tableCell10.StyleName = "DetailData1";
            this.tableCell10.StylePriority.UseBorderColor = false;
            this.tableCell10.StylePriority.UseBorders = false;
            this.tableCell10.StylePriority.UseBorderWidth = false;
            this.tableCell10.Weight = 0.20232327974759615D;
            // 
            // tableCell11
            // 
            this.tableCell11.BorderColor = System.Drawing.Color.Black;
            this.tableCell11.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.tableCell11.BorderWidth = 1F;
            this.tableCell11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[HOTENKH]")});
            this.tableCell11.Name = "tableCell11";
            this.tableCell11.StyleName = "DetailData1";
            this.tableCell11.StylePriority.UseBorderColor = false;
            this.tableCell11.StylePriority.UseBorders = false;
            this.tableCell11.StylePriority.UseBorderWidth = false;
            this.tableCell11.Weight = 0.18715078500600962D;
            // 
            // tableCell12
            // 
            this.tableCell12.BorderColor = System.Drawing.Color.Black;
            this.tableCell12.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.tableCell12.BorderWidth = 1F;
            this.tableCell12.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TENVT]")});
            this.tableCell12.Name = "tableCell12";
            this.tableCell12.StyleName = "DetailData1";
            this.tableCell12.StylePriority.UseBorderColor = false;
            this.tableCell12.StylePriority.UseBorders = false;
            this.tableCell12.StylePriority.UseBorderWidth = false;
            this.tableCell12.Weight = 0.13663003774789664D;
            // 
            // tableCell13
            // 
            this.tableCell13.BorderColor = System.Drawing.Color.Black;
            this.tableCell13.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.tableCell13.BorderWidth = 1F;
            this.tableCell13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SOLUONG]")});
            this.tableCell13.Name = "tableCell13";
            this.tableCell13.StyleName = "DetailData1";
            this.tableCell13.StylePriority.UseBorderColor = false;
            this.tableCell13.StylePriority.UseBorders = false;
            this.tableCell13.StylePriority.UseBorderWidth = false;
            this.tableCell13.StylePriority.UseTextAlignment = false;
            this.tableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell13.Weight = 0.19052574744591347D;
            // 
            // tableCell14
            // 
            this.tableCell14.BorderColor = System.Drawing.Color.Black;
            this.tableCell14.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right)));
            this.tableCell14.BorderWidth = 1F;
            this.tableCell14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DONGIA]")});
            this.tableCell14.Name = "tableCell14";
            this.tableCell14.StyleName = "DetailData1";
            this.tableCell14.StylePriority.UseBorderColor = false;
            this.tableCell14.StylePriority.UseBorders = false;
            this.tableCell14.StylePriority.UseBorderWidth = false;
            this.tableCell14.StylePriority.UseTextAlignment = false;
            this.tableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tableCell14.Weight = 0.15852285531850963D;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "QuanLyVatTuPhanTan.Properties.Settings.QLVT_ConnectXRPT";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "sp_HoatDongNhanVien";
            queryParameter1.Name = "@MaNV";
            queryParameter1.Type = typeof(int);
            queryParameter1.ValueInfo = "3";
            queryParameter2.Name = "@TuNgay";
            queryParameter2.Type = typeof(System.DateTime);
            queryParameter2.ValueInfo = "2019-03-15";
            queryParameter3.Name = "@DenNgay";
            queryParameter3.Type = typeof(System.DateTime);
            queryParameter3.ValueInfo = "2025-06-17";
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2,
            queryParameter3});
            storedProcQuery1.StoredProcName = "sp_HoatDongNhanVien";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new DevExpress.Drawing.DXFont("Arial", 14.25F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.Title.Name = "Title";
            this.Title.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // GroupCaption1
            // 
            this.GroupCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(104)))), ((int)(((byte)(196)))));
            this.GroupCaption1.BorderColor = System.Drawing.Color.White;
            this.GroupCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupCaption1.BorderWidth = 2F;
            this.GroupCaption1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GroupCaption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.GroupCaption1.Name = "GroupCaption1";
            this.GroupCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GroupCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GroupData1
            // 
            this.GroupData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(104)))), ((int)(((byte)(196)))));
            this.GroupData1.BorderColor = System.Drawing.Color.White;
            this.GroupData1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupData1.BorderWidth = 2F;
            this.GroupData1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GroupData1.ForeColor = System.Drawing.Color.White;
            this.GroupData1.Name = "GroupData1";
            this.GroupData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GroupData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailCaption1
            // 
            this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(104)))), ((int)(((byte)(196)))));
            this.DetailCaption1.BorderColor = System.Drawing.Color.White;
            this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailCaption1.BorderWidth = 2F;
            this.DetailCaption1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.DetailCaption1.ForeColor = System.Drawing.Color.White;
            this.DetailCaption1.Name = "DetailCaption1";
            this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData1
            // 
            this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
            this.DetailData1.BorderWidth = 2F;
            this.DetailData1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.DetailData1.ForeColor = System.Drawing.Color.Black;
            this.DetailData1.Name = "DetailData1";
            this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GroupFooterBackground3
            // 
            this.GroupFooterBackground3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(117)))), ((int)(((byte)(129)))));
            this.GroupFooterBackground3.BorderColor = System.Drawing.Color.White;
            this.GroupFooterBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupFooterBackground3.BorderWidth = 2F;
            this.GroupFooterBackground3.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GroupFooterBackground3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.GroupFooterBackground3.Name = "GroupFooterBackground3";
            this.GroupFooterBackground3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GroupFooterBackground3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData3_Odd
            // 
            this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
            this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.DetailData3_Odd.BorderWidth = 1F;
            this.DetailData3_Odd.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
            this.DetailData3_Odd.Name = "DetailData3_Odd";
            this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrLabel2});
            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("NGAY", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            this.GroupHeader1.HeightF = 30.33337F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // GroupFooter2
            // 
            this.GroupFooter2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrLabel4});
            this.GroupFooter2.HeightF = 28.4167F;
            this.GroupFooter2.Name = "GroupFooter2";
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NGAY]")});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(95.03969F, 0F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(100.641F, 23F);
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "xrLabel1";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel3.TextFormatString = "{0:MM/yyyy}";
            // 
            // xrLabel4
            // 
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(9.999996F, 0F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(85.0397F, 23F);
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Tổng tháng :";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(9.999996F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(85.0397F, 23F);
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Tháng :";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[NGAY]")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(95.03969F, 0F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(100.641F, 23F);
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "xrLabel1";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel2.TextFormatString = "{0:MM/yyyy}";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = null;
            // 
            // ReportHoatDongNhanVien
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.GroupHeader2,
            this.Detail,
            this.GroupHeader1,
            this.GroupFooter2});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataMember = "sp_HoatDongNhanVien";
            this.DataSource = this.sqlDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(86F, 100F, 164.5833F, 100F);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.GroupCaption1,
            this.GroupData1,
            this.DetailCaption1,
            this.DetailData1,
            this.GroupFooterBackground3,
            this.DetailData3_Odd,
            this.PageInfo});
            this.Version = "22.2";
            ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader2;
        private DevExpress.XtraReports.UI.XRTable table2;
        private DevExpress.XtraReports.UI.XRTableRow tableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tableCell3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell4;
        private DevExpress.XtraReports.UI.XRTableCell tableCell5;
        private DevExpress.XtraReports.UI.XRTableCell tableCell6;
        private DevExpress.XtraReports.UI.XRTableCell tableCell7;
        private DevExpress.XtraReports.UI.XRTableCell tableCell8;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRTable table3;
        private DevExpress.XtraReports.UI.XRTableRow tableRow3;
        private DevExpress.XtraReports.UI.XRTableCell tableCell9;
        private DevExpress.XtraReports.UI.XRTableCell tableCell10;
        private DevExpress.XtraReports.UI.XRTableCell tableCell11;
        private DevExpress.XtraReports.UI.XRTableCell tableCell12;
        private DevExpress.XtraReports.UI.XRTableCell tableCell13;
        private DevExpress.XtraReports.UI.XRTableCell tableCell14;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle GroupCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle GroupData1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
        private DevExpress.XtraReports.UI.XRControlStyle GroupFooterBackground3;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
        private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

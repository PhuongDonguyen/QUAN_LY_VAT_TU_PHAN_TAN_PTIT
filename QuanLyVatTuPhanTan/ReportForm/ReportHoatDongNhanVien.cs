using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;


namespace QuanLyVatTuPhanTan.ReportForm
{
    public partial class ReportHoatDongNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
       
        public ReportHoatDongNhanVien()
        {
            InitializeComponent();
        }
        private  readonly string[] Units = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        private   string[] Tens = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
        private static readonly string[] Thousands = { "", "nghìn", "triệu", "tỷ" };

        public  string Convert(long number)
        {
            if (number == 0)
                return "không đồng";

            string words = "";
            int thousandCounter = 0;

            while (number > 0)
            {
                int chunk = (int)(number % 1000);
                number /= 1000;

                string chunkWords = ConvertChunk(chunk);
                if (!string.IsNullOrWhiteSpace(chunkWords))
                {
                    words = chunkWords + (thousandCounter > 0 ? " " + Thousands[thousandCounter] : "") + " " + words;
                }

                thousandCounter++;
            }

            return words.Trim() + " đồng";
        }

        private  string ConvertChunk(int number)
        {
            if (number == 0)
                return "";

            string words = "";

            int hundreds = number / 100;
            int tens = (number % 100) / 10;
            int units = number % 10;

            if (hundreds > 0)
            {
                words += Units[hundreds] + " trăm";
                if (tens == 0 && units > 0)
                {
                    words += " lẻ";
                }
            }

            if (tens > 0)
            {
                words += " " + Tens[tens];
                if (units > 0)
                {
                    words += " " + (units == 1 ? "mốt" : Units[units]);
                }
            }
            else if (units > 0)
            {
                words += " " + Units[units];
            }

            return words.Trim();
        }
        public ReportHoatDongNhanVien(int maNhanVien, DateTime tuNgay, DateTime toiNgay)
        {   
      
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = maNhanVien;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = tuNgay;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = toiNgay;

            this.sqlDataSource1.Fill();

        }

        private void tbTongCong_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {
         
        }

        private void tbTongCong_SummaryCalculated(object sender, TextFormatEventArgs e)
        {
           
        }

        private void tbTongCong_BeforePrint(object sender, CancelEventArgs e)
        {
          
            long tongCong = long.Parse(tbTongCong.Summary.GetResult().ToString());
            string tc = Convert(tongCong);
            string res = char.ToUpper(tc[0]) + tc.Substring(1);
            tbChu.Text = $"{tongCong.ToString("N0")} đồng ({res})";
        }
    }
}

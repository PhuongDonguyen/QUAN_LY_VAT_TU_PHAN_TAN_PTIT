using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatTuPhanTan.SubForm
{
    public partial class FormChonKhoHang : DevExpress.XtraEditors.XtraForm
    {
        public FormChonKhoHang()
        {
            InitializeComponent();
        }

        private void FormChonKhoHang_Load(object sender, EventArgs e)
        {
            /*không kiểm tra khóa ngoại nữa*/
            dataSet.EnforceConstraints = false;
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.dataSet.Kho);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string maKhoHang = ((DataRowView)khoBindingSource.Current)["MAKHO"].ToString();

            /*Cach nay phai tuy bien ban moi chay duoc*/
            //Program.formDonDatHang.txtMaKho.Text = maKhoHang;


            Program.maKhoDuocChon = maKhoHang;
            this.Close();
        }
    }
}
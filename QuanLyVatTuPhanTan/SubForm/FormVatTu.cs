﻿using System;
using System.Data;

namespace QuanLyVatTuPhanTan.SubForm
{
    public partial class FormVatTu : DevExpress.XtraEditors.XtraForm
    {
        public FormVatTu()
        {
            InitializeComponent();
        }

        private void FormChonVatTu_Load(object sender, EventArgs e)
        {
            /*không kiểm tra khóa ngoại nữa*/
            dataSet.EnforceConstraints = false;
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.dataSet.Vattu);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string maVatTu = ((DataRowView)vattuBindingSource.Current)["MAVT"].ToString();
            int soLuongVatTu = int.Parse(((DataRowView)vattuBindingSource.Current)["SOLUONGTON"].ToString());

            Program.maVatTuDuocChon = maVatTu;
            Program.soLuongVatTu = soLuongVatTu;

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
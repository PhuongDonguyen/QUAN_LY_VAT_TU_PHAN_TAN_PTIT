﻿using DevExpress.XtraEditors;
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
    public partial class FormChonKho : DevExpress.XtraEditors.XtraForm
    {
        public FormChonKho()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DSP);

        }

        private void FormChonKho_Load(object sender, EventArgs e)
        {
            /*không kiểm tra khóa ngoại nữa*/
            DSP.EnforceConstraints = false;
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.FillBy(this.DSP.Kho);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            Program.maKhoDuocChon = ((DataRowView)bdsKho.Current)["MAKHO"].ToString();
            this.Close();
        }
    }
}
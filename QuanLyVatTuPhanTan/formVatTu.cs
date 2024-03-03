using DevExpress.XtraBars.ViewInfo;
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

namespace QuanLyVatTuPhanTan
{
    public partial class formVatTu : DevExpress.XtraEditors.XtraForm
    {
        //private object cmbChiNhanh;

        public formVatTu()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void formVatTu_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.dS.Vattu);

            // TODO: This line of code loads data into the 'dS.CTDDH' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.dS.CTDDH);

            // TODO: This line of code loads data into the 'dS.CTPN' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPNTableAdapter.Fill(this.dS.CTPN);
            // TODO: This line of code loads data into the 'dS.CTPX' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPXTableAdapter.Fill(this.dS.CTPX);
            
            if(Program.role == "CONGTY")
            {
                this.btnThem.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnGhi.Enabled = false;

                this.btnPhucHoi.Enabled = false;
                this.btnReaload.Enabled = true;
                this.btnThoat.Enabled = true;

            }

        }

        private void cTPXBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tENVTLabel_Click(object sender, EventArgs e)
        {

        }

        private void dVTLabel_Click(object sender, EventArgs e)
        {

        }
    }

}
using DevExpress.XtraBars;
using DevExpress.XtraBars.Customization;
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
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }
  
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Check xem form người dùng đang click đã mở từ trước hay chưa
        /// Tránh việc mở chồng cửa sổ
        /// </summary>
        /// <param name="formType"></param>
        /// <returns>Trả về kiểu form đó nếu form đã tồn tại trong MdiChildren</returns>
        private Form CheckFormOpen(Type formType)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == formType) return f;
            }
            return null;
        }

        /// <summary>
        /// Giải phóng các form trong bộ nhớ khi người dùng logout
        /// </summary>
        private void logout()
        {
            foreach (Form f in MdiChildren)
            {
                f.Dispose();
           
            }
        }

        /// <summary>
        /// Hiển thị các chức năng như NHẬP/XUẤT, v.v...
        /// khi đăng nhập thành công
        /// </summary>
        public void enableButtons()
        {
            btnDangNhap.Enabled = false;
            btnDangXuat.Enabled = true;
            btnVatTu.Enabled = true;

            pageNhapXuat.Visible = true;
            pageBaoCao.Visible = true;
            btnLapTaiKhoan.Enabled = true;

            if (Program.role == "USER")
            {
                btnLapTaiKhoan.Enabled = false;
            }
        }

        /// <summary>
        /// Disable các chức năng như NHẬP/XUẤT, v.v...
        /// khi người dùng đăng xuất
        /// </summary>
        private void disableButtons()
        {
            btnDangNhap.Enabled = true;
            btnDangXuat.Enabled = false;

            pageNhapXuat.Visible = false;
            pageBaoCao.Visible = false;
            btnLapTaiKhoan.Enabled = false;
        }

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {

            Form f = CheckFormOpen(typeof(FormLogin));
            if (f != null) f.Activate();
            else
            {
             
                FormLogin login = new FormLogin();
             
                login.Show();
          }

        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có muốn thoát chương trình?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có muốn đăng xuất?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                logout();
                disableButtons();
            }
        }

        private void btnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckFormOpen(typeof(FormNhanVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormNhanVien form = new FormNhanVien();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckFormOpen(typeof(FormKho));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormKho form = new FormKho();
                form.MdiParent = this;
                form.Show();
            }
        }
        private void btnVatTu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckFormOpen(typeof(formVatTu));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                formVatTu form = new formVatTu();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnPhieuNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckFormOpen(typeof(FormPhieuNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormPhieuNhap form = new FormPhieuNhap();
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}
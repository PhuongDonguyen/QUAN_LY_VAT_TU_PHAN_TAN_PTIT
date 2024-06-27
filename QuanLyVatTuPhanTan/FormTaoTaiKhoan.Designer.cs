namespace QuanLyVatTuPhanTan
{
    partial class FormTaoTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaoTaiKhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdChiNhanh = new System.Windows.Forms.RadioButton();
            this.rdUser = new System.Windows.Forms.RadioButton();
            this.btnChonNhanVien = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtXacNhanMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtMaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhanMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "TẠO TÀI KHOẢN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 280);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 330);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Mật Khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 374);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Xác Nhận Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Vai Trò";
            // 
            // rdChiNhanh
            // 
            this.rdChiNhanh.AutoSize = true;
            this.rdChiNhanh.Checked = true;
            this.rdChiNhanh.Location = new System.Drawing.Point(290, 423);
            this.rdChiNhanh.Name = "rdChiNhanh";
            this.rdChiNhanh.Size = new System.Drawing.Size(86, 20);
            this.rdChiNhanh.TabIndex = 31;
            this.rdChiNhanh.TabStop = true;
            this.rdChiNhanh.Text = "Chi Nhánh";
            this.rdChiNhanh.UseVisualStyleBackColor = true;
            // 
            // rdUser
            // 
            this.rdUser.AutoSize = true;
            this.rdUser.Location = new System.Drawing.Point(435, 423);
            this.rdUser.Name = "rdUser";
            this.rdUser.Size = new System.Drawing.Size(54, 20);
            this.rdUser.TabIndex = 32;
            this.rdUser.Text = "User";
            this.rdUser.UseVisualStyleBackColor = true;
            // 
            // btnChonNhanVien
            // 
            this.btnChonNhanVien.Location = new System.Drawing.Point(496, 274);
            this.btnChonNhanVien.Name = "btnChonNhanVien";
            this.btnChonNhanVien.Size = new System.Drawing.Size(138, 33);
            this.btnChonNhanVien.TabIndex = 33;
            this.btnChonNhanVien.Text = "Chọn Nhân Viên";
            this.btnChonNhanVien.UseVisualStyleBackColor = true;
            this.btnChonNhanVien.Click += new System.EventHandler(this.btnChonNhanVien_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.Blue;
            this.btnXacNhan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(116, 472);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(153, 44);
            this.btnXacNhan.TabIndex = 34;
            this.btnXacNhan.Text = "XÁC NHẬN";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(398, 472);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(153, 44);
            this.btnThoat.TabIndex = 35;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.EditValue = "123";
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(290, 375);
            this.txtXacNhanMatKhau.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.Properties.PasswordChar = '*';
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(178, 22);
            this.txtXacNhanMatKhau.TabIndex = 30;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.EditValue = "123";
            this.txtMatKhau.Location = new System.Drawing.Point(290, 327);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(178, 22);
            this.txtMatKhau.TabIndex = 29;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.Location = new System.Drawing.Point(290, 281);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(178, 22);
            this.txtMaNhanVien.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(264, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 199);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormTaoTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 549);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnChonNhanVien);
            this.Controls.Add(this.rdUser);
            this.Controls.Add(this.rdChiNhanh);
            this.Controls.Add(this.txtXacNhanMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormTaoTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTaoTaiKhoan";
            this.Load += new System.EventHandler(this.FormTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtXacNhanMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtMaNhanVien;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.TextEdit txtXacNhanMatKhau;
        private System.Windows.Forms.RadioButton rdChiNhanh;
        private System.Windows.Forms.RadioButton rdUser;
        private System.Windows.Forms.Button btnChonNhanVien;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

namespace QLSieuThi
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageCN = new System.Windows.Forms.TabPage();
            this.bntNhanvien = new DevComponents.DotNetBar.ButtonX();
            this.bntHangHoa = new DevComponents.DotNetBar.ButtonX();
            this.bntKH = new DevComponents.DotNetBar.ButtonX();
            this.pageQL = new System.Windows.Forms.TabPage();
            this.bntthoat = new DevComponents.DotNetBar.ButtonX();
            this.bntdangxuat = new DevComponents.DotNetBar.ButtonX();
            this.bnthuongdan = new DevComponents.DotNetBar.ButtonX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pageCN.SuspendLayout();
            this.pageQL.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuKhachHang,
            this.menuHangHoa,
            this.menuNhanVien,
            this.menuHuongDan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1230, 36);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuKhachHang
            // 
            this.menuKhachHang.Name = "menuKhachHang";
            this.menuKhachHang.Size = new System.Drawing.Size(128, 32);
            this.menuKhachHang.Text = "Khách hàng";
            this.menuKhachHang.Click += new System.EventHandler(this.menuKhachHang_Click);
            // 
            // menuHangHoa
            // 
            this.menuHangHoa.Name = "menuHangHoa";
            this.menuHangHoa.Size = new System.Drawing.Size(111, 32);
            this.menuHangHoa.Text = "Hàng hóa";
            this.menuHangHoa.Click += new System.EventHandler(this.menuHangHoa_Click);
            // 
            // menuNhanVien
            // 
            this.menuNhanVien.Name = "menuNhanVien";
            this.menuNhanVien.Size = new System.Drawing.Size(114, 32);
            this.menuNhanVien.Text = "Nhân viên";
            // 
            // menuHuongDan
            // 
            this.menuHuongDan.Name = "menuHuongDan";
            this.menuHuongDan.Size = new System.Drawing.Size(125, 32);
            this.menuHuongDan.Text = "Hướng dẫn";
            this.menuHuongDan.Click += new System.EventHandler(this.menuHuongDan_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(823, -18);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(159, 41);
            this.btnDangNhap.TabIndex = 10;
            this.btnDangNhap.Text = "Đăng xuất";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1230, 671);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(893, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 671);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageCN);
            this.tabControl1.Controls.Add(this.pageQL);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(337, 671);
            this.tabControl1.TabIndex = 0;
            // 
            // pageCN
            // 
            this.pageCN.Controls.Add(this.bntNhanvien);
            this.pageCN.Controls.Add(this.bntHangHoa);
            this.pageCN.Controls.Add(this.bntKH);
            this.pageCN.Location = new System.Drawing.Point(4, 25);
            this.pageCN.Name = "pageCN";
            this.pageCN.Padding = new System.Windows.Forms.Padding(3);
            this.pageCN.Size = new System.Drawing.Size(329, 642);
            this.pageCN.TabIndex = 0;
            this.pageCN.Text = "Chức năng";
            this.pageCN.UseVisualStyleBackColor = true;
            // 
            // bntNhanvien
            // 
            this.bntNhanvien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntNhanvien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bntNhanvien.Location = new System.Drawing.Point(6, 108);
            this.bntNhanvien.Name = "bntNhanvien";
            this.bntNhanvien.Size = new System.Drawing.Size(145, 76);
            this.bntNhanvien.TabIndex = 3;
            this.bntNhanvien.Text = "Nhân viên";
            this.bntNhanvien.Click += new System.EventHandler(this.bntNhanvien_Click);
            // 
            // bntHangHoa
            // 
            this.bntHangHoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntHangHoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bntHangHoa.Location = new System.Drawing.Point(167, 6);
            this.bntHangHoa.Name = "bntHangHoa";
            this.bntHangHoa.Size = new System.Drawing.Size(145, 76);
            this.bntHangHoa.TabIndex = 2;
            this.bntHangHoa.Text = "Hàng Hoá";
            this.bntHangHoa.Click += new System.EventHandler(this.bntHangHoa_Click);
            // 
            // bntKH
            // 
            this.bntKH.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntKH.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bntKH.Location = new System.Drawing.Point(6, 6);
            this.bntKH.Name = "bntKH";
            this.bntKH.Size = new System.Drawing.Size(145, 76);
            this.bntKH.TabIndex = 1;
            this.bntKH.Text = "Khách hàng";
            this.bntKH.Click += new System.EventHandler(this.bntKH_Click);
            // 
            // pageQL
            // 
            this.pageQL.Controls.Add(this.bntthoat);
            this.pageQL.Controls.Add(this.bntdangxuat);
            this.pageQL.Controls.Add(this.bnthuongdan);
            this.pageQL.Location = new System.Drawing.Point(4, 25);
            this.pageQL.Name = "pageQL";
            this.pageQL.Padding = new System.Windows.Forms.Padding(3);
            this.pageQL.Size = new System.Drawing.Size(329, 642);
            this.pageQL.TabIndex = 1;
            this.pageQL.Text = "Quản lý";
            this.pageQL.UseVisualStyleBackColor = true;
            // 
            // bntthoat
            // 
            this.bntthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntthoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bntthoat.Location = new System.Drawing.Point(6, 102);
            this.bntthoat.Name = "bntthoat";
            this.bntthoat.Size = new System.Drawing.Size(145, 76);
            this.bntthoat.TabIndex = 4;
            this.bntthoat.Text = "Thoát";
            // 
            // bntdangxuat
            // 
            this.bntdangxuat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bntdangxuat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bntdangxuat.Location = new System.Drawing.Point(167, 6);
            this.bntdangxuat.Name = "bntdangxuat";
            this.bntdangxuat.Size = new System.Drawing.Size(145, 76);
            this.bntdangxuat.TabIndex = 3;
            this.bntdangxuat.Text = "Đăng xuất";
            this.bntdangxuat.Click += new System.EventHandler(this.bntdangxuat_Click);
            // 
            // bnthuongdan
            // 
            this.bnthuongdan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnthuongdan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnthuongdan.Location = new System.Drawing.Point(6, 6);
            this.bnthuongdan.Name = "bnthuongdan";
            this.bnthuongdan.Size = new System.Drawing.Size(145, 76);
            this.bnthuongdan.TabIndex = 2;
            this.bnthuongdan.Text = "Hướng dẫn";
            this.bnthuongdan.Click += new System.EventHandler(this.bnthuongdan_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(893, 671);
            this.panel2.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(893, 671);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 707);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDangNhap);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.pageCN.ResumeLayout(false);
            this.pageQL.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem menuHangHoa;
        private System.Windows.Forms.ToolStripMenuItem menuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem menuHuongDan;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageCN;
        private DevComponents.DotNetBar.ButtonX bntNhanvien;
        private DevComponents.DotNetBar.ButtonX bntHangHoa;
        private DevComponents.DotNetBar.ButtonX bntKH;
        private System.Windows.Forms.TabPage pageQL;
        private DevComponents.DotNetBar.ButtonX bntthoat;
        private DevComponents.DotNetBar.ButtonX bntdangxuat;
        private DevComponents.DotNetBar.ButtonX bnthuongdan;
    }
}


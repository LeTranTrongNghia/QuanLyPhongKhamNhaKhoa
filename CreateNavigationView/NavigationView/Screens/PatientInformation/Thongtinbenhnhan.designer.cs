using System.Runtime.CompilerServices;

namespace NavigationView.Screens.PatientInformation
{
    partial class Thongtinbenhnhan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thongtinbenhnhan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtn_them = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_timkiem = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ts_btntim = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtn_exel = new System.Windows.Forms.ToolStripButton();
            this.tsbtn_Sua = new System.Windows.Forms.ToolStripButton();
            this.btnthanhtoan = new System.Windows.Forms.ToolStripButton();
            this.ms = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgv_patient = new System.Windows.Forms.DataGridView();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykhamdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lydo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sts_hienthingaygio = new System.Windows.Forms.StatusStrip();
            this.tslblhienthi = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.ms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_patient)).BeginInit();
            this.sts_hienthingaygio.SuspendLayout();
            this.SuspendLayout();
            // 
            // tm
            // 
            this.tm.Enabled = true;
            this.tm.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(231)))), ((int)(((byte)(239)))));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtn_them,
            this.toolStripSeparator1,
            this.txt_timkiem,
            this.toolStripSeparator3,
            this.toolStripSeparator2,
            this.ts_btntim,
            this.toolStripSeparator4,
            this.tsbtn_exel,
            this.tsbtn_Sua,
            this.btnthanhtoan});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1305, 32);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtn_them
            // 
            this.tsbtn_them.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_them.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_them.Image")));
            this.tsbtn_them.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_them.Name = "tsbtn_them";
            this.tsbtn_them.Size = new System.Drawing.Size(29, 29);
            this.tsbtn_them.Text = "Thêm";
            this.tsbtn_them.Click += new System.EventHandler(this.tsbtn_them_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txt_timkiem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_timkiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(250, 32);
            this.txt_timkiem.Tag = "";
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // ts_btntim
            // 
            this.ts_btntim.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ts_btntim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ts_btntim.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ts_btntim.Image = ((System.Drawing.Image)(resources.GetObject("ts_btntim.Image")));
            this.ts_btntim.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_btntim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btntim.Name = "ts_btntim";
            this.ts_btntim.Size = new System.Drawing.Size(29, 29);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 32);
            // 
            // tsbtn_exel
            // 
            this.tsbtn_exel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtn_exel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_exel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_exel.Image")));
            this.tsbtn_exel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_exel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_exel.Name = "tsbtn_exel";
            this.tsbtn_exel.Size = new System.Drawing.Size(29, 29);
            this.tsbtn_exel.Text = "Xuất exel";
            this.tsbtn_exel.Click += new System.EventHandler(this.tsbtn_exel_Click);
            // 
            // tsbtn_Sua
            // 
            this.tsbtn_Sua.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtn_Sua.Image = ((System.Drawing.Image)(resources.GetObject("tsbtn_Sua.Image")));
            this.tsbtn_Sua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtn_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtn_Sua.Name = "tsbtn_Sua";
            this.tsbtn_Sua.Size = new System.Drawing.Size(29, 29);
            this.tsbtn_Sua.Text = "Sửa";
            this.tsbtn_Sua.Click += new System.EventHandler(this.tsbtn_Sua_Click);
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnthanhtoan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnthanhtoan.Image = ((System.Drawing.Image)(resources.GetObject("btnthanhtoan.Image")));
            this.btnthanhtoan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(29, 29);
            this.btnthanhtoan.Text = "thanh toán";
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // ms
            // 
            this.ms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(231)))), ((int)(((byte)(239)))));
            this.ms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(1305, 30);
            this.ms.TabIndex = 11;
            this.ms.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(231)))), ((int)(((byte)(239)))));
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.lưuToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chứcNăngToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("chứcNăngToolStripMenuItem.Image")));
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thêmToolStripMenuItem.Image")));
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lưuToolStripMenuItem.Image")));
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lưuToolStripMenuItem.Text = "Lưu ";
            this.lưuToolStripMenuItem.Click += new System.EventHandler(this.lưuToolStripMenuItem_Click);
            // 
            // dtgv_patient
            // 
            this.dtgv_patient.AllowUserToAddRows = false;
            this.dtgv_patient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_patient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_patient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(231)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_patient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_patient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sdt,
            this.hoten,
            this.gioitinh,
            this.namsinh,
            this.diachi,
            this.ngaykhamdau,
            this.lydo});
            this.dtgv_patient.GridColor = System.Drawing.SystemColors.Control;
            this.dtgv_patient.Location = new System.Drawing.Point(3, 78);
            this.dtgv_patient.Name = "dtgv_patient";
            this.dtgv_patient.ReadOnly = true;
            this.dtgv_patient.RowHeadersWidth = 51;
            this.dtgv_patient.RowTemplate.Height = 24;
            this.dtgv_patient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_patient.Size = new System.Drawing.Size(1302, 517);
            this.dtgv_patient.TabIndex = 9;
            this.dtgv_patient.DefaultCellStyleChanged += new System.EventHandler(this.dtgv_patient_DefaultCellStyleChanged);
            this.dtgv_patient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_patient_CellDoubleClick);
            this.dtgv_patient.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgv_patient_CellFormatting);
            // 
            // sdt
            // 
            this.sdt.FillWeight = 55F;
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // hoten
            // 
            this.hoten.FillWeight = 60.51694F;
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // gioitinh
            // 
            this.gioitinh.FillWeight = 20F;
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            // 
            // namsinh
            // 
            this.namsinh.FillWeight = 60.51694F;
            this.namsinh.HeaderText = "Năm sinh";
            this.namsinh.MinimumWidth = 6;
            this.namsinh.Name = "namsinh";
            this.namsinh.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.FillWeight = 60.51694F;
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // ngaykhamdau
            // 
            this.ngaykhamdau.FillWeight = 60.51694F;
            this.ngaykhamdau.HeaderText = "Ngày khám đầu";
            this.ngaykhamdau.MinimumWidth = 6;
            this.ngaykhamdau.Name = "ngaykhamdau";
            this.ngaykhamdau.ReadOnly = true;
            // 
            // lydo
            // 
            this.lydo.FillWeight = 60.51694F;
            this.lydo.HeaderText = "Lý do";
            this.lydo.MinimumWidth = 6;
            this.lydo.Name = "lydo";
            this.lydo.ReadOnly = true;
            // 
            // sts_hienthingaygio
            // 
            this.sts_hienthingaygio.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sts_hienthingaygio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblhienthi});
            this.sts_hienthingaygio.Location = new System.Drawing.Point(0, 598);
            this.sts_hienthingaygio.Name = "sts_hienthingaygio";
            this.sts_hienthingaygio.Size = new System.Drawing.Size(1305, 26);
            this.sts_hienthingaygio.TabIndex = 12;
            this.sts_hienthingaygio.Text = "statusStrip1";
            // 
            // tslblhienthi
            // 
            this.tslblhienthi.Name = "tslblhienthi";
            this.tslblhienthi.Size = new System.Drawing.Size(151, 20);
            this.tslblhienthi.Text = "toolStripStatusLabel1";
            // 
            // Thongtinbenhnhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.sts_hienthingaygio);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ms);
            this.Controls.Add(this.dtgv_patient);
            this.Name = "Thongtinbenhnhan";
            this.Size = new System.Drawing.Size(1305, 624);
            this.Load += new System.EventHandler(this.ThongTinBenhNhan_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_patient)).EndInit();
            this.sts_hienthingaygio.ResumeLayout(false);
            this.sts_hienthingaygio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtn_them;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txt_timkiem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ts_btntim;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtn_exel;
        private System.Windows.Forms.ToolStripButton tsbtn_Sua;
        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        public System.Windows.Forms.DataGridView dtgv_patient;
        private System.Windows.Forms.StatusStrip sts_hienthingaygio;
        private System.Windows.Forms.ToolStripStatusLabel tslblhienthi;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn namsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykhamdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn lydo;
        private System.Windows.Forms.ToolStripButton btnthanhtoan;
    }
}

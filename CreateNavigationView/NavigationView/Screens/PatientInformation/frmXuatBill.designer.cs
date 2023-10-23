namespace NavigationView.Screens.PatientInformation
{
    partial class frmXuatBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatBill));
            this.rpv_xuatbill = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tsinbill = new System.Windows.Forms.ToolStrip();
            this.btntimkiem = new System.Windows.Forms.ToolStripButton();
            this.txtSDT = new System.Windows.Forms.ToolStripTextBox();
            this.tsinbill.SuspendLayout();
            this.SuspendLayout();
            // 
            // rpv_xuatbill
            // 
            this.rpv_xuatbill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpv_xuatbill.LocalReport.ReportEmbeddedResource = "NavigationView.Screens.PatientInformation.ReportBILL.rpBILL.rdlc";
            this.rpv_xuatbill.Location = new System.Drawing.Point(0, 27);
            this.rpv_xuatbill.Name = "rpv_xuatbill";
            this.rpv_xuatbill.ServerReport.BearerToken = null;
            this.rpv_xuatbill.Size = new System.Drawing.Size(800, 423);
            this.rpv_xuatbill.TabIndex = 0;
            // 
            // tsinbill
            // 
            this.tsinbill.BackColor = System.Drawing.Color.Cyan;
            this.tsinbill.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsinbill.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btntimkiem,
            this.txtSDT});
            this.tsinbill.Location = new System.Drawing.Point(0, 0);
            this.tsinbill.Name = "tsinbill";
            this.tsinbill.Size = new System.Drawing.Size(800, 27);
            this.tsinbill.TabIndex = 1;
            this.tsinbill.Text = "toolStrip1";
            // 
            // btntimkiem
            // 
            this.btntimkiem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btntimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btntimkiem.Image")));
            this.btntimkiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(29, 24);
            this.btntimkiem.Text = "toolStripButton1";
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.DarkTurquoise;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 27);
            // 
            // frmXuatBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpv_xuatbill);
            this.Controls.Add(this.tsinbill);
            this.Name = "frmXuatBill";
            this.Text = "frmXuatBill";
            this.Load += new System.EventHandler(this.frmXuatBill_Load);
            this.tsinbill.ResumeLayout(false);
            this.tsinbill.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpv_xuatbill;
        private System.Windows.Forms.ToolStrip tsinbill;
        private System.Windows.Forms.ToolStripButton btntimkiem;
        private System.Windows.Forms.ToolStripTextBox txtSDT;
    }
}
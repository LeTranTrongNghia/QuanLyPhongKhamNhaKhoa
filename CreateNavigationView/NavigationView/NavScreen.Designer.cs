namespace NavigationView
{
    partial class FormTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTest));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_exit = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btn_statics = new System.Windows.Forms.Button();
            this.btn_treatments = new System.Windows.Forms.Button();
            this.btn_patient = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 637);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btn_statics);
            this.panel1.Controls.Add(this.btn_treatments);
            this.panel1.Controls.Add(this.btn_patient);
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 633);
            this.panel1.TabIndex = 0;
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_exit.Image = ((System.Drawing.Image)(resources.GetObject("button_exit.Image")));
            this.button_exit.Location = new System.Drawing.Point(9, 524);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(157, 53);
            this.button_exit.TabIndex = 9;
            this.button_exit.Text = "Exit";
            this.button_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Silver;
            this.SidePanel.Location = new System.Drawing.Point(0, 8);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(5, 33);
            this.SidePanel.TabIndex = 3;
            // 
            // btn_statics
            // 
            this.btn_statics.Enabled = false;
            this.btn_statics.FlatAppearance.BorderSize = 0;
            this.btn_statics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_statics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_statics.Image = ((System.Drawing.Image)(resources.GetObject("btn_statics.Image")));
            this.btn_statics.Location = new System.Drawing.Point(8, 290);
            this.btn_statics.Name = "btn_statics";
            this.btn_statics.Size = new System.Drawing.Size(203, 67);
            this.btn_statics.TabIndex = 5;
            this.btn_statics.Text = "   Statics";
            this.btn_statics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_statics.UseVisualStyleBackColor = true;
            this.btn_statics.Click += new System.EventHandler(this.btn_statics_Click);
            // 
            // btn_treatments
            // 
            this.btn_treatments.Enabled = false;
            this.btn_treatments.FlatAppearance.BorderSize = 0;
            this.btn_treatments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_treatments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_treatments.Image = ((System.Drawing.Image)(resources.GetObject("btn_treatments.Image")));
            this.btn_treatments.Location = new System.Drawing.Point(9, 190);
            this.btn_treatments.Name = "btn_treatments";
            this.btn_treatments.Size = new System.Drawing.Size(202, 67);
            this.btn_treatments.TabIndex = 7;
            this.btn_treatments.Text = "Treatments";
            this.btn_treatments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_treatments.UseVisualStyleBackColor = true;
            this.btn_treatments.Click += new System.EventHandler(this.btn_treatments_Click);
            // 
            // btn_patient
            // 
            this.btn_patient.Enabled = false;
            this.btn_patient.FlatAppearance.BorderSize = 0;
            this.btn_patient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patient.Image = ((System.Drawing.Image)(resources.GetObject("btn_patient.Image")));
            this.btn_patient.Location = new System.Drawing.Point(8, 97);
            this.btn_patient.Name = "btn_patient";
            this.btn_patient.Size = new System.Drawing.Size(203, 67);
            this.btn_patient.TabIndex = 8;
            this.btn_patient.Text = "Patient";
            this.btn_patient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_patient.UseVisualStyleBackColor = true;
            this.btn_patient.Click += new System.EventHandler(this.btn_patient_Click);
            // 
            // btn_home
            // 
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.Location = new System.Drawing.Point(9, 8);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(202, 67);
            this.btn_home.TabIndex = 3;
            this.btn_home.Text = "Home";
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 637);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTest";
            this.Text = "Quan ly phong kham nha khoa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTest_FormClosing);
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_statics;
        private System.Windows.Forms.Button btn_treatments;
        private System.Windows.Forms.Button btn_patient;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button_exit;
    }
}


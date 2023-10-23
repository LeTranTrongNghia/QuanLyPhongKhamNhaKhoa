namespace NavigationView.widgets
{
    partial class UCCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Reason = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label_Time = new System.Windows.Forms.Label();
            this.label_FullName = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.label_Reason);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label_Time);
            this.panel2.Controls.Add(this.label_FullName);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 103);
            this.panel2.TabIndex = 4;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // label_Reason
            // 
            this.label_Reason.AutoSize = true;
            this.label_Reason.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Reason.ForeColor = System.Drawing.Color.Black;
            this.label_Reason.Location = new System.Drawing.Point(10, 70);
            this.label_Reason.Name = "label_Reason";
            this.label_Reason.Size = new System.Drawing.Size(55, 17);
            this.label_Reason.TabIndex = 2;
            this.label_Reason.Text = "Reason";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(268, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 23);
            this.button4.TabIndex = 1;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time.ForeColor = System.Drawing.Color.Black;
            this.label_Time.Location = new System.Drawing.Point(10, 5);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(47, 19);
            this.label_Time.TabIndex = 0;
            this.label_Time.Text = "Time";
            // 
            // label_FullName
            // 
            this.label_FullName.AutoSize = true;
            this.label_FullName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FullName.ForeColor = System.Drawing.Color.Black;
            this.label_FullName.Location = new System.Drawing.Point(10, 40);
            this.label_FullName.Name = "label_FullName";
            this.label_FullName.Size = new System.Drawing.Size(95, 21);
            this.label_FullName.TabIndex = 0;
            this.label_FullName.Text = "FullName ";
            this.label_FullName.Click += new System.EventHandler(this.label_FullName_Click);
            // 
            // UCCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "UCCard";
            this.Size = new System.Drawing.Size(300, 100);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Reason;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_FullName;
    }
}

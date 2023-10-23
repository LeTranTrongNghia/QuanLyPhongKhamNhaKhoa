namespace NavigationView.UserControls
{
    partial class HomeScreen
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.chart_profit = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.FLP_patient = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.lbl_revenue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_patient = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_ap = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_profit)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1068, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lich hen tiep theo";
            // 
            // chart_profit
            // 
            this.chart_profit.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            chartArea2.Name = "ChartArea1";
            this.chart_profit.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_profit.Legends.Add(legend2);
            this.chart_profit.Location = new System.Drawing.Point(24, 209);
            this.chart_profit.Name = "chart_profit";
            this.chart_profit.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_profit.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(199)))), ((int)(((byte)(248))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(245)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(237)))), ((int)(((byte)(189)))))};
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Profit";
            this.chart_profit.Series.Add(series2);
            this.chart_profit.Size = new System.Drawing.Size(908, 702);
            this.chart_profit.TabIndex = 11;
            this.chart_profit.Text = "chart1";
            // 
            // btn_refresh
            // 
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(1641, 31);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(38, 33);
            this.btn_refresh.TabIndex = 14;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_add
            // 
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(1597, 30);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(38, 33);
            this.btn_add.TabIndex = 15;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // FLP_patient
            // 
            this.FLP_patient.AutoScroll = true;
            this.FLP_patient.BackColor = System.Drawing.Color.White;
            this.FLP_patient.Location = new System.Drawing.Point(1067, 71);
            this.FLP_patient.Name = "FLP_patient";
            this.FLP_patient.Size = new System.Drawing.Size(733, 840);
            this.FLP_patient.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.lbl_revenue);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(633, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 112);
            this.panel4.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(267, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 40);
            this.button3.TabIndex = 10;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lbl_revenue
            // 
            this.lbl_revenue.AutoSize = true;
            this.lbl_revenue.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_revenue.ForeColor = System.Drawing.Color.Black;
            this.lbl_revenue.Location = new System.Drawing.Point(23, 15);
            this.lbl_revenue.Name = "lbl_revenue";
            this.lbl_revenue.Size = new System.Drawing.Size(116, 40);
            this.lbl_revenue.TabIndex = 3;
            this.lbl_revenue.Text = "2.319$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(26, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loi Nhuan";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.panel8.Controls.Add(this.button2);
            this.panel8.Controls.Add(this.lbl_patient);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Location = new System.Drawing.Point(333, 9);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(278, 112);
            this.panel8.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(218, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 40);
            this.button2.TabIndex = 10;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lbl_patient
            // 
            this.lbl_patient.AutoSize = true;
            this.lbl_patient.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_patient.ForeColor = System.Drawing.Color.Black;
            this.lbl_patient.Location = new System.Drawing.Point(23, 15);
            this.lbl_patient.Name = "lbl_patient";
            this.lbl_patient.Size = new System.Drawing.Size(53, 40);
            this.lbl_patient.TabIndex = 3;
            this.lbl_patient.Text = "27";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(26, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Benh nhan";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.panel9.Controls.Add(this.button1);
            this.panel9.Controls.Add(this.lbl_ap);
            this.panel9.Controls.Add(this.label13);
            this.panel9.Location = new System.Drawing.Point(24, 9);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(284, 112);
            this.panel9.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(217, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 40);
            this.button1.TabIndex = 10;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbl_ap
            // 
            this.lbl_ap.AutoSize = true;
            this.lbl_ap.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ap.ForeColor = System.Drawing.Color.Black;
            this.lbl_ap.Location = new System.Drawing.Point(23, 15);
            this.lbl_ap.Name = "lbl_ap";
            this.lbl_ap.Size = new System.Drawing.Size(71, 40);
            this.lbl_ap.TabIndex = 3;
            this.lbl_ap.Text = "329";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(26, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Lich hen";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(231)))), ((int)(((byte)(239)))));
            this.panel6.Location = new System.Drawing.Point(648, 165);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(44, 38);
            this.panel6.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(338, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 40);
            this.label10.TabIndex = 22;
            this.label10.Text = "Bang loi nhuan";
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.FLP_patient);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart_profit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeScreen";
            this.Size = new System.Drawing.Size(1800, 1000);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_profit)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_profit;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.FlowLayoutPanel FLP_patient;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbl_revenue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_patient;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_ap;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
    }
}

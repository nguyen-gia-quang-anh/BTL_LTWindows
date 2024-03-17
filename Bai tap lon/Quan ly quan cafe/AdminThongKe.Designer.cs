namespace Quan_ly_quan_cafe
{
    partial class AdminThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDoUong = new System.Windows.Forms.Button();
            this.btnDoAn = new System.Windows.Forms.Button();
            this.dateThangNam = new System.Windows.Forms.DateTimePicker();
            this.cbLoaiThongKe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.lbTongDoanhThu = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDoanhThuDoUong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDoanhThuDoAn = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnDoUong);
            this.groupBox1.Controls.Add(this.btnDoAn);
            this.groupBox1.Controls.Add(this.dateThangNam);
            this.groupBox1.Controls.Add(this.cbLoaiThongKe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng điều khiển";
            // 
            // btnDoUong
            // 
            this.btnDoUong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnDoUong.Enabled = false;
            this.btnDoUong.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoUong.ForeColor = System.Drawing.Color.White;
            this.btnDoUong.Location = new System.Drawing.Point(407, 77);
            this.btnDoUong.Name = "btnDoUong";
            this.btnDoUong.Size = new System.Drawing.Size(200, 40);
            this.btnDoUong.TabIndex = 5;
            this.btnDoUong.Text = "Thống kê đồ uống";
            this.btnDoUong.UseVisualStyleBackColor = false;
            this.btnDoUong.Click += new System.EventHandler(this.btnDoUong_Click);
            // 
            // btnDoAn
            // 
            this.btnDoAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnDoAn.Enabled = false;
            this.btnDoAn.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoAn.ForeColor = System.Drawing.Color.White;
            this.btnDoAn.Location = new System.Drawing.Point(408, 38);
            this.btnDoAn.Name = "btnDoAn";
            this.btnDoAn.Size = new System.Drawing.Size(200, 40);
            this.btnDoAn.TabIndex = 4;
            this.btnDoAn.Text = "Thống kê đồ ăn";
            this.btnDoAn.UseVisualStyleBackColor = false;
            this.btnDoAn.Click += new System.EventHandler(this.btnDoAn_Click);
            // 
            // dateThangNam
            // 
            this.dateThangNam.CustomFormat = "   dd/MM/yyyy";
            this.dateThangNam.Enabled = false;
            this.dateThangNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateThangNam.Location = new System.Drawing.Point(218, 84);
            this.dateThangNam.Name = "dateThangNam";
            this.dateThangNam.Size = new System.Drawing.Size(183, 27);
            this.dateThangNam.TabIndex = 3;
            this.dateThangNam.ValueChanged += new System.EventHandler(this.dateThangNam_ValueChanged);
            // 
            // cbLoaiThongKe
            // 
            this.cbLoaiThongKe.FormattingEnabled = true;
            this.cbLoaiThongKe.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Năm"});
            this.cbLoaiThongKe.Location = new System.Drawing.Point(218, 42);
            this.cbLoaiThongKe.Name = "cbLoaiThongKe";
            this.cbLoaiThongKe.Size = new System.Drawing.Size(184, 32);
            this.cbLoaiThongKe.TabIndex = 2;
            this.cbLoaiThongKe.SelectedIndexChanged += new System.EventHandler(this.cbLoaiThongKe_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chọn tháng / năm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn loại thống kê : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê bán hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng doanh thu:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.chart);
            this.groupBox2.Location = new System.Drawing.Point(0, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1210, 565);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(15, 16);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "ThongKe";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(1172, 464);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // lbTongDoanhThu
            // 
            this.lbTongDoanhThu.BackColor = System.Drawing.Color.White;
            this.lbTongDoanhThu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTongDoanhThu.Location = new System.Drawing.Point(198, 18);
            this.lbTongDoanhThu.Name = "lbTongDoanhThu";
            this.lbTongDoanhThu.Size = new System.Drawing.Size(262, 26);
            this.lbTongDoanhThu.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lbDoanhThuDoUong);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lbDoanhThuDoAn);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lbTongDoanhThu);
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(630, 46);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(473, 143);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-2, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Doanh thu đồ uống :";
            // 
            // lbDoanhThuDoUong
            // 
            this.lbDoanhThuDoUong.BackColor = System.Drawing.Color.White;
            this.lbDoanhThuDoUong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDoanhThuDoUong.Location = new System.Drawing.Point(198, 99);
            this.lbDoanhThuDoUong.Name = "lbDoanhThuDoUong";
            this.lbDoanhThuDoUong.Size = new System.Drawing.Size(262, 26);
            this.lbDoanhThuDoUong.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Doanh thu đồ ăn :";
            // 
            // lbDoanhThuDoAn
            // 
            this.lbDoanhThuDoAn.BackColor = System.Drawing.Color.White;
            this.lbDoanhThuDoAn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDoanhThuDoAn.Location = new System.Drawing.Point(198, 58);
            this.lbDoanhThuDoAn.Name = "lbDoanhThuDoAn";
            this.lbDoanhThuDoAn.Size = new System.Drawing.Size(262, 26);
            this.lbDoanhThuDoAn.TabIndex = 6;
            // 
            // AdminThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminThongKe";
            this.Size = new System.Drawing.Size(1213, 763);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDoUong;
        private System.Windows.Forms.Button btnDoAn;
        private System.Windows.Forms.DateTimePicker dateThangNam;
        private System.Windows.Forms.ComboBox cbLoaiThongKe;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.Label lbTongDoanhThu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDoanhThuDoUong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDoanhThuDoAn;
    }
}

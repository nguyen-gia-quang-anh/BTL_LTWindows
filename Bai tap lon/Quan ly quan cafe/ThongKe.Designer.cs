namespace Quan_ly_quan_cafe
{
    partial class ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLoaiThongKe = new System.Windows.Forms.ComboBox();
            this.dateThangNam = new System.Windows.Forms.DateTimePicker();
            this.btnDoAn = new System.Windows.Forms.Button();
            this.btnDoUong = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê bán hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDoUong);
            this.groupBox1.Controls.Add(this.btnDoAn);
            this.groupBox1.Controls.Add(this.dateThangNam);
            this.groupBox1.Controls.Add(this.cbLoaiThongKe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 236);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng điều kiển";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Location = new System.Drawing.Point(446, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 686);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn loại thống kê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chọn tháng/ năm";
            // 
            // cbLoaiThongKe
            // 
            this.cbLoaiThongKe.FormattingEnabled = true;
            this.cbLoaiThongKe.Location = new System.Drawing.Point(180, 34);
            this.cbLoaiThongKe.Name = "cbLoaiThongKe";
            this.cbLoaiThongKe.Size = new System.Drawing.Size(184, 28);
            this.cbLoaiThongKe.TabIndex = 2;
            // 
            // dateThangNam
            // 
            this.dateThangNam.CustomFormat = "dd/MM/yyyy";
            this.dateThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateThangNam.Location = new System.Drawing.Point(182, 69);
            this.dateThangNam.Name = "dateThangNam";
            this.dateThangNam.Size = new System.Drawing.Size(182, 27);
            this.dateThangNam.TabIndex = 3;
            // 
            // btnDoAn
            // 
            this.btnDoAn.Location = new System.Drawing.Point(16, 119);
            this.btnDoAn.Name = "btnDoAn";
            this.btnDoAn.Size = new System.Drawing.Size(348, 35);
            this.btnDoAn.TabIndex = 4;
            this.btnDoAn.Text = "Thống kê đồ ăn";
            this.btnDoAn.UseVisualStyleBackColor = true;
            // 
            // btnDoUong
            // 
            this.btnDoUong.Location = new System.Drawing.Point(13, 176);
            this.btnDoUong.Name = "btnDoUong";
            this.btnDoUong.Size = new System.Drawing.Size(350, 33);
            this.btnDoUong.TabIndex = 5;
            this.btnDoUong.Text = "Thống kê đồ uống";
            this.btnDoUong.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(4, 18);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(632, 673);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "TOP ĐỒ BÁN CHẠY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng doanh thu:";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 747);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ThongKe";
            this.Text = "Thống kê";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDoUong;
        private System.Windows.Forms.Button btnDoAn;
        private System.Windows.Forms.DateTimePicker dateThangNam;
        private System.Windows.Forms.ComboBox cbLoaiThongKe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
    }
}
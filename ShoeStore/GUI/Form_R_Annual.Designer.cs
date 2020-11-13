namespace ShoeStore.GUI
{
    partial class Form_R_Annual
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tB_Percent = new System.Windows.Forms.TextBox();
            this.tB_Interest = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tB_TotalOrder = new System.Windows.Forms.TextBox();
            this.tB_TotalMoney = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_TotalON = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.b_Close = new System.Windows.Forms.Button();
            this.b_OK = new System.Windows.Forms.Button();
            this.tB_Year = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.c_R_A = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_R_A)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.b_OK);
            this.panel1.Controls.Add(this.tB_Year);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 706);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(74, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.c_R_A);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.b_Close);
            this.groupBox1.Location = new System.Drawing.Point(3, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1050, 598);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tB_Percent);
            this.groupBox2.Controls.Add(this.tB_Interest);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tB_TotalOrder);
            this.groupBox2.Controls.Add(this.tB_TotalMoney);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tB_TotalON);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 436);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1038, 105);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tổng kết cả năm";
            // 
            // tB_Percent
            // 
            this.tB_Percent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tB_Percent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Percent.Enabled = false;
            this.tB_Percent.Location = new System.Drawing.Point(327, 72);
            this.tB_Percent.Name = "tB_Percent";
            this.tB_Percent.ReadOnly = true;
            this.tB_Percent.Size = new System.Drawing.Size(134, 27);
            this.tB_Percent.TabIndex = 17;
            this.tB_Percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tB_Interest
            // 
            this.tB_Interest.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tB_Interest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Interest.Enabled = false;
            this.tB_Interest.Location = new System.Drawing.Point(190, 72);
            this.tB_Interest.Name = "tB_Interest";
            this.tB_Interest.ReadOnly = true;
            this.tB_Interest.Size = new System.Drawing.Size(132, 27);
            this.tB_Interest.TabIndex = 16;
            this.tB_Interest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tiền lãi (Số tiền / %)";
            // 
            // tB_TotalOrder
            // 
            this.tB_TotalOrder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tB_TotalOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_TotalOrder.Enabled = false;
            this.tB_TotalOrder.Location = new System.Drawing.Point(190, 26);
            this.tB_TotalOrder.Name = "tB_TotalOrder";
            this.tB_TotalOrder.ReadOnly = true;
            this.tB_TotalOrder.Size = new System.Drawing.Size(271, 27);
            this.tB_TotalOrder.TabIndex = 11;
            this.tB_TotalOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tB_TotalMoney
            // 
            this.tB_TotalMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_TotalMoney.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tB_TotalMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_TotalMoney.Enabled = false;
            this.tB_TotalMoney.Location = new System.Drawing.Point(761, 72);
            this.tB_TotalMoney.Name = "tB_TotalMoney";
            this.tB_TotalMoney.ReadOnly = true;
            this.tB_TotalMoney.Size = new System.Drawing.Size(271, 27);
            this.tB_TotalMoney.TabIndex = 12;
            this.tB_TotalMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng doanh thu:";
            // 
            // tB_TotalON
            // 
            this.tB_TotalON.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_TotalON.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tB_TotalON.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_TotalON.Enabled = false;
            this.tB_TotalON.Location = new System.Drawing.Point(761, 26);
            this.tB_TotalON.Name = "tB_TotalON";
            this.tB_TotalON.ReadOnly = true;
            this.tB_TotalON.Size = new System.Drawing.Size(271, 27);
            this.tB_TotalON.TabIndex = 14;
            this.tB_TotalON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Số lượng sản phẩm bán ra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số đơn hàng:";
            // 
            // b_Close
            // 
            this.b_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Close.Location = new System.Drawing.Point(863, 547);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(181, 45);
            this.b_Close.TabIndex = 7;
            this.b_Close.Text = "Đóng";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // b_OK
            // 
            this.b_OK.Location = new System.Drawing.Point(249, 72);
            this.b_OK.Name = "b_OK";
            this.b_OK.Size = new System.Drawing.Size(108, 28);
            this.b_OK.TabIndex = 5;
            this.b_OK.Text = "Lấy báo cáo";
            this.b_OK.UseVisualStyleBackColor = true;
            this.b_OK.Click += new System.EventHandler(this.b_OK_Click);
            // 
            // tB_Year
            // 
            this.tB_Year.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tB_Year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Year.Location = new System.Drawing.Point(95, 72);
            this.tB_Year.Name = "tB_Year";
            this.tB_Year.Size = new System.Drawing.Size(148, 27);
            this.tB_Year.TabIndex = 4;
            this.tB_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_Year.TextChanged += new System.EventHandler(this.tB_Year_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(330, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO DOANH THU THEO NĂM";
            // 
            // c_R_A
            // 
            chartArea2.Name = "ChartArea1";
            this.c_R_A.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.c_R_A.Legends.Add(legend2);
            this.c_R_A.Location = new System.Drawing.Point(6, 21);
            this.c_R_A.Name = "c_R_A";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Doanh thu";
            this.c_R_A.Series.Add(series2);
            this.c_R_A.Size = new System.Drawing.Size(1038, 409);
            this.c_R_A.TabIndex = 16;
            this.c_R_A.Text = "chart1";
            // 
            // Form_R_Annual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 727);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_R_Annual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo doanh thu theo năm";
            this.Load += new System.EventHandler(this.Form_R_Annual_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_R_A)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_OK;
        private System.Windows.Forms.TextBox tB_Year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.TextBox tB_TotalON;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_TotalMoney;
        private System.Windows.Forms.TextBox tB_TotalOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tB_Percent;
        private System.Windows.Forms.TextBox tB_Interest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart c_R_A;
    }
}
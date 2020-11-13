namespace ShoeStore.GUI
{
    partial class Form_R_Monthly
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.b_OK = new System.Windows.Forms.Button();
            this.tB_Year = new System.Windows.Forms.TextBox();
            this.tB_Month = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_PMM = new System.Windows.Forms.Button();
            this.b_PMON = new System.Windows.Forms.Button();
            this.b_PMO = new System.Windows.Forms.Button();
            this.tB_TotalMoney = new System.Windows.Forms.TextBox();
            this.tB_TotalOrder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.b_Print = new System.Windows.Forms.Button();
            this.b_Close = new System.Windows.Forms.Button();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.b_OK);
            this.panel1.Controls.Add(this.tB_Year);
            this.panel1.Controls.Add(this.tB_Month);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 119);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(288, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(84, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "*";
            // 
            // b_OK
            // 
            this.b_OK.Location = new System.Drawing.Point(476, 65);
            this.b_OK.Name = "b_OK";
            this.b_OK.Size = new System.Drawing.Size(108, 28);
            this.b_OK.TabIndex = 5;
            this.b_OK.Text = "Lấy báo cáo";
            this.b_OK.UseVisualStyleBackColor = true;
            this.b_OK.Click += new System.EventHandler(this.b_OK_Click);
            // 
            // tB_Year
            // 
            this.tB_Year.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Year.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tB_Year.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Year.Location = new System.Drawing.Point(309, 68);
            this.tB_Year.Name = "tB_Year";
            this.tB_Year.Size = new System.Drawing.Size(111, 27);
            this.tB_Year.TabIndex = 4;
            this.tB_Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_Year.TextChanged += new System.EventHandler(this.tB_Year_TextChanged);
            // 
            // tB_Month
            // 
            this.tB_Month.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tB_Month.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tB_Month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Month.Location = new System.Drawing.Point(105, 68);
            this.tB_Month.Name = "tB_Month";
            this.tB_Month.Size = new System.Drawing.Size(100, 27);
            this.tB_Month.TabIndex = 3;
            this.tB_Month.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_Month.TextChanged += new System.EventHandler(this.tB_Month_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(345, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO DOANH THU THEO THÁNG";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.b_Print);
            this.panel2.Controls.Add(this.b_Close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 493);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 234);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_PMM);
            this.groupBox1.Controls.Add(this.b_PMON);
            this.groupBox1.Controls.Add(this.b_PMO);
            this.groupBox1.Controls.Add(this.tB_TotalMoney);
            this.groupBox1.Controls.Add(this.tB_TotalOrder);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1053, 153);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Báo cáo";
            // 
            // b_PMM
            // 
            this.b_PMM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_PMM.Location = new System.Drawing.Point(763, 37);
            this.b_PMM.Name = "b_PMM";
            this.b_PMM.Size = new System.Drawing.Size(262, 60);
            this.b_PMM.TabIndex = 2;
            this.b_PMM.Text = "Báo cáo sản phẩm có doanh thu cao nhất";
            this.b_PMM.UseVisualStyleBackColor = true;
            this.b_PMM.Click += new System.EventHandler(this.b_PMM_Click);
            // 
            // b_PMON
            // 
            this.b_PMON.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_PMON.Location = new System.Drawing.Point(402, 37);
            this.b_PMON.Name = "b_PMON";
            this.b_PMON.Size = new System.Drawing.Size(262, 60);
            this.b_PMON.TabIndex = 1;
            this.b_PMON.Text = "Báo cáo sản phẩm có số lượng bán ra nhiều nhất";
            this.b_PMON.UseVisualStyleBackColor = true;
            this.b_PMON.Click += new System.EventHandler(this.b_PMON_Click);
            // 
            // b_PMO
            // 
            this.b_PMO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_PMO.Location = new System.Drawing.Point(29, 37);
            this.b_PMO.Name = "b_PMO";
            this.b_PMO.Size = new System.Drawing.Size(262, 60);
            this.b_PMO.TabIndex = 0;
            this.b_PMO.Text = "Báo cáo sản phẩm phổ biến nhất";
            this.b_PMO.UseVisualStyleBackColor = true;
            this.b_PMO.Click += new System.EventHandler(this.b_PMO_Click);
            // 
            // tB_TotalMoney
            // 
            this.tB_TotalMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_TotalMoney.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tB_TotalMoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_TotalMoney.Enabled = false;
            this.tB_TotalMoney.Location = new System.Drawing.Point(763, 116);
            this.tB_TotalMoney.Name = "tB_TotalMoney";
            this.tB_TotalMoney.Size = new System.Drawing.Size(262, 27);
            this.tB_TotalMoney.TabIndex = 3;
            this.tB_TotalMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tB_TotalOrder
            // 
            this.tB_TotalOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_TotalOrder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tB_TotalOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_TotalOrder.Enabled = false;
            this.tB_TotalOrder.Location = new System.Drawing.Point(414, 116);
            this.tB_TotalOrder.Name = "tB_TotalOrder";
            this.tB_TotalOrder.Size = new System.Drawing.Size(183, 27);
            this.tB_TotalOrder.TabIndex = 2;
            this.tB_TotalOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số đơn hàng:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(640, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tổng doanh thu:";
            // 
            // b_Print
            // 
            this.b_Print.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Print.Location = new System.Drawing.Point(656, 174);
            this.b_Print.Name = "b_Print";
            this.b_Print.Size = new System.Drawing.Size(172, 45);
            this.b_Print.TabIndex = 5;
            this.b_Print.Text = "In báo cáo";
            this.b_Print.UseVisualStyleBackColor = true;
            this.b_Print.Click += new System.EventHandler(this.b_Print_Click);
            // 
            // b_Close
            // 
            this.b_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Close.Location = new System.Drawing.Point(856, 174);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(181, 45);
            this.b_Close.TabIndex = 4;
            this.b_Close.Text = "Đóng";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // dGV
            // 
            this.dGV.AllowUserToAddRows = false;
            this.dGV.AllowUserToDeleteRows = false;
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGV.Location = new System.Drawing.Point(0, 119);
            this.dGV.Name = "dGV";
            this.dGV.ReadOnly = true;
            this.dGV.RowHeadersWidth = 51;
            this.dGV.RowTemplate.Height = 24;
            this.dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV.Size = new System.Drawing.Size(1077, 374);
            this.dGV.TabIndex = 5;
            // 
            // Form_R_Monthly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 727);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_R_Monthly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo doanh thu theo tháng";
            this.Load += new System.EventHandler(this.Form_R_Monthly_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_OK;
        private System.Windows.Forms.TextBox tB_Year;
        private System.Windows.Forms.TextBox tB_Month;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_Print;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.TextBox tB_TotalMoney;
        private System.Windows.Forms.TextBox tB_TotalOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_PMM;
        private System.Windows.Forms.Button b_PMON;
        private System.Windows.Forms.Button b_PMO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}
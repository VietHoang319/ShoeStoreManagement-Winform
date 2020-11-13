namespace ShoeStore.GUI
{
    partial class Form_C_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_C_Customer));
            this.panel2 = new System.Windows.Forms.Panel();
            this.b_Close = new System.Windows.Forms.Button();
            this.b_Out = new System.Windows.Forms.Button();
            this.b_Save = new System.Windows.Forms.Button();
            this.b_Upd = new System.Windows.Forms.Button();
            this.b_Del = new System.Windows.Forms.Button();
            this.b_Add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tB_Note = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tB_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_Address = new System.Windows.Forms.TextBox();
            this.tB_CMND = new System.Windows.Forms.TextBox();
            this.tB_Nump = new System.Windows.Forms.TextBox();
            this.tB_Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.b_Close);
            this.panel2.Controls.Add(this.b_Out);
            this.panel2.Controls.Add(this.b_Save);
            this.panel2.Controls.Add(this.b_Upd);
            this.panel2.Controls.Add(this.b_Del);
            this.panel2.Controls.Add(this.b_Add);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 654);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 73);
            this.panel2.TabIndex = 7;
            // 
            // b_Close
            // 
            this.b_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Close.Location = new System.Drawing.Point(890, 19);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(113, 42);
            this.b_Close.TabIndex = 6;
            this.b_Close.Text = "&Đóng";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // b_Out
            // 
            this.b_Out.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Out.Location = new System.Drawing.Point(738, 19);
            this.b_Out.Name = "b_Out";
            this.b_Out.Size = new System.Drawing.Size(113, 42);
            this.b_Out.TabIndex = 5;
            this.b_Out.Text = "&Bỏ qua";
            this.b_Out.UseVisualStyleBackColor = true;
            this.b_Out.Click += new System.EventHandler(this.b_Out_Click);
            // 
            // b_Save
            // 
            this.b_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Save.Location = new System.Drawing.Point(583, 19);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(113, 42);
            this.b_Save.TabIndex = 3;
            this.b_Save.Text = "&Lưu";
            this.b_Save.UseVisualStyleBackColor = true;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click);
            // 
            // b_Upd
            // 
            this.b_Upd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Upd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Upd.Location = new System.Drawing.Point(261, 19);
            this.b_Upd.Name = "b_Upd";
            this.b_Upd.Size = new System.Drawing.Size(113, 42);
            this.b_Upd.TabIndex = 2;
            this.b_Upd.Text = "&Sửa";
            this.b_Upd.UseVisualStyleBackColor = true;
            this.b_Upd.Click += new System.EventHandler(this.b_Upd_Click);
            // 
            // b_Del
            // 
            this.b_Del.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_Del.Location = new System.Drawing.Point(428, 19);
            this.b_Del.Name = "b_Del";
            this.b_Del.Size = new System.Drawing.Size(113, 42);
            this.b_Del.TabIndex = 1;
            this.b_Del.Text = "&Xóa";
            this.b_Del.UseVisualStyleBackColor = true;
            this.b_Del.Click += new System.EventHandler(this.b_Del_Click);
            // 
            // b_Add
            // 
            this.b_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Add.Location = new System.Drawing.Point(90, 19);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(113, 42);
            this.b_Add.TabIndex = 0;
            this.b_Add.Text = "&Thêm";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tB_Note);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tB_ID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tB_Address);
            this.panel1.Controls.Add(this.tB_CMND);
            this.panel1.Controls.Add(this.tB_Nump);
            this.panel1.Controls.Add(this.tB_Name);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 215);
            this.panel1.TabIndex = 8;
            // 
            // tB_Note
            // 
            this.tB_Note.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Note.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_Note.Location = new System.Drawing.Point(714, 152);
            this.tB_Note.Name = "tB_Note";
            this.tB_Note.Size = new System.Drawing.Size(293, 27);
            this.tB_Note.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(597, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 19);
            this.label9.TabIndex = 28;
            this.label9.Text = "Ghi chú: ";
            // 
            // tB_ID
            // 
            this.tB_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_ID.Enabled = false;
            this.tB_ID.Location = new System.Drawing.Point(177, 61);
            this.tB_ID.Name = "tB_ID";
            this.tB_ID.ReadOnly = true;
            this.tB_ID.Size = new System.Drawing.Size(293, 27);
            this.tB_ID.TabIndex = 1;
            this.tB_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mã khách hàng";
            // 
            // tB_Address
            // 
            this.tB_Address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Address.Location = new System.Drawing.Point(177, 151);
            this.tB_Address.Name = "tB_Address";
            this.tB_Address.Size = new System.Drawing.Size(293, 27);
            this.tB_Address.TabIndex = 6;
            // 
            // tB_CMND
            // 
            this.tB_CMND.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_CMND.Location = new System.Drawing.Point(714, 104);
            this.tB_CMND.Name = "tB_CMND";
            this.tB_CMND.Size = new System.Drawing.Size(293, 27);
            this.tB_CMND.TabIndex = 4;
            // 
            // tB_Nump
            // 
            this.tB_Nump.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Nump.Location = new System.Drawing.Point(714, 61);
            this.tB_Nump.Name = "tB_Nump";
            this.tB_Nump.Size = new System.Drawing.Size(293, 27);
            this.tB_Nump.TabIndex = 2;
            // 
            // tB_Name
            // 
            this.tB_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tB_Name.Location = new System.Drawing.Point(177, 103);
            this.tB_Name.Name = "tB_Name";
            this.tB_Name.Size = new System.Drawing.Size(293, 27);
            this.tB_Name.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(409, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(351, 33);
            this.label8.TabIndex = 13;
            this.label8.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(597, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số CMTND";
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
            this.dGV.Location = new System.Drawing.Point(0, 215);
            this.dGV.Name = "dGV";
            this.dGV.ReadOnly = true;
            this.dGV.RowHeadersWidth = 51;
            this.dGV.RowTemplate.Height = 24;
            this.dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV.Size = new System.Drawing.Size(1077, 439);
            this.dGV.TabIndex = 9;
            this.dGV.Click += new System.EventHandler(this.dGV_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(156, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(693, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "*";
            // 
            // Form_C_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 727);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_C_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục quản lý khách hàng";
            this.Load += new System.EventHandler(this.Form_C_Customer_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Button b_Out;
        private System.Windows.Forms.Button b_Save;
        private System.Windows.Forms.Button b_Upd;
        private System.Windows.Forms.Button b_Del;
        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tB_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_Address;
        private System.Windows.Forms.TextBox tB_CMND;
        private System.Windows.Forms.TextBox tB_Nump;
        private System.Windows.Forms.TextBox tB_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_Note;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
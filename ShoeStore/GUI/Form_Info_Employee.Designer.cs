namespace ShoeStore.GUI
{
    partial class Form_Info_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Info_Employee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_Close = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_Save_A = new System.Windows.Forms.Button();
            this.b_Cancel_A = new System.Windows.Forms.Button();
            this.b_UpdateAcc = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tB_Pass = new System.Windows.Forms.TextBox();
            this.l_Usename = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_Save_I = new System.Windows.Forms.Button();
            this.b_Cancel_I = new System.Windows.Forms.Button();
            this.b_Update_Info = new System.Windows.Forms.Button();
            this.l_Position = new System.Windows.Forms.Label();
            this.b_Open = new System.Windows.Forms.Button();
            this.pB = new System.Windows.Forms.PictureBox();
            this.tB_Picture = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rB_Male = new System.Windows.Forms.RadioButton();
            this.rB_Famale = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_CMTND = new System.Windows.Forms.TextBox();
            this.tB_Address = new System.Windows.Forms.TextBox();
            this.tB_Nump = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.b_Close);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 703);
            this.panel1.TabIndex = 0;
            // 
            // b_Close
            // 
            this.b_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_Close.Location = new System.Drawing.Point(876, 637);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(162, 50);
            this.b_Close.TabIndex = 17;
            this.b_Close.Text = "Đóng";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.b_Save_A);
            this.groupBox2.Controls.Add(this.b_Cancel_A);
            this.groupBox2.Controls.Add(this.b_UpdateAcc);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tB_Pass);
            this.groupBox2.Controls.Add(this.l_Usename);
            this.groupBox2.Location = new System.Drawing.Point(3, 412);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1046, 206);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản";
            // 
            // b_Save_A
            // 
            this.b_Save_A.Location = new System.Drawing.Point(691, 141);
            this.b_Save_A.Name = "b_Save_A";
            this.b_Save_A.Size = new System.Drawing.Size(162, 50);
            this.b_Save_A.TabIndex = 18;
            this.b_Save_A.Text = "Lưu";
            this.b_Save_A.UseVisualStyleBackColor = true;
            this.b_Save_A.Click += new System.EventHandler(this.b_Save_A_Click);
            // 
            // b_Cancel_A
            // 
            this.b_Cancel_A.Location = new System.Drawing.Point(873, 141);
            this.b_Cancel_A.Name = "b_Cancel_A";
            this.b_Cancel_A.Size = new System.Drawing.Size(162, 50);
            this.b_Cancel_A.TabIndex = 17;
            this.b_Cancel_A.Text = "Hủy";
            this.b_Cancel_A.UseVisualStyleBackColor = true;
            this.b_Cancel_A.Click += new System.EventHandler(this.b_Cancel_A_Click);
            // 
            // b_UpdateAcc
            // 
            this.b_UpdateAcc.Location = new System.Drawing.Point(499, 141);
            this.b_UpdateAcc.Name = "b_UpdateAcc";
            this.b_UpdateAcc.Size = new System.Drawing.Size(162, 50);
            this.b_UpdateAcc.TabIndex = 16;
            this.b_UpdateAcc.Text = "Cập nhật tài khoản";
            this.b_UpdateAcc.UseVisualStyleBackColor = true;
            this.b_UpdateAcc.Click += new System.EventHandler(this.b_UpdateAcc_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mật khẩu: ";
            // 
            // tB_Pass
            // 
            this.tB_Pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Pass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tB_Pass.Location = new System.Drawing.Point(122, 102);
            this.tB_Pass.Name = "tB_Pass";
            this.tB_Pass.Size = new System.Drawing.Size(307, 28);
            this.tB_Pass.TabIndex = 10;
            this.tB_Pass.UseSystemPasswordChar = true;
            // 
            // l_Usename
            // 
            this.l_Usename.AutoSize = true;
            this.l_Usename.Location = new System.Drawing.Point(28, 56);
            this.l_Usename.Name = "l_Usename";
            this.l_Usename.Size = new System.Drawing.Size(125, 21);
            this.l_Usename.TabIndex = 8;
            this.l_Usename.Text = "Tên đăng nhập:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.b_Save_I);
            this.groupBox1.Controls.Add(this.b_Cancel_I);
            this.groupBox1.Controls.Add(this.b_Update_Info);
            this.groupBox1.Controls.Add(this.l_Position);
            this.groupBox1.Controls.Add(this.b_Open);
            this.groupBox1.Controls.Add(this.pB);
            this.groupBox1.Controls.Add(this.tB_Picture);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rB_Male);
            this.groupBox1.Controls.Add(this.rB_Famale);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tB_CMTND);
            this.groupBox1.Controls.Add(this.tB_Address);
            this.groupBox1.Controls.Add(this.tB_Nump);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.l_Name);
            this.groupBox1.Location = new System.Drawing.Point(3, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1046, 353);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // b_Save_I
            // 
            this.b_Save_I.Location = new System.Drawing.Point(691, 274);
            this.b_Save_I.Name = "b_Save_I";
            this.b_Save_I.Size = new System.Drawing.Size(162, 50);
            this.b_Save_I.TabIndex = 15;
            this.b_Save_I.Text = "Lưu";
            this.b_Save_I.UseVisualStyleBackColor = true;
            this.b_Save_I.Click += new System.EventHandler(this.b_Save_I_Click);
            // 
            // b_Cancel_I
            // 
            this.b_Cancel_I.Location = new System.Drawing.Point(873, 274);
            this.b_Cancel_I.Name = "b_Cancel_I";
            this.b_Cancel_I.Size = new System.Drawing.Size(162, 50);
            this.b_Cancel_I.TabIndex = 15;
            this.b_Cancel_I.Text = "Hủy";
            this.b_Cancel_I.UseVisualStyleBackColor = true;
            this.b_Cancel_I.Click += new System.EventHandler(this.b_Cancel_I_Click);
            // 
            // b_Update_Info
            // 
            this.b_Update_Info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_Update_Info.Location = new System.Drawing.Point(499, 274);
            this.b_Update_Info.Name = "b_Update_Info";
            this.b_Update_Info.Size = new System.Drawing.Size(162, 50);
            this.b_Update_Info.TabIndex = 14;
            this.b_Update_Info.Text = "Cập nhật thông tin";
            this.b_Update_Info.UseVisualStyleBackColor = true;
            this.b_Update_Info.Click += new System.EventHandler(this.b_Update_Info_Click);
            // 
            // l_Position
            // 
            this.l_Position.AutoSize = true;
            this.l_Position.Location = new System.Drawing.Point(495, 79);
            this.l_Position.Name = "l_Position";
            this.l_Position.Size = new System.Drawing.Size(78, 21);
            this.l_Position.TabIndex = 13;
            this.l_Position.Text = "Chức vụ:";
            // 
            // b_Open
            // 
            this.b_Open.Location = new System.Drawing.Point(691, 119);
            this.b_Open.Name = "b_Open";
            this.b_Open.Size = new System.Drawing.Size(102, 28);
            this.b_Open.TabIndex = 12;
            this.b_Open.Text = "Mở";
            this.b_Open.UseVisualStyleBackColor = true;
            this.b_Open.Click += new System.EventHandler(this.b_Open_Click);
            // 
            // pB
            // 
            this.pB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pB.Location = new System.Drawing.Point(799, 27);
            this.pB.Name = "pB";
            this.pB.Size = new System.Drawing.Size(236, 216);
            this.pB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB.TabIndex = 11;
            this.pB.TabStop = false;
            // 
            // tB_Picture
            // 
            this.tB_Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Picture.Enabled = false;
            this.tB_Picture.Location = new System.Drawing.Point(499, 153);
            this.tB_Picture.Name = "tB_Picture";
            this.tB_Picture.ReadOnly = true;
            this.tB_Picture.Size = new System.Drawing.Size(294, 90);
            this.tB_Picture.TabIndex = 10;
            this.tB_Picture.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hình ảnh:";
            // 
            // rB_Male
            // 
            this.rB_Male.AutoSize = true;
            this.rB_Male.Location = new System.Drawing.Point(146, 75);
            this.rB_Male.Name = "rB_Male";
            this.rB_Male.Size = new System.Drawing.Size(66, 25);
            this.rB_Male.TabIndex = 2;
            this.rB_Male.TabStop = true;
            this.rB_Male.Text = "Nam";
            this.rB_Male.UseVisualStyleBackColor = true;
            // 
            // rB_Famale
            // 
            this.rB_Famale.AutoSize = true;
            this.rB_Famale.Location = new System.Drawing.Point(284, 75);
            this.rB_Famale.Name = "rB_Famale";
            this.rB_Famale.Size = new System.Drawing.Size(54, 25);
            this.rB_Famale.TabIndex = 8;
            this.rB_Famale.TabStop = true;
            this.rB_Famale.Text = "Nữ";
            this.rB_Famale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số CMTND:";
            // 
            // tB_CMTND
            // 
            this.tB_CMTND.Location = new System.Drawing.Point(146, 215);
            this.tB_CMTND.Name = "tB_CMTND";
            this.tB_CMTND.Size = new System.Drawing.Size(307, 28);
            this.tB_CMTND.TabIndex = 6;
            // 
            // tB_Address
            // 
            this.tB_Address.Location = new System.Drawing.Point(146, 119);
            this.tB_Address.Name = "tB_Address";
            this.tB_Address.Size = new System.Drawing.Size(307, 28);
            this.tB_Address.TabIndex = 5;
            // 
            // tB_Nump
            // 
            this.tB_Nump.Location = new System.Drawing.Point(146, 167);
            this.tB_Nump.Name = "tB_Nump";
            this.tB_Nump.Size = new System.Drawing.Size(307, 28);
            this.tB_Nump.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giới tính:";
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Name.Location = new System.Drawing.Point(27, 35);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(212, 27);
            this.l_Name.TabIndex = 0;
            this.l_Name.Text = "Họ và tên nhân viên:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(429, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // Form_Info_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1077, 728);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form_Info_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin cá nhân";
            this.Load += new System.EventHandler(this.Form_Info_Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_CMTND;
        private System.Windows.Forms.TextBox tB_Address;
        private System.Windows.Forms.TextBox tB_Nump;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rB_Male;
        private System.Windows.Forms.RadioButton rB_Famale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox tB_Picture;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_Save_I;
        private System.Windows.Forms.Button b_Cancel_I;
        private System.Windows.Forms.Button b_Update_Info;
        private System.Windows.Forms.Label l_Position;
        private System.Windows.Forms.Button b_Open;
        private System.Windows.Forms.PictureBox pB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tB_Pass;
        private System.Windows.Forms.Label l_Usename;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Button b_Save_A;
        private System.Windows.Forms.Button b_Cancel_A;
        private System.Windows.Forms.Button b_UpdateAcc;
    }
}
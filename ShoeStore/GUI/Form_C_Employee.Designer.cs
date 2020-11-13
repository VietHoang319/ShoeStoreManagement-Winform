namespace ShoeStore.GUI
{
    partial class Form_C_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_C_Employee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tB_Pict = new System.Windows.Forms.RichTextBox();
            this.b_Open = new System.Windows.Forms.Button();
            this.pB = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tB_Pass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tB_Usename = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rB_Famale = new System.Windows.Forms.RadioButton();
            this.rB_Male = new System.Windows.Forms.RadioButton();
            this.tB_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_Address = new System.Windows.Forms.TextBox();
            this.tB_CMND = new System.Windows.Forms.TextBox();
            this.tB_Position = new System.Windows.Forms.TextBox();
            this.tB_Nump = new System.Windows.Forms.TextBox();
            this.tB_Name = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.b_Close = new System.Windows.Forms.Button();
            this.b_Out = new System.Windows.Forms.Button();
            this.b_Save = new System.Windows.Forms.Button();
            this.b_Upd = new System.Windows.Forms.Button();
            this.b_Del = new System.Windows.Forms.Button();
            this.b_Add = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tB_Pict);
            this.panel1.Controls.Add(this.b_Open);
            this.panel1.Controls.Add(this.pB);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tB_Pass);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tB_Usename);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.rB_Famale);
            this.panel1.Controls.Add(this.rB_Male);
            this.panel1.Controls.Add(this.tB_ID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tB_Address);
            this.panel1.Controls.Add(this.tB_CMND);
            this.panel1.Controls.Add(this.tB_Position);
            this.panel1.Controls.Add(this.tB_Nump);
            this.panel1.Controls.Add(this.tB_Name);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 295);
            this.panel1.TabIndex = 1;
            // 
            // tB_Pict
            // 
            this.tB_Pict.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Pict.BackColor = System.Drawing.SystemColors.Control;
            this.tB_Pict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_Pict.Enabled = false;
            this.tB_Pict.Location = new System.Drawing.Point(572, 227);
            this.tB_Pict.Name = "tB_Pict";
            this.tB_Pict.Size = new System.Drawing.Size(147, 52);
            this.tB_Pict.TabIndex = 33;
            this.tB_Pict.Text = "";
            // 
            // b_Open
            // 
            this.b_Open.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Open.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Open.Location = new System.Drawing.Point(725, 227);
            this.b_Open.Name = "b_Open";
            this.b_Open.Size = new System.Drawing.Size(82, 52);
            this.b_Open.TabIndex = 32;
            this.b_Open.Text = "Mở";
            this.b_Open.UseVisualStyleBackColor = true;
            this.b_Open.Click += new System.EventHandler(this.b_Open_Click);
            // 
            // pB
            // 
            this.pB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pB.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pB.Location = new System.Drawing.Point(825, 59);
            this.pB.Name = "pB";
            this.pB.Size = new System.Drawing.Size(240, 220);
            this.pB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB.TabIndex = 31;
            this.pB.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(463, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 19);
            this.label11.TabIndex = 29;
            this.label11.Text = "Hình ảnh";
            // 
            // tB_Pass
            // 
            this.tB_Pass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Pass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tB_Pass.Location = new System.Drawing.Point(572, 185);
            this.tB_Pass.Name = "tB_Pass";
            this.tB_Pass.Size = new System.Drawing.Size(235, 27);
            this.tB_Pass.TabIndex = 28;
            this.tB_Pass.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(461, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "Mật khẩu";
            // 
            // tB_Usename
            // 
            this.tB_Usename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Usename.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tB_Usename.Location = new System.Drawing.Point(572, 143);
            this.tB_Usename.Name = "tB_Usename";
            this.tB_Usename.Size = new System.Drawing.Size(235, 27);
            this.tB_Usename.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(461, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Tên đăng nhập";
            // 
            // rB_Famale
            // 
            this.rB_Famale.AutoSize = true;
            this.rB_Famale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rB_Famale.Location = new System.Drawing.Point(270, 145);
            this.rB_Famale.Name = "rB_Famale";
            this.rB_Famale.Size = new System.Drawing.Size(51, 23);
            this.rB_Famale.TabIndex = 24;
            this.rB_Famale.TabStop = true;
            this.rB_Famale.Text = "Nữ";
            this.rB_Famale.UseVisualStyleBackColor = true;
            // 
            // rB_Male
            // 
            this.rB_Male.AutoSize = true;
            this.rB_Male.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rB_Male.Location = new System.Drawing.Point(147, 145);
            this.rB_Male.Name = "rB_Male";
            this.rB_Male.Size = new System.Drawing.Size(62, 23);
            this.rB_Male.TabIndex = 23;
            this.rB_Male.TabStop = true;
            this.rB_Male.Text = "Nam";
            this.rB_Male.UseVisualStyleBackColor = true;
            // 
            // tB_ID
            // 
            this.tB_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tB_ID.Enabled = false;
            this.tB_ID.Location = new System.Drawing.Point(147, 60);
            this.tB_ID.Name = "tB_ID";
            this.tB_ID.ReadOnly = true;
            this.tB_ID.Size = new System.Drawing.Size(284, 27);
            this.tB_ID.TabIndex = 22;
            this.tB_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mã nhân viên";
            // 
            // tB_Address
            // 
            this.tB_Address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Address.Location = new System.Drawing.Point(147, 186);
            this.tB_Address.Name = "tB_Address";
            this.tB_Address.Size = new System.Drawing.Size(284, 27);
            this.tB_Address.TabIndex = 18;
            // 
            // tB_CMND
            // 
            this.tB_CMND.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_CMND.Location = new System.Drawing.Point(572, 101);
            this.tB_CMND.Name = "tB_CMND";
            this.tB_CMND.Size = new System.Drawing.Size(235, 27);
            this.tB_CMND.TabIndex = 17;
            // 
            // tB_Position
            // 
            this.tB_Position.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Position.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tB_Position.Location = new System.Drawing.Point(147, 228);
            this.tB_Position.Name = "tB_Position";
            this.tB_Position.Size = new System.Drawing.Size(284, 27);
            this.tB_Position.TabIndex = 16;
            // 
            // tB_Nump
            // 
            this.tB_Nump.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Nump.Location = new System.Drawing.Point(572, 59);
            this.tB_Nump.Name = "tB_Nump";
            this.tB_Nump.Size = new System.Drawing.Size(235, 27);
            this.tB_Nump.TabIndex = 15;
            // 
            // tB_Name
            // 
            this.tB_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tB_Name.Location = new System.Drawing.Point(147, 101);
            this.tB_Name.Name = "tB_Name";
            this.tB_Name.Size = new System.Drawing.Size(284, 27);
            this.tB_Name.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(422, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(320, 33);
            this.label8.TabIndex = 13;
            this.label8.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Chức vụ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 104);
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
            this.dGV.Location = new System.Drawing.Point(0, 295);
            this.dGV.Name = "dGV";
            this.dGV.ReadOnly = true;
            this.dGV.RowHeadersWidth = 51;
            this.dGV.RowTemplate.Height = 24;
            this.dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV.Size = new System.Drawing.Size(1077, 432);
            this.dGV.TabIndex = 5;
            this.dGV.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dGV_CellFormatting);
            this.dGV.Click += new System.EventHandler(this.dGV_Click);
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
            this.panel2.TabIndex = 6;
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
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(551, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 16);
            this.label12.TabIndex = 34;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(126, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 16);
            this.label13.TabIndex = 35;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(101, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 16);
            this.label14.TabIndex = 36;
            this.label14.Text = "*";
            // 
            // Form_C_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 727);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_C_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục quản lý nhân viên";
            this.Load += new System.EventHandler(this.Form_C_Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_Open;
        private System.Windows.Forms.PictureBox pB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tB_Pass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tB_Usename;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rB_Famale;
        private System.Windows.Forms.RadioButton rB_Male;
        private System.Windows.Forms.TextBox tB_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_Address;
        private System.Windows.Forms.TextBox tB_CMND;
        private System.Windows.Forms.TextBox tB_Position;
        private System.Windows.Forms.TextBox tB_Nump;
        private System.Windows.Forms.TextBox tB_Name;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tB_Pict;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Button b_Out;
        private System.Windows.Forms.Button b_Save;
        private System.Windows.Forms.Button b_Upd;
        private System.Windows.Forms.Button b_Del;
        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}
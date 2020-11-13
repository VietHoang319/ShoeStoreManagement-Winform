namespace ShoeStore.GUI
{
    partial class Form_O_OrderEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_O_OrderEntry));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tB_NameP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tB_EntryPrice = new System.Windows.Forms.TextBox();
            this.tB_IntoMoney = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tB_TNOP = new System.Windows.Forms.TextBox();
            this.tB_Supp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cB_Product = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tB_Date = new System.Windows.Forms.TextBox();
            this.b_Add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cB_Employee = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tB_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.B_CencelEntry = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tB_Total = new System.Windows.Forms.TextBox();
            this.b_Enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.b_Close = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.B_CencelEntry);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tB_Total);
            this.panel1.Controls.Add(this.b_Enter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 727);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tB_NameP);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tB_EntryPrice);
            this.groupBox2.Controls.Add(this.tB_IntoMoney);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tB_TNOP);
            this.groupBox2.Controls.Add(this.tB_Supp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cB_Product);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 296);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết đơn nhập";
            // 
            // tB_NameP
            // 
            this.tB_NameP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_NameP.Enabled = false;
            this.tB_NameP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_NameP.Location = new System.Drawing.Point(132, 69);
            this.tB_NameP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_NameP.Name = "tB_NameP";
            this.tB_NameP.ReadOnly = true;
            this.tB_NameP.Size = new System.Drawing.Size(256, 27);
            this.tB_NameP.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 19);
            this.label12.TabIndex = 33;
            this.label12.Text = "Tên sản phẩm";
            // 
            // tB_EntryPrice
            // 
            this.tB_EntryPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_EntryPrice.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_EntryPrice.Location = new System.Drawing.Point(132, 204);
            this.tB_EntryPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_EntryPrice.Name = "tB_EntryPrice";
            this.tB_EntryPrice.Size = new System.Drawing.Size(256, 27);
            this.tB_EntryPrice.TabIndex = 32;
            this.tB_EntryPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tB_EntryPrice.TextChanged += new System.EventHandler(this.tB_EntryPrice_TextChanged);
            // 
            // tB_IntoMoney
            // 
            this.tB_IntoMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_IntoMoney.Enabled = false;
            this.tB_IntoMoney.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_IntoMoney.Location = new System.Drawing.Point(132, 256);
            this.tB_IntoMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_IntoMoney.Name = "tB_IntoMoney";
            this.tB_IntoMoney.ReadOnly = true;
            this.tB_IntoMoney.Size = new System.Drawing.Size(256, 27);
            this.tB_IntoMoney.TabIndex = 31;
            this.tB_IntoMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 19);
            this.label9.TabIndex = 30;
            this.label9.Text = "Thành tiền";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "Số lượng nhập";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 28;
            this.label7.Text = "Giá nhập";
            // 
            // tB_TNOP
            // 
            this.tB_TNOP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_TNOP.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_TNOP.Location = new System.Drawing.Point(132, 154);
            this.tB_TNOP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_TNOP.Name = "tB_TNOP";
            this.tB_TNOP.Size = new System.Drawing.Size(256, 27);
            this.tB_TNOP.TabIndex = 27;
            this.tB_TNOP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tB_TNOP.TextChanged += new System.EventHandler(this.tB_TNOP_TextChanged);
            // 
            // tB_Supp
            // 
            this.tB_Supp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Supp.Enabled = false;
            this.tB_Supp.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_Supp.Location = new System.Drawing.Point(132, 104);
            this.tB_Supp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_Supp.Name = "tB_Supp";
            this.tB_Supp.ReadOnly = true;
            this.tB_Supp.Size = new System.Drawing.Size(256, 27);
            this.tB_Supp.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nhà cung cấp";
            // 
            // cB_Product
            // 
            this.cB_Product.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cB_Product.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cB_Product.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cB_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_Product.FormattingEnabled = true;
            this.cB_Product.Location = new System.Drawing.Point(132, 33);
            this.cB_Product.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cB_Product.Name = "cB_Product";
            this.cB_Product.Size = new System.Drawing.Size(256, 28);
            this.cB_Product.TabIndex = 24;
            this.cB_Product.TextChanged += new System.EventHandler(this.cB_Product_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mã sản phẩm";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tB_Date);
            this.groupBox1.Controls.Add(this.b_Add);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cB_Employee);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tB_ID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 183);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn nhập";
            // 
            // tB_Date
            // 
            this.tB_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Date.Enabled = false;
            this.tB_Date.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_Date.Location = new System.Drawing.Point(132, 87);
            this.tB_Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_Date.Name = "tB_Date";
            this.tB_Date.Size = new System.Drawing.Size(256, 27);
            this.tB_Date.TabIndex = 31;
            this.tB_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // b_Add
            // 
            this.b_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Add.Location = new System.Drawing.Point(302, 40);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(86, 27);
            this.b_Add.TabIndex = 30;
            this.b_Add.Text = "Thêm đơn";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Ngày nhập";
            // 
            // cB_Employee
            // 
            this.cB_Employee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cB_Employee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cB_Employee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cB_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_Employee.FormattingEnabled = true;
            this.cB_Employee.Location = new System.Drawing.Point(132, 132);
            this.cB_Employee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cB_Employee.Name = "cB_Employee";
            this.cB_Employee.Size = new System.Drawing.Size(256, 28);
            this.cB_Employee.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Nhân viên";
            // 
            // tB_ID
            // 
            this.tB_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_ID.Enabled = false;
            this.tB_ID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_ID.Location = new System.Drawing.Point(132, 40);
            this.tB_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_ID.Name = "tB_ID";
            this.tB_ID.ReadOnly = true;
            this.tB_ID.Size = new System.Drawing.Size(156, 27);
            this.tB_ID.TabIndex = 26;
            this.tB_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã nhập";
            // 
            // B_CencelEntry
            // 
            this.B_CencelEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_CencelEntry.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_CencelEntry.Location = new System.Drawing.Point(37, 672);
            this.B_CencelEntry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.B_CencelEntry.Name = "B_CencelEntry";
            this.B_CencelEntry.Size = new System.Drawing.Size(363, 42);
            this.B_CencelEntry.TabIndex = 25;
            this.B_CencelEntry.Text = "HỦY ĐƠN";
            this.B_CencelEntry.UseVisualStyleBackColor = true;
            this.B_CencelEntry.Click += new System.EventHandler(this.B_CencelEntry_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(144, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 33);
            this.label11.TabIndex = 23;
            this.label11.Text = "ĐƠN NHẬP";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 561);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "Tổng Tiền";
            // 
            // tB_Total
            // 
            this.tB_Total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Total.Enabled = false;
            this.tB_Total.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_Total.Location = new System.Drawing.Point(144, 558);
            this.tB_Total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_Total.Name = "tB_Total";
            this.tB_Total.ReadOnly = true;
            this.tB_Total.Size = new System.Drawing.Size(256, 27);
            this.tB_Total.TabIndex = 19;
            this.tB_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // b_Enter
            // 
            this.b_Enter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Enter.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Enter.Location = new System.Drawing.Point(37, 593);
            this.b_Enter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.b_Enter.Name = "b_Enter";
            this.b_Enter.Size = new System.Drawing.Size(363, 71);
            this.b_Enter.TabIndex = 15;
            this.b_Enter.Text = "THÊM VÀO KHO";
            this.b_Enter.UseVisualStyleBackColor = true;
            this.b_Enter.Click += new System.EventHandler(this.b_Enter_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, -26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIẾT ĐƠN NHẬP";
            // 
            // dGV
            // 
            this.dGV.AllowUserToAddRows = false;
            this.dGV.AllowUserToDeleteRows = false;
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGV.Location = new System.Drawing.Point(432, 0);
            this.dGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dGV.Name = "dGV";
            this.dGV.ReadOnly = true;
            this.dGV.RowHeadersWidth = 51;
            this.dGV.RowTemplate.Height = 24;
            this.dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV.Size = new System.Drawing.Size(645, 727);
            this.dGV.TabIndex = 2;
            this.dGV.DoubleClick += new System.EventHandler(this.dGV_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.b_Close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(432, 657);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 70);
            this.panel2.TabIndex = 3;
            // 
            // b_Close
            // 
            this.b_Close.Location = new System.Drawing.Point(522, 15);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(111, 42);
            this.b_Close.TabIndex = 0;
            this.b_Close.Text = "Đóng";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // Form_O_OrderEntry
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
            this.Name = "Form_O_OrderEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn hàng nhập";
            this.Load += new System.EventHandler(this.Form_O_OrderEntry_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tB_EntryPrice;
        private System.Windows.Forms.TextBox tB_IntoMoney;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tB_TNOP;
        private System.Windows.Forms.TextBox tB_Supp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cB_Product;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tB_Date;
        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cB_Employee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tB_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_CencelEntry;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tB_Total;
        private System.Windows.Forms.Button b_Enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.TextBox tB_NameP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button b_Close;
    }
}
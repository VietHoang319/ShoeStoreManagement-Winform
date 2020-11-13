namespace ShoeStore.GUI
{
    partial class Form_O_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_O_Order));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_Seach = new System.Windows.Forms.Button();
            this.cB_Seach = new System.Windows.Forms.ComboBox();
            this.tB_TNOGs = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_Close = new System.Windows.Forms.Button();
            this.b_Print = new System.Windows.Forms.Button();
            this.b_CancelOrder = new System.Windows.Forms.Button();
            this.b_Save = new System.Windows.Forms.Button();
            this.b_Add = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.tB_TotalAmount = new System.Windows.Forms.TextBox();
            this.tB_IntoMoney = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tB_Sale = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tB_Price = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cB_Product = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_Date = new System.Windows.Forms.Button();
            this.tB_Date = new System.Windows.Forms.TextBox();
            this.tB_NumpCus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tB_AddressCus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cB_Customer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cB_Employee = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tB_Product = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.tB_Product);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.b_Seach);
            this.groupBox2.Controls.Add(this.cB_Seach);
            this.groupBox2.Controls.Add(this.tB_TNOGs);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.dGV);
            this.groupBox2.Controls.Add(this.tB_TotalAmount);
            this.groupBox2.Controls.Add(this.tB_IntoMoney);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tB_Sale);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tB_Price);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cB_Product);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 209);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1053, 505);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết đơn hàng";
            // 
            // b_Seach
            // 
            this.b_Seach.Location = new System.Drawing.Point(397, 470);
            this.b_Seach.Name = "b_Seach";
            this.b_Seach.Size = new System.Drawing.Size(104, 27);
            this.b_Seach.TabIndex = 21;
            this.b_Seach.Text = "Tìm kiếm";
            this.b_Seach.UseVisualStyleBackColor = true;
            this.b_Seach.Click += new System.EventHandler(this.b_Seach_Click);
            // 
            // cB_Seach
            // 
            this.cB_Seach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cB_Seach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cB_Seach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cB_Seach.FormattingEnabled = true;
            this.cB_Seach.Location = new System.Drawing.Point(80, 470);
            this.cB_Seach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cB_Seach.Name = "cB_Seach";
            this.cB_Seach.Size = new System.Drawing.Size(296, 27);
            this.cB_Seach.TabIndex = 26;
            this.cB_Seach.DropDown += new System.EventHandler(this.cB_Seach_DropDown);
            // 
            // tB_TNOGs
            // 
            this.tB_TNOGs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_TNOGs.Location = new System.Drawing.Point(132, 100);
            this.tB_TNOGs.Name = "tB_TNOGs";
            this.tB_TNOGs.Size = new System.Drawing.Size(151, 27);
            this.tB_TNOGs.TabIndex = 25;
            this.tB_TNOGs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tB_TNOGs.TextChanged += new System.EventHandler(this.tB_TNOGs_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.b_Close);
            this.panel1.Controls.Add(this.b_Print);
            this.panel1.Controls.Add(this.b_CancelOrder);
            this.panel1.Controls.Add(this.b_Save);
            this.panel1.Controls.Add(this.b_Add);
            this.panel1.Location = new System.Drawing.Point(6, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 75);
            this.panel1.TabIndex = 24;
            // 
            // b_Close
            // 
            this.b_Close.Location = new System.Drawing.Point(871, 14);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(129, 45);
            this.b_Close.TabIndex = 20;
            this.b_Close.Text = "Đóng";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // b_Print
            // 
            this.b_Print.Location = new System.Drawing.Point(672, 14);
            this.b_Print.Name = "b_Print";
            this.b_Print.Size = new System.Drawing.Size(129, 45);
            this.b_Print.TabIndex = 19;
            this.b_Print.Text = "In hóa đơn";
            this.b_Print.UseVisualStyleBackColor = true;
            this.b_Print.Click += new System.EventHandler(this.b_Print_Click);
            // 
            // b_CancelOrder
            // 
            this.b_CancelOrder.Location = new System.Drawing.Point(470, 14);
            this.b_CancelOrder.Name = "b_CancelOrder";
            this.b_CancelOrder.Size = new System.Drawing.Size(129, 45);
            this.b_CancelOrder.TabIndex = 18;
            this.b_CancelOrder.Text = "Hủy hóa đơn";
            this.b_CancelOrder.UseVisualStyleBackColor = true;
            this.b_CancelOrder.Click += new System.EventHandler(this.b_CancelOrder_Click);
            // 
            // b_Save
            // 
            this.b_Save.Location = new System.Drawing.Point(277, 14);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(129, 45);
            this.b_Save.TabIndex = 17;
            this.b_Save.Text = "Lưu hóa đơn";
            this.b_Save.UseVisualStyleBackColor = true;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click);
            // 
            // b_Add
            // 
            this.b_Add.Location = new System.Drawing.Point(74, 14);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(129, 45);
            this.b_Add.TabIndex = 13;
            this.b_Add.Text = "Thêm hóa đơn";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(12, 357);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(197, 19);
            this.label15.TabIndex = 22;
            this.label15.Text = "Click đúp một dòng để xóa";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(561, 357);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 19);
            this.label14.TabIndex = 21;
            this.label14.Text = "Tổng tiền";
            // 
            // dGV
            // 
            this.dGV.AllowUserToAddRows = false;
            this.dGV.AllowUserToDeleteRows = false;
            this.dGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGV.Location = new System.Drawing.Point(6, 134);
            this.dGV.Name = "dGV";
            this.dGV.ReadOnly = true;
            this.dGV.RowHeadersWidth = 51;
            this.dGV.RowTemplate.Height = 24;
            this.dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV.Size = new System.Drawing.Size(1041, 213);
            this.dGV.TabIndex = 3;
            this.dGV.DoubleClick += new System.EventHandler(this.dGV_DoubleClick);
            // 
            // tB_TotalAmount
            // 
            this.tB_TotalAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_TotalAmount.BackColor = System.Drawing.SystemColors.Control;
            this.tB_TotalAmount.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_TotalAmount.Location = new System.Drawing.Point(707, 354);
            this.tB_TotalAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_TotalAmount.Name = "tB_TotalAmount";
            this.tB_TotalAmount.ReadOnly = true;
            this.tB_TotalAmount.Size = new System.Drawing.Size(299, 27);
            this.tB_TotalAmount.TabIndex = 20;
            this.tB_TotalAmount.Text = "0VND";
            this.tB_TotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tB_IntoMoney
            // 
            this.tB_IntoMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_IntoMoney.BackColor = System.Drawing.SystemColors.Control;
            this.tB_IntoMoney.Enabled = false;
            this.tB_IntoMoney.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_IntoMoney.Location = new System.Drawing.Point(707, 100);
            this.tB_IntoMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_IntoMoney.Name = "tB_IntoMoney";
            this.tB_IntoMoney.ReadOnly = true;
            this.tB_IntoMoney.Size = new System.Drawing.Size(299, 27);
            this.tB_IntoMoney.TabIndex = 17;
            this.tB_IntoMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(561, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 19);
            this.label12.TabIndex = 16;
            this.label12.Text = "Thành tiền";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(12, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "Tên sản phẩm";
            // 
            // tB_Sale
            // 
            this.tB_Sale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Sale.Location = new System.Drawing.Point(707, 65);
            this.tB_Sale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_Sale.Name = "tB_Sale";
            this.tB_Sale.Size = new System.Drawing.Size(299, 27);
            this.tB_Sale.TabIndex = 13;
            this.tB_Sale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tB_Sale.TextChanged += new System.EventHandler(this.tB_Sale_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(561, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 19);
            this.label10.TabIndex = 12;
            this.label10.Text = "Giảm giá %";
            // 
            // tB_Price
            // 
            this.tB_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Price.BackColor = System.Drawing.SystemColors.Control;
            this.tB_Price.Enabled = false;
            this.tB_Price.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_Price.Location = new System.Drawing.Point(707, 31);
            this.tB_Price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_Price.Name = "tB_Price";
            this.tB_Price.ReadOnly = true;
            this.tB_Price.Size = new System.Drawing.Size(299, 27);
            this.tB_Price.TabIndex = 11;
            this.tB_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(561, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Đơn giá";
            // 
            // cB_Product
            // 
            this.cB_Product.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cB_Product.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cB_Product.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cB_Product.FormattingEnabled = true;
            this.cB_Product.Location = new System.Drawing.Point(132, 31);
            this.cB_Product.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cB_Product.Name = "cB_Product";
            this.cB_Product.Size = new System.Drawing.Size(342, 27);
            this.cB_Product.TabIndex = 7;
            this.cB_Product.SelectedIndexChanged += new System.EventHandler(this.cB_Product_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(12, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mã sản phẩm";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(427, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.b_Date);
            this.groupBox1.Controls.Add(this.tB_Date);
            this.groupBox1.Controls.Add(this.tB_NumpCus);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tB_AddressCus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cB_Customer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cB_Employee);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tB_ID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1053, 151);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // b_Date
            // 
            this.b_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Date.Location = new System.Drawing.Point(402, 62);
            this.b_Date.Name = "b_Date";
            this.b_Date.Size = new System.Drawing.Size(72, 27);
            this.b_Date.TabIndex = 14;
            this.b_Date.Text = "...";
            this.b_Date.UseVisualStyleBackColor = true;
            this.b_Date.Click += new System.EventHandler(this.b_Date_Click);
            // 
            // tB_Date
            // 
            this.tB_Date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Date.Location = new System.Drawing.Point(132, 62);
            this.tB_Date.Name = "tB_Date";
            this.tB_Date.Size = new System.Drawing.Size(253, 27);
            this.tB_Date.TabIndex = 13;
            this.tB_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tB_NumpCus
            // 
            this.tB_NumpCus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_NumpCus.BackColor = System.Drawing.SystemColors.Control;
            this.tB_NumpCus.Enabled = false;
            this.tB_NumpCus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_NumpCus.Location = new System.Drawing.Point(707, 98);
            this.tB_NumpCus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_NumpCus.Name = "tB_NumpCus";
            this.tB_NumpCus.ReadOnly = true;
            this.tB_NumpCus.Size = new System.Drawing.Size(299, 27);
            this.tB_NumpCus.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(561, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Số điện thoại";
            // 
            // tB_AddressCus
            // 
            this.tB_AddressCus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_AddressCus.BackColor = System.Drawing.SystemColors.Control;
            this.tB_AddressCus.Enabled = false;
            this.tB_AddressCus.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_AddressCus.Location = new System.Drawing.Point(707, 63);
            this.tB_AddressCus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_AddressCus.Name = "tB_AddressCus";
            this.tB_AddressCus.ReadOnly = true;
            this.tB_AddressCus.Size = new System.Drawing.Size(299, 27);
            this.tB_AddressCus.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(561, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Địa chỉ";
            // 
            // cB_Customer
            // 
            this.cB_Customer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cB_Customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cB_Customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cB_Customer.FormattingEnabled = true;
            this.cB_Customer.Location = new System.Drawing.Point(707, 28);
            this.cB_Customer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cB_Customer.Name = "cB_Customer";
            this.cB_Customer.Size = new System.Drawing.Size(299, 27);
            this.cB_Customer.TabIndex = 8;
            this.cB_Customer.SelectedIndexChanged += new System.EventHandler(this.cB_Customer_SelectedIndexChanged);
            this.cB_Customer.TextChanged += new System.EventHandler(this.cB_Customer_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(561, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Khách hàng";
            // 
            // cB_Employee
            // 
            this.cB_Employee.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cB_Employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_Employee.FormattingEnabled = true;
            this.cB_Employee.Location = new System.Drawing.Point(132, 101);
            this.cB_Employee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cB_Employee.Name = "cB_Employee";
            this.cB_Employee.Size = new System.Drawing.Size(342, 27);
            this.cB_Employee.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nhân viên";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(11, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày bán";
            // 
            // tB_ID
            // 
            this.tB_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_ID.BackColor = System.Drawing.SystemColors.Control;
            this.tB_ID.Enabled = false;
            this.tB_ID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_ID.Location = new System.Drawing.Point(132, 28);
            this.tB_ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tB_ID.Name = "tB_ID";
            this.tB_ID.ReadOnly = true;
            this.tB_ID.Size = new System.Drawing.Size(342, 27);
            this.tB_ID.TabIndex = 3;
            this.tB_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã đơn hàng";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(12, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 19);
            this.label13.TabIndex = 27;
            this.label13.Text = "Số lượng";
            // 
            // tB_Product
            // 
            this.tB_Product.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Product.Enabled = false;
            this.tB_Product.Location = new System.Drawing.Point(132, 65);
            this.tB_Product.Name = "tB_Product";
            this.tB_Product.ReadOnly = true;
            this.tB_Product.Size = new System.Drawing.Size(342, 27);
            this.tB_Product.TabIndex = 28;
            this.tB_Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form_O_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 727);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_O_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn hàng bán";
            this.Load += new System.EventHandler(this.Form_O_Order_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_Seach;
        private System.Windows.Forms.ComboBox cB_Seach;
        private System.Windows.Forms.TextBox tB_TNOGs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Button b_Print;
        private System.Windows.Forms.Button b_CancelOrder;
        private System.Windows.Forms.Button b_Save;
        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.TextBox tB_TotalAmount;
        private System.Windows.Forms.TextBox tB_IntoMoney;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tB_Sale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tB_Price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cB_Product;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_Date;
        private System.Windows.Forms.TextBox tB_Date;
        private System.Windows.Forms.TextBox tB_NumpCus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tB_AddressCus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cB_Customer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cB_Employee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_Product;
        private System.Windows.Forms.Label label13;
    }
}
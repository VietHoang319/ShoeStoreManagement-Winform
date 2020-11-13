namespace ShoeStore.GUI
{
    partial class Form_C_Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_C_Supplier));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tB_Web = new System.Windows.Forms.TextBox();
            this.tB_Address = new System.Windows.Forms.TextBox();
            this.tB_Nump = new System.Windows.Forms.TextBox();
            this.tB_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.b_Del = new System.Windows.Forms.Button();
            this.b_Upd = new System.Windows.Forms.Button();
            this.b_Save = new System.Windows.Forms.Button();
            this.b_Close = new System.Windows.Forms.Button();
            this.b_Add = new System.Windows.Forms.Button();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tB_Web);
            this.panel1.Controls.Add(this.tB_Address);
            this.panel1.Controls.Add(this.tB_Nump);
            this.panel1.Controls.Add(this.tB_Name);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 170);
            this.panel1.TabIndex = 1;
            // 
            // tB_Web
            // 
            this.tB_Web.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Web.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_Web.Location = new System.Drawing.Point(716, 115);
            this.tB_Web.Name = "tB_Web";
            this.tB_Web.Size = new System.Drawing.Size(338, 25);
            this.tB_Web.TabIndex = 4;
            // 
            // tB_Address
            // 
            this.tB_Address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Address.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_Address.Location = new System.Drawing.Point(204, 115);
            this.tB_Address.Name = "tB_Address";
            this.tB_Address.Size = new System.Drawing.Size(322, 25);
            this.tB_Address.TabIndex = 2;
            // 
            // tB_Nump
            // 
            this.tB_Nump.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Nump.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_Nump.Location = new System.Drawing.Point(716, 67);
            this.tB_Nump.Name = "tB_Nump";
            this.tB_Nump.Size = new System.Drawing.Size(338, 25);
            this.tB_Nump.TabIndex = 3;
            // 
            // tB_Name
            // 
            this.tB_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tB_Name.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_Name.Location = new System.Drawing.Point(204, 67);
            this.tB_Name.Name = "tB_Name";
            this.tB_Name.Size = new System.Drawing.Size(322, 25);
            this.tB_Name.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(602, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số điện thoại: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(602, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Website: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Địa chỉ: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên nhà cung cấp: ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(388, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH MỤC NHÀ CUNG CẤP";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.b_Del);
            this.panel3.Controls.Add(this.b_Upd);
            this.panel3.Controls.Add(this.b_Save);
            this.panel3.Controls.Add(this.b_Close);
            this.panel3.Controls.Add(this.b_Add);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 654);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1077, 73);
            this.panel3.TabIndex = 5;
            // 
            // b_Del
            // 
            this.b_Del.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Del.Location = new System.Drawing.Point(463, 19);
            this.b_Del.Name = "b_Del";
            this.b_Del.Size = new System.Drawing.Size(113, 42);
            this.b_Del.TabIndex = 10;
            this.b_Del.Text = "&Xóa";
            this.b_Del.UseVisualStyleBackColor = true;
            this.b_Del.Click += new System.EventHandler(this.b_Del_Click);
            // 
            // b_Upd
            // 
            this.b_Upd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Upd.Location = new System.Drawing.Point(277, 19);
            this.b_Upd.Name = "b_Upd";
            this.b_Upd.Size = new System.Drawing.Size(113, 42);
            this.b_Upd.TabIndex = 9;
            this.b_Upd.Text = "&Sửa";
            this.b_Upd.UseVisualStyleBackColor = true;
            this.b_Upd.Click += new System.EventHandler(this.b_Upd_Click);
            // 
            // b_Save
            // 
            this.b_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Save.Location = new System.Drawing.Point(649, 19);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(113, 42);
            this.b_Save.TabIndex = 7;
            this.b_Save.Text = "&Lưu";
            this.b_Save.UseVisualStyleBackColor = true;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click);
            // 
            // b_Close
            // 
            this.b_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Close.Location = new System.Drawing.Point(837, 19);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(113, 42);
            this.b_Close.TabIndex = 8;
            this.b_Close.Text = "&Đóng";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // b_Add
            // 
            this.b_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Add.Location = new System.Drawing.Point(75, 19);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(113, 42);
            this.b_Add.TabIndex = 5;
            this.b_Add.Text = "&Thêm";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // dGV
            // 
            this.dGV.AllowUserToAddRows = false;
            this.dGV.AllowUserToDeleteRows = false;
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGV.Location = new System.Drawing.Point(0, 170);
            this.dGV.Name = "dGV";
            this.dGV.ReadOnly = true;
            this.dGV.RowHeadersWidth = 51;
            this.dGV.RowTemplate.Height = 24;
            this.dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV.Size = new System.Drawing.Size(1077, 484);
            this.dGV.TabIndex = 6;
            this.dGV.Click += new System.EventHandler(this.dGV_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(183, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "*";
            // 
            // Form_C_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 727);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_C_Supplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục quản lý nhà cung cấp";
            this.Load += new System.EventHandler(this.Form_C_Supplier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tB_Web;
        private System.Windows.Forms.TextBox tB_Address;
        private System.Windows.Forms.TextBox tB_Nump;
        private System.Windows.Forms.TextBox tB_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button b_Save;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Button b_Upd;
        private System.Windows.Forms.Button b_Del;
        private System.Windows.Forms.Label label6;
    }
}
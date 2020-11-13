namespace ShoeStore.GUI
{
    partial class Form_C_TypeOfGoods
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_Save = new System.Windows.Forms.Button();
            this.b_Close = new System.Windows.Forms.Button();
            this.b_Del = new System.Windows.Forms.Button();
            this.b_Add = new System.Windows.Forms.Button();
            this.tB_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.b_Save);
            this.panel1.Controls.Add(this.b_Close);
            this.panel1.Controls.Add(this.b_Del);
            this.panel1.Controls.Add(this.b_Add);
            this.panel1.Controls.Add(this.tB_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 183);
            this.panel1.TabIndex = 0;
            // 
            // b_Save
            // 
            this.b_Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Save.Location = new System.Drawing.Point(204, 129);
            this.b_Save.Name = "b_Save";
            this.b_Save.Size = new System.Drawing.Size(80, 29);
            this.b_Save.TabIndex = 6;
            this.b_Save.Text = "&Lưu";
            this.b_Save.UseVisualStyleBackColor = true;
            this.b_Save.Click += new System.EventHandler(this.b_Save_Click);
            // 
            // b_Close
            // 
            this.b_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Close.Location = new System.Drawing.Point(306, 129);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(82, 29);
            this.b_Close.TabIndex = 2;
            this.b_Close.Text = "&Đóng";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // b_Del
            // 
            this.b_Del.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Del.Location = new System.Drawing.Point(104, 129);
            this.b_Del.Name = "b_Del";
            this.b_Del.Size = new System.Drawing.Size(77, 29);
            this.b_Del.TabIndex = 3;
            this.b_Del.Text = "&Xóa";
            this.b_Del.UseVisualStyleBackColor = true;
            this.b_Del.Click += new System.EventHandler(this.b_Del_Click);
            // 
            // b_Add
            // 
            this.b_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Add.Location = new System.Drawing.Point(12, 129);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(72, 29);
            this.b_Add.TabIndex = 1;
            this.b_Add.Text = "&Thêm";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // tB_Name
            // 
            this.tB_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tB_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tB_Name.Location = new System.Drawing.Point(133, 75);
            this.tB_Name.Name = "tB_Name";
            this.tB_Name.Size = new System.Drawing.Size(250, 27);
            this.tB_Name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại hàng";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(77, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC LOẠI HÀNG";
            // 
            // dGV
            // 
            this.dGV.AllowUserToAddRows = false;
            this.dGV.AllowUserToDeleteRows = false;
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGV.Location = new System.Drawing.Point(0, 183);
            this.dGV.Name = "dGV";
            this.dGV.ReadOnly = true;
            this.dGV.RowHeadersWidth = 51;
            this.dGV.RowTemplate.Height = 24;
            this.dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV.Size = new System.Drawing.Size(400, 430);
            this.dGV.TabIndex = 5;
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
            this.label4.Location = new System.Drawing.Point(112, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "*";
            // 
            // Form_C_TypeOfGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(400, 613);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form_C_TypeOfGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục quản lý loại hàng";
            this.Load += new System.EventHandler(this.Form_C_TypeOfGoods_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_Name;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Button b_Del;
        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.Button b_Save;
        private System.Windows.Forms.Label label4;
    }
}
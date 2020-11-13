namespace ShoeStore
{
    partial class Form_LOGIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LOGIN));
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_ForgetPassword = new System.Windows.Forms.Label();
            this.b_Exit = new System.Windows.Forms.Button();
            this.b_Login = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tB_Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tB_UseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.l_ForgetPassword);
            this.panel1.Controls.Add(this.b_Exit);
            this.panel1.Controls.Add(this.b_Login);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 261);
            this.panel1.TabIndex = 0;
            // 
            // l_ForgetPassword
            // 
            this.l_ForgetPassword.AutoSize = true;
            this.l_ForgetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l_ForgetPassword.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ForgetPassword.ForeColor = System.Drawing.Color.Red;
            this.l_ForgetPassword.Location = new System.Drawing.Point(188, 229);
            this.l_ForgetPassword.Name = "l_ForgetPassword";
            this.l_ForgetPassword.Size = new System.Drawing.Size(130, 21);
            this.l_ForgetPassword.TabIndex = 5;
            this.l_ForgetPassword.Text = "Quên mật khẩu?";
            this.l_ForgetPassword.Click += new System.EventHandler(this.l_ForgetPassword_Click);
            // 
            // b_Exit
            // 
            this.b_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Exit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Exit.Location = new System.Drawing.Point(36, 170);
            this.b_Exit.Name = "b_Exit";
            this.b_Exit.Size = new System.Drawing.Size(152, 47);
            this.b_Exit.TabIndex = 4;
            this.b_Exit.Text = "Thoát";
            this.b_Exit.UseVisualStyleBackColor = true;
            this.b_Exit.Click += new System.EventHandler(this.b_Exit_Click);
            // 
            // b_Login
            // 
            this.b_Login.AutoSize = true;
            this.b_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Login.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Login.Location = new System.Drawing.Point(290, 170);
            this.b_Login.Name = "b_Login";
            this.b_Login.Size = new System.Drawing.Size(147, 47);
            this.b_Login.TabIndex = 3;
            this.b_Login.Text = "Đăng nhập";
            this.b_Login.UseVisualStyleBackColor = true;
            this.b_Login.Click += new System.EventHandler(this.b_Login_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tB_Password);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(3, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(461, 54);
            this.panel3.TabIndex = 2;
            // 
            // tB_Password
            // 
            this.tB_Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tB_Password.Location = new System.Drawing.Point(172, 13);
            this.tB_Password.Name = "tB_Password";
            this.tB_Password.Size = new System.Drawing.Size(262, 27);
            this.tB_Password.TabIndex = 2;
            this.tB_Password.UseSystemPasswordChar = true;
            this.tB_Password.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tB_Password_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tB_UseName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 59);
            this.panel2.TabIndex = 1;
            // 
            // tB_UseName
            // 
            this.tB_UseName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tB_UseName.Location = new System.Drawing.Point(172, 14);
            this.tB_UseName.Name = "tB_UseName";
            this.tB_UseName.Size = new System.Drawing.Size(262, 27);
            this.tB_UseName.TabIndex = 1;
            this.tB_UseName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tB_UseName_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(169, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // Form_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(488, 284);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_LOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_LOGIN_FormClosing);
            this.Load += new System.EventHandler(this.Form_LOGIN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_Exit;
        private System.Windows.Forms.Button b_Login;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tB_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_UseName;
        private System.Windows.Forms.Label l_ForgetPassword;
    }
}


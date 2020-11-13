using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShoeStore.GUI;

namespace ShoeStore
{
    public partial class Form_LOGIN : Form
    {
        public Form_LOGIN()
        {
            InitializeComponent();
        }

        private void l_ForgetPassword_Click(object sender, EventArgs e)
        {
            Form_ForgetPassword f = new Form_ForgetPassword(tB_UseName.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void b_Login_Click(object sender, EventArgs e)
        {
            if (tB_UseName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tB_UseName.Focus();
                return;
            }

            if (tB_Password.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tB_Password.Focus();
                return;
            }

            IDEmployee = Class.DataConnection.GetID(tB_UseName.Text.Trim(), tB_Password.Text.Trim());
            if (IDEmployee != "")
            {
                Form_Menu f = new Form_Menu(IDEmployee);
                this.Hide();
                f.ShowDialog();
                this.Show();
                tB_UseName.Text = "";
                tB_Password.Text = "";
            }

            else
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng. Xin hãy nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static string IDEmployee = "";

        private void b_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_LOGIN_Load(object sender, EventArgs e)
        {
            try
            {
                Class.DataConnection.Connect();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                DialogResult re = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form_LOGIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            Class.DataConnection.Disconnect();
        }

        private void tB_UseName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void tB_Password_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}

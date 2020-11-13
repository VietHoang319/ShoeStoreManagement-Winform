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

namespace ShoeStore.GUI
{
    public partial class Form_ForgetPassword : Form
    {
        public Form_ForgetPassword()
        {
            InitializeComponent();
        }

        private void b_Confirm_Click(object sender, EventArgs e)
        {
            String sql;
            sql = "Select CMTND from Employee where CMTND = '" + tB_CMTND.Text.Trim() + "' and Usename = '" + tB_Usename.Text.Trim() + "'";
            try
            {
                if (Class.DataConnection.CheckKey(sql))
                {
                    sql = "Update Employee set Pass = '" + 1 + "' where CMTND = " + tB_CMTND.Text + "";
                    Class.DataConnection.RunSql(sql);
                    MessageBox.Show("Mật khẩu của bạn đã được đổi thành: 1  \n \n Hãy đổi lại mật khẩu khi đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Sai tên đăng nhập hoặc số chứng minh nhân dân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void b_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string _message;

        public Form_ForgetPassword(string Message) : this()
        {
            _message = Message;
            tB_Usename.Text = Message;
        }

        private void tB_Usename_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void tB_CMTND_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}

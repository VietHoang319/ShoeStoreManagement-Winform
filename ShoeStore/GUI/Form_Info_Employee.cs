using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeStore.GUI
{
    public partial class Form_Info_Employee : Form
    {
        public Form_Info_Employee()
        {
            InitializeComponent();
        }

        DataTable DT;

        private void b_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Info_Employee_Load(object sender, EventArgs e)
        {
            tB_Address.Enabled = false;
            tB_CMTND.Enabled = false;
            tB_Nump.Enabled = false;
            tB_Pass.Enabled = false;
            b_Cancel_A.Enabled = false;
            b_Cancel_I.Enabled = false;
            b_Open.Enabled = false;
            b_Save_A.Enabled = false;
            b_Save_I.Enabled = false;
            rB_Famale.Enabled = false;
            rB_Male.Enabled = false;
        }

        public string _message;

        public Form_Info_Employee(string Message) : this()
        {
            _message = Message;
            string sql = "Select * from Employee where IDEmployee = " + Message + "";
            DT = Class.DataConnection.GetDataToTable(sql);
            if (DT != null)
            {
                foreach (DataRow DR in DT.Rows)
                {
                    l_Name.Text = "Họ và tên nhân viên: " + DR["NameEmployee"].ToString();
                    l_Position.Text = "Chức vụ: " + DR["Position"].ToString();
                    l_Usename.Text = "Tên đăng nhập: " + DR["UseName"].ToString();
                    tB_Address.Text = DR["AddressEmployee"].ToString();
                    tB_Nump.Text = DR["NumpEmployee"].ToString();
                    tB_CMTND.Text = DR["CMTND"].ToString();
                    tB_Pass.Text = DR["Pass"].ToString();
                    tB_Picture.Text = DR["Picture"].ToString();
                    if (DR["Sex"].ToString() == "Nam")
                        rB_Male.Checked = true;
                    else rB_Famale.Checked = true;
                    if (tB_Picture.Text.Length > 0)
                        pB.Image = Image.FromFile(tB_Picture.Text);
                    else pB.Image = null;
                }
            }
        }

        private void b_Update_Info_Click(object sender, EventArgs e)
        {
            tB_Address.Enabled = true;
            tB_CMTND.Enabled = true;
            tB_Nump.Enabled = true;
            b_Cancel_I.Enabled = true;
            b_Open.Enabled = true;
            b_Save_I.Enabled = true;
            b_Update_Info.Enabled = false;
            b_UpdateAcc.Enabled = false;
            rB_Famale.Enabled = true;
            rB_Male.Enabled = true;
        }

        private void b_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Bitmap (*.bmp)|*.bmp|JPEG(*.jpg)|*jpg|GIF(*gif)|*gif|All files(*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.Title = "Chọn ảnh minh họa cho sản phẩm";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pB.Image = Image.FromFile(openFileDialog.FileName);
                tB_Picture.Text = openFileDialog.FileName;
            }
        }

        private void b_Save_I_Click(object sender, EventArgs e)
        {
            string gt, sql;

            if (tB_CMTND.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập chứng minh thư của bạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_CMTND.Focus();
                return;
            }

            if (rB_Male.Checked == true && rB_Famale.Checked == false)
            {
                gt = "Nam";
            }
            else gt = "Nữ";

            sql = "Update Employee set AddressEmployee = N'" + tB_Address.Text.Trim() + "', Sex = N'" + gt + "', CMTND = '" + tB_CMTND.Text.Trim() + "', Picture = N'"
                + tB_Picture.Text.Trim() + "', NumpEmployee = '" + tB_Nump.Text.Trim() + "' where IDEmployee = " + _message + "";
            Class.DataConnection.RunSql(sql);
            tB_Address.Enabled = false;
            tB_CMTND.Enabled = false;
            tB_Nump.Enabled = false;
            tB_Pass.Enabled = false;
            b_Cancel_I.Enabled = false;
            b_Open.Enabled = false;
            b_UpdateAcc.Enabled = true;
            b_Update_Info.Enabled = true;
            b_Save_I.Enabled = false;
            rB_Famale.Enabled = false;
            rB_Male.Enabled = false;
        }

        private void b_Cancel_I_Click(object sender, EventArgs e)
        {
            tB_Address.Enabled = false;
            tB_CMTND.Enabled = false;
            tB_Nump.Enabled = false;
            tB_Pass.Enabled = false;
            b_Cancel_A.Enabled = false;
            b_Cancel_I.Enabled = false;
            b_Open.Enabled = false;
            b_Save_A.Enabled = false;
            b_Save_I.Enabled = false;
            rB_Famale.Enabled = false;
            rB_Male.Enabled = false;
            b_UpdateAcc.Enabled = true;
            b_Update_Info.Enabled = true;
        }

        private void b_Cancel_A_Click(object sender, EventArgs e)
        {
            tB_Address.Enabled = false;
            tB_CMTND.Enabled = false;
            tB_Nump.Enabled = false;
            tB_Pass.Enabled = false;
            b_Cancel_A.Enabled = false;
            b_Cancel_I.Enabled = false;
            b_Open.Enabled = false;
            b_Save_A.Enabled = false;
            b_Save_I.Enabled = false;
            rB_Famale.Enabled = false;
            rB_Male.Enabled = false;
            b_UpdateAcc.Enabled = true;
            b_Update_Info.Enabled = true;
        }

        private void b_UpdateAcc_Click(object sender, EventArgs e)
        {
            tB_Pass.Enabled = true;
            b_UpdateAcc.Enabled = false;
            b_Update_Info.Enabled = false;
            b_Save_A.Enabled = true;
            b_Cancel_A.Enabled = true;
        }

        private void b_Save_A_Click(object sender, EventArgs e)
        {
            string sql;

            if (tB_Pass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu của bạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_Pass.Focus();
                return;
            }

            sql = "Update Employee set Pass = '" + tB_Pass.Text.Trim() + "' where IDEmployee = " + _message + "";
            Class.DataConnection.RunSql(sql);
            tB_Pass.Enabled = false;
            b_UpdateAcc.Enabled = true;
            b_Update_Info.Enabled = true;
            b_Save_A.Enabled = false;
            b_Cancel_A.Enabled = false;
        }
    }
}

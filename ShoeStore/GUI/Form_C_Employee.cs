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
    public partial class Form_C_Employee : Form
    {
        public Form_C_Employee()
        {
            InitializeComponent();
        }

        DataTable DT;

        private void Form_C_Employee_Load(object sender, EventArgs e)
        {
            tB_Name.Enabled = false;
            tB_Address.Enabled = false;
            tB_CMND.Enabled = false;
            tB_Nump.Enabled = false;
            tB_Pass.Enabled = false;
            tB_Position.Enabled = false;
            tB_Usename.Enabled = false;
            b_Open.Enabled = false;
            b_Out.Enabled = false;
            b_Save.Enabled = false;
            rB_Famale.Enabled = false;
            rB_Male.Enabled = false;
            b_Upd.Enabled = false;
            b_Del.Enabled = false;
            ResetValues();
            LoadDGV();
        }

        private void LoadDGV()
        {
            string query;
            query = "Select IDEmployee as [Mã nhân viên], NameEmployee as [Tên nhân viên], AddressEmployee as [Địa chỉ], Sex as [Giới tính], CMTND as [Chứng minh thư], Picture as [Hình ảnh], NumpEmployee as [Số điện thoại], Usename as [Tên đăng nhập], Pass as [Mật khẩu], Position as [Chức vụ] from Employee";
            DT = Class.DataConnection.GetDataToTable(query);
            dGV.DataSource = DT;
        }

        private string GiveNextIDEmployee()
        {
            string query;
            query = "Select Max(IDEmployee) from Employee";
            DT = Class.DataConnection.GetDataToTable(query);
            try
            {
                return ((int)DT.Rows[0][0] + 1).ToString();
            }
            catch
            {
                return "0";
            }
        }

        private void ResetValues()
        {
            tB_Address.Text = "";
            tB_CMND.Text = "";
            tB_ID.Text = "";
            tB_Name.Text = "";
            tB_Nump.Text = "";
            tB_Pass.Text = "";
            tB_Pict.Text = "";
            tB_Position.Text = "";
            tB_Usename.Text = "";
            pB.Image = null;
            rB_Famale.Checked = false;
            rB_Male.Checked = false;
        }

        private void dGV_Click(object sender, EventArgs e)
        {
            if (b_Add.Enabled == false)
            {
                MessageBox.Show("Bạn đang ở trạng thái thêm mới.", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tB_Name.Focus();
                return;
            }

            if (DT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            tB_ID.Text = dGV.CurrentRow.Cells["Mã nhân viên"].Value.ToString();
            tB_Name.Text = dGV.CurrentRow.Cells["Tên nhân viên"].Value.ToString();
            if (dGV.CurrentRow.Cells["Giới tính"].Value.ToString() == "Nam")
                rB_Male.Checked = true;
            else rB_Famale.Checked = true;
            tB_Address.Text = dGV.CurrentRow.Cells["Địa chỉ"].Value.ToString();
            tB_Position.Text = dGV.CurrentRow.Cells["Chức vụ"].Value.ToString();
            tB_Nump.Text = dGV.CurrentRow.Cells["Số điện thoại"].Value.ToString();
            tB_CMND.Text = dGV.CurrentRow.Cells["Chứng minh thư"].Value.ToString();
            tB_Pict.Text = dGV.CurrentRow.Cells["Hình ảnh"].Value.ToString();
            tB_Usename.Text = dGV.CurrentRow.Cells["Tên đăng nhập"].Value.ToString();
            tB_Pass.Text = dGV.CurrentRow.Cells["Mật khẩu"].Value.ToString();
            if (tB_Pict.Text.Length > 0)
                pB.Image = Image.FromFile(tB_Pict.Text);
            else pB.Image = null;
            b_Upd.Enabled = true;
            b_Del.Enabled = true;
            b_Out.Enabled = true;
            b_Open.Enabled = true;
            tB_Name.Enabled = false;
            tB_Address.Enabled = true;
            tB_CMND.Enabled = false;
            tB_Nump.Enabled = true;
            tB_Pass.Enabled = true;
            tB_Position.Enabled = true;
            tB_Usename.Enabled = true;
            rB_Famale.Enabled = true;
            rB_Male.Enabled = true;
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            tB_Name.Enabled = true;
            tB_Address.Enabled = true;
            tB_CMND.Enabled = true;
            tB_Nump.Enabled = true;
            tB_Pass.Enabled = true;
            tB_Position.Enabled = true;
            tB_Usename.Enabled = true;
            b_Open.Enabled = true;
            b_Out.Enabled = true;
            b_Save.Enabled = true;
            rB_Famale.Enabled = true;
            rB_Male.Enabled = true;
            b_Upd.Enabled = false;
            b_Del.Enabled = false;
            ResetValues();
            tB_ID.Text = GiveNextIDEmployee();
        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tB_Name.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_Name.Focus();
                return;
            }

            if (tB_CMND.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập số CMTND của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_CMND.Focus();
                return;
            }

            if (rB_Famale.Checked == false && rB_Male.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rB_Male.Checked == true && rB_Famale.Checked == false)
            {
                gt = "Nam";
            }
            else gt = "Nữ";

            sql = "Select CMTND from Employee where CMTND = " + tB_CMND.Text.Trim() + "";
            if (Class.DataConnection.CheckKey(sql))
            {
                MessageBox.Show("Nhân viên này đã có sẵn.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            sql = "Select Usename from Employee where Usename = '" + tB_Usename.Text.Trim() + "'";
            if (Class.DataConnection.CheckKey(sql))
            {
                MessageBox.Show("Tài khoản này đã có sẵn.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tB_Usename.Focus();
                return;
            }

            sql = "Insert into Employee(NameEmployee, AddressEmployee, Sex, CMTND, Picture, NumpEmployee, Usename, Pass, Position) values(N'" + tB_Name.Text.Trim() + "', N'" + tB_Address.Text.Trim() + "', N'" + gt + "', '"
                + tB_CMND.Text.Trim() + "', N'" + tB_Pict.Text + "', '" + tB_Nump.Text.Trim() + "', '" + tB_Usename.Text.Trim() + "', '" + tB_Pass.Text.Trim() + "', N'" + tB_Position.Text.Trim() + "')";

            Class.DataConnection.RunSql(sql);
            LoadDGV();
            ResetValues();
            tB_Name.Enabled = false;
            tB_Address.Enabled = false;
            tB_CMND.Enabled = false;
            tB_Nump.Enabled = false;
            tB_Pass.Enabled = false;
            tB_Position.Enabled = false;
            tB_Usename.Enabled = false;
            b_Open.Enabled = false;
            b_Out.Enabled = false;
            b_Save.Enabled = false;
            rB_Famale.Enabled = false;
            rB_Male.Enabled = false;
            b_Upd.Enabled = false;
            b_Del.Enabled = false;
            b_Add.Enabled = true;
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
                tB_Pict.Text = openFileDialog.FileName;
            }
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_Upd_Click(object sender, EventArgs e)
        {
            string sql, gt;

            if (tB_Name.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_Name.Focus();
                return;
            }

            if (tB_CMND.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập chứng minh thư của nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_CMND.Focus();
                return;
            }

            if (rB_Male.Checked == true && rB_Famale.Checked == false)
            {
                gt = "Nam";
            }
            else gt = "Nữ";

            sql = "Update Employee set NameEmployee = N'" + tB_Name.Text.Trim() + "', AddressEmployee = N'" + tB_Address.Text.Trim() + "', Sex = N'" + gt + "', CMTND = '"
                + tB_CMND.Text.Trim() + "', Picture = N'" + tB_Pict.Text.Trim() + "', NumpEmployee = '" + tB_Nump.Text.Trim() + "', Usename = '" + tB_Usename.Text.Trim() + "', Pass = '"
                + tB_Pass.Text.Trim() + "', Position = N'" + tB_Position.Text.Trim() + "' where IDEmployee = " + tB_ID.Text + "";
            Class.DataConnection.RunSql(sql);
            LoadDGV();
            ResetValues();
            tB_Name.Enabled = false;
            tB_Address.Enabled = false;
            tB_CMND.Enabled = false;
            tB_Nump.Enabled = false;
            tB_Pass.Enabled = false;
            tB_Position.Enabled = false;
            tB_Usename.Enabled = false;
            b_Open.Enabled = false;
            b_Out.Enabled = false;
            b_Save.Enabled = false;
            rB_Famale.Enabled = false;
            rB_Male.Enabled = false;
            b_Upd.Enabled = false;
            b_Del.Enabled = false;
        }

        private void b_Del_Click(object sender, EventArgs e)
        {
            string sql;

            if (MessageBox.Show("bạn có muốn xóa nhân viên này hay không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete Employee where IDEmployee = '" + tB_ID.Text + "'";
                Class.DataConnection.RunSqlDel(sql);
                LoadDGV();
                ResetValues();
            }

            tB_Name.Enabled = false;
            tB_Address.Enabled = false;
            tB_CMND.Enabled = false;
            tB_Nump.Enabled = false;
            tB_Pass.Enabled = false;
            tB_Position.Enabled = false;
            tB_Usename.Enabled = false;
            b_Open.Enabled = false;
            b_Out.Enabled = false;
            b_Save.Enabled = false;
            rB_Famale.Enabled = false;
            rB_Male.Enabled = false;
            b_Upd.Enabled = false;
            b_Del.Enabled = false;
        }

        private void dGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void b_Out_Click(object sender, EventArgs e)
        {
            ResetValues();
            tB_Name.Enabled = false;
            tB_Address.Enabled = false;
            tB_CMND.Enabled = false;
            tB_Nump.Enabled = false;
            tB_Pass.Enabled = false;
            tB_Position.Enabled = false;
            tB_Usename.Enabled = false;
            b_Open.Enabled = false;
            b_Out.Enabled = false;
            b_Save.Enabled = false;
            rB_Famale.Enabled = false;
            rB_Male.Enabled = false;
            b_Upd.Enabled = false;
            b_Del.Enabled = false;
            b_Add.Enabled = true;
        }
    }
}

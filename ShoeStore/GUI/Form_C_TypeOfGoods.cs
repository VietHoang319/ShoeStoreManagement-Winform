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
    public partial class Form_C_TypeOfGoods : Form
    {
        public Form_C_TypeOfGoods()
        {
            InitializeComponent();
        }

        DataTable DT;

        private void Form_C_TypeOfGoods_Load(object sender, EventArgs e)
        {
            tB_Name.Enabled = false;
            b_Del.Enabled = false;
            b_Save.Enabled = false;
            LoadDGV();
        }

        private void LoadDGV()
        {
            string query = "Select NameTOGs as [Tên loại hàng] from TOGs";
            DT = Class.DataConnection.GetDataToTable(query);
            dGV.DataSource = DT;
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

            b_Del.Enabled = true;

            tB_Name.Text = dGV.CurrentRow.Cells["Tên loại hàng"].Value.ToString();
        }

        private void ResetValues()
        {
            tB_Name.Text = "";
            b_Del.Enabled = false;
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            b_Del.Enabled = false;
            b_Save.Enabled = true;
            ResetValues();
            tB_Name.Enabled = true;
            tB_Name.Focus();
        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            string sql;
            if (tB_Name.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên loại hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_Name.Focus();
                return;
            }

            sql = "Select NameTOGs from TOGs where NameTOGs = N'" + tB_Name.Text.Trim() + "'";

            if (Class.DataConnection.CheckKey(sql))
            {
                MessageBox.Show("Loại hàng này đã có sẵn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tB_Name.Focus();
                return;
            }

            sql = "Insert into TOGs(NameTOGs) values (N'" + tB_Name.Text.Trim() + "')";
            Class.DataConnection.RunSql(sql);   //Thực hiện câu lệnh sql.
            LoadDGV(); //Cập nhật lại DataGridView.
            ResetValues();
            b_Add.Enabled = true;
            tB_Name.Enabled = false;
            b_Save.Enabled = false;
            b_Del.Enabled = false;
        }

        private void b_Del_Click(object sender, EventArgs e)
        {
            string sql;
            if (DT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Nếu chưa chọn bản ghi nào.
            if (tB_Name.Text == "")
            {
                MessageBox.Show("Không có bản ghi trong bộ nhớ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("bạn có muốn xóa hay không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete TOGs where NameTOGs = N'" + tB_Name.Text + "'";
                Class.DataConnection.RunSqlDel(sql);
                LoadDGV();
                ResetValues();
            }
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

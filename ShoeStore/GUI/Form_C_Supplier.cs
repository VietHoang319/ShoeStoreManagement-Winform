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
    public partial class Form_C_Supplier : Form
    {
        public Form_C_Supplier()
        {
            InitializeComponent();
        }

        DataTable DT;

        private void Form_C_Supplier_Load(object sender, EventArgs e)
        {
            tB_Name.Enabled = false;
            tB_Address.Enabled = false;
            tB_Nump.Enabled = false;
            tB_Web.Enabled = false;
            b_Save.Enabled = false;
            b_Del.Enabled = false;
            b_Upd.Enabled = false;
            LoadDGV(); //Hiển thị danh sách nhà cung cấp
        }

        private void LoadDGV()
        {
            string query = "Select NameSupp as [Tên nhà cung cấp], AddressSupp as [Địa chỉ], NumpSupp as [Số điện thoại], WebSupp as [Website] from Supplier";
            DT = Class.DataConnection.GetDataToTable(query);
            dGV.DataSource = DT;
        }

        private void dGV_Click(object sender, EventArgs e)
        {
            if(b_Add.Enabled == false)
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

            tB_Name.Text = dGV.CurrentRow.Cells["Tên nhà cung cấp"].Value.ToString();
            tB_Address.Text = dGV.CurrentRow.Cells["Địa chỉ"].Value.ToString();
            tB_Nump.Text = dGV.CurrentRow.Cells["Số điện thoại"].Value.ToString();
            tB_Web.Text = dGV.CurrentRow.Cells["Website"].Value.ToString();

            b_Upd.Enabled = true;
            b_Del.Enabled = true;
            tB_Address.Enabled = true;
            tB_Nump.Enabled = true;
            tB_Web.Enabled = true;
        }

        private void ResetValues()
        {
            tB_Name.Text = "";
            tB_Address.Text = "";
            tB_Nump.Text = "";
            tB_Web.Text = "";
            b_Del.Enabled = false;
            b_Upd.Enabled = false;
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            b_Del.Enabled = false;
            b_Upd.Enabled = false;
            b_Save.Enabled = true;
            b_Add.Enabled = false;
            ResetValues();
            tB_Name.Enabled = true;
            tB_Address.Enabled = true;
            tB_Nump.Enabled = true;
            tB_Web.Enabled = true;
            tB_Name.Focus();
        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            string sql;
            if (tB_Name.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_Name.Focus();
                return;
            }

            sql = "Select NameSupp from Supplier where NameSupp = N'" + tB_Name.Text.Trim() + "'";

            if (Class.DataConnection.CheckKey(sql))
            {
                MessageBox.Show("Nhà cung cấp này đã có sẵn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tB_Name.Focus();
                return;
            }

            sql = "Insert into Supplier(NameSupp, AddressSupp, NumpSupp, WebSupp) values (N'" + tB_Name.Text + "', N'" + tB_Address.Text + "', '" + tB_Nump.Text + "', '" + tB_Web.Text + "')";
            Class.DataConnection.RunSql(sql);   //Thực hiện câu lệnh sql.
            LoadDGV(); //Cập nhật lại DataGridView.
            ResetValues();
            b_Add.Enabled = true;
            tB_Name.Enabled = false;
            tB_Address.Enabled = false;
            tB_Nump.Enabled = false;
            tB_Web.Enabled = false;
            b_Save.Enabled = false;
            b_Del.Enabled = false;
            b_Upd.Enabled = false;
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
                sql = "Delete Supplier where NameSupp = N'" + tB_Name.Text + "'";
                Class.DataConnection.RunSqlDel(sql);
                LoadDGV();
                ResetValues();
            }
        }

        private void b_Upd_Click(object sender, EventArgs e)
        {
            string sql;
            if (DT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tB_Name.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tB_Name.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_Name.Focus();
                return;
            }

            sql = "Update Supplier set AddressSupp = N'" + tB_Address.Text.Trim().ToString() + "', NumpSupp =  '" + tB_Nump.Text.Trim().ToString() + "', WebSupp = '" 
                + tB_Web.Text.Trim().ToString() + "' where NameSupp = N'" + tB_Name.Text.Trim().ToString() + "'";
            Class.DataConnection.RunSql(sql);
            LoadDGV();
            ResetValues();
            tB_Address.Enabled = false;
            tB_Nump.Enabled = false;
            tB_Web.Enabled = false;
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

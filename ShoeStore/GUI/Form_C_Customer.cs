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
    public partial class Form_C_Customer : Form
    {
        public Form_C_Customer()
        {
            InitializeComponent();
        }

        DataTable DT;

        private void Form_C_Customer_Load(object sender, EventArgs e)
        {
            tB_Name.Enabled = false;
            tB_Address.Enabled = false;
            tB_CMND.Enabled = false;
            tB_Nump.Enabled = false;
            tB_Note.Enabled = false;
            b_Out.Enabled = false;
            b_Save.Enabled = false;
            b_Upd.Enabled = false;
            b_Del.Enabled = false;
            ResetValues();
            LoadDGV();
        }

        private void LoadDGV()
        {
            string query = "Select IDCus as [Mã khách hàng], NameCus as [Tên khách hàng], AddressCus as [Địa chỉ], NumpCus as [Số điện thoại], CMTND as [Chứng minh thư], Note as [Ghi chú] from Customer";
            DT = Class.DataConnection.GetDataToTable(query);
            dGV.DataSource = DT;
        }

        private void ResetValues()
        {
            tB_Name.Text = "";
            tB_Address.Text = "";
            tB_CMND.Text = "";
            tB_Nump.Text = "";
            tB_Note.Text = "";
            tB_ID.Text = "";
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

            tB_ID.Text = dGV.CurrentRow.Cells["Mã khách hàng"].Value.ToString();
            tB_Name.Text = dGV.CurrentRow.Cells["Tên khách hàng"].Value.ToString();
            tB_CMND.Text = dGV.CurrentRow.Cells["Chứng minh thư"].Value.ToString();
            tB_Nump.Text = dGV.CurrentRow.Cells["Số điện thoại"].Value.ToString();
            tB_Note.Text = dGV.CurrentRow.Cells["Ghi chú"].Value.ToString();
            tB_Address.Text = dGV.CurrentRow.Cells["Địa chỉ"].Value.ToString();
            b_Upd.Enabled = true;
            b_Del.Enabled = true;
            b_Out.Enabled = true;
            tB_Name.Enabled = true;
            tB_Address.Enabled = true;
            tB_CMND.Enabled = true;
            tB_Nump.Enabled = true;
            tB_Note.Enabled = true;
        }

        private string GiveNextIDCustomer()
        {
            string query;
            query = "Select Max(IDCus) from Customer";
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

        private void b_Add_Click(object sender, EventArgs e)
        {
            tB_Name.Enabled = true;
            tB_Address.Enabled = true;
            tB_CMND.Enabled = true;
            tB_Nump.Enabled = true;
            tB_Note.Enabled = true;
            b_Out.Enabled = true;
            b_Upd.Enabled = false;
            b_Del.Enabled = false;
            b_Save.Enabled = true;
            ResetValues();
            tB_ID.Text = GiveNextIDCustomer();
        }

        private void b_Upd_Click(object sender, EventArgs e)
        {
            string sql;
            if (tB_Name.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_Name.Focus();
                return;
            }

            if (tB_Nump.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại của khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_CMND.Focus();
                return;
            }

            sql = "Update Customer set NameCus = N'" + tB_Name.Text.Trim() + "', AddressCus = N'" + tB_Address.Text.Trim() + "', Note = N'" + tB_Note.Text.Trim() + "', CMTND = '"
                + tB_CMND.Text.Trim() + "', NumpCus = '" + tB_Nump.Text.Trim() + "'";
            Class.DataConnection.RunSql(sql);
            LoadDGV();
            ResetValues();
            tB_Name.Enabled = false;
            tB_Address.Enabled = false;
            tB_CMND.Enabled = false;
            tB_Nump.Enabled = false;
            tB_Note.Enabled = false;
            b_Out.Enabled = false;
            b_Save.Enabled = false;
            b_Upd.Enabled = false;
            b_Del.Enabled = false;
        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            string sql;
            if (tB_Name.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_Name.Focus();
                return;
            }

            if (tB_Nump.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại của khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_Nump.Focus();
                return;
            }

            sql = "Select NameCus, NumpCus from Customer where NameCus = N'" + tB_Name.Text.Trim() + "' and NumpCus = '" + tB_Nump.Text.Trim() + "'";
            if (Class.DataConnection.CheckKey(sql))
            {
                MessageBox.Show("Tên khách hàng này đã có sẵn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sql = "Insert into Customer(NameCus, AddressCus, Note, CMTND, NumpCus) values(N'" + tB_Name.Text.Trim() + "', N'" + tB_Address.Text.Trim() + "', N'" + tB_Note.Text.Trim() + "', '"
                + tB_CMND.Text.Trim() + "', '" + tB_Nump.Text.Trim() + "')";

            Class.DataConnection.RunSql(sql);
            LoadDGV();
            ResetValues();
            tB_Name.Enabled = false;
            tB_Address.Enabled = false;
            tB_CMND.Enabled = false;
            tB_Nump.Enabled = false;
            tB_Note.Enabled = false;
            b_Out.Enabled = false;
            b_Save.Enabled = false;
            b_Upd.Enabled = false;
            b_Del.Enabled = false;
            b_Add.Enabled = true;
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_Del_Click(object sender, EventArgs e)
        {
            string sql;

            if (MessageBox.Show("bạn có muốn xóa khách hàng này hay không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete Customer where IDCus = '" + tB_ID.Text + "'";
                Class.DataConnection.RunSqlDel(sql);
                LoadDGV();
                ResetValues();
            }

            tB_Name.Enabled = false;
            tB_Address.Enabled = false;
            tB_CMND.Enabled = false;
            tB_Nump.Enabled = false;
            tB_Note.Enabled = false;
            b_Out.Enabled = false;
            b_Save.Enabled = false;
            b_Upd.Enabled = false;
            b_Del.Enabled = false;
        }

        private void b_Out_Click(object sender, EventArgs e)
        {
            ResetValues();
            tB_Name.Enabled = false;
            tB_Address.Enabled = false;
            tB_CMND.Enabled = false;
            tB_Nump.Enabled = false;
            tB_Note.Enabled = false;
            b_Out.Enabled = false;
            b_Save.Enabled = false;
            b_Upd.Enabled = false;
            b_Del.Enabled = false;
            b_Add.Enabled = true;
        }
    }
}

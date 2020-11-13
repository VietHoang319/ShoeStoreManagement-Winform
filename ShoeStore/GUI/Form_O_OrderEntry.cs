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
    public partial class Form_O_OrderEntry : Form
    {
        public Form_O_OrderEntry()
        {
            InitializeComponent();
        }

        DataTable DT;

        private void Form_O_OrderEntry_Load(object sender, EventArgs e)
        {
            LoadDGV();
            Update_cB_Product();
            Update_cB_Employee();
            b_Add.Enabled = true;
            b_Enter.Enabled = false;
            B_CencelEntry.Enabled = false;
            tB_TNOP.Enabled = false;
            cB_Employee.Enabled = false;
            cB_Product.Enabled = false;
            tB_EntryPrice.Enabled = false;
        }

        private void LoadDGV()
        {
            string query;
            query = "Select EntryLineItem.IDProduct as [Mã sản phẩm], NameProduct as [Tên sản phẩm], NameSupp as [Nhà cung cấp], EntryNumber as [Số lượng], EntryPrice as [Giá nhập], IntoMoney as [Thành tiền] from Supplier, EntryLineItem, Product " +
                "where Supplier.IDSupp = Product.IDSupp and Product.IDProduct = EntryLineItem.IDProduct and IDOE = N'" + tB_ID.Text + "'";
            DT = Class.DataConnection.GetDataToTable(query);
            dGV.DataSource = DT;
        }

        private void Update_cB_Product()
        {
            string query;
            query = "select IDProduct from Product";
            Class.DataConnection.FillCombo(query, cB_Product, "IDProduct", "IDProduct");
            cB_Product.SelectedIndex = -1;
        }

        private void Update_cB_Employee()
        {
            string query;
            query = "Select IDEmployee, NameEmployee From Employee";
            Class.DataConnection.FillCombo(query, cB_Employee, "IDEmployee", "NameEmployee");
            cB_Employee.SelectedIndex = -1;
        }

        private void ResetValues()
        {
            tB_ID.Text = "";
            cB_Product.Text = "";
            tB_NameP.Text = "";
            tB_Supp.Text = "";
            cB_Employee.Text = "";
            tB_Date.Text = DateTime.Now.ToShortDateString();
            tB_IntoMoney.Text = "";
            tB_TNOP.Text = "";
            tB_Total.Text = "0";
            tB_EntryPrice.Text = "";
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            ResetValues();
            b_Add.Enabled = false;
            b_Enter.Enabled = true;
            cB_Employee.Enabled = true;
            cB_Product.Enabled = true;
            tB_EntryPrice.Enabled = true;
            tB_TNOP.Enabled = true;
            tB_ID.Text = Class.DataConnection.CreateKey("HDN");
            LoadDGV();
        }

        private void cB_Product_TextChanged(object sender, EventArgs e)
        {
            string str;
            if (cB_Product.Text == "")
            {
                tB_Supp.Text = "";
                tB_NameP.Text = "";
            }

            str = "Select NameSupp from Product, Supplier where Supplier.IDSupp = Product.IDSupp and IDProduct = '" + cB_Product.Text + "'";
            tB_Supp.Text = Class.DataConnection.GetFieldValues(str);
            str = "Select NameProduct from Product where IDProduct = '" + cB_Product.Text + "'";
            tB_NameP.Text = Class.DataConnection.GetFieldValues(str);
        }

        private void b_Enter_Click(object sender, EventArgs e)
        {
            string sql, querry;
            double sl, slthem, tong, tongmoi;
            sql = "Select IDOE from OrderEntry where IDOE = N'" + tB_EntryPrice.Text + "'";
            if (!Class.DataConnection.CheckKey(sql))
            {
                if (tB_Date.Text.Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập ngày nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tB_Date.Focus();
                    return;
                }

                if (cB_Employee.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa chọn nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cB_Employee.Focus();
                    return;
                }

                sql = "Insert into OrderEntry(IDOE, IDEmployee, DateEntry, TotalAmount) Values(N'" + tB_ID.Text.Trim() + "', " + cB_Employee.SelectedValue + ", '"
                    + Class.DataConnection.ConvertDateTime(tB_Date.Text.Trim()) + "', " + tB_Total.Text.Trim() + ")";
                Class.DataConnection.RunSql(sql);
            }

            if (cB_Product.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm cần thêm.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cB_Product.Focus();
                return;
            }

            if ((tB_TNOP.Text.Trim().Length == 0) || (tB_TNOP.Text.Trim() == "0"))
            {
                MessageBox.Show("Bạn chưa nhập số lượng sản phẩm cần thêm.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tB_TNOP.Focus();
                return;
            }

            if (tB_EntryPrice.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập giá sản phẩm cần thêm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tB_EntryPrice.Focus();
                return;
            }

            sql = "Select IDProduct from EntryLineItem where IDProduct = '" + cB_Product.SelectedValue + "' and IDOE = N'" + tB_ID.Text + "'";
            if (Class.DataConnection.CheckKey(sql))
            {
                MessageBox.Show("Sản phẩm này đã có, bạn phải lựa chọn sản phẩm khác.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesP();
                cB_Product.Focus();
                return;
            }

            sl = Convert.ToDouble(Class.DataConnection.GetFieldValues("Select TNOP from Product where IDProduct = '" + cB_Product.SelectedValue + "'"));

            sql = "Insert into EntryLineItem(IDOE, IDProduct, EntryNumber,IntoMoney) Values(N'" + tB_ID.Text.Trim() + "', '" + cB_Product.SelectedValue + "', "
                 + tB_TNOP.Text.Trim() + "," + tB_IntoMoney.Text.Trim() + ")";
            Class.DataConnection.RunSql(sql);
            LoadDGV();

            querry = "Update Product set EntryPrice = " + tB_EntryPrice.Text.Trim() + " where IDProduct = '" + cB_Product.SelectedValue + "'";
            Class.DataConnection.RunSql(querry);
            LoadDGV();

            //Cập nhật lại số lượng sản phẩm
            slthem = sl + Convert.ToDouble(tB_TNOP.Text);
            sql = "Update Product set TNOP = " + slthem + " where IDProduct = '" + cB_Product.SelectedValue + "'";
            Class.DataConnection.RunSql(sql);

            tong = Convert.ToDouble(Class.DataConnection.GetFieldValues("Select TotalAmount from OrderEntry where IDOE = N'" + tB_ID.Text + "'"));
            tongmoi = tong + Convert.ToDouble(tB_IntoMoney.Text);
            sql = "Update OrderEntry set TotalAmount = " + tongmoi + " where IDOE = N'" + tB_ID.Text + "'";
            Class.DataConnection.RunSql(sql);
            tB_Total.Text = tongmoi.ToString();

            sql = "Update Product set EntryPrice = " + tB_IntoMoney.Text.Trim() + " where IDProduct = '" + cB_Product.SelectedValue + "'";
            Class.DataConnection.RunSql(sql);
            tB_Total.Text = tongmoi.ToString();
            ResetValuesP();
            b_Add.Enabled = true;
            B_CencelEntry.Enabled = true;
        }

        private void ResetValuesP()
        {
            cB_Product.Text = "";
            tB_Supp.Text = "";
            tB_TNOP.Text = "";
            tB_IntoMoney.Text = "";
            tB_EntryPrice.Text = "";
            tB_NameP.Text = "";
        }

        private void tB_TNOP_TextChanged(object sender, EventArgs e)
        {
            double sl, dg, tt;
            if (tB_TNOP.Text == "")
            {
                sl = 0;
            }
            else
                sl = Convert.ToDouble(tB_TNOP.Text);

            if (tB_EntryPrice.Text == "")
            {
                dg = 0;
            }
            else
                dg = Convert.ToDouble(tB_EntryPrice.Text);

            tt = sl * dg;
            tB_IntoMoney.Text = tt.ToString();
        }

        private void tB_EntryPrice_TextChanged(object sender, EventArgs e)
        {
            double sl, dg, tt;
            if (tB_TNOP.Text == "")
            {
                sl = 0;
            }
            else
                sl = Convert.ToDouble(tB_TNOP.Text);

            if (tB_EntryPrice.Text == "")
            {
                dg = 0;
            }
            else
                dg = Convert.ToDouble(tB_EntryPrice.Text);

            tt = sl * dg;
            tB_IntoMoney.Text = tt.ToString();
        }

        private void dGV_DoubleClick(object sender, EventArgs e)
        {
            string maspxoa, sql;
            Double thanhtienxoa, slxoa, sl, slcon, tong, tongmoi;
            if (DT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                maspxoa = dGV.CurrentRow.Cells["Mã sản phẩm"].Value.ToString();
                slxoa = Convert.ToDouble(dGV.CurrentRow.Cells["Số lượng"].Value.ToString());
                thanhtienxoa = Convert.ToDouble(dGV.CurrentRow.Cells["Thành tiền"].Value.ToString());
                sql = "Delete EntryLineItem where IDOE = N'" + tB_ID.Text + "' and IDProduct = '" + maspxoa + "'";
                Class.DataConnection.RunSql(sql);

                //Cập nhật lại số lượng của các sản phẩm
                sl = Convert.ToDouble(Class.DataConnection.GetFieldValues("Select TNOP from Product where IDProduct = '" + maspxoa + "'"));
                slcon = sl - slxoa;
                sql = "Update Product set TNOP = " + slcon + " where IDProduct = '" + maspxoa + "'";
                Class.DataConnection.RunSql(sql);

                //Cập nhật lại tổng tiền trong đơn hàng
                tong = Convert.ToDouble(Class.DataConnection.GetFieldValues("Select TotalAmount from OrderEntry where IDOE = N'" + tB_ID.Text + "'"));
                tongmoi = tong - thanhtienxoa;
                sql = "Update OrderEntry set TotalAmount = " + tongmoi + " where IDOE = N'" + tB_ID.Text + "'";
                Class.DataConnection.RunSql(sql);
                tB_Total.Text = tongmoi.ToString();
                LoadDGV();
            }
        }

        private void B_CencelEntry_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy đơn không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "Select IDProduct, EntryNumber from EntryLineItem where IDOE = N'" + tB_ID.Text + "'";
                DataTable DT_DHN_SP = Class.DataConnection.GetDataToTable(sql);
                for (int sp = 0; sp <= DT_DHN_SP.Rows.Count - 1; sp++)
                {
                    //Cập nhật lại số lượng các mặt hàng.
                    sl = Convert.ToDouble(Class.DataConnection.GetFieldValues("Select TNOP from Product where IDProduct = '" + DT_DHN_SP.Rows[sp][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(DT_DHN_SP.Rows[sp][1].ToString());
                    slcon = sl - slxoa;
                    sql = "Update Product set TNOP = " + slcon + " where IDProduct = '" + DT_DHN_SP.Rows[sp][0].ToString() + "'";
                    Class.DataConnection.RunSql(sql);
                }

                //Xóa chi tiết đơn hàng
                sql = "Delete EntryLineItem where IDOE = N'" + tB_ID.Text + "'";
                Class.DataConnection.RunSqlDel(sql);

                //Xóa đơn hàng
                sql = "Delete OrderEntry where IDOE = N'" + tB_ID.Text + "'";
                Class.DataConnection.RunSqlDel(sql);
                ResetValues();
                LoadDGV();
            }
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMExcel = Microsoft.Office.Interop.Excel;


namespace ShoeStore.GUI
{
    public partial class Form_O_Order : Form
    {
        public Form_O_Order()
        {
            InitializeComponent();
        }

        DataTable DT;

        private void Form_O_Order_Load(object sender, EventArgs e)
        {
            b_CancelOrder.Enabled = false;
            b_Date.Enabled = false;
            b_Print.Enabled = false;
            b_Save.Enabled = false;
            tB_Date.Enabled = false;
            cB_Employee.Enabled = false;
            cB_Customer.Enabled = false;
            cB_Product.Enabled = false;
            tB_TNOGs.Enabled = false;
            tB_Sale.Enabled = false;
            UpdateCus();
            UpdateEmployee();
            UpdateProduct();
            if (tB_ID.Text != "")
            {
                LoadInfoOrder();
                b_CancelOrder.Enabled = true;
                b_Print.Enabled = true;
            }
            LoadDGV();
        }

        private void UpdateCus()
        {
            string query;
            query = "Select IDCus, NameCus From Customer";
            Class.DataConnection.FillCombo(query, cB_Customer, "IDCus", "NameCus");
            cB_Customer.SelectedIndex = -1;
        }

        private void UpdateEmployee()
        {
            string query;
            query = "Select IDEmployee, NameEmployee From Employee";
            Class.DataConnection.FillCombo(query, cB_Employee, "IDEmployee", "NameEmployee");
            cB_Employee.SelectedIndex = -1;
        }

        private void UpdateProduct()
        {
            string query;
            query = "Select IDProduct From Product";
            Class.DataConnection.FillCombo(query, cB_Product, "IDProduct", "IDProduct");
            cB_Product.SelectedIndex = -1;
        }

        private void LoadDGV()
        {
            string query;
            query = "Select InfoOrder.IDProduct as [Mã sản phẩm], NameProduct as [Tên sản phẩm], InfoOrder.OrderNumber as [Số lượng], Price as [Đơn giá], Sale as [Giảm giá], IntoMoney as [Thành tiền] from Product, InfoOrder " +
                "where Product.IDProduct = InfoOrder.IDProduct and IDOrder = N'" + tB_ID.Text + "'";
            DT = Class.DataConnection.GetDataToTable(query);
            dGV.DataSource = DT;
        }
        
        private void LoadInfoOrder()
        {
            string str;
            str = "Select DateOrder from Orders where IDOrder = '" + tB_ID.Text + "'";
            tB_Date.Text = Class.DataConnection.ConvertDateTime(Class.DataConnection.GetFieldValues(str));
            str = "Select NameEmployee from Orders, Employee where Employee.IDEmployee = Orders.IDEmployee and IDOrder = N'" + tB_ID.Text + "'";
            cB_Employee.Text = Class.DataConnection.GetFieldValues(str);
            str = "Select NameCus from Orders, Customer where Customer.IDCus = Orders.IDCus and IDOrder = N'" + tB_ID.Text + "'";
            cB_Customer.Text = Class.DataConnection.GetFieldValues(str);
            str = "Select TotalAmount from Orders where IDOrder = N'" + tB_ID.Text + "'";
            tB_TotalAmount.Text = Class.DataConnection.GetFieldValues(str);
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            b_CancelOrder.Enabled = false;
            b_Date.Enabled = true;
            b_Print.Enabled = false;
            b_Save.Enabled = true;
            tB_Date.Enabled = true;
            cB_Employee.Enabled = true;
            cB_Customer.Enabled = true;
            cB_Product.Enabled = true;
            tB_TNOGs.Enabled = true;
            tB_Sale.Enabled = true;
            ResetValues();
            tB_ID.Text = Class.DataConnection.CreateKey("HDB");
            LoadDGV();
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetValues()
        {
            tB_ID.Text = "";
            tB_Date.Text = DateTime.Now.ToShortDateString();
            cB_Customer.Text = "";
            cB_Employee.Text = "";
            cB_Product.Text = "";
            tB_TNOGs.Text = "";
            tB_Sale.Text = "0";
            tB_Price.Text = "0";
            tB_Product.Text = "";
            tB_TotalAmount.Text = "0";
            tB_NumpCus.Text = "";
            tB_IntoMoney.Text = "";
            tB_AddressCus.Text = "";
        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, slcon, tong, tongmoi;

            sql = "Select IDOrder from Orders where IDOrder = N'" + tB_ID.Text + "'";

            //Nếu Mã đơn chưa có thì tạo đơn mới.
            //Nếu Mã đơn đã có thì lưu các sản phẩm được thêm trong đơn hàng.

            if (!Class.DataConnection.CheckKey(sql))
            {
                if (tB_Date.Text.Length == 0)
                {
                    MessageBox.Show("Bạn chưa nhập ngày bán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tB_Date.Focus();
                    return;
                }

                if (cB_Employee.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa chọn nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cB_Employee.Focus();
                    return;
                }

                if (cB_Customer.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn chưa chọn khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cB_Customer.Focus();
                    return;
                }

                sql = "Insert into Orders(IDOrder, IDCus, IDEmployee, DateOrder, TotalAmount) values(N'" + tB_ID.Text.Trim() + "', " + cB_Customer.SelectedValue + ", "
                    + cB_Employee.SelectedValue + ", '" + Class.DataConnection.ConvertDateTime(tB_Date.Text.Trim()) + "', " + tB_TotalAmount.Text.Trim() + ")";
                Class.DataConnection.RunSql(sql);
            }

            if ((tB_TNOGs.Text.Length == 0) || (tB_TNOGs.Text == "0"))
            {
                MessageBox.Show("Bạn chưa nhập số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_TNOGs.Text = "";
                tB_TNOGs.Focus();
                return;
            }

            if (cB_Product.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cB_Product.Focus();
                return;
            }

            if (tB_Sale.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập giảm giá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_Sale.Focus();
                return;
            }

            sql = "Select IDProduct from InfoOrder where IDProduct = '" + cB_Product.SelectedValue + "' and IDOrder = N'" + tB_ID.Text.Trim() + "'";

            if (Class.DataConnection.CheckKey(sql))
            {
                MessageBox.Show("Sản phẩm này đã có, bạn phải lựa chọn sản phẩm khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesProduct();
                cB_Product.Focus();
                return;
            }

            sl = Convert.ToDouble(Class.DataConnection.GetFieldValues("Select TNOP from Product where IDProduct = '" + cB_Product.SelectedValue + "'"));

            if (Convert.ToDouble(tB_TNOGs.Text) > sl)
            {
                MessageBox.Show("Số lượng sản phẩm này chỉ còn " + sl, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tB_TNOGs.Text = "";
                tB_TNOGs.Focus();
                return;
            }

            sql = "Insert into InfoOrder(IDOrder, IDProduct, OrderNumber, Sale, IntoMoney) Values(N'" + tB_ID.Text.Trim() + "', '" + cB_Product.SelectedValue + "', "
                + tB_TNOGs.Text.Trim() + ", " + tB_Sale.Text.Trim() + ", " + tB_IntoMoney.Text + ")";
            Class.DataConnection.RunSql(sql);
            LoadDGV();

            //Cập nhật lại số lượng sản phẩm
            slcon = sl - Convert.ToDouble(tB_TNOGs.Text);
            sql = "Update Product set TNOP = " + slcon + " where IDProduct = '" + cB_Product.SelectedValue + "'";
            Class.DataConnection.RunSql(sql);

            //Cập nhật lại tông tiền cho hóa đơn
            tong = Convert.ToDouble(Class.DataConnection.GetFieldValues("Select TotalAmount from Orders where IDOrder = N'" + tB_ID.Text + "'"));
            tongmoi = tong + Convert.ToDouble(tB_IntoMoney.Text);
            sql = "Update Orders set TotalAmount = " + tongmoi + " where IDOrder = N'" + tB_ID.Text + "'";
            Class.DataConnection.RunSql(sql);
            tB_TotalAmount.Text = tongmoi.ToString();
            ResetValuesProduct();
            b_CancelOrder.Enabled = true;
            b_Add.Enabled = true;
            b_Print.Enabled = true;
        }

        private void ResetValuesProduct()
        {
            cB_Product.Text = "";
            tB_TNOGs.Text = "";
            tB_IntoMoney.Text = "0";
            tB_Product.Text = "";
            tB_Price.Text = "0";
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

            b_CancelOrder.Enabled = true;
            b_Date.Enabled = true;
            b_Print.Enabled = true;
            b_Save.Enabled = false;
            tB_Date.Enabled = false;
            cB_Employee.Enabled = false;
            cB_Customer.Enabled = false;
            cB_Product.Enabled = false;
            tB_TNOGs.Enabled = false;
            tB_Sale.Enabled = false;

            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                maspxoa = dGV.CurrentRow.Cells["Mã sản phẩm"].Value.ToString();
                slxoa = Convert.ToDouble(dGV.CurrentRow.Cells["Số lượng"].Value.ToString());
                thanhtienxoa = Convert.ToDouble(dGV.CurrentRow.Cells["Thành tiền"].Value.ToString());
                sql = "Delete InfoOrder where IDOrder = N'" + tB_ID.Text + "' and IDProduct = '" + maspxoa + "'";
                Class.DataConnection.RunSql(sql);

                //Cập nhật lại số lượng của các sản phẩm.
                sl = Convert.ToDouble(Class.DataConnection.GetFieldValues("Select TNOP from Product where IDProduct = '" + maspxoa + "'"));
                slcon = sl + slxoa;
                sql = "Update Product set TNOP = " + slcon + " where IDProduct = '" + maspxoa + "'";
                Class.DataConnection.RunSql(sql);

                //Cập nhật lại tổng tiền trong đơn hàng.
                tong = Convert.ToDouble(Class.DataConnection.GetFieldValues("Select TotalAmount from Orders where IDOrder = N'" + tB_ID.Text + "'"));
                tongmoi = tong - thanhtienxoa;
                sql = "Update Orders set TotalAmount = " + tongmoi + " where IDOrder = N'" + tB_ID.Text + "'";
                Class.DataConnection.RunSql(sql);
                tB_TotalAmount.Text = tongmoi.ToString();
                LoadDGV();
            }
        }

        private void cB_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cB_Customer.Text == "")
            {
                tB_AddressCus.Text = "";
                tB_NumpCus.Text = "";
            }

            //Khi chọn tên khách thì sẽ hiện ra thông tin của khách đó.
            str = "Select AddressCus from Customer where NameCus = N'" + cB_Customer.Text + "'";
            tB_AddressCus.Text = Class.DataConnection.GetFieldValues(str);
            str = "Select NumpCus from Customer where NameCus = N'" + cB_Customer.Text + "'";
            tB_NumpCus.Text = Class.DataConnection.GetFieldValues(str);
        }

        private void cB_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cB_Product.Text == "")
            {
                tB_Price.Text = "";
                tB_Product.Text = "";
            }
            //Khi chọn sản phẩm sẽ hiện đơn giá của sản phẩm đấy.
            str = "Select Price from Product where IDProduct = '" + cB_Product.Text + "'";
            tB_Price.Text = Class.DataConnection.GetFieldValues(str);
            str = "Select NameProduct from Product where IDProduct = '" + cB_Product.Text + "'";
            tB_Product.Text = Class.DataConnection.GetFieldValues(str);
        }

        private void b_CancelOrder_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "Select IDProduct, OrderNumber from InfoOrder where IDOrder = N'" + tB_ID.Text + "'";
                DataTable DT_DH_SP = Class.DataConnection.GetDataToTable(sql);
                for (int sp = 0; sp <= DT_DH_SP.Rows.Count - 1; sp++)
                {
                    //Cập nhật lại số lượng các mặt hàng.
                    sl = Convert.ToDouble(Class.DataConnection.GetFieldValues("Select TNOP from Product where IDProduct = '" + DT_DH_SP.Rows[sp][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(DT_DH_SP.Rows[sp][1].ToString());
                    slcon = sl + slxoa;
                    sql = "Update Product set TNOP = " + slcon + " where IDProduct = '" + DT_DH_SP.Rows[sp][0].ToString() + "'";
                    Class.DataConnection.RunSql(sql);
                }

                //Xóa chi tiết đơn hàng
                sql = "Delete InfoOrder where IDOrder = N'" + tB_ID.Text + "'";
                Class.DataConnection.RunSqlDel(sql);

                //Xóa đơn hàng
                sql = "Delete Orders where IDOrder = N'" + tB_ID.Text + "'";
                Class.DataConnection.RunSqlDel(sql);
                ResetValues();
                LoadDGV();
                b_CancelOrder.Enabled = false;
                b_Print.Enabled = false;
                b_Date.Enabled = false;
                b_Save.Enabled = false;
                tB_Date.Enabled = false;
                cB_Employee.Enabled = false;
                cB_Customer.Enabled = false;
                cB_Product.Enabled = false;
                tB_TNOGs.Enabled = false;
                tB_Sale.Enabled = false;
            }
        }

        private void tB_TNOGs_TextChanged(object sender, EventArgs e)
        {
            double sl, dg, gg, tt;
            if (tB_TNOGs.Text == "")
            {
                sl = 0;
            }
            else
                sl = Convert.ToDouble(tB_TNOGs.Text);

            if (tB_Sale.Text == "")
            {
                gg = 0;
            }
            else
                gg = Convert.ToDouble(tB_Sale.Text);

            if (tB_Price.Text == "")
            {
                dg = 0;
            }
            else
                dg = Convert.ToDouble(tB_Price.Text);

            tt = sl * dg * (1 - gg * 0.01);
            tB_IntoMoney.Text = tt.ToString();
        }

        private void tB_Sale_TextChanged(object sender, EventArgs e)
        {
            double sl, dg, gg, tt;

            if (tB_TNOGs.Text == "")
            {
                sl = 0;
            }
            else
                sl = Convert.ToDouble(tB_TNOGs.Text);

            if (tB_Sale.Text == "")
            {
                gg = 0;
            }
            else
                gg = Convert.ToDouble(tB_Sale.Text);

            if (tB_Price.Text == "")
            {
                dg = 0;
            }
            else
                dg = Convert.ToDouble(tB_Price.Text);

            tt = sl * dg * (1 - gg * 0.01);
            tB_IntoMoney.Text = tt.ToString();
        }

        private void b_Date_Click(object sender, EventArgs e)
        {
            tB_Date.Text = DateTime.Now.ToString();
        }

        private void b_Print_Click(object sender, EventArgs e)
        {
            //Khởi động Excel.
            COMExcel.Application ExApp = new COMExcel.Application();
            //Trong chương trình Excel có nhiều WorkBook.
            COMExcel.Workbook ExBook;
            //Trong 1 WorkBook có nhiều Sheet khác nhau.
            COMExcel.Worksheet ExSheet;
            COMExcel.Range ExRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable DT_TT_DonHang, DT_TT_CTDH;
            ExBook = ExApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            ExSheet = ExBook.Worksheets[1];

            //Định dạng chung.
            ExRange = ExSheet.Cells[1, 1];
            //Font chữ.
            ExRange.Range["A1:Z300"].Font.Name = "Times new roman";
            //Cỡ chữ trong ô A1 đến B3 là 10.
            ExRange.Range["A1:B3"].Font.Size = 10;
            ExRange.Range["A1:B3"].Font.Bold = true;
            ExRange.Range["A1:B3"].Font.ColorIndex = 5;
            ExRange.Range["A1:A1"].ColumnWidth = 15;
            ExRange.Range["B1:B1"].ColumnWidth = 15;
            //Gộp 2 ô lại với nhau.
            ExRange.Range["A1:B1"].MergeCells = true;
            //Căn giữa 2 ô.
            ExRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            ExRange.Range["A1:B1"].Value = "CỬA HÀNG GIÀY DÉP BÔNG BÔNG";
            ExRange.Range["A2:B2"].MergeCells = true;
            ExRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            ExRange.Range["A2:B2"].Value = "Địa chỉ: Tây Hồ - Hà Nội";
            ExRange.Range["A3:B3"].MergeCells = true;
            ExRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            ExRange.Range["A3:B3"].Value = "Số điện thoại: 0437535424";
            ExRange.Range["C5:E5"].Font.Size = 18;
            ExRange.Range["C5:E5"].Font.Bold = true;
            ExRange.Range["C5:E5"].Font.ColorIndex = 3;
            ExRange.Range["C5:E5"].MergeCells = true;
            ExRange.Range["C5:E5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            ExRange.Range["C5:E5"].Value = "HÓA ĐƠN";
            //Biểu diễn thông tin của hóa đơn bán.
            sql = "Select Orders.IDOrder, DateOrder, NameCus, AddressCus, NumpCus, NameEmployee, TotalAmount from Customer, Employee, Orders where Orders.IDCus = Customer.IDCus and Orders.IDEmployee = Employee.IDEmployee and Orders.IDOrder = N'" + tB_ID.Text + "'";
            DT_TT_DonHang = Class.DataConnection.GetDataToTable(sql);
            ExRange.Range["B7:C10"].Font.Size = 12;
            ExRange.Range["B7:B7"].Value = "Mã đơn hàng: ";
            ExRange.Range["C7:E7"].MergeCells = true;
            ExRange.Range["C7:E7"].Value = DT_TT_DonHang.Rows[0][0].ToString();
            ExRange.Range["B8:B8"].Value = "Khách hàng: ";
            ExRange.Range["C8:E8"].MergeCells = true;
            ExRange.Range["C8:E8"].Value = DT_TT_DonHang.Rows[0][2].ToString();
            ExRange.Range["B9:B9"].Value = "Địa chỉ: ";
            ExRange.Range["C9:E9"].MergeCells = true;
            ExRange.Range["C9:E9"].Value = DT_TT_DonHang.Rows[0][3].ToString();
            ExRange.Range["B10:B10"].Value = "Số điện thoại: ";
            ExRange.Range["C10:E10"].MergeCells = true;
            ExRange.Range["C10:E10"].Value = "'" + DT_TT_DonHang.Rows[0][4].ToString();
            //Biểu diễn thông tin của chi tiết đơn hàng.
            sql = "Select NameProduct, OrderNumber, Price, Sale, IntoMoney from InfoOrder, Product where Product.IDProduct = InfoOrder.IDProduct and IDOrder = N'" + tB_ID.Text + "'";
            DT_TT_CTDH = Class.DataConnection.GetDataToTable(sql);
            ExRange.Range["A12:F12"].Font.Bold = true;
            ExRange.Range["A12:F12"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            ExRange.Range["C12:F12"].ColumnWidth = 12;
            ExRange.Range["A12:A12"].Value = "STT";
            ExRange.Range["B12:B12"].Value = "Tên sản phẩm";
            ExRange.Range["B12:B12"].ColumnWidth = 40;
            ExRange.Range["C12:C12"].Value = "Số lượng";
            ExRange.Range["D12:D12"].Value = "Đơn giá";
            ExRange.Range["E12:E12"].Value = "Giảm giá";
            ExRange.Range["F12:F12"].Value = "Thành tiền";

            for (hang = 0; hang < DT_TT_CTDH.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột một dòng số 13.
                ExSheet.Cells[1][hang + 13] = hang + 1;
                for (cot = 0; cot < DT_TT_CTDH.Columns.Count; cot++)
                {
                    ExSheet.Cells[cot + 2][hang + 13] = DT_TT_CTDH.Rows[hang][cot].ToString();
                    if (cot == 3)
                        ExSheet.Cells[cot + 2][hang + 13] = DT_TT_CTDH.Rows[hang][cot].ToString() + "%";
                }
            }

            ExRange = ExSheet.Cells[cot][hang + 15];
            ExRange.Font.Bold = true;
            ExRange.Value2 = "Tổng tiền: ";
            ExRange = ExSheet.Cells[cot + 1][hang + 15];
            ExRange.Font.Bold = true;
            ExRange.Value2 = DT_TT_DonHang.Rows[0][6].ToString();
            ExRange = ExSheet.Cells[1][hang + 16];

            ExRange = ExSheet.Cells[4][hang + 18];
            ExRange.Range["A1:C1"].MergeCells = true;
            ExRange.Range["A1:C1"].Font.Italic = true;
            ExRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(DT_TT_DonHang.Rows[0][1]);
            ExRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            ExRange.Range["A2:C2"].MergeCells = true;
            ExRange.Range["A2:C2"].Font.Italic = true;
            ExRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            ExRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            ExRange.Range["A6:C6"].MergeCells = true;
            ExRange.Range["A6:C6"].Font.Italic = true;
            ExRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            ExRange.Range["A6:C6"].Value = DT_TT_DonHang.Rows[0][5];

            ExSheet.Name = "Hóa đơn bán";
            ExApp.Visible = true;
        }

        private void b_Seach_Click(object sender, EventArgs e)
        {
            if (cB_Seach.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã đơn để tìm kiếm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cB_Seach.Focus();
                return;
            }

            tB_ID.Text = cB_Seach.Text;
            LoadInfoOrder();
            LoadDGV();
            b_CancelOrder.Enabled = true;
            b_Save.Enabled = true;
            b_Print.Enabled = true;
            cB_Seach.SelectedIndex = -1;
        }

        private void cB_Seach_DropDown(object sender, EventArgs e)
        {
            string query;
            query = "Select IDOrder From Orders";
            Class.DataConnection.FillCombo(query, cB_Seach, "IDOrder", "IDOrder");
            cB_Seach.SelectedIndex = -1;
        }

        private void cB_Customer_TextChanged(object sender, EventArgs e)
        {
            string sql;

            sql = "Select Note from Customer where NameCus = N'" + cB_Customer.Text + "'";
            DT = Class.DataConnection.GetDataToTable(sql);

            if (DT != null)
            {
                foreach (DataRow DR in DT.Rows)
                {
                    if (DR["Note"].ToString() == "Thành viên Đồng")
                        tB_Sale.Text = "5";
                    if (DR["Note"].ToString() == "Thành viên Bạc")
                        tB_Sale.Text = "10";
                    if (DR["Note"].ToString() == "Thành viên Vàng")
                        tB_Sale.Text = "20";
                    if (DR["Note"].ToString() == "Thành viên Bạch Kim")
                        tB_Sale.Text = "50";
                    if (DR["Note"].ToString() == "Thành viên Kim Cương")
                        tB_Sale.Text = "100";
                    if (DR["Note"].ToString() == "")
                        tB_Sale.Text = "0";
                }
            }
        }
    }
}

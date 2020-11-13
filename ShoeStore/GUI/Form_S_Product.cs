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
    public partial class Form_S_Product : Form
    {
        public Form_S_Product()
        {
            InitializeComponent();
        }

        DataTable DT;

        private void Form_S_Product_Load(object sender, EventArgs e)
        {
            LoadDGV();
            ResetValues();
            Update_cB_Product();
        }

        private void LoadDGV()
        {
            string query;
            query = "Select IDProduct as [Mã sản phẩm], NameProduct as [Tên sản phẩm], Supplier as [Nhà cung cấp], TOGs as [Loại hàng], Size, TNOP as [Số lượng], Price as [Giá bán], EntryPrice as [Giá nhập], LastDay as [Lần nhập gần nhất], Picture as [Hình ảnh], Note as [Ghi Chú]" +
                "from v_Info_Product";
            DT = Class.DataConnection.GetDataToTable(query);
            dGV.DataSource = DT;
        }

        private void ResetValues()
        {
            cB_Name.Text = "";
            tB_ID.Text = "";
            tB_Supplier.Text = "";
            tB_TOGs.Text = "";
            tB_Size.Text = "";
            tB_TNOP.Text = "";
            tB_Price.Text = "";
            tB_EntryPrice.Text = "";
            tB_EntryDay.Text = "";
            rTB_Picture.Text = "";
            tB_Note.Text = "";
            pB_Picture.Image = null;
        }

        private void Update_cB_Product()
        {
            string query;
            query = "Select IDProduct, NameProduct From Product";
            Class.DataConnection.FillCombo(query, cB_Name, "IDProduct", "NameProduct");
            cB_Name.SelectedIndex = -1;
        }

        private void dGV_Click(object sender, EventArgs e)
        {
            if (DT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            cB_Name.Text = dGV.CurrentRow.Cells["Tên sản phẩm"].Value.ToString();
            tB_ID.Text = dGV.CurrentRow.Cells["Mã sản phẩm"].Value.ToString();
            tB_Supplier.Text = dGV.CurrentRow.Cells["Nhà cung cấp"].Value.ToString();
            tB_TOGs.Text = dGV.CurrentRow.Cells["Loại hàng"].Value.ToString();
            tB_Size.Text = dGV.CurrentRow.Cells["Size"].Value.ToString();
            tB_TNOP.Text = dGV.CurrentRow.Cells["Số lượng"].Value.ToString();
            tB_Price.Text = dGV.CurrentRow.Cells["Giá bán"].Value.ToString();
            tB_EntryPrice.Text = dGV.CurrentRow.Cells["Giá nhập"].Value.ToString();
            tB_EntryDay.Text = dGV.CurrentRow.Cells["Lần nhập gần nhất"].Value.ToString();
            rTB_Picture.Text = dGV.CurrentRow.Cells["Hình ảnh"].Value.ToString();
            pB_Picture.Image = Image.FromFile(rTB_Picture.Text);
            tB_Note.Text = dGV.CurrentRow.Cells["Ghi chú"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_Search_Click(object sender, EventArgs e)
        {
            dGV.DataSource = null;
            if (cB_Name.Text == "")
            {
                MessageBox.Show("Bạn cần chọn tên sản phẩm cần tìm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cB_Name.Focus();
                return;
            }

            string query;
            query = "Select IDProduct as [Mã sản phẩm], NameProduct as [Tên sản phẩm], Supplier as [Nhà cung cấp], TOGs as [Loại hàng], Size, TNOP as [Số lượng], Price as [Giá bán], EntryPrice as [Giá nhập], LastDay as [Lần nhập gần nhất], Picture as [Hình ảnh], Note as [Ghi Chú]" +
                "from f_SearchProduct('" + cB_Name.SelectedValue + "')";
            DT = Class.DataConnection.GetDataToTable(query);
            dGV.DataSource = DT;

            if (dGV.Rows.Count != 0)
            {
                ResetValues();
            }

            if (dGV.Rows.Count == 0)
            {
                ResetValues();
                MessageBox.Show("Sản phẩm này chưa nhập  về", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string str;
                str = "Select NameProduct from Product where IDProduct = '" + cB_Name.SelectedValue + "'";
                cB_Name.Text = Class.DataConnection.GetFieldValues(str);
                str = "Select IDProduct from Product where IDProduct = '" + cB_Name.SelectedValue + "'";
                tB_ID.Text = Class.DataConnection.GetFieldValues(str);
                str = "Select NameSupp from Product, Supplier where Supplier.IDSupp = Product.IDSupp and IDProduct = '" + cB_Name.SelectedValue + "'";
                tB_Supplier.Text = Class.DataConnection.GetFieldValues(str);
                str = "Select NameTOGs from Product, TOGs where TOGs.IDTOGs = Product.IDTOGs and MaSP = '" + cB_Name.SelectedValue + "'";
                tB_TOGs.Text = Class.DataConnection.GetFieldValues(str);
                str = "Select Size from Product where IDProduct = '" + cB_Name.SelectedValue + "'";
                tB_Size.Text = Class.DataConnection.GetFieldValues(str);
                str = "Select TNOP from Product where IDProduct = '" + cB_Name.SelectedValue + "'";
                tB_TNOP.Text = Class.DataConnection.GetFieldValues(str);
                str = "Select Price from Product where IDProduct = '" + cB_Name.SelectedValue + "'";
                tB_Price.Text = Class.DataConnection.GetFieldValues(str);
                str = "Select EntryPrice from Product where IDProduct = '" + cB_Name.SelectedValue + "'";
                tB_EntryPrice.Text = Class.DataConnection.GetFieldValues(str);
                tB_EntryDay.Text = "Chưa nhập sản phẩm về";
                str = "Select Picture from Product where IDProduct = '" + cB_Name.SelectedValue + "'";
                rTB_Picture.Text = Class.DataConnection.GetFieldValues(str);
                pB_Picture.Image = Image.FromFile(rTB_Picture.Text);
            }
        }
    }
}

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
    public partial class Form_C_Product : Form
    {
        public Form_C_Product()
        {
            InitializeComponent();
        }

        DataTable DT;

        private void Form_C_Product_Load(object sender, EventArgs e)
        {
            tB_Name.Enabled = false;
            tB_Note.Enabled = false;
            tB_ID.Enabled = false;
            tB_Pict.Enabled = false;
            tB_Price.Enabled = false;
            tB_Size.Enabled = false;
            cB_Supp.Enabled = false;
            cB_TOGs.Enabled = false;
            b_Open.Enabled = false;
            b_Del.Enabled = false;
            b_Upd.Enabled = false;
            b_Save.Enabled = false;
            b_Out.Enabled = false;
            UpdateSupp();
            UpdateTOGs();
            ResetValues();
            LoadDGV();
        }

        private void UpdateSupp()
        {
            string query;
            query = "Select IDSupp, NameSupp From Supplier";
            Class.DataConnection.FillCombo(query, cB_Supp, "IDSupp", "NameSupp");
            cB_Supp.SelectedIndex = -1;
        }

        private void UpdateTOGs()
        {
            string query;
            query = "Select IDTOGs, NameTOGs From TOGs";
            Class.DataConnection.FillCombo(query, cB_TOGs, "IDTOGs", "NameTOGs");
            cB_TOGs.SelectedIndex = -1;
        }

        private void ResetValues()
        {
            tB_ID.Text = "";
            tB_Name.Text = "";
            cB_Supp.Text = "";
            cB_TOGs.Text = "";
            tB_Size.Text = "";
            tB_Pict.Text = "";
            tB_Price.Text = "";
            tB_EntryPrice.Text = "";
            pB_SP.Image = null;
        }

        private void LoadDGV()
        {
            string query = "Select IDProduct as [Mã sản phẩm], NameProduct as [Tên sản phẩm], NameSupp as [Tên nhà cung cấp], NameTOGs as [Tên loại hàng], Size, Price as [Giá bán], EntryPrice as [Giá nhập], Picture as [Hình ảnh], TNOP as [Số lượng], Note as [Ghi chú] " +
                "from TOGs, Supplier, Product where Product.IDSupp = Supplier.IDSupp and TOGs.IDTOGs = Product.IDTOGs";
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

            tB_ID.Text = dGV.CurrentRow.Cells["Mã sản phẩm"].Value.ToString();
            tB_Name.Text = dGV.CurrentRow.Cells["Tên sản phẩm"].Value.ToString();
            cB_Supp.Text = dGV.CurrentRow.Cells["Tên nhà cung cấp"].Value.ToString();
            cB_TOGs.Text = dGV.CurrentRow.Cells["Tên loại hàng"].Value.ToString();
            tB_Size.Text = dGV.CurrentRow.Cells["Size"].Value.ToString();
            tB_Price.Text = dGV.CurrentRow.Cells["Giá bán"].Value.ToString();
            tB_EntryPrice.Text = dGV.CurrentRow.Cells["Giá nhập"].Value.ToString();
            tB_Note.Text = dGV.CurrentRow.Cells["Ghi chú"].Value.ToString();
            tB_Pict.Text = dGV.CurrentRow.Cells["Hình ảnh"].Value.ToString();
            if (tB_Pict.Text.Length > 0)
                pB_SP.Image = Image.FromFile(tB_Pict.Text);
            else pB_SP.Image = null;

            b_Upd.Enabled = true;
            b_Del.Enabled = true;
            b_Out.Enabled = true;
            b_Open.Enabled = true;
            tB_Name.Enabled = true;
            tB_Note.Enabled = true;
            tB_Pict.Enabled = true;
            tB_Price.Enabled = true;
            tB_Size.Enabled = true;
            cB_Supp.Enabled = true;
            cB_TOGs.Enabled = true;
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            b_Del.Enabled = false;
            b_Upd.Enabled = false;
            b_Open.Enabled = true;
            b_Out.Enabled = true;
            b_Save.Enabled = true;
            b_Add.Enabled = false;
            tB_Name.Enabled = true;
            tB_Note.Enabled = true;
            tB_ID.Enabled = true;
            tB_Price.Enabled = true;
            tB_Size.Enabled = true;
            cB_Supp.Enabled = true;
            cB_TOGs.Enabled = true;
            ResetValues();
        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            string sql;
            if (tB_Name.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập tên sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_Name.Focus();
                return;
            }

            if (tB_ID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_ID.Focus();
                return;
            }

            if (cB_Supp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cB_Supp.Focus();
                return;
            }

            if (cB_TOGs.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn loại hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cB_TOGs.Focus();
                return;
            }

            if (tB_Price.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập giá bán cho sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_Price.Focus();
                return;
            }

            sql = "Select IDProduct from Product where IDProduct = '" + tB_ID.Text.Trim() + "'";
            if (Class.DataConnection.CheckKey(sql))
            {
                MessageBox.Show("Sản phẩm này đã có sẵn.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tB_ID.Focus();
                return;
            }

            sql = "Insert into Product(IDProduct, NameProduct, IDSupp, IDTOGs, Size, Price, Picture, Note) values('" + tB_ID.Text.Trim() + "_S"+ tB_Size.Text + "', N'" + tB_Name.Text.Trim() + "_S" + tB_Size.Text + "', " 
                + cB_Supp.SelectedValue.ToString() + ", " + cB_TOGs.SelectedValue.ToString() + ", " + tB_Size.Text.Trim() + ", " + tB_Price.Text.Trim() + ", N'" + tB_Pict.Text + "', N'" + tB_Note.Text.Trim() + "')";
            
            Class.DataConnection.RunSql(sql);
            LoadDGV();
            ResetValues();
            tB_Name.Enabled = false;
            tB_Note.Enabled = false;
            tB_ID.Enabled = false;
            tB_Pict.Enabled = false;
            tB_Price.Enabled = false;
            tB_Size.Enabled = false;
            cB_Supp.Enabled = false;
            cB_TOGs.Enabled = false;
            b_Open.Enabled = false;
            b_Del.Enabled = false;
            b_Upd.Enabled = false;
            b_Save.Enabled = false;
            b_Out.Enabled = false;
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
                pB_SP.Image = Image.FromFile(openFileDialog.FileName);
                tB_Pict.Text = openFileDialog.FileName;
            }
        }

        private void b_Close_Click(object sender, EventArgs e) 
        {
            this.Close();
        }

        private void b_Upd_Click(object sender, EventArgs e)
        {
            string sql;

            if (tB_ID.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_ID.Focus();
                return;
            }

            if (tB_Name.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_Name.Focus();
                return;
            }

            if (tB_Price.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập đơn giá cho sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tB_Price.Focus();
                return;
            }

            if (cB_Supp.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn nhà cung cấp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cB_Supp.Focus();
                return;
            }

            if (cB_TOGs.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn loại hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cB_TOGs.Focus();
                return;
            }

            sql = "Update Product set NameProduct = N'" + tB_Name.Text.Trim().ToString() + "', IDSupp = " + cB_Supp.SelectedValue.ToString() + ", IDTOGs = " + cB_TOGs.SelectedValue.ToString() + ", Size = " 
                + tB_Size.Text.Trim() + ", Price = "   + tB_Price.Text.Trim() + ", Picture = N'" + tB_Pict.Text.Trim() + "', Note = N'" + tB_Note.Text + "' where IDProduct = '" + tB_ID.Text.Trim() + "'";
            Class.DataConnection.RunSql(sql);
            LoadDGV();
            ResetValues();
            tB_Name.Enabled = false;
            tB_Note.Enabled = false;
            tB_ID.Enabled = false;
            tB_Pict.Enabled = false;
            tB_Price.Enabled = false;
            tB_Size.Enabled = false;
            cB_Supp.Enabled = false;
            cB_TOGs.Enabled = false;
            b_Open.Enabled = false;
            b_Del.Enabled = false;
            b_Upd.Enabled = false;
            b_Save.Enabled = false;
            b_Out.Enabled = false;
        }

        private void b_Del_Click(object sender, EventArgs e)
        {
            string sql;
            if (DT.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("bạn có muốn xóa hay không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "Delete Product where IDProduct = '" + tB_ID.Text + "'";
                Class.DataConnection.RunSqlDel(sql);
                LoadDGV();
                ResetValues();
            }

            b_Del.Enabled = false;
            b_Upd.Enabled = false;
            b_Out.Enabled = false;
            tB_Name.Enabled = false;
            tB_Note.Enabled = false;
            tB_ID.Enabled = false;
            tB_Pict.Enabled = false;
            tB_Price.Enabled = false;
            tB_Size.Enabled = false;
            cB_Supp.Enabled = false;
            cB_TOGs.Enabled = false;
            b_Open.Enabled = false;
        }

        private void b_Out_Click(object sender, EventArgs e)
        {
            ResetValues();
            b_Del.Enabled = false;
            b_Add.Enabled = true;
            b_Upd.Enabled = false;
            b_Out.Enabled = false;
            b_Save.Enabled = false;
            b_Open.Enabled = false;
            tB_Name.Enabled = false;
            tB_Note.Enabled = false;
            tB_ID.Enabled = false;
            tB_Pict.Enabled = false;
            tB_Price.Enabled = false;
            tB_Size.Enabled = false;
            cB_Supp.Enabled = false;
            cB_TOGs.Enabled = false;
        }
    }
}

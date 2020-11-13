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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        DataTable DT;

        private void mT_ProductManagement_Click(object sender, EventArgs e)
        {
            Form_C_Product f = new Form_C_Product();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mT_SupplierManagement_Click(object sender, EventArgs e)
        {
            Form_C_Supplier f = new Form_C_Supplier();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mT_GoodsCategoryManagement_Click(object sender, EventArgs e)
        {
            Form_C_TypeOfGoods f = new Form_C_TypeOfGoods();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Form_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void mT_EmployeeManager_Click(object sender, EventArgs e)
        {
            Form_C_Employee f = new Form_C_Employee();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mT_CustomerManagement_Click(object sender, EventArgs e)
        {
            Form_C_Customer f = new Form_C_Customer();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mT_Orders_Click(object sender, EventArgs e)
        {
            Form_O_Order f = new Form_O_Order();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mT_OrderEntry_Click(object sender, EventArgs e)
        {
            Form_O_OrderEntry f = new Form_O_OrderEntry();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mT_SearchProduct_Click(object sender, EventArgs e)
        {
            Form_S_Product f = new Form_S_Product();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        public string _message;

        public Form_Menu(string Message) : this()
        {
            _message = Message;
            string sql;
            sql = "Select NameEmployee, Position, Picture from Employee where IDEmployee = " + Message + "";
            DT = Class.DataConnection.GetDataToTable(sql);
            if (DT != null)
            {
                foreach (DataRow DR in DT.Rows)
                {
                    l_name.Text = "Tên nhân viên: " + DR["NameEmployee"].ToString();
                    l_Position.Text = "Chức vụ: " + DR["Position"].ToString();
                    if (DR["Picture"].ToString().Length > 0)
                        pB_Employee.Image = Image.FromFile(DR["Picture"].ToString());
                    else pB_Employee.Image = null;
                    if (DR["Position"].ToString() == "NHÂN VIÊN")
                    {
                        mT_EmployeeManager.Enabled = false;
                        mT_OrderEntry.Enabled = false;
                        mT_SupplierManagement.Enabled = false;
                        mT_GoodsCategoryManagement.Enabled = false;
                        mT_ProductManagement.Enabled = false;
                        mT_Report.Enabled = false;
                    }

                    if (DR["Position"].ToString() == "QUẢN LÝ KHO")
                    {
                        mT_EmployeeManager.Enabled = false;
                        mT_GoodsCategoryManagement.Enabled = false;
                        mT_Report.Enabled = false;
                    }

                    if (DR["Position"].ToString() == "")
                    {
                        mT_Class.Enabled = false;
                        mT_Order.Enabled = false;
                        mT_Search.Enabled = false;
                        mT_Report.Enabled = false;
                        l_Position.Text = "Chức vụ: Bạn chưa được phân quyền.";
                    }
                }
            }
        }

        private void l_name_Click(object sender, EventArgs e)
        {
            Form_Info_Employee f = new Form_Info_Employee(_message);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mT_MonthlyReport_Click(object sender, EventArgs e)
        {
            Form_R_Monthly f = new Form_R_Monthly();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mT_AnnualReport_Click(object sender, EventArgs e)
        {
            Form_R_Annual f = new Form_R_Annual();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void mT_Help_Click(object sender, EventArgs e)
        {
            Form_Help f = new Form_Help();
            f.Show();
        }
    }
}
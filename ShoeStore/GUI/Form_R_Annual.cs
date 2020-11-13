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
    public partial class Form_R_Annual : Form
    {
        public Form_R_Annual()
        {
            InitializeComponent();
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_R_Annual_Load(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void ResetValues()
        {
            b_OK.Enabled = true;
            c_R_A.DataSource = null;
            tB_Interest.Text = "";
            tB_Percent.Text = "";
            tB_TotalMoney.Text = "";
            tB_TotalON.Text = "";
            tB_TotalOrder.Text = "";
        }

        DataTable DT;

        private void b_OK_Click(object sender, EventArgs e)
        {
            try
            {
                b_OK.Enabled = false;
                Class.DataConnection.IsNumber(tB_Year.Text);
                string sql;

                if (tB_Year.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập năm cần báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tB_Year.Focus();
                    ResetValues();
                    return;
                }

                sql = "Select * from f_R_TotalAnnual('" + tB_Year.Text + "')";
                DT = Class.DataConnection.GetDataToTable(sql);
                if (DT != null)
                {
                    foreach (DataRow DR in DT.Rows)
                    {
                        tB_TotalOrder.Text = DR["TotalOrder"].ToString();
                        tB_TotalMoney.Text = DR["TotalMoney"].ToString();
                        tB_TotalON.Text = DR["TotalON"].ToString();
                    }
                }

                sql = "Select round(((TotalMoney - TotalMoneyEntry) * 100 / TotalMoneyEntry),0) from f_R_TotalMoneyEntry('" + tB_Year.Text + "'), f_R_TotalAnnual('" + tB_Year.Text + "')";
                tB_Percent.Text = Class.DataConnection.GetFieldValues(sql) + "%";
                
                sql = "Select round((TotalMoney - TotalMoneyEntry),0) from f_R_TotalMoneyEntry('" + tB_Year.Text +"'), f_R_TotalAnnual('" + tB_Year.Text + "')";
                tB_Interest.Text = Class.DataConnection.GetFieldValues(sql);

                sql = "Select N'Tháng ' + cast(DATEPART(MM, Convert(date, DateOrder))as char(2)) as [Tháng], SUM(TotalMoney) as [Doanh thu]" +
                    "from v_R_InfoMonthly where cast(DATEPART(YYYY, Convert(date, DateOrder)) as char(4)) = '" + tB_Year.Text + "' Group by cast(DATEPART(MM, Convert(date, DateOrder)) as char(2))";
                DT = Class.DataConnection.GetDataToTable(sql);
                c_R_A.DataSource = DT;
                c_R_A.Series["Doanh thu"].YValueMembers = "Doanh thu";
                c_R_A.Series["Doanh thu"].XValueMember = "Tháng";
                
                c_R_A.Titles.Clear();
                c_R_A.Titles.Add("Doanh thu theo tháng");
                
                c_R_A.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;

                c_R_A.ChartAreas[0].AxisY.Title = "Doanh thu (đồng)";
                c_R_A.ChartAreas[0].AxisY.TitleFont = new Font("Times New Roman", 10, FontStyle.Bold);
                c_R_A.ChartAreas[0].AxisX.Title = "Các tháng hoạt động trong năm " + tB_Year.Text;
                c_R_A.ChartAreas[0].AxisX.TitleFont = new Font("Times New Roman", 10, FontStyle.Bold);

                if (DT != null)
                {
                    foreach (DataRow DR in DT.Rows)
                    {
                        c_R_A.Series["Doanh thu"].Label = DR["Doanh thu"].ToString();
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Bạn nhập sai kiểu ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tB_Year_TextChanged(object sender, EventArgs e)
        {
            ResetValues();
        }
    }
}

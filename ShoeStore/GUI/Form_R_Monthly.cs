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
    public partial class Form_R_Monthly : Form
    {
        public Form_R_Monthly()
        {
            InitializeComponent();
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DataTable DT;

        private void b_OK_Click(object sender, EventArgs e)
        {
            try
            {
                b_PMM.Enabled = true;
                b_PMO.Enabled = true;
                b_PMON.Enabled = true;
                b_Print.Enabled = true;
                Class.DataConnection.IsNumber(tB_Month.Text);
                Class.DataConnection.IsNumber(tB_Year.Text);

                if(tB_Month.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tháng cần báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tB_Month.Focus();
                    ResetValues();
                    return;
                }

                if (tB_Year.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập năm cần báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tB_Year.Focus();
                    ResetValues();
                    return;
                }

                string sql;
                sql = "Select DateOrder as [Ngày], TotalOrder as [Số đơn đặt hàng], TotalMoney as [Tổng danh thu ngày] from f_R_InfoMonthly('" + tB_Month.Text.Trim() + "', '" + tB_Year.Text.Trim() + "')";
                DT = Class.DataConnection.GetDataToTable(sql);
                dGV.DataSource = DT;

                sql = "Select * from f_R_TotalMonthly('" + tB_Month.Text.Trim() + "', '" + tB_Year.Text.Trim() + "')";
                DT = Class.DataConnection.GetDataToTable(sql);
                if (DT != null)
                {
                    foreach (DataRow DR in DT.Rows)
                    {
                        tB_TotalOrder.Text = DR["TotalOrder"].ToString();
                        tB_TotalMoney.Text = DR["TotalMoney"].ToString();
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Bạn nhập sai kiểu ký tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_R_Monthly_Load(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void b_PMO_Click(object sender, EventArgs e)
        {
            b_PMO.Enabled = false;
            b_PMM.Enabled = true;
            b_PMON.Enabled = true;

            if (tB_Month.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tháng cần báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tB_Month.Focus();
                ResetValues();
                return;
            }

            if (tB_Year.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập năm cần báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tB_Year.Focus();
                ResetValues();
                return;
            }

            string sql;
            sql = "select Distinct IDP as [Mã sản phẩm], left(trim(NameProduct), charindex('_', TRIM(NameProduct))-1) as [Tên sản phẩm], TotalOrder_P as [Số đơn hàng] from f_R_PMO('"+ tB_Month.Text + "','" + tB_Year.Text + "'), Product " +
                "where left(trim(IDProduct), charindex('_', TRIM(IDProduct))-1) = IDP";
            DT = Class.DataConnection.GetDataToTable(sql);
            dGV.DataSource = DT;
        }

        private void b_PMON_Click(object sender, EventArgs e)
        {
            b_PMON.Enabled = false;
            b_PMO.Enabled = true;
            b_PMM.Enabled = true;

            if (tB_Month.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tháng cần báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tB_Month.Focus();
                ResetValues();
                return;
            }

            if (tB_Year.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập năm cần báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tB_Year.Focus();
                ResetValues();
                return;
            }

            string sql;
            sql = "Select Distinct IDP as [Mã sản phẩm], left(trim(NameProduct), charindex('_', TRIM(NameProduct))-1) as [Tên sản phẩm], TotalON_P as [Số lượng bán] from f_R_PMON('" + tB_Month.Text + "', '" + tB_Year.Text + "'), Product " +
                "where left(trim(IDProduct), charindex('_', TRIM(IDProduct))-1) = IDP";
            DT = Class.DataConnection.GetDataToTable(sql);
            dGV.DataSource = DT;
        }

        private void b_PMM_Click(object sender, EventArgs e)
        {
            b_PMM.Enabled = false;
            b_PMO.Enabled = true;
            b_PMON.Enabled = true;

            if (tB_Month.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tháng cần báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tB_Month.Focus();
                ResetValues();
                return;
            }

            if (tB_Year.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập năm cần báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tB_Year.Focus();
                ResetValues();
                return;
            }

            string sql;
            sql = "Select Distinct IDP as [Mã sản phẩm], left(trim(NameProduct), charindex('_', TRIM(NameProduct))-1) as [Tên sản phẩm], TotalMoney_P as [Doanh thu] from f_R_PMM('" + tB_Month.Text + "', '" + tB_Year.Text + "'), Product " +
                "where left(trim(IDProduct), charindex('_', TRIM(IDProduct))-1) = IDP";
            DT = Class.DataConnection.GetDataToTable(sql);
            dGV.DataSource = DT;
        }

        private void ResetValues()
        {
            b_Print.Enabled = false;
            b_OK.Enabled = true;
            b_PMON.Enabled = false;
            b_PMO.Enabled = false;
            b_PMM.Enabled = false;
            dGV.DataSource = null;
            tB_TotalMoney.Text = "";
            tB_TotalOrder.Text = "";
        }

        private void b_Print_Click(object sender, EventArgs e)
        {
            if (tB_Month.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tháng cần báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tB_Month.Focus();
                ResetValues();
                return;
            }

            if (tB_Year.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập năm cần báo cáo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tB_Year.Focus();
                ResetValues();
                return;
            }

            COMExcel.Application ExApp = new COMExcel.Application();
            COMExcel.Workbook ExBook;
            COMExcel.Worksheet ExSheet;
            COMExcel.Range ExRange;
            string sql;
            int hang = 0, cot = 0;
            ExBook = ExApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            ExSheet = ExBook.Worksheets[1];

            //Định dạng chung.
            ExRange = ExSheet.Cells[1, 1];
            ExRange.Range["A1:Z300"].Font.Name = "Times new roman";
            ExRange.Range["A1:B3"].Font.Size = 10;
            ExRange.Range["A1:B3"].Font.Bold = true;
            ExRange.Range["A1:B3"].Font.ColorIndex = 5;
            ExRange.Range["A1:A1"].ColumnWidth = 15;
            ExRange.Range["B1:B1"].ColumnWidth = 15;
            ExRange.Range["A1:B1"].MergeCells = true;
            ExRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            ExRange.Range["A1:B1"].Value = "CỬA HÀNG GIÀY DÉP BÔNG BÔNG";
            ExRange.Range["A2:B2"].MergeCells = true;
            ExRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            ExRange.Range["A2:B2"].Value = "Địa chỉ: Tây Hồ - Hà Nội";
            ExRange.Range["A3:B3"].MergeCells = true;
            ExRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            ExRange.Range["A3:B3"].Value = "Số điện thoại: 0437535424";
            ExRange.Range["C5:F5"].Font.Size = 18;
            ExRange.Range["C5:F5"].Font.Bold = true;
            ExRange.Range["C5:F5"].Font.ColorIndex = 3;
            ExRange.Range["C5:F5"].MergeCells = true;
            ExRange.Range["C5:F5"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            ExRange.Range["C5:F5"].Value = "BÁO CÁO DOANH THU THÁNG " + tB_Month.Text + " NĂM " + tB_Year.Text + "";

            //Thông tin báo cáo
            ExRange.Range["B7:D7"].Font.Size = 14;
            ExRange.Range["B7:D7"].MergeCells = true;
            ExRange.Range["B7:D7"].Value = "Danh sách sản phẩm phổ biến nhất";
            ExRange.Range["B7:D7"].Font.Bold = true;
            sql = sql = "select Distinct IDP, left(trim(NameProduct), charindex('_', TRIM(NameProduct))-1), TotalOrder_P from f_R_PMO('" + tB_Month.Text + "','" + tB_Year.Text + "'), Product " +
                "where left(trim(IDProduct), charindex('_', TRIM(IDProduct))-1) = IDP";
            DT = Class.DataConnection.GetDataToTable(sql);
            ExRange.Range["A9:D9"].Font.Bold = true;
            ExRange.Range["A9:D9"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            ExRange.Range["C9:D9"].ColumnWidth = 14;
            ExRange.Range["C9:C9"].ColumnWidth = 40;
            ExRange.Range["A9:A9"].Value = "STT";
            ExRange.Range["B9:B9"].Value = "Mã sản phẩm";
            ExRange.Range["C9:C9"].Value = "Tên sản phẩm";
            ExRange.Range["D9:D9"].Value = "Số đơn hàng";
            for (hang = 0; hang < DT.Rows.Count; hang++)
            {
                ExSheet.Cells[1][hang + 10] = hang + 1;
                for (cot = 0; cot < DT.Columns.Count; cot++)
                {
                    ExSheet.Cells[cot + 2][hang + 10] = DT.Rows[hang][cot].ToString();
                }
            }

            ExRange = ExSheet.Cells[2][hang + 11];
            ExRange.Font.Bold = true;
            ExRange.Font.Size = 14;
            ExRange.Value2 = "Danh sách sản phẩm có số lượng bán ra nhiều nhất nhất";
            sql = "Select Distinct IDP as [Mã sản phẩm], left(trim(NameProduct), charindex('_', TRIM(NameProduct))-1) as [Tên sản phẩm], TotalON_P as [Số lượng bán] from f_R_PMON('" + tB_Month.Text + "', '" + tB_Year.Text + "'), Product " +
                "where left(trim(IDProduct), charindex('_', TRIM(IDProduct))-1) = IDP";
            DT = Class.DataConnection.GetDataToTable(sql);
            ExRange = ExSheet.Cells[1][hang + 13];
            ExRange.ColumnWidth = 14;
            ExRange.Range["C1:C1"].ColumnWidth = 40;
            ExRange.HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            ExRange.Range["A1:D1"].Font.Bold = true;
            ExRange.Range["A1:A1"].Value = "STT";
            ExRange.Range["B1:B1"].Value = "Mã sản phẩm";
            ExRange.Range["C1:C1"].Value = "Tên sản phẩm";
            ExRange.Range["D1:D1"].Value = "Số lượng bán ra";
            for (hang = 0; hang < DT.Rows.Count; hang++)
            {
                ExSheet.Cells[1][hang + 15] = hang + 1;
                for (cot = 0; cot < DT.Columns.Count; cot++)
                {
                    ExSheet.Cells[cot + 2][hang + 15] = DT.Rows[hang][cot].ToString();
                }
            }

            ExRange = ExSheet.Cells[2][hang + 16];
            ExRange.Font.Bold = true;
            ExRange.Font.Size = 14;
            ExRange.Value2 = "Danh sách sản phẩm có doanh thu nhiều nhất nhất";
            sql = "Select Distinct IDP as [Mã sản phẩm], left(trim(NameProduct), charindex('_', TRIM(NameProduct))-1) as [Tên sản phẩm], TotalMoney_P as [Doanh thu] from f_R_PMM('" + tB_Month.Text + "', '" + tB_Year.Text + "'), Product " +
                "where left(trim(IDProduct), charindex('_', TRIM(IDProduct))-1) = IDP";
            DT = Class.DataConnection.GetDataToTable(sql);
            ExRange = ExSheet.Cells[1][hang + 18];
            ExRange.ColumnWidth = 14;
            ExRange.HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            ExRange.Range["A1:D1"].Font.Bold = true;
            ExRange.Range["A1:A1"].Value = "STT";
            ExRange.Range["B1:B1"].Value = "Mã sản phẩm";
            ExRange.Range["C1:C1"].Value = "Tên sản phẩm";
            ExRange.Range["D1:D1"].Value = "Doanh thu";
            for (hang = 0; hang < DT.Rows.Count; hang++)
            {
                ExSheet.Cells[1][hang + 21] = hang + 1;
                for (cot = 0; cot < DT.Columns.Count; cot++)
                {
                    ExSheet.Cells[cot + 2][hang + 21] = DT.Rows[hang][cot].ToString();
                }
            }

            ExRange = ExSheet.Cells[2][hang + 22];
            ExRange.Font.Bold = true;
            ExRange.Font.Size = 14;
            ExRange.Value2 = "Tổng số lượng đơn hàng tháng " + tB_Month.Text + " là: " + tB_TotalOrder.Text + "";

            ExRange = ExSheet.Cells[2][hang + 24];
            ExRange.Font.Bold = true;
            ExRange.Font.Size = 14;
            ExRange.Value2 = "Tổng doanh thu tháng " + tB_Month.Text + " là: " + tB_TotalMoney.Text + "";

            ExSheet.Name = "Báo cáo doanh thu tháng";
            ExApp.Visible = true;
        }

        private void tB_Month_TextChanged(object sender, EventArgs e)
        {
            ResetValues();
        }

        private void tB_Year_TextChanged(object sender, EventArgs e)
        {
            ResetValues();
        }
    }
}

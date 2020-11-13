using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ShoeStore.GUI;
using System.Windows.Forms;

namespace ShoeStore.Class
{
    class DataConnection
    {
        //SqlConnection là đối tượng dùng để kết nối.
        //SqlDataAdapter là đối tuọng dùng để thực hiện các câu lệnh Select.
        //SqlCommand có 2 phương thức để thực thi câu lệnh SQL:
        // - ExecuteNoneQuery: thực thi các câu lệnh không yêu cầu trẻ về dữ liệu như Insert, Update, Delete.
        // - ExecuteReader: thực thi câu lệnh yêu cầu trả về dữ liệu như Select.
        public static SqlConnection Conn;   //Khai báo đối tượng kết nối

        public static void Connect()
        {
            Conn = new SqlConnection(); //Khởi tạo đối yượng kết nối
            Conn.ConnectionString = @"Data Source=ARIS-HOANG\SQLEXPRESS;Initial Catalog=ShoeStore;Integrated Security=True";
            Conn.Open();    //Mở kết nối
        }

        public static void Disconnect()
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();   //Đóng kết nối
                Conn.Dispose(); //Giải phóng tài nguyên
                Conn = null;
            }
        }

        //Hàm thực hiện câu lệnh query truy vấn dữ liệu và đổ vào bảng bảng.
        public static DataTable GetDataToTable(String query)
        {
            
                //Định nghĩa đối tượng thuộc lớp DataAdapter.
                SqlDataAdapter DA = new SqlDataAdapter(query, Conn);
                //Khai báo đối tương DT thuộc lớp DataTable.
                DataTable DT = new DataTable();
                //Đổ kết quả từ câu lệnh query vào DT.
                DA.Fill(DT);
                return DT;
        }

        public static void RunSql(string sql)
        {
            SqlCommand Cmd; //Đối tượng thuộc lớp Command.
            Cmd = new SqlCommand();
            Cmd.Connection = DataConnection.Conn;   //Gán kết nối.
            Cmd.CommandText = sql;  //Gán câu lệnh SQL.

            try
            {
                Cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL.
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Cmd.Dispose();             //Giải phóng bộ nhớ.
            Cmd = null;
        }

        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = DataConnection.Conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Dữ liệu đang được sử dụng, không thể xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }

        //Hàm kiểm tra kiểm tra khóa trùng.
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter DA = new SqlDataAdapter(sql, Conn);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            if (DT.Rows.Count > 0)
                return true;
            else return false;
        }

        //Hàm cập nhật ComboBox.
        public static void FillCombo(string query, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter DA = new SqlDataAdapter(query, Conn);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            cbo.DataSource = DT;
            //Trường giá trị.
            cbo.ValueMember = ma;
            //Trường hiển thị.
            cbo.DisplayMember = ten;
        }

        //Hàm lấy dữ liệu từ câu lệnh SQL.
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand Cmd = new SqlCommand(sql, Conn);
            SqlDataReader reader;
            // ExecuteReader thực thi câu lệnh sql yêu cầu dữ liệu trả về: Select
            reader = Cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }

        //Hàm chuyển đổi kiểu dữ liệu của ngày.
        public static string ConvertDateTime(string date)
        {
            string[] elements = date.Split('/');
            string dt = string.Format("{0}/{1}/{2}", elements[0], elements[1], elements[2]);
            return dt;
        }

        //Hàm tạo mã tự động theo ngày tháng năm.
        public static string CreateKey(string tiento)
        {
            //Mã có dạng: Tiền tố_ngaythangnam_giophutgiay
            string key = tiento;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');
            string d = String.Format("_{0}{1}{2}", partsDay[1], partsDay[0], partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }

        //Hàm đổi thời gian từ 12h thành 24h.
        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
            }
            return h;
        }

        //Hàm đăng nhập.
        public static string GetID(string un, string pass)
        {
            string ID = "";
            try
            {
                SqlCommand Cmd = new SqlCommand("Select * from Employee where Usename = '" + un + "' and Pass = '" + pass + "'", Conn);
                SqlDataAdapter DA = new SqlDataAdapter(Cmd);
                DataTable DT = new DataTable();
                DA.Fill(DT);
                if (DT != null)
                {
                    foreach (DataRow DR in DT.Rows)
                    {
                        ID = DR["IDEmployee"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ID;
        }

        public static bool IsNumber(string txt)
        {
            foreach (Char c in txt)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
}

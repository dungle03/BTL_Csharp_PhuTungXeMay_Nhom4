using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DevExpress.Xpo.DB.Helpers;

namespace PhuTungXeMay
{
    public class myClass
    {
        // Khai báo biến kết nối
        //static SqlConnection con = new SqlConnection();
        static SqlConnection con = new SqlConnection(@"Data Source=DUNGLE\DUNGLEE;Initial Catalog=CuaHangSuaChuaXeMay;User ID=sa;Password=mao29082003;");

        // tạo hàm kết nối
        public static void TaoKetNoi()
        {
            try 
            { 
                con.Open(); 
            }
            catch (Exception)
            {
                throw;
            }
        }

        // tạo hàm đóng kết nối
        public static void DongKetNoi()
        {
            con.Close();
        }

        // Hàm đổ dữ liệu vào database
        public static DataTable getData(string query)
        {
            TaoKetNoi();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(tb);
            DongKetNoi();
            return tb;
        }

        // Hàm lấy dữ liệu bằng DataSet
        public static DataSet getDataSet(string query)
        {
            TaoKetNoi();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        // Hàm thực thi câu lệnh
        public static void executeQuery(string query)
        {
            TaoKetNoi();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            DongKetNoi();
        }   
    }
}

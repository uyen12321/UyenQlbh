using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace QuanLyBanHangTaiPhucLong
{
    class Ketnoi
    {
        private string strCon = @"Data Source=DESKTOP-NTGIIVN\SQLEXPRESS;Initial Catalog=QUANLYBANHANGTAIPHUCLONG;Integrated Security=True";
        public SqlConnection GetConnect()
        {
            SqlConnection sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            return sqlCon;
        }
        public int EXECUTENONQUERY(string query)
        {
            int data = 0;
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                data = cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            return data;
        }


        public DataTable Executequery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(strCon))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataAdapter laydulieu = new SqlDataAdapter(cmd);
                laydulieu.Fill(data);
                sqlCon.Close();
            }
            return data;
        }
    }
}

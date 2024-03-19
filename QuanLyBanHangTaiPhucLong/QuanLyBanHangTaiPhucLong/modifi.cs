using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuanLyBanHangTaiPhucLong
{
    class modifi
    {
        
        public modifi()
        {

        }
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;
        public DataTable table(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = connection.GetConnect())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public void Command(string query)
        {
            using (SqlConnection sqlConnection = connection.GetConnect())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }

}

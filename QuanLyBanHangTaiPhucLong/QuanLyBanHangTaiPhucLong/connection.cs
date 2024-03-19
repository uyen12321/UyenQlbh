using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QuanLyBanHangTaiPhucLong
{
    class connection
    {
        private static string stringConnection = @"Data Source=DESKTOP-NTGIIVN\SQLEXPRESS;Initial Catalog=QUANLYBANHANGTAIPHUCLONG;Integrated Security=True";
        public static SqlConnection GetConnect()
        {

            return new SqlConnection(stringConnection);
        }
    }
}

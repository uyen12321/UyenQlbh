using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanHangTaiPhucLong
{
    public partial class FrmBaoCao : Form
    {
        public FrmBaoCao()
        {
            InitializeComponent();
        }

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            //BÀN ĂN
            Connection = new SqlConnection(str);
            Connection.Open();
            loaddata();

          
            //Món ăn
            Connection1 = new SqlConnection(str1);
            Connection1.Open();
            loaddata1();
            
            //DANH MỤC
            Connection2 = new SqlConnection(str2);
            Connection2.Open();
            loaddata2();

            //Thống kê
        }

        //BÀN ĂN
        //*******************************************************************************************
        SqlConnection Connection;
        SqlCommand Command;
        string str = @"Data Source=DESKTOP-NTGIIVN\SQLEXPRESS;Initial Catalog=QUANLYBANHANGTAIPHUCLONG;Integrated Security=True";
        SqlDataAdapter Adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            Command = Connection.CreateCommand();
            Command.CommandText = "Select * from dbo.DatBan";
            Adapter.SelectCommand = Command;
            table.Clear();
            Adapter.Fill(table);
            dtgvBanAn.DataSource = table;
        }

        private void dtgvBanAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaBan.ReadOnly = true;
            int i;
            i = dtgvBanAn.CurrentRow.Index;
            txtMaBan.Text = dtgvBanAn.Rows[i].Cells[0].Value.ToString();
            txtTenBan.Text = dtgvBanAn.Rows[i].Cells[1].Value.ToString();
            cbTrangThai.Text = dtgvBanAn.Rows[i].Cells[2].Value.ToString();
        }
    }
}

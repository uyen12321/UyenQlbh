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
            ConnectionDatBan = new SqlConnection(strDatBan);
            ConnectionDatBan.Open();
            loadDatBan();


            //Món ăn
            ConnectionMon = new SqlConnection(strMon);
            ConnectionMon.Open();
            loadMon();

            //DANH MỤC
            ConnectionDanhMuc = new SqlConnection(strDanhMuc);
            ConnectionDanhMuc.Open();
            loadDanhMuc();

            //Thống kê
        }

        //BÀN ĂN
        //*******************************************************************************************
        SqlConnection ConnectionDatBan;
        SqlCommand CommandDatBan;
        string strDatBan = @"Data Source=DESKTOP-NTGIIVN\SQLEXPRESS;Initial Catalog=QUANLYBANHANGTAIPHUCLONG;Integrated Security=True";
        SqlDataAdapter AdapterDatBan = new SqlDataAdapter();
        DataTable DatBan = new DataTable();

        void loadDatBan()
        {
            CommandDatBan = ConnectionDatBan.CreateCommand();
            CommandDatBan.CommandText = "Select * from dbo.DatBan";
            AdapterDatBan.SelectCommand = CommandDatBan;
            DatBan.Clear();
            AdapterDatBan.Fill(DatBan);
            dtgvBanAn.DataSource = DatBan;
        }
        //hiển thị sql
        private void dtgvBanAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtMaBan.ReadOnly = true;
            int i;
            i = dtgvBanAn.CurrentRow.Index;
            txtMaBan.Text = dtgvBanAn.Rows[i].Cells[0].Value.ToString();
            txtTenBan.Text = dtgvBanAn.Rows[i].Cells[1].Value.ToString();
            cbTrangThai.Text = dtgvBanAn.Rows[i].Cells[2].Value.ToString();
            txtMaKH.Text = dtgvBanAn.Rows[i].Cells[3].Value.ToString();
        }
        //thêm bàn
        private void btnThemBan_Click(object sender, EventArgs e)
        {
            CommandDatBan = ConnectionDatBan.CreateCommand();
            CommandDatBan.CommandText = "insert into dbo.DatBan values ('" + txtMaBan.Text + "', N'" + txtTenBan.Text + "' , N'" + cbTrangThai.Text + "', '"+txtMaKH.Text+"' )";
            CommandDatBan.ExecuteNonQuery();
            loadDatBan();
        }
        
       
        //sửa bàn
        private void btnSuaBan_Click(object sender, EventArgs e)
        {
            CommandDatBan = ConnectionDatBan.CreateCommand();
            CommandDatBan.CommandText = "update dbo.DatBan set  TenBan= N '" + txtTenBan.Text + "' , TrangThai= N '" + cbTrangThai.Text+ "', MaKH= '"+txtMaKH.Text+"'where MaBan = '" + txtMaBan.Text + "' ";
            CommandDatBan.ExecuteNonQuery();
            loadDatBan();
        }
        //xóa bàn
        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            CommandDatBan = ConnectionDatBan.CreateCommand();
            CommandDatBan.CommandText = "delete from dbo.DatBan where MaBan = '" + txtMaBan.Text + "'";
            CommandDatBan.ExecuteNonQuery();
            loadDatBan();
        }
        //THoát đặt bàn
        private void btnThoatBan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Khởi tạo đặt bàn
        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            txtMaBan.Text = "";
            txtTenBan.Text = "";
            cbTrangThai.Text = "";
            txtMaKH.Text = "";
        }




        //MÓN ĂN
        //*******************************************************************************************
        SqlConnection ConnectionMon;
        SqlCommand CommandMon;
        string strMon = @"Data Source=DESKTOP-NTGIIVN\SQLEXPRESS;Initial Catalog=QUANLYBANHANGTAIPHUCLONG;Integrated Security=True";
        SqlDataAdapter AdapterMon = new SqlDataAdapter();
        DataTable Mon = new DataTable();

        void loadMon()
        {
            CommandMon = ConnectionMon.CreateCommand();
            CommandMon.CommandText = "Select * from dbo.Mon";
            AdapterMon.SelectCommand = CommandMon;
            Mon.Clear();
            AdapterMon.Fill(Mon);
            dtgvMon.DataSource = Mon;
        }
        //Hiển thị món ăn
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //txtMaMon.ReadOnly = true;
            int i;
            i = dtgvMon.CurrentRow.Index;
            txtMaMon.Text = dtgvMon.Rows[i].Cells[0].Value.ToString();
            txtTenMon.Text = dtgvMon.Rows[i].Cells[1].Value.ToString();
            cbDanhMuc.Text = dtgvMon.Rows[i].Cells[2].Value.ToString();
            nupGiaMon.Text = dtgvMon.Rows[i].Cells[3].Value.ToString();
        }
        //Thêm món ăn
        private void btnThem_Click(object sender, EventArgs e)
        {
            CommandMon = ConnectionMon.CreateCommand();
            CommandMon.CommandText = "insert into dbo.Mon values (N'" + txtMaMon.Text + "', N'" + txtTenMon.Text + "' ,N'" + cbDanhMuc.Text + "'," + nupGiaMon.Text + " )";
            CommandMon.ExecuteNonQuery();
            loadMon();
        }
        //sửa món ăn
        private void btnSua_Click(object sender, EventArgs e)
        {
            CommandMon = ConnectionMon.CreateCommand();
            CommandMon.CommandText = "update dbo.Mon set TenMon= N'" + txtTenMon.Text + "' , DanhMuc= N'" + cbDanhMuc.Text + "', GiaMon= " + nupGiaMon.Text + " where MaMon = '" + txtMaMon.Text + "' ";
            CommandMon.ExecuteNonQuery();
            loadMon();
        }
        //xóa món ăn
        private void btnXoa_Click(object sender, EventArgs e)
        {
            CommandMon = ConnectionMon.CreateCommand();
            CommandMon.CommandText = "delete from dbo.Mon where MaMon = '" + txtMaMon.Text + "'";
            CommandMon.ExecuteNonQuery();
            loadMon();
        }
        //Khởi tạo món ăn
        private void btnKhoitaoMon_Click(object sender, EventArgs e)
        {
            txtMaMon.Text = "";
            txtTenMon.Text = "";
            cbDanhMuc.Text = "";
            nupGiaMon.Text = "";
        }
        //Thoát món ăn
        private void button1_Click(object sender, EventArgs e)
        {
             this.Close();
        }



        //DANH MỤC SẢN PHẨM//
        //*************************************************************************************************
        SqlConnection ConnectionDanhMuc;
        SqlCommand CommandDanhMuc;
        string strDanhMuc = @"Data Source=DESKTOP-NTGIIVN\SQLEXPRESS;Initial Catalog=QUANLYBANHANGTAIPHUCLONG;Integrated Security=True";
        SqlDataAdapter AdapterDanhMuc = new SqlDataAdapter();
        DataTable tableDanhMuc = new DataTable();

        void loadDanhMuc()
        {
            CommandDanhMuc = ConnectionDanhMuc.CreateCommand();
            CommandDanhMuc.CommandText = "Select * from dbo.DanhMucSanPham";
            AdapterDanhMuc.SelectCommand = CommandDanhMuc;
            tableDanhMuc.Clear();
            AdapterDanhMuc.Fill(tableDanhMuc);
            dtgvDanhMuc.DataSource = tableDanhMuc;

        }
        //hiển thị danh mục sản phẩm
        private void dtgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDM.ReadOnly = true;
            int i;
            i = dtgvDanhMuc.CurrentRow.Index;
            txtMaDM.Text = dtgvDanhMuc.Rows[i].Cells[0].Value.ToString();
            txtTenDM.Text = dtgvDanhMuc.Rows[i].Cells[1].Value.ToString();
        }
        //thêm danh mục
        private void btnThemDm_Click(object sender, EventArgs e)
        {
            CommandDanhMuc = ConnectionDanhMuc.CreateCommand();
            CommandDanhMuc.CommandText = "insert into dbo.DanhMucSanPham values (N'" + txtMaDM.Text + "',  N'" + txtTenDM.Text + "' )";
            CommandDanhMuc.ExecuteNonQuery();
            loadDanhMuc();
        }
        //sửa danh mục
        private void btnSuaDM_Click(object sender, EventArgs e)
        {
            CommandDanhMuc = ConnectionDanhMuc.CreateCommand();
            CommandDanhMuc.CommandText = "update dbo.DanhMucSanPham set  TenDanhMuc= N'" + txtTenDM.Text + "'where MaDanhMuc = '" + txtMaDM.Text + "' ";
            CommandDanhMuc.ExecuteNonQuery();
            loadDanhMuc();
        }
        //xóa danh mục
        private void btnXoaDM_Click(object sender, EventArgs e)
        {

            CommandDanhMuc = ConnectionDanhMuc.CreateCommand();
            CommandDanhMuc.CommandText = "delete from dbo.DanhMucSanPham where MaDanhMuc = '" + txtMaDM.Text + "'";
            CommandDanhMuc.ExecuteNonQuery();
            loadDanhMuc();
        }
        //Thoát danh mục
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //khởi tạo danh mục
        private void btnKhoiTaoDM_Click(object sender, EventArgs e)
        {
            txtMaDM.Text = "";
            txtTenDM.Text = "";
        }


        //THỐNG KÊ
        //**********************************************************************
        private void btnThoatTK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tpBan_Click(object sender, EventArgs e)
        {

        }
    }
}

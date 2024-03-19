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
        Ketnoi KN = new Ketnoi();
        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            LoadBanAN();
            LoadMon();
            LoadDanhMuc();
            LoadKM();

        }
        //*********************************************************************************
        //*********************************************************************************
        //Bàn ăn
        private void LoadBanAN()
        {
            string str = "SELECT * FROM DatBan";
            SqlDataAdapter da = new SqlDataAdapter(str, KN.GetConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgvBanAn.DataSource = dt;
        }

        //hiển thị sql
        private void dtgvBanAn_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaBan.Text = dtgvBanAn.CurrentRow.Cells[0].Value.ToString();
            txtTenBan.Text = dtgvBanAn.CurrentRow.Cells[1].Value.ToString();
            cbTrangThai.Text = dtgvBanAn.CurrentRow.Cells[2].Value.ToString();
            txtMaKH.Text = dtgvBanAn.CurrentRow.Cells[3].Value.ToString();
        }
        //thêm bàn
        private void btnThemBan_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dtgvBanAn.CurrentCell.RowIndex;
                string MaBan = txtMaBan.Text;
                string TenBan = txtTenBan.Text;
                string TrangThai = cbTrangThai.Text;
                string MaKH = txtMaKH.Text;
               
                KN.EXECUTENONQUERY("insert into DatBan values ('" + MaBan + "', N'" + TenBan + "', N'" + TrangThai + "','" + MaKH + "')");
                MessageBox.Show("Thêm Bàn  " + MaBan + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBanAN();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        //sửa bàn
        private void btnSuaBan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cho phép sửa bàn " + txtMaBan.Text + " Thông báo");
        }
        //xóa bàn
        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dtgvBanAn.CurrentCell.RowIndex;
                string MaBan = txtMaBan.Text;
                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY("delete from DatBan where MaBan='" + MaBan + "'");
                    MessageBox.Show("Xóa bàn " + MaBan + " thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBanAN();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Lưu bàn
        private void btnLuuBan_Click(object sender, EventArgs e)
        {

            try
            {
                int vitri = dtgvBanAn.CurrentCell.RowIndex;
                string MaBan = txtMaBan.Text;
                string TenBan = txtTenBan.Text;
                string TrangThai = cbTrangThai.Text;
                string MaKH = txtMaKH.Text;
                KN.EXECUTENONQUERY("update DatBan set TenBan ='" + TenBan + "',TrangThai = '" + TrangThai + "',MaKH ='" + MaKH + "' where MaBan='" + MaBan + "'");
                MessageBox.Show("Lưu bàn " + MaBan + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBanAN();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //THoát đặt bàn
        private void btnThoatBan_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn rời khỏi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK)
                this.Close();
        }
        
        //khởi tạo bàn
        private void btnKhoiTao_Click_1(object sender, EventArgs e)
        {
            txtMaBan.Text = "";
            txtTenBan.Text = "";
            txtMaKH.Text = "";
            cbTrangThai.Text = "";
        }

        //*****************************************************************************
        //*******************************************************************************
        private void LoadMon()
        {
            string str = "SELECT * FROM Mon";
            SqlDataAdapter da = new SqlDataAdapter(str, KN.GetConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgvMon.DataSource = dt;
        }
        //Hiển thị món ăn
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaMon.Text = dtgvMon.CurrentRow.Cells[0].Value.ToString();
            txtTenMon.Text = dtgvMon.CurrentRow.Cells[1].Value.ToString();
            cbDanhMuc.Text = dtgvMon.CurrentRow.Cells[2].Value.ToString();
            nupGiaMon.Text = dtgvMon.CurrentRow.Cells[3].Value.ToString();
        }
        //Thêm món ăn
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dtgvMon.CurrentCell.RowIndex;
                string MaMon = txtMaMon.Text;
                string TenMon = txtTenMon.Text;
                string TenDanhMuc = cbDanhMuc.Text;              
                string GiaMon = nupGiaMon.Text;

                KN.EXECUTENONQUERY("insert into Mon values ('" + MaMon + "', '" + TenMon + "', N'" + TenDanhMuc + "',N'" + GiaMon + "')");
                MessageBox.Show("Thêm món ăn " + MaMon + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMon();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        //sửa món ăn
        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cho phép sửa món ăn " + txtMaMon.Text + " Thông báo");
        }
        //xóa món ăn
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dtgvMon.CurrentCell.RowIndex;
                string MaMon = dtgvMon.Rows[vitri].Cells[0].Value.ToString();
                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY("delete from Mon where MaMon='" + MaMon + "'");
                    MessageBox.Show("Xóa món ăn " + MaMon + " thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnLuuMon_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dtgvMon.CurrentCell.RowIndex;
                string MaMon = txtMaMon.Text;
                string TenMon = txtTenMon.Text;
                string TenDanhMuc = cbDanhMuc.Text;
                string GiaMon = nupGiaMon.Text;
                KN.EXECUTENONQUERY("update Mon set TenMon ='" + TenMon + "',MaDanhMuc = '" + TenDanhMuc + "',GiaMon ='" + GiaMon + "' where MaMon='" + MaMon + "'");
                MessageBox.Show("Lưu món ăn " + MaMon + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn rời khỏi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK)
                this.Close();
        }
        //****************************************************************************************************      
        //*************************************************************************************************
        //DANH MỤC SẢN PHẨM//
        private void LoadDanhMuc()
        {
            string str = "SELECT * FROM DanhMucSanPham";
            SqlDataAdapter da = new SqlDataAdapter(str, KN.GetConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgvDanhMuc.DataSource = dt;
        }
        //hiển thị danh mục sản phẩm
        private void dtgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDM.Text = dtgvDanhMuc.CurrentRow.Cells[0].Value.ToString();
            txtTenDM.Text = dtgvDanhMuc.CurrentRow.Cells[1].Value.ToString();
        }
        //thêm danh mục
        private void btnThemDm_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dtgvDanhMuc.CurrentCell.RowIndex;
                string MaDanhMuc = txtMaDM.Text;
                string TenDanhMuc = txtTenDM.Text;               
                KN.EXECUTENONQUERY("insert into DanhMucSanPham values ('" + MaDanhMuc + "', N'" + TenDanhMuc + "')");
                MessageBox.Show("Thêm danh mục sản phẩm " + MaDanhMuc + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhMuc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            
        }
        //sửa danh mục
        private void btnSuaDM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cho phép sửa món ăn " + txtMaDM.Text + " Thông báo");
        }
        //xóa danh mục
        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            try
            {

                int vitri = dtgvDanhMuc.CurrentCell.RowIndex;
                string MaDanhMuc = dtgvDanhMuc.Rows[vitri].Cells[0].Value.ToString();
                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY("delete from DanhMucSanPham where MaDanhMuc='" + MaDanhMuc + "'");
                    MessageBox.Show("Xóa danh mục sản phẩm " + MaDanhMuc + " thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhMuc();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //lưu danh mục
        private void btnLuuDM_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dtgvDanhMuc.CurrentCell.RowIndex;
                string MaDanhMuc = txtMaDM.Text;
                string TenDanhMuc = txtTenDM.Text;
                KN.EXECUTENONQUERY("update DanhMucSanPham set TenDanhMuc ='" + TenDanhMuc + "' where MaDanhMuc='" + MaDanhMuc + "'");
                MessageBox.Show("Lưu danh mục sản phẩm " + MaDanhMuc + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhMuc();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Thoát danh mục
        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn rời khỏi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK)
                this.Close();
        }
        //khởi tạo danh mục
        private void btnKhoiTaoDM_Click(object sender, EventArgs e)
        {
            txtMaDM.Text = "";
            txtTenDM.Text = "";
        }


        //*********************************************************************
        //**********************************************************************
        //KHuyến mãi
        void LoadKM()
        {
            string str = "SELECT * FROM KhuyenMai";
            SqlDataAdapter da = new SqlDataAdapter(str, KN.GetConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
        }
    
        private void tpBan_Click(object sender, EventArgs e)
        {

        }
        //hiển thị khuyến mãi
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {           
            txtMaKM.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            txtMaHD.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            txtTenCT.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            dateTimeTu.Text =  dataGridView3.CurrentRow.Cells[3].Value.ToString();
            dateTimeDen.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
            cbHinhThuc.Text = dataGridView3.CurrentRow.Cells[5].Value.ToString();
            cbDieuKien.Text = dataGridView3.CurrentRow.Cells[6].Value.ToString();
        }
        //thêm khuyến mãi
        private void btnThemKM_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dataGridView3.CurrentCell.RowIndex;
                string MaKM = txtMaKM.Text;
                string MaHD = txtMaHD.Text;
                string TenCTKM = txtTenCT.Text;
                string NgayBDKM = dateTimeTu.Text;
                string NgayKTKM = dateTimeDen.Text;
                string HinhThucKM = cbHinhThuc.Text;
                string DKApDung = cbDieuKien.Text;
                KN.EXECUTENONQUERY("insert into KhuyenMai values ('" + MaKM + "', '" + MaHD + "', N'" + TenCTKM + "','" + NgayBDKM + "','" + NgayKTKM + "',  '" + HinhThucKM + "', '" + DKApDung + "')");
                MessageBox.Show("Thêm khuyến mãi " + MaKM + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKM();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }
        //xóa khuyến mãi
        private void btnXoaKM_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dataGridView3.CurrentCell.RowIndex;
                string MaKM = dataGridView3.Rows[vitri].Cells[0].Value.ToString();

                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY("delete from KhuyenMai where MaKM='" + MaKM + "'");
                    MessageBox.Show("Xóa chương trình khuyến mãi " + MaKM + " thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKM();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //sửa khuyến mãi
        private void btnSuaKM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cho phép sửa chương trình khuyến mãi " + txtMaKM.Text + " Thông báo");
        }
        //lưu khuyến mãi
        private void btnLuuKM_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dataGridView3.CurrentCell.RowIndex;
                string MaKM = txtMaKM.Text;
                string MaHD = txtMaHD.Text;
                string TenCTKM = txtTenCT.Text;
                string NgayBDKM = dateTimeTu.Text;
                string NgayKTKM = dateTimeDen.Text;
                string HinhThucKM = cbHinhThuc.Text;
                string DKApDung = cbDieuKien.Text;
                KN.EXECUTENONQUERY("update KhuyenMai set MaHD='" + MaHD + "',TenCTKM = '" + TenCTKM + "',NgayBDKM ='" + NgayBDKM + "', NgayKTKM ='" + NgayKTKM + "', HinhThucKM ='" + HinhThucKM + "', DKApDung ='" + DKApDung + "' where MaKM='" + MaKM + "'");
                MessageBox.Show("Lưu Chương trình khuyến mãi " + MaKM + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKM();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //thoát khuyến mãi
        private void btnThoatTK_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn rời khỏi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK)
                this.Close();
        }       
        //khởi tạo khuyến mãi
        private void btnKhoiTaoKM_Click(object sender, EventArgs e)
        {
            txtMaKM.Text = "";
            txtMaHD.Text = "";
            txtTenCT.Text = "";
            dateTimeTu.Text = "";
            dateTimeDen.Text = "";
            cbHinhThuc.Text = "";
            cbDieuKien.Text = "";
        }

        private void txtMaKM_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenCT_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbDieuKien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

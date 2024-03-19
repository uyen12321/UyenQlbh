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
    public partial class FrmXuatNhapKho : Form
    {
        public FrmXuatNhapKho()
        {
            InitializeComponent();
        }
        Ketnoi KN = new Ketnoi();
        //khai báo
        private void LoadNhap()
        {
            string str = "SELECT * FROM PhieuNhapKho";
            SqlDataAdapter da = new SqlDataAdapter(str, KN.GetConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgvNK.DataSource = dt;
        }
        private void LoadXuat()
        {
            string str = "SELECT * FROM PhieuXuatKho";
            SqlDataAdapter da = new SqlDataAdapter(str, KN.GetConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgvXK.DataSource = dt;
        }
        //tải dữ liệu
        private void FrmXuatNhapKho_Load(object sender, EventArgs e)
        {
            
            LoadNhap();
            LoadXuat();
        }
        //********************************************************************
        //********************************************************************
        //Nhập KHO
        //hiển thị nhập kho
        private void dtgvXK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNK.Text = dtgvNK.CurrentRow.Cells[0].Value.ToString();
            txtMaKho.Text = dtgvNK.CurrentRow.Cells[1].Value.ToString();
            dtpkNNK.Text = dtgvNK.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dtgvNK.CurrentRow.Cells[3].Value.ToString();
            txtMaNV.Text = dtgvNK.CurrentRow.Cells[4].Value.ToString();
        }
        //thêm nhập kho
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dtgvNK.CurrentCell.RowIndex;
                string MaNK = txtMaNK.Text;
                string MaKho = txtMaKho.Text;
                string NgayNK = dtpkNNK.Text;
                string SoLuongNhap = txtSoLuong.Text;
                string MaNV = txtMaNV.Text;
               
                KN.EXECUTENONQUERY("insert into PhieuNhapKho values ('" + MaNK + "','" + MaKho + "', '" + NgayNK + "','" + SoLuongNhap + "','" + MaNV + "')");
                MessageBox.Show("Thêm phiếu nhập kho " + MaNK + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhap();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo thêm thất bại", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        //sửa nhập kho
        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cho phép sửa phiếu nhập kho " + txtMaNK.Text + " Thông báo");
        }
        //xóa nhập kho
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                int vitri = dtgvNK.CurrentCell.RowIndex;
                string MaNK = dtgvNK.Rows[vitri].Cells[0].Value.ToString();

                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY("delete from PhieuNhapKho where MaNK='" + MaNK + "'");
                    MessageBox.Show("Xóa phiếu nhập kho " + MaNK + " thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //lưu nhập kho
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {

                int vitri = dtgvNK.CurrentCell.RowIndex;
                string MaNK = txtMaNK.Text;
                string MaKho = txtMaKho.Text;
                string NgayNK = dtpkNNK.Text;
                string SoLuongNhap = txtSoLuong.Text;
                string MaNV = txtMaNV.Text;
                KN.EXECUTENONQUERY("update PhieuNhapKho set  MaKho ='" + MaKho + "',NgayNK ='" + NgayNK + "',SoLuongNhap = '" + SoLuongNhap + "',MaNV ='" + MaNV + "'  where MaNK='" + MaNK + "'");
                MessageBox.Show("Lưu phiếu nhập kho " + MaNK + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhap();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //tìm  nhập kho
        private void btnTimNV_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery("select * From PhieuNhapKho"));
            if (rbtnMaNK.Checked == true)
            {
                dv.RowFilter = string.Format("MaNK LIKE '%{0}%'", txtTimMaNK.Text);
                dtgvNK.DataSource = dv;
            }
            else if (rbtnMaNV.Checked == true)
            {
                dv.RowFilter = string.Format("MaNV LIKE '%{0}%'", txtTimMaNV.Text);
                dtgvNK.DataSource = dv;
            }
        }
        //khởi tạo nhập kho
        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtMaNK.Text = "";
            txtMaKho.Text = "";
            txtSoLuong.Text = "";
            dtpkNNK.Text = "";
        }
        //thoát nhập kho
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn rời khỏi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK)
                this.Close();
        }

        //*************************************************************************************
        //****************************************************************************************
        //***************************************************************************************
        //xuất KHO
        private void dtgvXK_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaXK.Text = dtgvXK.CurrentRow.Cells[0].Value.ToString();
            txtMaKhoXuat.Text = dtgvXK.CurrentRow.Cells[1].Value.ToString();
            dtpkNXK.Text = dtgvXK.CurrentRow.Cells[2].Value.ToString();
            txtSoLuongXuat.Text = dtgvXK.CurrentRow.Cells[3].Value.ToString();
            txtMaNVxuat.Text = dtgvXK.CurrentRow.Cells[4].Value.ToString();
        }
        private void btnThemX_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dtgvXK.CurrentCell.RowIndex;
                string MaXK = txtMaXK.Text;
                string MaKho = txtMaKhoXuat.Text;
                string NgayXK = dtpkNXK.Text;
                string SoLuongXuat = txtSoLuongXuat.Text;
                string MaNV = txtMaNVxuat.Text;

                KN.EXECUTENONQUERY("insert into PhieuXuatKho values ('" + MaXK + "','" + MaKho + "', '" + NgayXK + "','" + SoLuongXuat + "','" + MaNV + "')");
                MessageBox.Show("Thêm phiếu xuất kho " + MaXK + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadXuat();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnSuaX_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cho phép sửa phiếu xuất kho " + txtMaXK.Text + " Thông báo");
        }

        private void btnXoaX_Click(object sender, EventArgs e)
        {
            try
            {

                int vitri = dtgvXK.CurrentCell.RowIndex;
                string MaXK = dtgvXK.Rows[vitri].Cells[0].Value.ToString();

                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY("delete from PhieuXuatKho where MaXK='" + MaXK + "'");
                    MessageBox.Show("Xóa phiếu xuất kho " + MaXK + " thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadXuat();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuX_Click(object sender, EventArgs e)
        {
            try
            {

                int vitri = dtgvXK.CurrentCell.RowIndex;
                string MaXK = txtMaNK.Text;
                string MaKho = txtMaKhoXuat.Text;
                string NgayXK = dtpkNXK.Text;
                string SoLuongXuat = txtSoLuongXuat.Text;
                string MaNV = txtMaNVxuat.Text;
                KN.EXECUTENONQUERY("update PhieuXuatKho set  MaKho ='" + MaKho + "', NgayXK ='" + NgayXK + "',SoLuongXuat = '" + SoLuongXuat + "',MaNV ='" + MaNV + "'  where MaXK='" + MaXK + "'");
                MessageBox.Show("Lưu phiếu xuất kho " + MaXK + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadXuat();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKhoiTaoX_Click(object sender, EventArgs e)
        {
            txtMaNVxuat.Text = "";
            txtMaNK.Text = "";
            txtSoLuongXuat.Text = "";
            dtpkNXK.Text = "";
            txtMaKhoXuat.Text = "";
        }

        private void btnThoatX_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn rời khỏi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK)
                this.Close();
        }

        private void btnTimXK_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery("select * From PhieuXuatKho"));
            if (rMaXK.Checked == true)
            {
                dv.RowFilter = string.Format("MaXK LIKE '%{0}%'", txtTimMaXK.Text);
                dtgvXK.DataSource = dv;
            }
            else if (rMaNV.Checked == true)
            {
                dv.RowFilter = string.Format("MaNV LIKE '%{0}%'", txtTimMaNVXK.Text);
                dtgvXK.DataSource = dv;
            }
        }

        
    }
}

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
    public partial class FrmLuongNhanVien : Form
    {
        public FrmLuongNhanVien()
        {
            InitializeComponent();
        }
        Ketnoi KN = new Ketnoi();

        private void LoadLuongNV()
        {
            string str = "SELECT * FROM LuongNhanVien";
            SqlDataAdapter da = new SqlDataAdapter(str, KN.GetConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgvLuongNV.DataSource = dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //tải dữ liệu
        private void FrmLuongNhanVien_Load(object sender, EventArgs e)
        {
            LoadLuongNV();
        }
        //hiển thị
        private void dtgvLuongNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dtgvLuongNV.CurrentRow.Cells[0].Value.ToString();
            txtMaCV.Text = dtgvLuongNV.CurrentRow.Cells[1].Value.ToString();
            txtTenCV.Text = dtgvLuongNV.CurrentRow.Cells[2].Value.ToString();
            timeNhanChuc.Text = dtgvLuongNV.CurrentRow.Cells[3].Value.ToString();
            txtMaPC.Text = dtgvLuongNV.CurrentRow.Cells[4].Value.ToString();
            txtMaCLV.Text = dtgvLuongNV.CurrentRow.Cells[5].Value.ToString();
            txtGioBatDau.Text = dtgvLuongNV.CurrentRow.Cells[6].Value.ToString();
            txtGioKetThuc.Text = dtgvLuongNV.CurrentRow.Cells[7].Value.ToString();
            txtLuong.Text = dtgvLuongNV.CurrentRow.Cells[8].Value.ToString();
            txtGhiChu.Text = dtgvLuongNV.CurrentRow.Cells[9].Value.ToString();
        }
        //thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dtgvLuongNV.CurrentCell.RowIndex;
                string MaNV = txtMaNV.Text;
                string MaCV = txtMaCV.Text;
                string TenChucVu = txtTenCV.Text;
                string NgayNhanChuc = timeNhanChuc.Text;
                string MaPC = txtMaPC.Text;
                string MaCLV = txtMaCLV.Text;
                string GioBD = txtGioBatDau.Text;
                string GioKT = txtGioKetThuc.Text;
                string Luong = txtLuong.Text;
                string GhiChu = txtGhiChu.Text;

                KN.EXECUTENONQUERY("insert into LuongNhanVien values ('" + MaNV + "', '" + MaCV + "', N'" + TenChucVu + "',N'" + NgayNhanChuc + "','" + MaPC + "','" + MaCLV + "','" + GioBD + "','" + GioKT + "','" + Luong + "','" + GhiChu + "')");
                MessageBox.Show("Thêm thông tin lương của nhân viên " + MaNV + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLuongNV();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        //sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cho phép sửa lương của Nhân viên " + txtMaNV.Text+ " Thông báo");
        }
        //xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                int vitri = dtgvLuongNV.CurrentCell.RowIndex;
                string MaNV = dtgvLuongNV.Rows[vitri].Cells[0].Value.ToString();

                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY("delete from LuongNhanVien where MaNV='" + MaNV + "'");
                    MessageBox.Show("Xóa thông tin lương của nhân viên " + MaNV + " thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLuongNV();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //lưu
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dtgvLuongNV.CurrentCell.RowIndex;
                string MaNV = txtMaNV.Text;
                string MaCV = txtMaCV.Text;
                string TenChucVu = txtTenCV.Text;
                string NgayNhanChuc = timeNhanChuc.Text;
                string MaPC = txtMaPC.Text;
                string MaCLV = txtMaCLV.Text;
                string GioBatDau = txtGioBatDau.Text;
                string GioKetThuc = txtGioKetThuc.Text;
                string Luong = txtLuong.Text;
                string GhiChu = txtGhiChu.Text;
                KN.EXECUTENONQUERY("update LuongNhanVien set MaCV ='" + MaCV + "',TenChucVu= '" + TenChucVu + "',NgayNhanChuc ='" + NgayNhanChuc + "', MaPC  ='" + MaPC + "', " +
                    "MaCLV  ='" + MaCLV+ "', GioBD  ='" + GioBatDau + "', GioKT  ='" + GioKetThuc + "', Luong  ='" + Luong + "', GhiChu  =  '" + GhiChu + "' where MaNV='" + MaNV + "'");
                MessageBox.Show("Lưu thông tin lương của nhân viên " + MaNV + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLuongNV();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //tạo mới
        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtMaCV.Text = "";
            txtTenCV.Text = "";
            timeNhanChuc.Text = "";
            txtMaPC.Text = "";
            txtMaCLV.Text = "";
            txtGioBatDau.Text = "";
            txtGioKetThuc.Text = "";
            txtLuong.Text = "";
            txtGhiChu.Text = "";
        }

        //thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn rời khỏi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK)
                this.Close();
        }

        private void txtGioBatDau_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

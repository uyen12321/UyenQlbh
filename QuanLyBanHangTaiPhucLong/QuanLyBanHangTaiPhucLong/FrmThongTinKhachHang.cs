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
    public partial class FrmThongTinKhachHang : Form
    {
        public FrmThongTinKhachHang()
        {
            InitializeComponent();
        }
        Ketnoi KN = new Ketnoi();
        private void LoadKhachHang()
        {
            string str = "SELECT * FROM KhachHang";
            SqlDataAdapter da = new SqlDataAdapter(str, KN.GetConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgvThongTinKhachHang.DataSource = dt;
        }
        //tải dữ liệu
        private void FrmThongTinKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }
        //hiển thị
        private void dtgvThongTinNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKH.Text = dtgvThongTinKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtMaCN.Text = dtgvThongTinKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtHoTenKH.Text = dtgvThongTinKhachHang.CurrentRow.Cells[2].Value.ToString();
            dtpkNSKH.Text = dtgvThongTinKhachHang.CurrentRow.Cells[3].Value.ToString();
            txtGTinhKH.Text = dtgvThongTinKhachHang.CurrentRow.Cells[4].Value.ToString();
            txtDChiKH.Text = dtgvThongTinKhachHang.CurrentRow.Cells[5].Value.ToString();
            txtSDTKH.Text = dtgvThongTinKhachHang.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dtgvThongTinKhachHang.CurrentRow.Cells[7].Value.ToString();
            dtpkNDk.Text = dtgvThongTinKhachHang.CurrentRow.Cells[8].Value.ToString();
            txtCMNDKH.Text = dtgvThongTinKhachHang.CurrentRow.Cells[9].Value.ToString();
            txtTongDiemKH.Text = dtgvThongTinKhachHang.CurrentRow.Cells[10].Value.ToString();
            cbThanhVien.Text = dtgvThongTinKhachHang.CurrentRow.Cells[11].Value.ToString();
        }
        //thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dtgvThongTinKhachHang.CurrentCell.RowIndex;
                string MaKH = txtMaKH.Text;
                string MaCN = txtMaCN.Text;
                string HoTenKH = txtHoTenKH.Text;
                string NgaySinh = dtpkNSKH.Text;
                string GioiTinh = txtGTinhKH.Text;
                string DiaChi = txtDChiKH.Text;
                string SDT = txtSDTKH.Text;
                string Email = txtEmail.Text;
                string NgayDangKy = dtpkNDk.Text;
                string CMNDorCCCD = txtCMNDKH.Text;
                string TongDiem = txtTongDiemKH.Text;
                string ThanhVien = cbThanhVien.Text;

                KN.EXECUTENONQUERY("insert into KhachHang values ('" + MaKH + "', '" + MaCN+ "', N'" + HoTenKH + "','" + NgaySinh + "','" + GioiTinh + "'," +
                    "'" + DiaChi + "','" + SDT + "','" + Email + "','" + NgayDangKy + "','" + CMNDorCCCD + "','" + TongDiem + "','" + ThanhVien + "')");
                MessageBox.Show("Thêm Khách hàng " + MaKH + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhachHang();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        //sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cho phép sửa thông tin khách hàng " + txtMaKH.Text + " Thông báo");
        }
        //xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                int vitri = dtgvThongTinKhachHang.CurrentCell.RowIndex;
                string MaKH = dtgvThongTinKhachHang.Rows[vitri].Cells[0].Value.ToString();

                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY("delete from KhachHang where MaKH='" + MaKH + "'");
                    MessageBox.Show("Xóa thông tin khách hàng " + MaKH + " thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHang();
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
                int vitri = dtgvThongTinKhachHang.CurrentCell.RowIndex;
                string MaKH = txtMaKH.Text;
                string MaCN = txtMaCN.Text;
                string HoTenKH = txtHoTenKH.Text;
                string NgaySinh = dtpkNSKH.Text;
                string GioiTinh = txtGTinhKH.Text;
                string DiaChi = txtDChiKH.Text;
                string SDT = txtSDTKH.Text;
                string Email = txtEmail.Text;
                string NgayDangKy = dtpkNDk.Text;
                string CMNDorCCCD = txtCMNDKH.Text;
                string TongDiem = txtTongDiemKH.Text;
                string ThanhVien = cbThanhVien.Text;
                KN.EXECUTENONQUERY("update KhachHang set MaCN ='" + MaCN + "',HoTenKH =  '" + HoTenKH + "',NgaySinh =  '" + NgaySinh + "',GioiTinh =  '" + GioiTinh + "', DiaChi =  '" + DiaChi + "', SDT ='" + SDT + "',Email = '" + Email + "',NgayDangKy =  '" + NgayDangKy + "',CMNDorCCCD =  '" + CMNDorCCCD + "',TongDiem = '" + TongDiem + "',ThanhVien =  '" + ThanhVien + "' where MaKH='" + MaKH + "'");
                MessageBox.Show("Lưu thông tin khách hàng " + MaKH + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadKhachHang();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
       
        //tạo mới
        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtMaCN.Text = "";
            txtHoTenKH.Text = "";
            txtGTinhKH.Text = "";
            txtEmail.Text = "";
            txtCMNDKH.Text = "";
            txtDChiKH.Text = "";
            txtSDTKH.Text = "";
            dtpkNDk.Text = "";
            dtpkNSKH.Text = "";
            cbThanhVien.Text = "";
            txtTongDiemKH.Text = "";
        }
        //thoát
        private void btnThoat_Click_1(object sender, EventArgs e)
        {

            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn rời khỏi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK)
                this.Close();
        }
    }
}

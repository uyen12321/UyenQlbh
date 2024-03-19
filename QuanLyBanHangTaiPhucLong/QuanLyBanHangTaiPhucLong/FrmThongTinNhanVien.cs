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
    public partial class FrmThongTinNhanVien : Form
    {
        public FrmThongTinNhanVien()
        {
            InitializeComponent();
        }
        Ketnoi KN = new Ketnoi();
       

        void loadThongTinNV()
        {
            string str = "SELECT * FROM NhanVien";
            SqlDataAdapter da = new SqlDataAdapter(str, KN.GetConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgvThongTinNV.DataSource = dt;
        }
        //tải dữ liệu
        private void FrmThongTinNhanVien_Load(object sender, EventArgs e)
        {

            loadThongTinNV();
        }
        //hiển thị sql
        private void dtgvThongTinNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dtgvThongTinNV.CurrentRow.Cells[0].Value.ToString();
            txtMaCN.Text = dtgvThongTinNV.CurrentRow.Cells[1].Value.ToString();
            txtHoTenNV.Text = dtgvThongTinNV.CurrentRow.Cells[2].Value.ToString();
            dtpkNgaySinhNV.Text = dtgvThongTinNV.CurrentRow.Cells[3].Value.ToString();
            cbGioiTinhNV.Text= dtgvThongTinNV.CurrentRow.Cells[4].Value.ToString(); ;
            txtCMNDorCCCDNV.Text = dtgvThongTinNV.CurrentRow.Cells[5].Value.ToString();
            txtDiaChiNV.Text = dtgvThongTinNV.CurrentRow.Cells[6].Value.ToString();
            txtSDTNV.Text = dtgvThongTinNV.CurrentRow.Cells[7].Value.ToString();
            txtEmail.Text = dtgvThongTinNV.CurrentRow.Cells[8].Value.ToString();
        }
        //Thêm Nhân viên
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dtgvThongTinNV.CurrentCell.RowIndex;
                string MaNV = txtMaNV.Text;
                string MaCN = txtMaCN.Text;
                string HoTenNV = txtHoTenNV.Text;
                string NgaySinh = dtpkNgaySinhNV.Text;
                string GioiTinhNV = cbGioiTinhNV.Text;
                string CMNDorCCCD = txtCMNDorCCCDNV.Text;
                string DiaChi = txtDiaChiNV.Text;
                string SDT = txtSDTNV.Text;
                string Email = txtEmail.Text;
                KN.EXECUTENONQUERY("insert into NhanVien values ('" + MaNV + "', '" + MaCN + "', '" + HoTenNV + "','" + NgaySinh + "','" + GioiTinhNV + "','" + CMNDorCCCD + "','" + DiaChi + "','" + SDT + "','" + Email + "')");
                MessageBox.Show("Thêm thông tin của nhân viên " + MaNV + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadThongTinNV();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            
        }

        //sửa nhân viên
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cho phép sửa thông tin của nhân viên " + txtMaNV.Text + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //try
            //{
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Cho phép sửa thông tin nhân viên" + txtMaNV.Text + " Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            //}
            //MessageBox.Show("Thông báo" + txtMaNV.Text + "\n\nCho phép sửa nhân viên ");
            //MessageBox.Show(ex.Message, "Cho phép sửa thông tin nhân viên " + txtMaNV.Text + " Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        //Lưu nhân viên
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dtgvThongTinNV.CurrentCell.RowIndex;
                string MaNV = txtMaNV.Text;
                string MaCN = txtMaCN.Text;
                string HoTenNV = txtHoTenNV.Text;
                string NgaySinh = dtpkNgaySinhNV.Text;               
                string GioiTinhNV = cbGioiTinhNV.Text;
                string CMNDorCCCD = txtCMNDorCCCDNV.Text;
                string DiaChi = txtDiaChiNV.Text;
                string SDT = txtSDTNV.Text;
                string Email = txtEmail.Text;
                KN.EXECUTENONQUERY("update NhanVien set MaCN ='" + MaCN + "',HoTenNV = '" + HoTenNV + "',NgaySinh = '" + NgaySinh + "',GioiTinhNV = '" + GioiTinhNV + "',CMNDorCCCD = '" + CMNDorCCCD + "',DiaChi ='" + DiaChi + "', SDT ='" + SDT + "',Email = '" + Email + "' where MaNV='" + MaNV+ "'");
                MessageBox.Show("Lưu thông tin nhân viên " + MaNV + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadThongTinNV();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //xóa nhân viên
        private void btnXoaNV_Click(object sender, EventArgs e)
        {


            try
            {

                int vitri = dtgvThongTinNV.CurrentCell.RowIndex;
                string MaNV = dtgvThongTinNV.Rows[vitri].Cells[0].Value.ToString();

                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY("delete from NhanVien where MaNV='" + MaNV + "'");
                    MessageBox.Show("Xóa thông tin nhân viên " + MaNV + " thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadThongTinNV();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        //khởi tạo nhân viên
        private void btnKhoiTaoNV_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "";
            txtMaCN.Text = "";
            txtHoTenNV.Text = "";
            dtpkNgaySinhNV.Text = "";
            txtEmail.Text = "";
            cbGioiTinhNV.Text = "";
            txtCMNDorCCCDNV.Text = "";
            txtDiaChiNV.Text = "";
            txtSDTNV.Text = "";
            
        }
        //Thoát nhân viên
        private void btnThoat_Click(object sender, EventArgs e)
        {

            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn rời khỏi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK)
                this.Close();
        }

       
    }
}

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
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        Ketnoi KN = new Ketnoi();
        private void LoadHoaDon()
        {
            string str = "SELECT * FROM HoaDon";
            SqlDataAdapter da = new SqlDataAdapter(str, KN.GetConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgvHoaDon.DataSource = dt;
        }
        private void HoaDon_Load(object sender, EventArgs e)
        {

            LoadHoaDon();
        }
        //hiển thị
        private void dtgvBanAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Text = dtgvHoaDon.CurrentRow.Cells[0].Value.ToString();
            txtMaNV.Text = dtgvHoaDon.CurrentRow.Cells[1].Value.ToString();
            txtMaKH.Text = dtgvHoaDon.CurrentRow.Cells[2].Value.ToString();
            txtThanhTien.Text = dtgvHoaDon.CurrentRow.Cells[3].Value.ToString();
            timeNgayLap.Text = dtgvHoaDon.CurrentRow.Cells[4].Value.ToString();
            txtGhiChu.Text = dtgvHoaDon.CurrentRow.Cells[5].Value.ToString();
        }
        //thêm
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dtgvHoaDon.CurrentCell.RowIndex;
                string MaHD = txtMaHD.Text;
                string MaNV = txtMaNV.Text;
                string MaKH = txtMaKH.Text;
                string ThanhTien = txtThanhTien.Text;
                string NgayLapHD = timeNgayLap.Text;
                string GhiChu = txtGhiChu.Text;

                KN.EXECUTENONQUERY("insert into HoaDon values ('" + MaHD + "', '" + MaNV + "', N'" + MaKH + "',N'" + ThanhTien + "','" + NgayLapHD + "','" + GhiChu + "')");
                MessageBox.Show("Thêm hóa đơn " + MaHD + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHoaDon();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        //sửa
        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cho phép sửa hóa đơn " + txtMaHD.Text + " Thông báo");
        }
        //xóa
        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            try
            {

                int vitri = dtgvHoaDon.CurrentCell.RowIndex;
                string MaHD = dtgvHoaDon.Rows[vitri].Cells[0].Value.ToString();

                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY("delete from HoaDon where MaHD='" + MaHD + "'");
                    MessageBox.Show("Xóa hóa đơn " + MaHD + " thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadHoaDon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //lưu
        private void btnLuuHD_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dtgvHoaDon.CurrentCell.RowIndex;
                string MaHD = txtMaHD.Text;
                string MaNV = txtMaNV.Text;
                string MaKH = txtMaKH.Text;
                string ThanhTien = txtThanhTien.Text;
                string NgayLapHD = timeNgayLap.Text;
                string GhiChu = txtGhiChu.Text;
                KN.EXECUTENONQUERY("update HoaDon set MaNV ='" + MaNV + "',MaKH = '" + MaKH + "',ThanhTien ='" + ThanhTien + "', NgayLapHD ='" + NgayLapHD + "', GhiChu ='" + GhiChu + "' where MaHD='" + MaHD + "'");
                MessageBox.Show("Lưu hóa đơn " + MaHD + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHoaDon();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //thoát
        private void btnThoatHD_Click(object sender, EventArgs e)
        {

            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn rời khỏi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK)
                this.Close();
        }
        //khởi tạo
        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            txtMaNV.Text = "";
            txtMaKH.Text = "";
            txtThanhTien.Text = "";
            txtGhiChu.Text = "";
            timeNgayLap.Text = "";
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void txtTenBan_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}

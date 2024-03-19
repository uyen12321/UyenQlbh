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
    public partial class FrmChiNhanh : Form
    {
        public FrmChiNhanh()
        {
            InitializeComponent();
        }
        Ketnoi KN = new Ketnoi();
        
        private void LoadChiNhanh()
        {
            string str = "SELECT MaCN, MaKV, TenCN, DiaChi, SoDienThoai FROM ChiNhanh";
            SqlDataAdapter da = new SqlDataAdapter(str, KN.GetConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtgvChiNhanh.DataSource = dt;
        }


        private void FrmChiNhanh_Load(object sender, EventArgs e)
        {
            LoadChiNhanh();

        }

        //dtgvChiNhanh
        private void dtgvBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCN.Text = dtgvChiNhanh.CurrentRow.Cells[0].Value.ToString();
            txtMaKV.Text = dtgvChiNhanh.CurrentRow.Cells[1].Value.ToString();
            txtTenCN.Text = dtgvChiNhanh.CurrentRow.Cells[2].Value.ToString();
            txtDChiCN.Text = dtgvChiNhanh.CurrentRow.Cells[3].Value.ToString();
            txtSDTCN.Text = dtgvChiNhanh.CurrentRow.Cells[4].Value.ToString();

        }
        
        //thêm
        private void btnThemCN_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dtgvChiNhanh.CurrentCell.RowIndex;
                string MaCN = txtMaCN.Text;
                string MaKV = txtMaKV.Text;
                string TenCN = txtTenCN.Text;
                string DiaChi= txtDChiCN.Text;
                string SoDienThoai= txtSDTCN.Text;
                
                KN.EXECUTENONQUERY("insert into ChiNhanh values ('" + MaCN + "', '" + MaKV + "', N'" + TenCN + "',N'" + DiaChi + "','" + SoDienThoai + "')");
                MessageBox.Show("Thêm Chi Nhánh " + MaCN + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChiNhanh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        //sửa
        private void btnSuaCN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cho phép sửa Chi nhánh " + txtMaCN.Text +  " Thông báo");
        }
        //Lưu
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dtgvChiNhanh.CurrentCell.RowIndex;
                string MaCN = txtMaCN.Text;
                string MaKV = txtMaKV.Text;
                string TenCN = txtTenCN.Text;
                string DiaChi = txtDChiCN.Text;
                string SoDienThoai = txtSDTCN.Text;
                KN.EXECUTENONQUERY("update ChiNhanh set MaKV ='" + MaKV + "',TenCN = '" + TenCN + "',DiaChi ='" + DiaChi + "', SoDienThoai ='" + SoDienThoai + "' where MaCN='" + MaCN + "'");
                MessageBox.Show("Lưu Chi Nhánh " + MaCN + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadChiNhanh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //xóa
        private void btnXoaCN_Click(object sender, EventArgs e)
        {
            try
            {

                int vitri = dtgvChiNhanh.CurrentCell.RowIndex;
                string MaCN = dtgvChiNhanh.Rows[vitri].Cells[0].Value.ToString();

                DialogResult dg = new DialogResult();
                dg = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    KN.EXECUTENONQUERY("delete from ChiNhanh where MaCN='" + MaCN + "'");
                    MessageBox.Show("Xóa Chi Nhánh " + MaCN + " thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadChiNhanh();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //thoát
        private void btnThoatBan_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn rời khỏi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK)
                this.Close();
        }
        //tạo mới
        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            txtMaCN.Text = "";
            txtMaKV.Text = "";
            txtTenCN.Text = "";
            txtDChiCN.Text = "";
            txtSDTCN.Text = "";
        }
    }
}

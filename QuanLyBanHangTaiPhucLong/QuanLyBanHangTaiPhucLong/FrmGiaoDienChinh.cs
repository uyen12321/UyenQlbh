using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangTaiPhucLong
{
    public partial class FrmGiaoDienChinh : Form
    {
        public FrmGiaoDienChinh(string QuyenTK)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            if(QuyenTK == "0")
            {
                QuanliMenuItem.Enabled = true;
                thongtinMenuItem.Enabled = true;
                BaoCaoMenuItem.Enabled = true;
                TroGiupMenuItem1.Enabled = true;
                trợGiúpMenuItem.Enabled = true;
               
            }
            else
            {
                tàiKhoảnToolStripMenuItem.Enabled = true;
                phụCấpToolStripMenuItem.Enabled = false;
                chiNhánhToolStripMenuItem.Enabled = false;
                thôngTinNhânViênToolStripMenuItem.Enabled = false;
                thongtinMenuItem.Enabled = true;
                trợGiúpMenuItem.Enabled = true;
                TroGiupMenuItem1.Enabled = false;
                BaoCaoMenuItem.Enabled = false;
            }
        }
        Ketnoi KN =new Ketnoi();
        private void thôngTinNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmThongTinNhanVien f = new FrmThongTinNhanVien();
            f.ShowDialog();
        }

        private void lươngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLuongNhanVien f = new FrmLuongNhanVien();
            f.ShowDialog();
        }

        private void BaoCaoMenuItem_Click(object sender, EventArgs e)
        {
            //FrmBaoCao f = new FrmBaoCao();
            //f.ShowDialog();
        }

        private void trợGiúpMenuItem_Click(object sender, EventArgs e)
        {
         

            FrmTroGiup f = new FrmTroGiup();
            f.ShowDialog();
        }

        private void TimKiemMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTimKiem f = new FrmTimKiem();
            f.ShowDialog();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThongTinKhachHang f = new FrmThongTinKhachHang();
            f.ShowDialog();
        }

        private void chiNhánhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChiNhanh f = new FrmChiNhanh();
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn rời khỏi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK)
                this.Close();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmThongTinKhachHang f = new FrmThongTinKhachHang();
            f.ShowDialog();
        }

        private void đăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TroGiupMenuItem1_Click(object sender, EventArgs e)
        {
            //FrmTimKiem f = new FrmTimKiem();
            //f.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmrepertNV f = new FrmrepertNV();
            f.ShowDialog();
        }

        private void cửaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoCao f = new FrmBaoCao();
            f.ShowDialog();
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
           HoaDon f = new HoaDon();
            f.ShowDialog();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTimKiem f = new FrmTimKiem();
            f.ShowDialog();
        }

        private void phụCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmXuatNhapKho f = new FrmXuatNhapKho();
            f.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTimKiemKH f = new FrmTimKiemKH();
            f.ShowDialog();
        }

        private void mónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiemMonAn f = new FrmTimKiemMonAn();
            f.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiemHoaDon f = new FrmTimKiemHoaDon();
            f.ShowDialog();
        }

        private void FrmGiaoDienChinh_Load(object sender, EventArgs e)
        {
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoiMatKhau f = new FrmDoiMatKhau();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn đăng xuất? ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK)
                this.Close();
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmreportHD f = new FrmreportHD();
            f.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmreportKH f = new FrmreportKH();
            f.ShowDialog();
        }

        private void chiNhánhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmreportCN f = new FrmreportCN();
            f.ShowDialog();
        }
    }
    
}

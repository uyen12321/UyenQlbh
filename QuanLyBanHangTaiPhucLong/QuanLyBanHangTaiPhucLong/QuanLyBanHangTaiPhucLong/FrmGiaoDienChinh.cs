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
        public FrmGiaoDienChinh()
        {
            InitializeComponent();
        }

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
            FrmBaoCao f = new FrmBaoCao();
            f.ShowDialog();
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
    }
}

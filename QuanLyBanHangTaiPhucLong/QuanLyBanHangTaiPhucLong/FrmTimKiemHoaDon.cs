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
    public partial class FrmTimKiemHoaDon : Form
    {
        public FrmTimKiemHoaDon()
        {
            InitializeComponent();
        }
        Ketnoi KN = new Ketnoi();
        private void FrmTimKiemHoaDon_Load(object sender, EventArgs e)
        {

            string strselect = "select * from HoaDon";
            SqlDataAdapter adapter = new SqlDataAdapter(strselect, KN.GetConnect());
            DataTable data1 = new DataTable();
            adapter.Fill(data1);
            dataGridView1.DataSource = data1;
        }

        private void btnTimNV_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery(@"select *from HoaDon"));
            if (rbtnMaNV.Checked == true)
            {
                dv.RowFilter = string.Format("MaHD LIKE '%{0}%'", txtMaHD.Text);
                dataGridView1.DataSource = dv;
            }
            else if (rbtnHoTen.Checked == true)
            {
                dv.RowFilter = string.Format("MaKH LIKE '%{0}%'", txtMaKH.Text);
                dataGridView1.DataSource = dv;
            }
        }

        private void btnThoatTimKiem_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn rời khỏi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK)
                this.Close();
        }
    }
}

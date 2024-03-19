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
    public partial class FrmTimKiem : Form
    {
       
        public FrmTimKiem()
        {
            InitializeComponent();
        }
        Ketnoi KN = new Ketnoi();
        
        private void FrmTimKiem_Load(object sender, EventArgs e)
        {
            string strselect = "select * from NhanVien";
            SqlDataAdapter adapter = new SqlDataAdapter(strselect, KN.GetConnect());
            DataTable data = new DataTable();
            adapter.Fill(data);
            dataGridView1.DataSource = data;
        }
       
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void btnTimNV_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(KN.Executequery(@"select *from NhanVien"));
            if (rbtnMaNV.Checked == true)
            {
                dv.RowFilter = string.Format("MaNV LIKE '%{0}%'", txtMaNV.Text);
                dataGridView1.DataSource = dv;
            }
            else if (rbtnHoTen.Checked == true)
            {
                dv.RowFilter = string.Format("HoTenNV LIKE '%{0}%'", txtTen.Text);
                dataGridView1.DataSource = dv;
            }

        }

        private void rbtnMaNV_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbtnHoTen_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbtnCMND_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn rời khỏi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dg == DialogResult.OK)
                this.Close();
        }

       
       
        private void txtTimKIem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

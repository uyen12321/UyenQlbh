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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }
        string strcon = @"Data Source=DESKTOP-NTGIIVN\SQLEXPRESS;Initial Catalog=QUANLYBANHANGTAIPHUCLONG;Integrated Security=True";
        public static string QuyenTK = "-1";

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {

                // kiểm tra nhập
                if (txtTenDN.Text != null && txtTenDN.Text.Trim() != " ") { }
                else
                {
                    MessageBox.Show("Chưa nhập thông tin Tên tài khoản", "Thông Báo");
                    txtTenDN.Focus();
                    return;
                }
                if (txtMatKhau.Text != null && txtMatKhau.Text.Trim() != " ") { }
                else
                {
                    MessageBox.Show("Chưa nhập thông tin Mật khẩu", "Thông Báo");
                    txtMatKhau.Focus();
                    return;
                }


                // kiểm tra thông tin 

                SqlConnection sqlcon = new SqlConnection(strcon);
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                string TenTK = txtTenDN.Text.Trim();
                string Matkhau = txtMatKhau.Text.Trim();
                string str = ("SELECT * FROM DangNhap2 WHERE TenDN='" + TenTK + "' AND MatKhau=" + Matkhau + "");
                SqlCommand sqlcmd = new SqlCommand(str, sqlcon);
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    QuyenTK = ds.Tables[0].Rows[0]["Quyen"].ToString();
                    FrmGiaoDienChinh f = new FrmGiaoDienChinh(QuyenTK);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Email/Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Email/Tên đăng nhập hoặc mật khẩu không đúng!" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}

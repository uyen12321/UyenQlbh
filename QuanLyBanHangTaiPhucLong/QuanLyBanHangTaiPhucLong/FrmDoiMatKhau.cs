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
    public partial class FrmDoiMatKhau : Form
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
        }
        Ketnoi KN = new Ketnoi();
        private void btnHoanTatDMK_Click(object sender, EventArgs e)
        {
            
               
                string ten = txtTenDN.Text;
                if (ten == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên truy cập");
                }
                else
                {
                    if (txtMK.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu");
                    }
                    else
                    {
                        if (txtMKMoi.Text == "")
                        {
                            MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                        }
                        else
                        {
                            if (txtNLMK.Text == "")
                            {
                                MessageBox.Show("Bạn chưa nhập lại mật khẩu");
                            }
                            else
                            {
                                if (txtMKMoi.Text == txtNLMK.Text)
                                {
                                    KN.EXECUTENONQUERY("update DangNhap2 set  MatKhau = '" + txtMKMoi.Text + "' where TenDN = '" + txtTenDN.Text + "'");
                                    MessageBox.Show("Bạn đã thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                   
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Bạn nhập lại mật khẩu không đúng");
                                }
                            }
                        }
                    }
                }
            
        }

        private void btnNLMK_Click(object sender, EventArgs e)
        {
            txtTenDN.Text = "";
            txtNLMK.Text = "";
            txtMKMoi.Text = "";
            txtMK.Text = "";

        }

        private void btnHuyBoMK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hủy bỏ các thay đổi và thoát ", " Thông báo");
            this.Close();
        }
    }
}

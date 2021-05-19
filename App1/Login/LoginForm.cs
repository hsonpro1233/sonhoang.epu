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

namespace App1
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("SELECT TaiKhoan,MatKhau FROM NHANVIEN WHERE TaiKhoan = N'" + txb_taikhoan.Text + "' AND MatKhau = N'" + txb_matkhau.Text + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                label1.Text = "";
                MessageBox.Show("Đăng nhập thành công");
                TrangThai();
                Form x = new MainMenu();
                this.Hide();
                x.Show();
            }
            else
            {
                label1.Text = "Tài khoản hoặc mật khẩu không chính xác";
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2CheckBox1.Checked==true)
            {
                txb_matkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txb_matkhau.UseSystemPasswordChar = true;
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Form x = new SignUp();
            x.Show();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }
        private void txb_matkhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                guna2GradientButton1_Click(sender, new EventArgs());
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form x = new ForgotPass();
            x.Show();
            this.Hide();
        }
        private void TrangThai()
        {
            connect db = new connect();
            try
            {
                bool b = db.capnhat("UPDATE TRANGTHAI set TaiKhoan='" + txb_taikhoan.Text + "' WHERE CheDo = 1");
                b = db.capnhat("UPDATE dbo.TRANGTHAI SET  MaNV = NHANVIEN.MaNv FROM TRANGTHAI,NHANVIEN WHERE TRANGTHAI.TaiKhoan=NHANVIEN.TaiKhoan ");
            }
            catch
            {

            }
        }
    }
}

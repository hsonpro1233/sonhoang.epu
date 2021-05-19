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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LayMaNV()
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("SELECT COUNT(*) MaNV FROM NHANVIEN");
            string a = ds.Tables[0].Rows[0]["MaNV"].ToString();
            int b = Convert.ToInt32(a);
            txb_manhanvien.Text = (b + 1).ToString();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            connect db = new connect();
            bool b = db.capnhat("Insert into NHANVIEN(MaNV,TaiKhoan,MatKhau,HoTen,NgaySinh,GioiTinh,DiaChi,Email,CMND,SDT,ChucVu,NgayBDLV) values ('" + txb_manhanvien.Text + "','" + txb_taikhoan.Text + "','" + txb_matkhau.Text + "','" + txb_hoten.Text + "','" + ngaysinh.Value + "','" + cbx_gioitinh.Text + "','" + txb_diachi.Text + "','" + txb_email.Text + "','" + tbx_cmnd.Text + "','" + txb_sdt.Text + "','" + cbx_ChucVu.Text + "','" + ngaybdlv.Value + "')");
            if (b == true && txb_maxacnhan.Text=="SMA_01")
            {
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi!");
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            LayMaNV();
        }
    }
}

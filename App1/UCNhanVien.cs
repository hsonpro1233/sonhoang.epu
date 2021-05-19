using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class UCNhanVien : UserControl
    {
        public UCNhanVien()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private string XacMinh(string sql, int i)
        {
            string a = "";
            connect db = new connect();
            a = db.reader(sql, i);
            return a;
        }


        private bool Admin()
        {
            bool a = false;
            string sql = "SELECT * FROM NHANVIEN, TRANGTHAI WHERE NHANVIEN.MaNv=TRANGTHAI.MaNV";
            connect db = new connect();
            DataSet ds = new DataSet();
            ds = db.truyvan(sql);
            if(ds.Tables[0].Rows.Count>0)
            {
                if(XacMinh(sql,11).Contains("Quản")==true)
                {
                    a = true;
                }
            }
            return a;
        }

        private void UCNhanVien_Load(object sender, EventArgs e)
        {
            HienThi();
            AnNut();
        }
        
        private void HienThi()
        {
            string sql = "SELECT HoTen,DiaChi,SDT,NgaySinh,GioiTinh,ChucVu,NgayBDLV,Email,CMND,TaiKhoan,MatKhau,MaNv,AnhNv FROM NHANVIEN";
            connect db = new connect();
            DataSet ds = new DataSet();
            ds = db.truyvan(sql);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void AnNut()
        {
            bool a = Admin();
            if(a!=true)
            {
                btn_them.Visible = btn_sua.Visible = btn_xoa.Visible = false;
                tb_matkhau.UseSystemPasswordChar = true;
            }
        }

        private bool CheckNV()
        {
            bool a = true;
            DataSet ds = new DataSet();
            connect db = new connect();
            string sql = "SELECT * FROM NHANVIEN WHERE  MaNv = N'" + tb_manv.Text + "' OR CMND ='" + tb_cmnd.Text + "'OR TaiKhoan ='" + tb_taikhoan.Text + "'";
            ds = db.truyvan(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                a = false;
            }
            else
            {
                a = true;
            }
            return a;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            bool a = CheckNV();
            if (tb_manv.Text != "" || tb_tennv.Text != "" || tb_diachi.Text != "" || tb_email.Text != "" || tb_cmnd.Text != "" || tb_matkhau.Text != "" || tb_taikhoan.Text != "" || datebdlv.Value.ToString() != "" || datesinh.Value.ToString() != ""||cb_chucvu.Text==""||tb_gioitinh.Text=="")
            {
                connect db = new connect();
                bool b = db.capnhat("Insert into NHANVIEN(MaNv,TaiKhoan,MatKhau,HoTen,NgaySinh,GioiTinh,DiaChi,Email,CMND,SDT,AnhNv,ChucVu,NgayBDLV) values ('" + tb_manv.Text + "',N'" + tb_taikhoan.Text + "',N'" + tb_matkhau.Text + "',N'" + tb_tennv.Text + "',N'" + datesinh.Value + "',N'" + tb_gioitinh.Text + "',N'" + tb_diachi.Text + "','" + tb_email.Text + "','" + tb_cmnd.Text + "','" + tb_sdt.Text + "',N'" + guna2PictureBox1.Tag + "',N'" + cb_chucvu.Text + "',N'" + datebdlv.Value + "')");
                if (a != true)
                {
                    if (b != true)
                    {
                        MessageBox.Show("Thêm nhân viên mới thành công");
                        HienThi();
                        btn_don_Click(sender, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Lỗi SQL!");
                    }
                }
                else
                {
                    MessageBox.Show("Có 1 người tương tự đã tồn tại trên hệ thống");
                }
            }
            else
            {
                MessageBox.Show("Bạn đã nhập gì đâu :|");
            }
        }

        private void btn_don_Click(object sender, EventArgs e)
        {
            tb_cmnd.Text = tb_diachi.Text = tb_email.Text = tb_gioitinh.Text = tb_manv.Text = tb_matkhau.Text = tb_sdt.Text = tb_search.Text = tb_taikhoan.Text = tb_tennv.Text = null;
            cb_chucvu.Text = null;
            guna2PictureBox1.Image = null;
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                guna2DataGridView1.CurrentRow.Selected = true;
                tb_manv.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["MaNv"].FormattedValue.ToString();
                tb_tennv.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["HoTen"].FormattedValue.ToString();
                tb_diachi.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["DiaChi"].FormattedValue.ToString();
                tb_cmnd.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["CMND"].FormattedValue.ToString();
                tb_email.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                tb_matkhau.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["MatKhau"].FormattedValue.ToString();
                datesinh.Value = Convert.ToDateTime(guna2DataGridView1.Rows[e.RowIndex].Cells["NgaySinh"].FormattedValue.ToString());
                tb_sdt.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["SDT"].FormattedValue.ToString();
                tb_gioitinh.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Sex"].FormattedValue.ToString();
                cb_chucvu.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["ChucVu"].FormattedValue.ToString();
                tb_taikhoan.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["TaiKhoan"].FormattedValue.ToString();
                datebdlv.Value = Convert.ToDateTime(guna2DataGridView1.Rows[e.RowIndex].Cells["NgayBDLV"].FormattedValue.ToString());
                try
                {
                    guna2PictureBox1.Image = new Bitmap(guna2DataGridView1.Rows[e.RowIndex].Cells["AnhNV"].FormattedValue.ToString());
                }
                catch
                {
                    guna2PictureBox1.Image = null;
                }
            }
            catch
            {

            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                connect db = new connect();
                guna2PictureBox1.Image = new Bitmap(opnfd.FileName);
                guna2PictureBox1.Tag = opnfd.FileName;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool a = CheckNV();
            if (a == true)
            {
                MessageBox.Show("Oh no, chưa có mã nhân viên này trên hệ thống!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc sửa theo những thông tin này không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string sql = "UPDATE NHANVIEN set HoTen=N'" + tb_tennv.Text + "',DiaChi=N'" + tb_diachi.Text + "',NgaySinh='" + datesinh.Value + "',GioiTinh=N'" + tb_gioitinh.Text + "',ChucVu=N'" + cb_chucvu.Text + "',NgayBDLV='" + datebdlv.Value + "',Email=N'" + tb_email.Text + "',CMND='" + tb_cmnd.Text + "',TaiKhoan=N'" + tb_taikhoan.Text + "',MatKhau='" + tb_matkhau.Text + "',SDT=N'" + tb_sdt.Text + "',AnhNv=N'" + guna2PictureBox1.Tag + "'where MaNv='" + tb_manv.Text + "'";
                    connect db = new connect();
                    bool b = db.capnhat(sql);
                    if (b == true)
                    {
                        MessageBox.Show("Sửa thành công");
                        HienThi();
                        btn_don_Click(sender, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Lỗi");
                    }
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                connect db = new connect();
                bool b = db.capnhat("delete from NhanVien where MaNv='" + tb_manv.Text + "'");
                if (b == true)
                {
                    MessageBox.Show("Xoá thành công");
                    HienThi();
                    btn_don_Click(sender, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Lỗi!");
                }
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("SELECT HoTen,DiaChi,SDT,NgaySinh,GioiTinh,ChucVu,NgayBDLV,Email,CMND,TaiKhoan,MatKhau,MaNv,AnhNv FROM NHANVIEN WHERE HoTen LIKE N'%" + tb_search.Text.Trim() + "%' OR TaiKhoan LIKE  N'%" + tb_search.Text.Trim() + "%' OR NgaySinh LIKE  N'%" + tb_search.Text.Trim() + "%' OR DiaChi LIKE  N'%" + tb_search.Text.Trim() + "%'OR Email LIKE  N'%" + tb_search.Text.Trim() + "%'OR CMND LIKE  N'%" + tb_search.Text.Trim() + "%'OR SDT LIKE  N'%" + tb_search.Text.Trim() + "%'");
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}

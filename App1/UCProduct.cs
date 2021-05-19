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
    public partial class UCProduct : UserControl
    {
        public UCProduct()
        {
            InitializeComponent();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        public void LayMaSP()
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("SELECT COUNT(*) MaHang FROM HANG");
            string a = ds.Tables[0].Rows[0]["MaHang"].ToString();
            int b = Convert.ToInt32(a);
            tb_masp.Text = "H" + (b + 1).ToString();

        }

        private void HienThi()
        {
            LayMaSP();
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("Select TenHang,SoLuong,DonGiaNhap,DonGiaBan,TenChatLieu,NgayNhapKho,NguonGoc,DaBan,ChiPhi,AnhHH,MaHang FROM Hang ");
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void UCProduct_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private bool CheckHang()
        {
            bool a = true;
            DataSet ds = new DataSet();
            connect db = new connect();
            string sql = "SELECT * FROM HANG WHERE  MaHang = N'" + tb_masp.Text + "'";
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

        private void LoadAnh()
        {
            connect db = new connect();
            string sql = "SELECT AnhHH FROM HANG WHERE  TenHang = N'" + tb_tensp.Text + "'";
            string b = "";
            b = db.reader(sql, 0);
            MessageBox.Show(b);
            guna2PictureBox1.Image = new Bitmap(b);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            bool a = CheckHang();
            if (tb_tensp.Text != "" || tb_soluong.Text != "" || tb_nhap.Text != "" || tb_ban.Text != "")
            {
                connect db = new connect();
                bool b = db.capnhat("Insert into HANG(MaHang,TenHang,TenChatLieu,NgayNhapKho,GhiChu,SoLuong,NguonGoc,DonGiaNhap,DonGiaBan,ChiPhi,AnhHH) values ('" + tb_masp.Text + "',N'" + tb_tensp.Text + "',N'" + tb_chatlieu.Text + "','" + guna2DateTimePicker1.Value + "',N'" + tb_mota.Text + "','" + tb_soluong.Text + "',N'" + tb_nguongoc.Text + "','" + tb_nhap.Text + "','" + tb_ban.Text + "','" + tb_tien.Text + "',N'" + guna2PictureBox1.Tag + "')");

                if (a == true)
                {
                    if (b == true)
                    {
                        MessageBox.Show("Thêm sản phẩm mới thành công");
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
                    MessageBox.Show("Có 1 sản phẩm tương tự đã tồn tại trên hệ thống");
                }
            }
            else
            {
                MessageBox.Show("Bạn đã nhập gì đâu :|");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                connect db = new connect();
                bool b = db.capnhat("delete from HANG where MaHang='" + tb_masp.Text + "'");
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

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                guna2DataGridView1.CurrentRow.Selected = true;
                tb_masp.Text= guna2DataGridView1.Rows[e.RowIndex].Cells["MaHang"].FormattedValue.ToString();
                tb_tensp.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["TenHang"].FormattedValue.ToString();
                tb_soluong.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["SoLuong"].FormattedValue.ToString();
                tb_nhap.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["DonGiaNhap"].FormattedValue.ToString();
                tb_ban.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["DonGiaBan"].FormattedValue.ToString();
                tb_chatlieu.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["TenChatLieu"].FormattedValue.ToString();
                guna2DateTimePicker1.Value = Convert.ToDateTime(guna2DataGridView1.Rows[e.RowIndex].Cells["NgayNhapKho"].FormattedValue.ToString());
                tb_nguongoc.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["NguonGoc"].FormattedValue.ToString();
                tb_soluong.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["SoLuong"].FormattedValue.ToString();
                tb_tien.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["ChiPhi"].FormattedValue.ToString();
                guna2PictureBox1.Image = new Bitmap(guna2DataGridView1.Rows[e.RowIndex].Cells["AnhHH"].FormattedValue.ToString());
                try
                {
                    int a = Int32.Parse(tb_nhap.Text);
                    int b = Int32.Parse(tb_soluong.Text);
                    int c = (a * b);
                    tb_tien.Text = c.ToString();
                }
                catch
                {

                }
            }
            catch
            {

            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool a = CheckHang();
            if(a==true)
            {
                MessageBox.Show("Oh no, chưa có mã sản phẩm này trên hệ thống!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc sửa theo những thông tin này không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string sql = "UPDATE HANG set TenHang=N'" + tb_tensp.Text + "',DonGiaNhap='" + tb_nhap.Text + "',DonGiaBan='" + tb_ban.Text + "',SoLuong='" + tb_soluong.Text + "',TenChatLieu=N'" + tb_chatlieu.Text + "',GhiChu='" + tb_mota.Text + "',AnhHH=N'" + guna2PictureBox1.ImageLocation + "',NgayNhapKho='" + guna2DateTimePicker1.Value + "',NguonGoc=N'" + tb_nguongoc.Text + "',ChiPhi='" + tb_tien.Text + "'where MaHang='" + tb_masp.Text + "'";
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

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                string a = opnfd.FileName;
                connect db = new connect();
                guna2PictureBox1.Image = new Bitmap(opnfd.FileName);
                guna2PictureBox1.Tag = a;
                bool b = db.capnhat("UPDATE Hang SET AnhHH =N'" + a + "' WHERE TenHang='" + tb_tensp.Text + "'");
                if (b == true)
                {
                    MessageBox.Show("true");
                    HienThi();
                }
                else
                {
                    MessageBox.Show("false");
                }
                
            }
        }

        private void btn_don_Click(object sender, EventArgs e)
        {
            tb_ban.Text = tb_chatlieu.Text = tb_masp.Text = tb_mota.Text = tb_nguongoc.Text = tb_nhap.Text = tb_search.Text = tb_soluong.Text = tb_tensp.Text = tb_tien.Text = "";
            HienThi();
        }

        private void tb_soluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Int32.Parse(tb_nhap.Text);
                int b = Int32.Parse(tb_soluong.Text);
                int c = (a * b);
                tb_tien.Text = c.ToString();
            }
            catch
            {
                
            }
        }

        private void tb_nhap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int a = Int32.Parse(tb_nhap.Text);
                int b = Int32.Parse(tb_soluong.Text);
                int c = (a * b);
                tb_tien.Text = c.ToString();
            }
            catch
            {

            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("SELECT TenHang,SoLuong,DonGiaNhap,DonGiaBan,TenChatLieu,NgayNhapKho,NguonGoc,DaBan,ChiPhi,AnhHH,MaHang FROM Hang WHERE TenHang LIKE N'%" + tb_search.Text.Trim() + "%' OR SoLuong LIKE  N'%" + tb_search.Text.Trim() + "%' OR DonGiaNhap LIKE  N'%" + tb_search.Text.Trim() + "%' OR DonGiaBan LIKE  N'%" + tb_search.Text.Trim() + "%'OR TenChatLieu LIKE  N'%" + tb_search.Text.Trim() + "%'OR NgayNhapKho LIKE  N'%" + tb_search.Text.Trim() + "%'OR NguonGoc LIKE  N'%" + tb_search.Text.Trim() + "%'OR DaBan LIKE  N'%" + tb_search.Text.Trim() + "%'");
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}

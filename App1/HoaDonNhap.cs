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
    public partial class HoaDonNhap : UserControl
    {
        public HoaDonNhap()
        {
            InitializeComponent();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private string LayMaNV()
        {
            string sql = "SELECT MaNv FROM TRANGTHAI";
            string a=XacMinh(sql, 0);
            return a;
        }

        private string XacMinh(string sql, int i)
        {
            string a = "";
            connect db = new connect();
            a = db.reader(sql, i);
            return a;
        }

        private string LayDonGia(string sql, int i)
        {
            string a = "";
            connect db = new connect();
            a = db.readerdouble(sql, i);
            return a;
        }

        private void HienThi()
        {
            string sql = "SELECT MaHDNHAP,HOADONNHAP.MaHang,hang.TenHang,manv,ngaynhap,HOADONNHAP.SoLuong,hang.DonGiaNhap,thanhtien from HOADONNHAP,HANG where HANG.MaHang=HOADONNHAP.MaHang";
            connect db = new connect();
            DataSet ds = new DataSet();
            ds = db.truyvan(sql);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private bool CheckHoaDon()
        {
            bool a = true;
            DataSet ds = new DataSet();
            connect db = new connect();
            string sql = "SELECT * FROM HOADONNHAP WHERE  MaHDNhap = N'" + tb_mahd.Text + "'";
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
            bool a = CheckHoaDon();
            if (tb_mahd.Text != "" || tb_soluong.Text != "" || tb_masp.Text != "")
            {
                string nv = LayMaNV();
                connect db = new connect();
                bool b = db.capnhat("Insert into HOADONNHAP(MaHDNhap,MaHang,Manv,NgayNhap,SoLuong,ThanhTien) values ('" + tb_mahd.Text + "',N'" + tb_masp.Text + "',N'" + nv + "','" + guna2DateTimePicker1.Value + "',N'" + tb_soluong.Text + "','" + tb_thanhtien.Text + "')");

                if (a == true)
                {
                    if (b == true)
                    {
                        MessageBox.Show("Thêm hóa đơn nhập mới thành công,kho hàng đã được cập nhật");
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
                    MessageBox.Show("Có 1 hóa đơn tương tự đã tồn tại trên hệ thống");
                }
            }
            else
            {
                MessageBox.Show("Bạn đã nhập gì đâu :|");
            }
        }

        private void HoaDonNhap_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                guna2DataGridView1.CurrentRow.Selected = true;
                tb_mahd.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["MaHDNhap"].FormattedValue.ToString();
                tb_manv.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["MaNv"].FormattedValue.ToString();
                tb_soluong.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["SoLuong"].FormattedValue.ToString();
                guna2DateTimePicker1.Value = Convert.ToDateTime(guna2DataGridView1.Rows[e.RowIndex].Cells["NgayNhap"].FormattedValue.ToString());
                tb_masp.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["MaHang"].FormattedValue.ToString();
                try
                {
                    int a = Convert.ToInt32(guna2DataGridView1.Rows[e.RowIndex].Cells["DonGiaNhap"].FormattedValue.ToString());
                    int b = Int32.Parse(tb_soluong.Text);
                    int c = (a * b);
                    tb_thanhtien.Text = c.ToString();
                }
                catch
                {

                }
            }
            catch
            {

            }
        }

        private void btn_don_Click(object sender, EventArgs e)
        {
            tb_mahd.Text = tb_manv.Text = tb_masp.Text = tb_search.Text = tb_soluong.Text = tb_thanhtien.Text = "";
            HienThi();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool a = CheckHoaDon();
            if (a == true)
            {
                MessageBox.Show("Oh no, chưa có mã hóa đơn này trên hệ thống!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc sửa theo những thông tin này không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string sql = "UPDATE HOADONNHAP set MaHDNhap=N'" + tb_mahd.Text + "',MaHang='" + tb_masp.Text + "',MaNv='" + tb_manv.Text + "',SoLuong='" + tb_soluong.Text + "',NgayNhapKho='" + guna2DateTimePicker1.Value + "',ThanhTien=N'" + tb_thanhtien.Text + "'";
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
                bool b = db.capnhat("delete from HOADONNHAP where MaHDNhap='" + tb_mahd.Text + "'");
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

        private void tb_soluong_Click(object sender, EventArgs e)
        {

        }

        private void tb_soluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(tb_masp.Text!=null)
                {
                    string sql = "SELECT Dongianhap FROM HANG WHERE MaHang='" + tb_masp.Text + "'";
                    double a = Convert.ToDouble(LayDonGia(sql, 0));
                    int b = Convert.ToInt32(tb_soluong.Text);
                    double c = a * b;
                    tb_thanhtien.Text = c.ToString();
                }
                
            }
            catch
            {

            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("SELECT MaHDNHAP,HOADONNHAP.MaHang,hang.TenHang,manv,ngaynhap,HOADONNHAP.SoLuong,hang.DonGiaNhap,thanhtien from HOADONNHAP,HANG WHERE MaHDNhap LIKE N'%" + tb_search.Text.Trim() + "%' OR HoaDonNhap.SoLuong LIKE  N'%" + tb_search.Text.Trim() + "%' OR Hang.DonGiaNhap LIKE  N'%" + tb_search.Text.Trim() + "%'OR NgayNhap LIKE  N'%" + tb_search.Text.Trim() + "%'OR ThanhTien LIKE  N'%" + tb_search.Text.Trim() + "%'");
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tb_manv_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_masp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tb_mahd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tb_thanhtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

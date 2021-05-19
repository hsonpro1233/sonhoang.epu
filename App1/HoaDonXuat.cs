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
    public partial class HoaDonXuat : UserControl
    {
        public HoaDonXuat()
        {
            InitializeComponent();
        }

        private string LayMaNV()
        {
            string sql = "SELECT MaNv FROM TRANGTHAI";
            string a = XacMinh(sql, 0);
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

        private string LayTamGia(string sql, int i)
        {
            string a = "";
            connect db = new connect();
            a = db.readertriple(sql, i);
            return a;
        }

        private void HienThi()
        {
            string sql = "SELECT * FROM HOADONXUAT";
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
            string sql = "SELECT * FROM HOADONXUAT WHERE  MaHDXuat = N'" + tb_mahd.Text + "'";
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

        private bool CheckCTHoaDon()
        {
            bool a = true;
            DataSet ds = new DataSet();
            connect db = new connect();
            string sql = "SELECT * FROM CTHDB WHERE  MaHDXuat = N'" + tb_mahd.Text + "' AND MaHang=N'"+tb_mahang.Text+"'";
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

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            bool a = CheckHoaDon();
            try
            {
                if(a==true)
                {
                    if(tb_mahd.Text==""|| tb_manv.Text == "" || tb_makh.Text == "")
                    {
                        MessageBox.Show("Làm ơn hãy nhập đủ thông tin ạ ><");
                    }
                    else
                    {
                        connect db = new connect();
                        string sql = "INSERT INTO HOADONXUAT(MaHDXuat,MaNv,MaKh,NgayBan,TongTien) VALUES ('"+tb_mahd.Text+"','"+tb_manv.Text+"','"+tb_makh.Text+"','"+guna2DateTimePicker1.Value+"',"+tb_tongtien.Text+")";
                        bool b = db.capnhat(sql);
                        if (b == true)
                        {
                            MessageBox.Show("Thêm hóa đơn bán mới thành công,kho hàng đã được cập nhật");
                            HienThi();
                            btn_don_Click(sender, new EventArgs());
                        }
                        else
                        {
                            MessageBox.Show("Lỗi SQL1!");
                        }
                    }
                }
                else
                {
                    if (tb_mahang.Text == "" || tb_soluong.Text == "" || tb_thanhtien.Text=="")
                    {
                        MessageBox.Show("Làm ơn hãy nhập đủ thông tin ạ ><");
                    }
                    else
                    {
                        bool c = CheckCTHoaDon();
                        if(c==true)
                        {
                            connect db = new connect();
                            string sql = "INSERT INTO CTHDB(MaHDXuat,MaHang,SoLuongBan,Sale,ThanhTien) Values ('" + tb_mahd.Text + "','" + tb_mahang.Text + "','" + tb_soluong.Text + "','" + guna2NumericUpDown1.Value + "','" + tb_thanhtien.Text + "')";
                            bool b = db.capnhat(sql);
                            if (b == true)
                            {
                                MessageBox.Show("Thêm chi tiết bán mới thành công,kho hàng đã được cập nhật");
                                HienThi();
                                btn_don_Click(sender, new EventArgs());
                            }
                            else
                            {
                                MessageBox.Show("Lỗi SQL2!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Đã có đơn này rồi, hãy xem lại ạ");
                        }
                    }
                }
            }
            catch
            {

            }
            
        }

        private void HoaDonXuat_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void HienThi2()
        {
            string sql = "SELECT MaHang,SoLuongBan,Sale,ThanhTien FROM CTHDB WHERE MaHDXuat ='"+tb_mahd.Text+"'";
            connect db = new connect();
            DataSet ds = new DataSet();
            ds = db.truyvan(sql);
            guna2DataGridView2.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                guna2DataGridView1.CurrentRow.Selected = true;
                tb_mahd.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["MaHDXuat"].FormattedValue.ToString();
                tb_manv.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["MaNv"].FormattedValue.ToString();
                tb_makh.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["MaKH"].FormattedValue.ToString();
                guna2DateTimePicker1.Value = Convert.ToDateTime(guna2DataGridView1.Rows[e.RowIndex].Cells["NgayBan"].FormattedValue.ToString());
                tb_tongtien.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["TongTien"].FormattedValue.ToString();
                HienThi2();
            }
            catch
            {

            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                guna2DataGridView2.CurrentRow.Selected = true;
                tb_mahang.Text = guna2DataGridView2.Rows[e.RowIndex].Cells["MaHang"].FormattedValue.ToString();
                tb_soluong.Text = guna2DataGridView2.Rows[e.RowIndex].Cells["SoLuongBan"].FormattedValue.ToString();
                guna2NumericUpDown1.Value = Convert.ToInt32(guna2DataGridView2.Rows[e.RowIndex].Cells["Sale"].FormattedValue.ToString());
                tb_soluong_TextChanged(sender, new EventArgs());
                tb_thanhtien.Text = guna2DataGridView2.Rows[e.RowIndex].Cells["ThanhTien"].FormattedValue.ToString();
                string sql = "SELECT SUM(ThanhTien) FROM CTHDB WHERE MaHDXuat='" + tb_mahd.Text + "'";
                tb_tongtien.Text = LayTamGia(sql, 0);
            }
            catch
            {

            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool a = CheckHoaDon();
            bool c = CheckCTHoaDon();
            if (a == true&&c==true)
            {
                MessageBox.Show("Oh no, chưa có mã hóa đơn này trên hệ thống!");
            }
            if(a==false&&c==true)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc sửa hóa đơn bán theo những thông tin này không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string sql = "UPDATE HOADONXUAT set MaNV='" + tb_manv.Text + "',MaKH='" + tb_makh.Text + "',NgayBan='" + guna2DateTimePicker1.Value + "',TongTien='" + tb_tongtien.Text + "' WHERE MaHDXuat='"+tb_mahd.Text+"'";
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
            if(c==false)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc sửa chi tiết bán theo những thông tin này không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string sql = "UPDATE CTHDB set SoLuongBan='" + tb_soluong.Text + "',Sale='" + guna2NumericUpDown1.Value.ToString() + "',ThanhTien='" + tb_thanhtien.Text + "' WHERE MaHDXuat='" + tb_mahd.Text + "' AND MaHang='"+tb_mahang.Text+"'";
                    connect db = new connect();
                    bool b = db.capnhat(sql);
                    if (b == true)
                    {
                        MessageBox.Show("Sửa thành công");
                        HienThi2();
                        btn_don_Click(sender, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Lỗi 2");
                    }
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bool a = CheckHoaDon();
            bool c = CheckCTHoaDon();
            if(a==false&&c==false)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa chi tiết không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    connect db = new connect();
                    bool b = db.capnhat("delete from CTHDB where MaHDXuat='" + tb_mahd.Text + "' AND MaHang='" + tb_mahang.Text + "'");
                    if (b == true)
                    {
                        MessageBox.Show("Xoá thành công");
                        HienThi2();
                        btn_don_Click(sender, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Lỗi!");
                    }
                }
            }
            if(a==false&&c==true)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    connect db = new connect();
                    bool b = db.capnhat("delete from HOADONXUAT where MaHDXuat='" + tb_mahd.Text + "'");
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
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("SELECT * from HOADONXUAT WHERE MaHDXuat LIKE N'%" + tb_search.Text.Trim() + "%' OR MaNv LIKE  N'%" + tb_search.Text.Trim() + "%' OR MaKh LIKE  N'%" + tb_search.Text.Trim() + "%'OR NgayBan LIKE  N'%" + tb_search.Text.Trim() + "%'OR Tongtien LIKE  N'%" + tb_search.Text.Trim() + "%'");
            guna2DataGridView1.DataSource = ds.Tables[0];
            ds = db.truyvan("SELECT * from CTHDB WHERE MaHDXuat LIKE N'%" + tb_search.Text.Trim() + "%' OR MaHang LIKE  N'%" + tb_search.Text.Trim() + "%' OR SoLuongBan LIKE  N'%" + tb_search.Text.Trim() + "%'OR Sale LIKE  N'%" + tb_search.Text.Trim() + "%'OR ThanhTien LIKE  N'%" + tb_search.Text.Trim() + "%'");
            guna2DataGridView2.DataSource = ds.Tables[0];
        }

        private void btn_don_Click(object sender, EventArgs e)
        {
            tb_mahd.Text = tb_manv.Text = tb_makh.Text = tb_search.Text = tb_soluong.Text = tb_thanhtien.Text = tb_tongtien.Text = "";
            HienThi();
            HienThi2();
        }

        private void tb_soluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_mahang.Text != null)
                {
                    string sql = "SELECT DonGiaBan FROM HANG WHERE MaHang='" + tb_mahang.Text + "'";
                    double a = Convert.ToDouble(LayDonGia(sql, 0));
                    int b = Convert.ToInt32(tb_soluong.Text);
                    double c = a*b;
                    tb_thanhtien.Text = (c-(c* Convert.ToDouble(guna2NumericUpDown1.Value /100))).ToString();
                }

            }
            catch
            {

            }
        }

        private void tb_thanhtien_TextChanged(object sender, EventArgs e)
        { 
        }
    }
}

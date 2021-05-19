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
    public partial class UCKhach : UserControl
    {
        public UCKhach()
        {
            InitializeComponent();
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void UCKhach_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void HienThi()
        {
            LayMaKH();
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("Select TenKH, DiaChiKH, SDTKH,Bank from KHACHHANG");
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private bool CheckKh()
        {
            bool a = true;
            DataSet ds = new DataSet();
            connect db = new connect();
            string sql = "SELECT * FROM KHACHHANG WHERE TenKH = N'"+tb_tenkh.Text+"' AND DiaChiKH = N'" + tb_diachi.Text + "'";
            ds = db.truyvan(sql);
            if(ds.Tables[0].Rows.Count>0)
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
            bool a = CheckKh();
            if(tb_makh.Text!=""|| tb_tenkh.Text != "" || tb_diachi.Text != "" || tb_sdtkh.Text!="")
            {
                connect db = new connect();
                bool b = db.capnhat("Insert into KHACHHANG(MaKH,TenKH,DiaChiKH,SDTKH,Bank) values ('" + tb_makh.Text + "','" + tb_tenkh.Text + "','" + tb_diachi.Text + "','" + tb_sdtkh.Text + "','" + tb_bank.Text + "')");

                if (a == true)
                {
                    if (b == true)
                    {
                        MessageBox.Show("Thêm khách hàng mới thành công");
                        HienThi();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi SQL!");
                    }
                }
                else
                {
                    MessageBox.Show("Khách hàng đã tồn tại trên hệ thống");
                }
            }
            else
            {
                MessageBox.Show("Bạn đã nhập gì đâu :|");
            }
        }

        private void tb_sdtkh_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb_sdtkh.Text, "[^0-9]"))
            {
                MessageBox.Show("Nhập số thôi bạn ơi :/");
                tb_sdtkh.Text = tb_sdtkh.Text.Remove(tb_sdtkh.Text.Length - 1);
            }
        }

        private void tb_bank_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb_bank.Text, "[^0-9]"))
            {
                MessageBox.Show("Nhập số thôi bạn ơi :/");
                tb_bank.Text = tb_bank.Text.Remove(tb_bank.Text.Length - 1);
            }
        }

        public void LayMaKH()
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("SELECT COUNT(*) MaKH FROM KHACHHANG");
            string a = ds.Tables[0].Rows[0]["MaKH"].ToString();
            int b = Convert.ToInt32(a);
            tb_makh.Text ="KH"+ (b + 1).ToString();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                connect db = new connect();
                bool b = db.capnhat("delete from KHACHHANG where SDTKH='" + tb_sdtkh.Text + "'");
                if (b == true)
                {
                    MessageBox.Show("Xoá thành công");
                    HienThi();
                }
                else
                {
                    MessageBox.Show("Lỗi!");
                }
            }
            
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2DataGridView1.CurrentRow.Selected = true;
            tb_tenkh.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["TenKhach"].FormattedValue.ToString();
            tb_diachi.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["DiaChiKH"].FormattedValue.ToString();
            tb_sdtkh.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["SDTKH"].FormattedValue.ToString();
            tb_bank.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Bank"].FormattedValue.ToString();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc sửa theo những thông tin này không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                connect db = new connect();
                bool b = db.capnhat("UPDATE KHACHHANG set TenKH='"+tb_tenkh.Text+"',DiaChiKH='"+tb_diachi.Text+"',SDTKH='"+tb_sdtkh.Text+"',Bank='"+tb_bank.Text+"'where MaKH='"+tb_makh.Text+"'");
                if (b == true)
                {
                    MessageBox.Show("Sửa thành công");
                    HienThi();
                }
                else
                {
                    MessageBox.Show("Lỗi, xem lại mã khách hàng nhé!");
                }
            }
            
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                guna2DataGridView1.CurrentRow.Selected = true;
                tb_tenkh.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["TenKhach"].FormattedValue.ToString();
                tb_diachi.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["DiaChiKH"].FormattedValue.ToString();
                tb_sdtkh.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["SDTKH"].FormattedValue.ToString();
                tb_bank.Text = guna2DataGridView1.Rows[e.RowIndex].Cells["Bank"].FormattedValue.ToString();
            }
            catch
            {

            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("select TenKH,DiaChiKH,SDTKH,Bank FROM KHACHHANG WHERE TenKH LIKE N'%" + tb_search.Text.Trim() + "%' OR DiaChiKH LIKE  N'%" + tb_search.Text.Trim() + "%' OR SDTKH LIKE  N'%" + tb_search.Text.Trim() + "%' OR Bank LIKE  N'%" + tb_search.Text.Trim() + "%'");
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_don_Click(object sender, EventArgs e)
        {
            tb_makh.ResetText();
            tb_tenkh.ResetText();
            tb_diachi.ResetText();
            tb_sdtkh.ResetText();
            tb_bank.ResetText();
            tb_search.ResetText();
            LayMaKH();
            HienThi();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace App1
{
    public partial class CaNhan : UserControl
    {
        public CaNhan()
        {
            InitializeComponent();
        }

        private void CaNhan_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM NHANVIEN, TRANGTHAI WHERE NHANVIEN.MaNv=TRANGTHAI.MaNV";
            string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            timer1.Start();
            DateTime tn = DateTime.Now;
            lbngay.Text = tn.ToString("dd/MM/yyyy");
            NameLabel.Text = XacMinh(sql,1);
            lb_manv.Text = XacMinh(sql,0);
            lb_hoten.Text = XacMinh(sql,3);
            lb_diachi.Text = XacMinh(sql,6);
            lb_chucvu.Text = XacMinh(sql,11);
            lb_cmnd.Text = XacMinh(sql,8);
            lb_email.Text = XacMinh(sql, 7);
            lb_ngaybdlv.Text = XacMinhNgayThang(sql, 12,"?");
            lb_sdt.Text = XacMinh(sql, 9);
            guna2CirclePictureBox1.Image = new Bitmap(XacMinh(sql,10));
            LayThongBao();
            Admin();
        }

        public void Admin()
        {
            if (lb_chucvu.Text.ToLower().Contains("quản") == false)
            {
                guna2GradientButton1.Visible = false;
                guna2GradientButton2.Visible = false;
                guna2GradientButton3.Visible = false;
                guna2GradientButton4.Visible = false;
                guna2GradientButton5.Visible = false;
                guna2GradientButton6.Visible = false;
                btn_thongbao.Visible = false;
                tb_tb.Visible = false;
            }
            else
            {
                guna2GradientButton1.Visible = true;
                guna2GradientButton2.Visible = true;
                guna2GradientButton3.Visible = true;
                guna2GradientButton4.Visible = true;
                guna2GradientButton5.Visible = true;
                guna2GradientButton6.Visible = true;
                btn_thongbao.Visible = true;
                tb_tb.Visible = true;
            }
        }

        public void LayThongBao()
        {
            string sql = "SELECT * FROM THONGBAO";
            string a = "";
            connect db = new connect();
            DataSet ds = new DataSet();
            ds = db.truyvan(sql);
            int loop = ds.Tables[0].Rows.Count;
            for(int i=0;i<=loop;i++)
            {
                a = db.reader(sql, "ThongBao");
                richTextBox1.Text += "\n" + a;
            }
            
        }

        private string XacMinh(string sql, int i)
        {
            string a = "";
            connect db = new connect();
            a=db.reader(sql,i);
            return a;
        }

        private string XacMinhNgayThang(string sql,int i, string b)
        {
            string a = "";
            connect db = new connect();
            a = db.reader(sql, i, b);
            return a;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime tn = DateTime.Now;
            lbgio.Text = tn.ToString("hh:mm:ss tt");
        }

        private void btn_thongbao_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn cập nhật thông báo mới", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == System.Windows.Forms.DialogResult.OK)
            {
                if (lb_chucvu.Text == "Quản lý")
                {
                    bool b = false;
                    connect db = new connect();
                    b=db.capnhat("INSERT INTO THONGBAO Values (N'" + lb_chucvu.Text + " " + lb_hoten.Text + ": " + tb_tb + "')");
                    if (b==true)
                    {
                        LayThongBao();
                        MessageBox.Show("Cập nhật thông báo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        tb_tb.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông báo thất bại ! Kiểm tra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
 
        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                string a = opnfd.FileName;
                connect db = new connect();
                bool b = db.capnhat("UPDATE NHANVIEN SET AnhNV =N'" + a + "' WHERE SDT='" + lb_sdt.Text + "'");
                if(b==true)
                {
                    MessageBox.Show("true");
                }
                else
                {
                    MessageBox.Show("false");
                }
                guna2CirclePictureBox1.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            guna2CirclePictureBox1_Click(sender, new EventArgs());
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Form x = new Print.Sanpham();
            x.Show();

        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            Form x = new Print.InNhanVien();
            x.Show();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            Form x = new Print.InKhachHang();
            x.Show();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Form x = new Print.InHoaDon();
            x.Show();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Form x = new Print.InDoanhThu();
            x.Show();
        }
    }
}

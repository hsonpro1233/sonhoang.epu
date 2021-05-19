using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1.Print
{
    public partial class InNhanVien : Form
    {
        public InNhanVien()
        {
            InitializeComponent();
        }

        Bitmap bmp;
        private void btn_sua_Click(object sender, EventArgs e)
        {
            int h = guna2DataGridView1.Height;
            guna2DataGridView1.Height = guna2DataGridView1.RowCount * guna2DataGridView1.RowTemplate.Height *2;
            bmp = new Bitmap(guna2DataGridView1.Width, guna2DataGridView1.Height);
            guna2DataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, guna2DataGridView1.Width, guna2DataGridView1.Height));
            guna2DataGridView1.Height = h;
            printPreviewDialog1.ShowDialog();
            this.Close();
        }

        private void InNhanVien_Load(object sender, EventArgs e)
        {
            string sql = "SELECT HoTen,DiaChi,SDT,NgaySinh,GioiTinh,ChucVu,NgayBDLV,Email,CMND,TaiKhoan,MatKhau,MaNv,AnhNv FROM NHANVIEN";
            connect db = new connect();
            DataSet ds = new DataSet();
            ds = db.truyvan(sql);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}

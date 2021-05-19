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
    public partial class InHoaDon : Form
    {
        public InHoaDon()
        {
            InitializeComponent();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            string sql = "SELECT MaHDNHAP,HOADONNHAP.MaHang,hang.TenHang,manv,ngaynhap,HOADONNHAP.SoLuong,hang.DonGiaNhap,thanhtien from HOADONNHAP,HANG where HANG.MaHang=HOADONNHAP.MaHang";
            connect db = new connect();
            DataSet ds = new DataSet();
            ds = db.truyvan(sql);
            gunaNhap.DataSource = ds.Tables[0];

            sql = "SELECT * FROM HOADONXUAT";
            db = new connect();
            ds = new DataSet();
            ds = db.truyvan(sql);
            gunaxuat.DataSource = ds.Tables[0];

            sql = "SELECT * FROM CTHDB";
            db = new connect();
            ds = new DataSet();
            ds = db.truyvan(sql);
            gunadetail.DataSource = ds.Tables[0];
        }

        Bitmap bmp,bmp2,bmp3;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int w = System.Math.Max(gunaNhap.Width, gunaxuat.Width);
            int h = gunaNhap.Height + gunaxuat.Height +gunadetail.Height;
            Bitmap bmp = new Bitmap(w, h);
            Rectangle r = new Rectangle(0, 0, gunaNhap.Width, gunaNhap.Height);
            gunaNhap.DrawToBitmap(bmp, r);
            r.Y = gunaNhap.Height;
            r.Width = gunaxuat.Width;
            r.Height = gunaxuat.Height;
            gunaxuat.DrawToBitmap(bmp, r);
            e.Graphics.DrawImage(bmp, e.MarginBounds);
            r.Width = gunadetail.Width;
            r.Height = gunadetail.Height;
            gunadetail.DrawToBitmap(bmp, r);
            e.Graphics.DrawImage(bmp, e.MarginBounds);
        }


        private void btn_sua_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.Landscape = true;
            printDocument1.OriginAtMargins = true;
            printDocument1.Print();
        }

    }
}

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
    public partial class InDoanhThu : Form
    {
        public InDoanhThu()
        {
            InitializeComponent();
        }

        private void InDoanhThu_Load(object sender, EventArgs e)
        {
            connect db = new connect();
            DataSet ds = new DataSet();
            string sql = "SELECT HANG.TenHang, Hang.DonGiaNhap, Hang.DonGiaBan, CTHDB.SoLuongBan, HANG.ChiPhi FROM HANG,CTHDB WHERE CTHDB.MaHang=HANG.MaHang";
            ds = db.truyvan(sql);
            guna2DataGridView1.DataSource = ds.Tables[0];
            for(int i =0;i<guna2DataGridView1.RowCount;++i)
            {
                guna2DataGridView1.Rows[i].Cells["LoiNhuan"].Value= (Convert.ToInt32(guna2DataGridView1.Rows[i].Cells["DonGiaBan"].Value)* Convert.ToInt32(guna2DataGridView1.Rows[i].Cells["DaBan"].Value)- Convert.ToInt32(guna2DataGridView1.Rows[i].Cells["ChiPhi"].Value)).ToString();
            }
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            connect db = new connect();
            DataSet ds = new DataSet();
            string sql = "SELECT HANG.TenHang, Hang.DonGiaNhap, Hang.DonGiaBan, CTHDB.SoLuongBan, HANG.ChiPhi FROM HANG,CTHDB,HOADONXUAT WHERE CTHDB.MaHang=HANG.MaHang AND CTHDB.MaHDXuat=HOADONXUAT.MaHDXuat AND HOADONXUAT.Ngayban LIKE '%"+guna2DateTimePicker1.Value.Year.ToString()+"-"+ guna2DateTimePicker1.Value.Month.ToString() + "%' ";
            ds = db.truyvan(sql);
            guna2DataGridView1.DataSource = ds.Tables[0];
            for (int i = 0; i < guna2DataGridView1.RowCount; ++i)
            {
                guna2DataGridView1.Rows[i].Cells["LoiNhuan"].Value = (Convert.ToInt32(guna2DataGridView1.Rows[i].Cells["DonGiaBan"].Value) * Convert.ToInt32(guna2DataGridView1.Rows[i].Cells["DaBan"].Value) - Convert.ToInt32(guna2DataGridView1.Rows[i].Cells["ChiPhi"].Value)).ToString();
            }
        }

        Bitmap bmp;

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int h = guna2DataGridView1.Height;
            guna2DataGridView1.Height = guna2DataGridView1.RowCount * guna2DataGridView1.RowTemplate.Height * 2;
            bmp = new Bitmap(guna2DataGridView1.Width, guna2DataGridView1.Height);
            guna2DataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, guna2DataGridView1.Width, guna2DataGridView1.Height));
            guna2DataGridView1.Height = h;
            printPreviewDialog1.ShowDialog();
            this.Close();
        }
    }
}

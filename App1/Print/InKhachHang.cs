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
    public partial class InKhachHang : Form
    {
        public InKhachHang()
        {
            InitializeComponent();
        }

        private void InKhachHang_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("Select TenKH, DiaChiKH, SDTKH,Bank from KHACHHANG");
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        Bitmap bmp;
        private void btn_sua_Click(object sender, EventArgs e)
        {
            int h = guna2DataGridView1.Height;
            guna2DataGridView1.Height = guna2DataGridView1.RowCount  * guna2DataGridView1.RowTemplate.Height *2;
            bmp = new Bitmap(guna2DataGridView1.Width, guna2DataGridView1.Height);
            guna2DataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, guna2DataGridView1.Width, guna2DataGridView1.Height));
            guna2DataGridView1.Height = h;
            printPreviewDialog1.ShowDialog();
            this.Close();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}

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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                FormProvider.MainMenu.Show();
                this.Close();
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            PointPanel.Height = btn_home.Height;
            PointPanel.Top = btn_home.Top;
            ucHomepage1.BringToFront();
        }

        private void button_customer_Click(object sender, EventArgs e)
        {
            PointPanel.Height = button_customer.Height;
            PointPanel.Top = button_customer.Top;
            ucKhach1.BringToFront();
        }


        private void MainMenu_Load(object sender, EventArgs e)
        {
            PointPanel.Height = btn_home.Height;
            PointPanel.Top = btn_home.Top;
            ucHomepage1.BringToFront();
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            PointPanel.Height = btn_home.Height;
            PointPanel.Top = btn_profile.Top;
            caNhan1.BringToFront();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            PointPanel.Height = btn_home.Height;
            PointPanel.Top = btn_product.Top;
            ucProduct1.BringToFront();
        }

        private void btn_employ_Click(object sender, EventArgs e)
        {
            PointPanel.Height = btn_home.Height;
            PointPanel.Top = btn_employ.Top;
            ucNhanVien1.BringToFront();
        }

        private void btn_reprot_Click(object sender, EventArgs e)
        {
            PointPanel.Height = btn_home.Height;
            PointPanel.Top = btn_reprot_in.Top;
            hoaDonNhap1.BringToFront();
        }

        private void btn_report_out_Click(object sender, EventArgs e)
        {
            PointPanel.Height = btn_home.Height;
            PointPanel.Top = btn_report_out.Top;
            hoaDonXuat1.BringToFront();
        }

        private void caNhan1_Load(object sender, EventArgs e)
        {

        }
    }
}

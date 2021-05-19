using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace App1
{
    public partial class ForgotPass : Form
    {
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            connect db = new connect();
            ds = db.truyvan("select * from NHANVIEN where TaiKhoan= '" + txb_taikhoan.Text +"'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                SmtpClient smtpClient = new SmtpClient("mail.MyWebsiteDomainName.com", 25);

                smtpClient.Credentials = new System.Net.NetworkCredential("info@MyWebsiteDomainName.com", "myIDPassword");
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = true;
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("info@MyWebsiteDomainName", "MyWeb Site");
                mail.To.Add(new MailAddress("info@MyWebsiteDomainName"));
                mail.CC.Add(new MailAddress("MyEmailID@gmail.com"));

                //smtpClient.Send(mail);
                MessageBox.Show("Đã gửi mật khẩu cho email đi kèm tài khoản "+ txb_taikhoan.Text+ "");
                FormProvider.MainMenu.Show();
            }
            else
            {
                MessageBox.Show("Tôi năm nay 70 tuổi rồi mà chưa thấy cái tài khoản nào nó như thế này cả");
            }
            
        }
    }
}

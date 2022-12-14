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
using System.Net;
using System.Configuration;
using System.Data.SqlClient;

namespace Final_Project
{
    public partial class Forgot_Password : Form
    {
        public String conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        SqlConnection conn;
        public Forgot_Password()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conString);
            conn.Open();
            String query = "Select * from users where users_email = '" +tb_emailReceiver.Text + "' and status = 1";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter check_email = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            check_email.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                String receiver = tb_emailReceiver.Text;
                Random random = new Random();
                String OTP = random.Next(111111, 999999).ToString();
                String mess = "Mã OTP của bạn: " + OTP;

                SendEmail("tuananhfake310801@gmail.com", receiver, "Xác minh tài khoản", mess);
                Check_OTP check = new Check_OTP(receiver, OTP);
                this.Close();
                check.Show();
            }

            else
            {
                MessageBox.Show("Email Chưa Tồn Tại Trong Hệ Thống");
            }
        }
        protected void SendEmail(String from, String to, String subject, String message)
        {
            MailMessage mess = new MailMessage(from, to, subject, message);
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("tuananhfake310801@gmail.com", "123467890Anh");
            client.Send(mess);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

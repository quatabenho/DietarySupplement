using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Login : Form
    {
        public String conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        SqlConnection conn;
        public string role = "";
        public string email = "";
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conString);
            conn.Open();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand(
                "Select * from users where users_email='"+ tb_login_account.Text + "'" + "and users_password='" + tb_login_password.Text + "'", conn
            );


            DataTable dt = new DataTable();
            SqlDataAdapter login_check = new SqlDataAdapter(sql);
            login_check.Fill(dt);

            DataRow[] dr = dt.Select("users_email= '" + tb_login_account.Text+"'");

            if (dt.Rows.Count > 0)
            {
                email = tb_login_account.Text;
                foreach(DataRow row in dr)
                {
                    role = row["role_id"].ToString();
                }
                if(role == "0")
                {
                    Admin_Management open = new Admin_Management(this, email);
                    this.Hide();
                    open.ShowDialog();
                }
                else if(role == "1")
                {
                    Accountant_Management open = new Accountant_Management(this, email);
                    this.Hide();
                    open.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Wrong username");
                }
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Forgot_Password fp = new Forgot_Password();
            //this.Hide();
            //fp.Show();
        }

        private void cb_showPass_CheckedChanged(object sender, EventArgs e)
        {
            tb_login_password.PasswordChar = cb_showPass.Checked ? '\0' : '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

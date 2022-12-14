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
    public partial class Change_Password : Form
    {
        private string email;
        public String conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        SqlConnection conn;
        private Accountant_Management accountant_Management;
        private Admin_Management admin_Management;

        public Change_Password()
        {
            InitializeComponent();
        }

        public Change_Password(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        public Change_Password(Accountant_Management accountant_Management, string email)
        {
            InitializeComponent();
            this.accountant_Management = accountant_Management;
            this.email = email;
        }

        public Change_Password(Admin_Management admin_Management, string email)
        {
            InitializeComponent();
            this.admin_Management = admin_Management;
            this.email = email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conString);
            conn.Open();
            if (tb_newPass.Text == tb_renewPass.Text)
            {
                String query = "Update users set users_password='" + tb_newPass.Text + "' where users_email='" + email + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adpapter = new SqlDataAdapter();
                adpapter.UpdateCommand = new SqlCommand(query, conn);
                adpapter.UpdateCommand.ExecuteNonQuery();

                cmd.Dispose();
                cmd.Clone();

                if (accountant_Management != null)
                {
                    accountant_Management.logout();
                }
                else
                {

                }

                if(admin_Management != null){
                    admin_Management.logout();
                }
                else
                {

                }
                Login loginAgain = new Login();
                loginAgain.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Mật Khẩu Không Khớp");
            }
        }

        private void Change_Password_Load(object sender, EventArgs e)
        {

        }
    }
}

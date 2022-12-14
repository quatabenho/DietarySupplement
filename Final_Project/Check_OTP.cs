using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Check_OTP : Form
    {
        private string receiver;
        private string OTP;

        public Check_OTP()
        {
            InitializeComponent();
        }

        public Check_OTP(string receiver, string OTP)
        {
            InitializeComponent();
            this.receiver = receiver;
            this.OTP = OTP;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if(tb_checkOTP.Text == this.OTP)
            {
                String email = receiver;
                Change_Password change = new Change_Password(email);
                change.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Mã OTP Không Chính Xác");
            }
        }

        private void btn_resend_Click(object sender, EventArgs e)
        {

        }
    }
}

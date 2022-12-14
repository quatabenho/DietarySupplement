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

namespace Final_Project.Management_Function
{
    public partial class Add_Staff : Form
    {
        public string conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        public SqlConnection conn;
        public int role = -1;
        public int gender = -1;
        public Add_Staff()
        {
            InitializeComponent();
        }

        private void Add_Staff_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conString);
            conn.Open();

            combobox_userRole.Items.Add("Kế Toán");
            combobox_userRole.Items.Add("Nhân Viên Bán Hàng");
            combobox_userRole.Items.Add("Nhân Viên Sửa Chữa");
            combobox_userRole.Items.Add("Admin");
            combobox_userRole.SelectedIndex = 0;

            combobox_userGender.Items.Add("Nam");
            combobox_userGender.Items.Add("Nữ");
            combobox_userGender.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Lưu Nhân Viên Này?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dia == DialogResult.OK)
            {
                String query_check = "Select * from users where users_email ='" + tb_userEmail.Text +"'";
                SqlCommand cmdCHECK = new SqlCommand(query_check, conn);
                DataTable dt = new DataTable();
                SqlDataAdapter check = new SqlDataAdapter(cmdCHECK);
                check.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("Nhân Viên Đã Tồn Tại");
                }

                else
                {
                    Random random = new Random();
                    String OTP = random.Next(111111, 999999).ToString();
                    String birthday = dtp_userBirth.Value.ToString();
                    String cmdString = "Insert into users(users_password, users_email, users_fullname, users_phone, users_gender, users_birthday, role_id, status) " +
                    "values(" +"'"+OTP + "','" + tb_userEmail.Text + "','" + tb_userName.Text + "','" + tb_userPhone.Text + "'," + gender + ",'" + birthday + "'," + role + ","+1+ ")";
                    MessageBox.Show(cmdString);
                    SqlCommand cmd = new SqlCommand(cmdString, conn);

                    SqlDataAdapter adt = new SqlDataAdapter();
                    adt.InsertCommand = new SqlCommand(cmdString, conn);
                    adt.InsertCommand.ExecuteNonQuery();

                    cmd.Dispose();
                    cmd.Clone();

                    MessageBox.Show("Thành Công");
                    tb_userEmail.Text = "";
                    tb_userName.Text = "";
                    tb_userPhone.Text = "";
                }
            }
            if (dia == DialogResult.Cancel)
            {

            }
        }

        private void combobox_userRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)combobox_userRole.SelectedItem == "Kế Toán")
            {
                role = 1;
            }
            else if ((string)combobox_userRole.SelectedItem == "Admin")
            {
                role = 0;
            }
            else if ((string)combobox_userRole.SelectedItem == "Nhân Viên Bán Hàng")
            {
                role = 2;
            }
            else if ((string)combobox_userRole.SelectedItem == "Nhân Viên Sửa Chữa")
            {
                role = 3;
            }
            else
            {
                role = -1;
            }
        }

        private void combobox_userGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)combobox_userGender.SelectedItem == "Nam")
            {
                gender = 0;
            }
            else if ((string)combobox_userGender.SelectedItem == "Nữ")
            {
                gender = 1;
            }
            else
            {
                gender = -1;
            }
        }

        private void tb_userPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_userEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dtp_userBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

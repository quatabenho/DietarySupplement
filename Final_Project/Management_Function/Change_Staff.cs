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
    public partial class Change_Staff : Form
    {
        public string conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        public SqlConnection conn;
        private string id;
        public int role=-1;
        public int gender=-1;

        public Change_Staff()
        {
            InitializeComponent();
        }

        public Change_Staff(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Change_Staff_Load(object sender, EventArgs e)
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

            String query = "Select * from users";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dtProduct = new DataTable();
            SqlDataAdapter Product_DA = new SqlDataAdapter(cmd);
            Product_DA.Fill(dtProduct);

            DataRow[] dr = dtProduct.Select("users_id = '" + id + "' and role_id is not null");

            foreach (DataRow row in dr)
            {
                tb_userName.Text = row["users_fullname"].ToString();
                tb_userEmail.Text = row["users_email"].ToString();
                tb_userPhone.Text = row["users_phone"].ToString();
                dtp_userBirth.Text = row["users_birthday"].ToString();
            }
        }

        private void combobox_userRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_userRole.SelectedIndex == 0)
            {
                role = 1;
            }
            else if (combobox_userRole.SelectedIndex == 1)
            {
                role = 0;
            }
            else if (combobox_userRole.SelectedIndex == 2)
            {
                role = 2;
            }
            else if (combobox_userRole.SelectedIndex == 3)
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
            if (combobox_userGender.SelectedIndex == 0)
            {
                gender = 0;
            }
            else if (combobox_userGender.SelectedIndex == 1)
            {
                gender = 1;
            }
            else
            {
                gender = -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có chắc muốn thay đổi thông tin nhân viên không?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dia == DialogResult.OK)
            {
                String birthday = dtp_userBirth.Value.ToString();
                String cmdString = "Update users set users_fullname =N'" + tb_userName.Text + "', users_email=N'" + tb_userEmail.Text + "', users_phone='" + tb_userPhone.Text + "', users_birthday='" + birthday + "', users_gender='" + gender + "', role_id='" + role + "' where users_id='" + id + "'";
                SqlCommand cmd = new SqlCommand(cmdString, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.Clone();

                MessageBox.Show("Sucessfull");
            }
            if (dia == DialogResult.Cancel)
            {

            }
        }

        private void combobox_userRole_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (combobox_userRole.SelectedIndex == 0)
            {
                role = 1;
            }
            else if (combobox_userRole.SelectedIndex == 1)
            {
                role = 0;
            }
            else if (combobox_userRole.SelectedIndex == 2)
            {
                role = 2;
            }
            else if (combobox_userRole.SelectedIndex == 3)
            {
                role = 3;
            }
            else
            {
                role = -1;
            }
        }

        private void combobox_userGender_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (combobox_userGender.SelectedIndex == 0)
            {
                gender = 0;
            }
            else if (combobox_userGender.SelectedIndex == 1)
            {
                gender = 1;
            }
            else
            {
                gender = -1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm không?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dia == DialogResult.OK)
            {
                String query = "Delete from users where users_id='" + id + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                cmd.Clone();
                this.Close();
            }
            if (dia == DialogResult.Cancel)
            {

            }
        }
    }
}

using Final_Project.Management_Function;
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
    public partial class Admin_Management : Form
    {
        public string conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        public SqlConnection conn;
        private Add_Product add_Product;
        private string email;
        private Login login;

        public Admin_Management()
        {
            InitializeComponent();
        }

        public Admin_Management(Add_Product add_Product)
        {
            InitializeComponent();
            this.add_Product = add_Product;
        }

        public Admin_Management(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        public Admin_Management(Login login, string email)
        {
            InitializeComponent();
            this.login = login;
            this.email = email;
        }

        private void thêmSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Product add = new Add_Product();
            add.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Admin_Management_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conString);
            conn.Open();
            String cmdString = "Select * from products";
            SqlCommand cmd = new SqlCommand(cmdString, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter load_product = new SqlDataAdapter(cmd);
            load_product.Fill(dt);
            dgv_LoadProduct.DataSource = dt;

            String cmdString1 = "Select * from users where role_id is not null";
            SqlCommand cmd1 = new SqlCommand(cmdString1, conn);
            DataTable dt1 = new DataTable();
            SqlDataAdapter load_staff = new SqlDataAdapter(cmd1);
            load_staff.Fill(dt1);
            dgv_staff.DataSource = dt1;

            String cmdString2 = "Select * from users where role_id is null";
            SqlCommand cmd2 = new SqlCommand(cmdString2, conn);
            DataTable dt2 = new DataTable();
            SqlDataAdapter load_customer = new SqlDataAdapter(cmd2);
            load_customer.Fill(dt2);
            dgv_customer.DataSource = dt2;
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            String cmdString = "Select * from products";
            SqlCommand cmd = new SqlCommand(cmdString, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter load_product = new SqlDataAdapter(cmd);
            load_product.Fill(dt);
            dgv_LoadProduct.DataSource = dt;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }

        private void tắtỨngDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("You want to exist?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                this.Close();
                System.Windows.Forms.Application.Exit(); 
            }
            if (res == DialogResult.Cancel)
            {

            }
        }

        private void thêmKếToánViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Staff addStaff = new Add_Staff();
            addStaff.Show();
        }

        private void btn_reload_staff_Click(object sender, EventArgs e)
        {
            String cmdString1 = "Select * from users where role_id is not null";
            SqlCommand cmd1 = new SqlCommand(cmdString1, conn);
            DataTable dt1 = new DataTable();
            SqlDataAdapter load_staff = new SqlDataAdapter(cmd1);
            load_staff.Fill(dt1);
            dgv_staff.DataSource = dt1;
        }

        private void btn_reload_product_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conString);
            conn.Open();
            String cmdString = "Select * from products";
            SqlCommand cmd = new SqlCommand(cmdString, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter load_product = new SqlDataAdapter(cmd);
            load_product.Fill(dt);
            dgv_LoadProduct.DataSource = dt;
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Password cp = new Change_Password(this, email);
            cp.Show();
        }

        public void logout()
        {
            login.Show();
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String id = tb_searchbyID.Text;
            SqlCommand sql = new SqlCommand(
                "Select * from users where users_id='" + id + "' and role_id is not null", conn
            );

            DataTable dt = new DataTable();
            SqlDataAdapter check_product = new SqlDataAdapter(sql);
            check_product.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Change_Staff cs = new Change_Staff(id);
                cs.Show();
            }
            else
            {
                MessageBox.Show("Accountant not exist");
            }
        }
    }
}

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
    public partial class Accountant_Management : Form
    {
        public string conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        public SqlConnection conn;
        private string email;
        private Login login;
        public int quarter = -1;
        public int quarter_ship = -1;
        public int quarter_detail = -1;

        public Accountant_Management()
        {
            InitializeComponent();
        }

        public Accountant_Management(Login login, string email)
        {
            InitializeComponent();
            this.email = email;
            this.login = login;
        }

        private void Accountant_Management_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conString);
            conn.Open();
            String query = "Select pd_id as ID, pd_name as Name, pd_detail as Detail, pd_price as Price, qty as Quantity, pd_added as Date from products";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter load_product = new SqlDataAdapter(cmd);
            dgv_LoadProduct.AllowUserToAddRows = false;
            load_product.Fill(dt);
            dgv_LoadProduct.DataSource = dt;
            cbox_quarter.Items.Add("Quarter 1");
            cbox_quarter.Items.Add("Quarter 2");
            cbox_quarter.Items.Add("Quarter 3");
            cbox_quarter.Items.Add("Quarter 4");
            cbox_quarter.SelectedIndex = 0;

            String query1 = "Select * from shipping";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            DataTable dt1 = new DataTable();
            SqlDataAdapter load_shipping = new SqlDataAdapter(cmd1);
            dgv_loadShipping.AllowUserToAddRows = false;
            load_shipping.Fill(dt1);
            dgv_loadShipping.DataSource = dt1;
            cbox_quarterShip.Items.Add("Quarter 1");
            cbox_quarterShip.Items.Add("Quarter 2");
            cbox_quarterShip.Items.Add("Quarter 3");
            cbox_quarterShip.Items.Add("Quarter 4");
            cbox_quarterShip.SelectedIndex = 0;

            String query2 = "Select order_id, shipping_id, pd_id, UnitPriceSale, QuantitySale, order_created from orders";
            SqlCommand cmd2 = new SqlCommand(query2, conn);
            DataTable dt2 = new DataTable();
            SqlDataAdapter load_detail = new SqlDataAdapter(cmd2);
            dgv_loadDetail.AllowUserToAddRows = false;
            load_detail.Fill(dt2);
            dgv_loadDetail.DataSource = dt2;
            cbox_quarterDetail.Items.Add("Quarter 1");
            cbox_quarterDetail.Items.Add("Quarter 2");
            cbox_quarterDetail.Items.Add("Quarter 3");
            cbox_quarterDetail.Items.Add("Quarter 4");
            cbox_quarterDetail.SelectedIndex = 0;
        }

        private void btn_reload_product_Click(object sender, EventArgs e)
        {
            String query = "Select pd_id as ID, pd_name as Name, pd_detail as Detail, pd_price as Price, qty as Quantity, pd_added as Date from products";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter load_product = new SqlDataAdapter(cmd);
            dgv_LoadProduct.AllowUserToAddRows = false;
            load_product.Fill(dt);
            dgv_LoadProduct.DataSource = dt;
        }

        private void xuấtFileExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String id = tb_searchbyID.Text;
            SqlCommand sql = new SqlCommand(
                "Select * from products where pd_id='" + id+"'", conn
            );

            DataTable dt = new DataTable();
            SqlDataAdapter check_product = new SqlDataAdapter(sql);
            check_product.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Change_Product cp = new Change_Product(id);
                cp.Show();
            }
            else
            {
                MessageBox.Show("Product ID not exist");
            }
         
        }

        private void thêmSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Product ap = new Add_Product();
            ap.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Password cp = new Change_Password(this, email);
            cp.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }

        public void logout()
        {
            login.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String day = dtp_bytime.Value.Day.ToString();
            String month = dtp_bytime.Value.Month.ToString();
            String year = dtp_bytime.Value.Year.ToString();
            String query = "Select pd_id as ID, pd_name as Name, pd_detail as Detail, pd_price as Price, qty as Quantity, pd_added as Date from products where Day(pd_added)='"+ day +"' and Month(pd_added)='"+ month +"' and Year(pd_added)='" + year +"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter load_product = new SqlDataAdapter(cmd);
            dgv_LoadProduct.AllowUserToAddRows = false;
            load_product.Fill(dt);
            dgv_LoadProduct.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String day = dtp_bytime.Value.Day.ToString();
            String month = dtp_bytime.Value.Month.ToString();
            String year = dtp_bytime.Value.Year.ToString();
            String query = "Select pd_id as ID, pd_name as Name, pd_detail as Detail, pd_price as Price, qty as Quantity, pd_added as Date from products where Month(pd_added)='" + month +"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter load_product = new SqlDataAdapter(cmd);
            dgv_LoadProduct.AllowUserToAddRows = false;
            load_product.Fill(dt);
            dgv_LoadProduct.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String day = dtp_bytime.Value.Day.ToString();
            String month = dtp_bytime.Value.Month.ToString();
            String year = dtp_bytime.Value.Year.ToString();
            String query = "Select pd_id as ID, pd_name as Name, pd_detail as Detail, pd_price as Price, qty as Quantity, pd_added as Date from products where Year(pd_added)='" + year + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter load_product = new SqlDataAdapter(cmd);
            dgv_LoadProduct.AllowUserToAddRows = false;
            load_product.Fill(dt);
            dgv_LoadProduct.DataSource = dt;
        }

        private void xuấtFileNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Filter = "Execl file (*.xlsx)|*.xlsx | Excel 2007 (*.xls) | *.xls ";
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                ExcelApp.Columns.ColumnWidth = 30;

                for (int i = 1; i < dgv_LoadProduct.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dgv_LoadProduct.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgv_LoadProduct.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_LoadProduct.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dgv_LoadProduct.Rows[i].Cells[j].Value.ToString();
                    }
                }

                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
        }

        private void cbox_quarter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cbox_quarter.SelectedItem == "Quarter 1")
            {
                quarter = 1;
            }
            else if ((string)cbox_quarter.SelectedItem == "Quarter 2")
            {
                quarter = 2;
            }
            else if ((string)cbox_quarter.SelectedItem == "Quarter 3")
            {
                quarter = 3;
            }
            else if ((string)cbox_quarter.SelectedItem == "Quarter 4")
            {
                quarter = 4;
            }
            else
            {
                quarter = -1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String year = tb_byYear.Text;
            String query = "Select pd_id as ID, pd_name as Name, pd_detail as Detail, pd_price as Price, qty as Quantity, pd_added as Date from products where Year(pd_added)='" + year + "' and datepart(quarter, pd_added)='" + quarter +"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter load_product = new SqlDataAdapter(cmd);
            dgv_LoadProduct.AllowUserToAddRows = false;
            load_product.Fill(dt);
            dgv_LoadProduct.DataSource = dt;
        }

        private void cbox_quarterShip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cbox_quarterShip.SelectedItem == "Quarter 1")
            {
                quarter_ship = 1;
            }
            else if ((string)cbox_quarterShip.SelectedItem == "Quarter 2")
            {
                quarter_ship = 2;
            }
            else if ((string)cbox_quarterShip.SelectedItem == "Quarter 3")
            {
                quarter_ship = 3;
            }
            else if ((string)cbox_quarterShip.SelectedItem == "Quarter 4")
            {
                quarter_ship = 4;
            }
            else
            {
                quarter_ship = -1;
            }
        }

        private void cbox_quarterDetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cbox_quarterDetail.SelectedItem == "Quarter 1")
            {
                quarter_detail = 1;
            }
            else if ((string)cbox_quarterDetail.SelectedItem == "Quarter 2")
            {
                quarter_detail = 2;
            }
            else if ((string)cbox_quarterDetail.SelectedItem == "Quarter 3")
            {
                quarter_detail = 3;
            }
            else if ((string)cbox_quarterDetail.SelectedItem == "Quarter 4")
            {
                quarter_detail = 4;
            }
            else
            {
                quarter_detail = -1;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            String day = dtp_Detail.Value.Day.ToString();
            String month = dtp_Detail.Value.Month.ToString();
            String year = dtp_Detail.Value.Year.ToString();
            String query = "Select order_id, shipping_id, pd_id, UnitPriceSale, QuantitySale, order_created from orders where Day(order_created)='" + day + "' and Month(order_created)='" + month + "' and Year(order_created)='" + year + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter load_detail = new SqlDataAdapter(cmd);
            dgv_loadDetail.AllowUserToAddRows = false;
            load_detail.Fill(dt);
            dgv_loadDetail.DataSource = dt;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            String day = dtp_Detail.Value.Day.ToString();
            String month = dtp_Detail.Value.Month.ToString();
            String year = dtp_Detail.Value.Year.ToString();
            String query = "Select order_id, shipping_id, pd_id, UnitPriceSale, QuantitySale, order_created from orders where Month(order_created)='" + month + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter load_detail = new SqlDataAdapter(cmd);
            dgv_loadDetail.AllowUserToAddRows = false;
            load_detail.Fill(dt);
            dgv_loadDetail.DataSource = dt;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            String day = dtp_Detail.Value.Day.ToString();
            String month = dtp_Detail.Value.Month.ToString();
            String year = dtp_Detail.Value.Year.ToString();
            String query = "Select order_id, shipping_id, pd_id, UnitPriceSale, QuantitySale, order_created from orders where Year(order_created)='" + year + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter load_detail = new SqlDataAdapter(cmd);
            dgv_loadDetail.AllowUserToAddRows = false;
            load_detail.Fill(dt);
            dgv_loadDetail.DataSource = dt;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String year = tb_yearDetail.Text;
            String query = "Select order_id, shipping_id, pd_id, UnitPriceSale, QuantitySale, order_created from orders where Year(order_created)='" + year + "' and datepart(quarter, order_created)='" + quarter_detail + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter load_detail = new SqlDataAdapter(cmd);
            dgv_loadDetail.AllowUserToAddRows = false;
            load_detail.Fill(dt);
            dgv_loadDetail.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String day = dtp_shipping.Value.Day.ToString();
            String month = dtp_shipping.Value.Month.ToString();
            String year = dtp_shipping.Value.Year.ToString();
            String query = "Select * from shipping where Day(shipping_created)='" + day + "' and Month(shipping_created)='" + month + "' and Year(shipping_created)='" + year + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter load_shipping = new SqlDataAdapter(cmd);
            dgv_loadShipping.AllowUserToAddRows = false;
            load_shipping.Fill(dt);
            dgv_loadShipping.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String day = dtp_shipping.Value.Day.ToString();
            String month = dtp_shipping.Value.Month.ToString();
            String year = dtp_shipping.Value.Year.ToString();
            String query = "Select * from shipping where Month(shipping_created)='" + month + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter load_shipping = new SqlDataAdapter(cmd);
            dgv_loadShipping.AllowUserToAddRows = false;
            load_shipping.Fill(dt);
            dgv_loadShipping.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String day = dtp_shipping.Value.Day.ToString();
            String month = dtp_shipping.Value.Month.ToString();
            String year = dtp_shipping.Value.Year.ToString();
            String query = "Select * from shipping where Year(shipping_created)='" + year + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter load_shipping = new SqlDataAdapter(cmd);
            dgv_loadShipping.AllowUserToAddRows = false;
            load_shipping.Fill(dt);
            dgv_loadShipping.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String year = tb_yearShip.Text;
            String query = "Select * from shipping where Year(shipping_created)='" + year + "' and datepart(quarter, shipping_created)='" + quarter_ship + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter load_shipping = new SqlDataAdapter(cmd);
            dgv_loadShipping.AllowUserToAddRows = false;
            load_shipping.Fill(dt);
            dgv_loadShipping.DataSource = dt;
        }

        private void xuấtFileXuấtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Filter = "Execl file (*.xlsx)|*.xlsx | Excel 2007 (*.xls) | *.xls ";
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                ExcelApp.Columns.ColumnWidth = 30;

                for (int i = 1; i < dgv_loadShipping.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dgv_loadShipping.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgv_loadShipping.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_loadShipping.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dgv_loadShipping.Rows[i].Cells[j].Value.ToString();
                    }
                }

                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
        }

        private void chiTiếtXuấtKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Filter = "Execl file (*.xlsx)|*.xlsx | Excel 2007 (*.xls) | *.xls ";
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

                ExcelApp.Columns.ColumnWidth = 30;

                for (int i = 1; i < dgv_loadDetail.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = dgv_loadDetail.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgv_loadDetail.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv_loadDetail.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = dgv_loadDetail.Rows[i].Cells[j].Value.ToString();
                    }
                }

                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
        }
    }
}

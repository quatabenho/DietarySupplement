using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.Management_Function
{
    public partial class Change_Product : Form
    {
        public string conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        public SqlConnection conn;
        private string id;
        public Image pd_image = null;
        public int setActive = -1;

        public Change_Product()
        {
            InitializeComponent();
        }

        public Change_Product(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Change_Product_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(conString);
            conn.Open();

            combobox_active.Items.Add("Kích Hoạt");
            combobox_active.Items.Add("Ẩn");
            combobox_active.SelectedIndex = 0;

            String query = "Select * from products";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dtProduct = new DataTable();
            SqlDataAdapter Product_DA = new SqlDataAdapter(cmd);
            Product_DA.Fill(dtProduct);

            DataRow[] dr = dtProduct.Select("pd_id = '" + id+"'");
            
            foreach(DataRow row in dr)
            {
                tb_pdID.Text = row["pd_id"].ToString();
                tb_pdName.Text = row["pd_name"].ToString();
                tb_pdDetail.Text = row["pd_detail"].ToString();
                tb_pdPrice.Text = row["pd_price"].ToString();
                tb_pdQty.Text = row["qty"].ToString();
                pb_pdImage.Image = CovertByteToImage((byte[])row["pd_image"]);
                tb_imagePath.Text = row["pd_imagePath"].ToString();
            }
        }
        private static Image CovertByteToImage(byte[] img)
        {
            using (MemoryStream ms = new MemoryStream(img))
            {
                return Image.FromStream(ms);
            }
        }

        public static Byte[] ConvertImageToByte(Image image)
        {
            if (image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            else
                return new Byte[0];
        }

        private void btn_chooseAgain_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Image Files (* .Jpeg, * .jpg , *.png) | * .Jpeg; *. Jpg ; *.png",
                Multiselect = false
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pd_image = Image.FromFile(ofd.FileName);
                    tb_imagePath.Text = ofd.FileName;
                    pb_pdImage.Image = pd_image;
                }
            }
        }

        private void btn_pdSave_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có chắc muốn thay đổi thông tin sản phẩm không?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dia == DialogResult.OK)
            {
                String cmdString = "Update products set pd_name =N'" + tb_pdName.Text + "', pd_detail=N'" + tb_pdDetail.Text+ "', pd_price='"+tb_pdPrice.Text+"', qty='"+tb_pdQty.Text+"', pd_image=@Image, pd_imagePath=@path, pd_added=GETDATE(), status='"+setActive+"' where pd_id='" + tb_pdID.Text + "'";
                SqlCommand cmd = new SqlCommand(cmdString, conn);
                cmd.Parameters.Add("@Image", SqlDbType.VarBinary).Value = ConvertImageToByte(pb_pdImage.Image);
                cmd.Parameters.Add("@path", tb_imagePath.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd.Clone();

                MessageBox.Show("Thành Công");
            }
            if (dia == DialogResult.Cancel)
            {

            }
        }



        private void combobox_active_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)combobox_active.SelectedItem == "Kích Hoạt")
            {
                setActive = 1;
            }
            else if ((string)combobox_active.SelectedItem == "Ẩn")
            {
                setActive = 0;
            }
            else
            {
                setActive = -1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dia = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm không?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dia == DialogResult.OK)
            {
                String query = "Delete from products where pd_id='" + id+"'";
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

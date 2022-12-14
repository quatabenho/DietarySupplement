using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Add_Product : Form
    {
        public string conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        public SqlConnection conn;
        public Image pd_image = null;
        
        public Add_Product()
        {
            InitializeComponent();
        }

        private void btn_pdSave_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conString);
            conn.Open();
            DialogResult dia = MessageBox.Show("You wanna save?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dia == DialogResult.OK)
            {
                Byte[] img = ConvertImageToByte(pd_image);

                String cmdString = "Insert into products(pd_name,pd_detail,pd_price,qty,status,pd_image,pd_added,pd_imagePath) " +
                    "values(" + "N'" + tb_pdName.Text + "',N'" + tb_pdDetail.Text + "'," + tb_pdPrice.Text + "," + tb_pdQty.Text + "," + 1 + ",@Image, GETDATE(), @path)";

                SqlCommand cmd = new SqlCommand(cmdString, conn);
                cmd.Parameters.Add("@Image", SqlDbType.VarBinary).Value = ConvertImageToByte(pd_image);
                SqlParameter sqlParameter = cmd.Parameters.Add("@path", tb_imagePath.Text);
                int v = cmd.ExecuteNonQuery();


                cmd.Dispose();
                cmd.Clone();

                MessageBox.Show("Successfully");
                tb_pdName.Text = "";
                tb_pdDetail.Text = "";
                tb_pdPrice.Text = "";
                tb_pdQty.Text = "";
                tb_imagePath.Text = "";
            }
            if (dia == DialogResult.Cancel)
            {

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

        private static Image CovertByteToImage(byte[] img)
        {
            using (MemoryStream ms = new MemoryStream(img))
            {
                return Image.FromStream(ms);
            }
        }

        private void lb_loadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Image Files (*.png, *.jpg, *.Jpeg) | *.png; *.Jpg ; *.Jpeg",
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

        private void btn_chooseAgain_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Image Files (*.Jpeg, *.jpg , *.png) | *.Jpeg; *.Jpg ; *.png",
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

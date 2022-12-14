
namespace Final_Project
{
    partial class Add_Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_pdSave = new System.Windows.Forms.Button();
            this.tb_pdName = new System.Windows.Forms.TextBox();
            this.tb_pdDetail = new System.Windows.Forms.TextBox();
            this.tb_pdPrice = new System.Windows.Forms.TextBox();
            this.tb_pdQty = new System.Windows.Forms.TextBox();
            this.lb_loadImage = new System.Windows.Forms.Label();
            this.pb_pdImage = new System.Windows.Forms.PictureBox();
            this.btn_chooseAgain = new System.Windows.Forms.Button();
            this.tb_imagePath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pdImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "IMPORT GOODS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Detail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 326);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 375);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity";
            // 
            // btn_pdSave
            // 
            this.btn_pdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pdSave.Location = new System.Drawing.Point(165, 443);
            this.btn_pdSave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pdSave.Name = "btn_pdSave";
            this.btn_pdSave.Size = new System.Drawing.Size(293, 45);
            this.btn_pdSave.TabIndex = 7;
            this.btn_pdSave.Text = "ADD PRODUCT";
            this.btn_pdSave.UseVisualStyleBackColor = true;
            this.btn_pdSave.Click += new System.EventHandler(this.btn_pdSave_Click);
            // 
            // tb_pdName
            // 
            this.tb_pdName.Location = new System.Drawing.Point(165, 133);
            this.tb_pdName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pdName.Name = "tb_pdName";
            this.tb_pdName.Size = new System.Drawing.Size(293, 27);
            this.tb_pdName.TabIndex = 9;
            // 
            // tb_pdDetail
            // 
            this.tb_pdDetail.Location = new System.Drawing.Point(165, 186);
            this.tb_pdDetail.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pdDetail.Multiline = true;
            this.tb_pdDetail.Name = "tb_pdDetail";
            this.tb_pdDetail.Size = new System.Drawing.Size(293, 124);
            this.tb_pdDetail.TabIndex = 10;
            // 
            // tb_pdPrice
            // 
            this.tb_pdPrice.Location = new System.Drawing.Point(165, 326);
            this.tb_pdPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pdPrice.Name = "tb_pdPrice";
            this.tb_pdPrice.Size = new System.Drawing.Size(293, 27);
            this.tb_pdPrice.TabIndex = 11;
            // 
            // tb_pdQty
            // 
            this.tb_pdQty.Location = new System.Drawing.Point(165, 372);
            this.tb_pdQty.Margin = new System.Windows.Forms.Padding(4);
            this.tb_pdQty.Name = "tb_pdQty";
            this.tb_pdQty.Size = new System.Drawing.Size(293, 27);
            this.tb_pdQty.TabIndex = 12;
            // 
            // lb_loadImage
            // 
            this.lb_loadImage.AutoSize = true;
            this.lb_loadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loadImage.Location = new System.Drawing.Point(546, 133);
            this.lb_loadImage.Name = "lb_loadImage";
            this.lb_loadImage.Size = new System.Drawing.Size(221, 20);
            this.lb_loadImage.TabIndex = 13;
            this.lb_loadImage.Text = "Add an image for product";
            this.lb_loadImage.Click += new System.EventHandler(this.lb_loadImage_Click);
            // 
            // pb_pdImage
            // 
            this.pb_pdImage.Location = new System.Drawing.Point(550, 156);
            this.pb_pdImage.Name = "pb_pdImage";
            this.pb_pdImage.Size = new System.Drawing.Size(264, 176);
            this.pb_pdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_pdImage.TabIndex = 14;
            this.pb_pdImage.TabStop = false;
            // 
            // btn_chooseAgain
            // 
            this.btn_chooseAgain.Location = new System.Drawing.Point(820, 372);
            this.btn_chooseAgain.Name = "btn_chooseAgain";
            this.btn_chooseAgain.Size = new System.Drawing.Size(97, 36);
            this.btn_chooseAgain.TabIndex = 15;
            this.btn_chooseAgain.Text = "Choose";
            this.btn_chooseAgain.UseVisualStyleBackColor = true;
            this.btn_chooseAgain.Click += new System.EventHandler(this.btn_chooseAgain_Click);
            // 
            // tb_imagePath
            // 
            this.tb_imagePath.Location = new System.Drawing.Point(550, 377);
            this.tb_imagePath.Name = "tb_imagePath";
            this.tb_imagePath.Size = new System.Drawing.Size(264, 27);
            this.tb_imagePath.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(546, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(804, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Dung - Nguyen Co., Ltd";
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 563);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_imagePath);
            this.Controls.Add(this.btn_chooseAgain);
            this.Controls.Add(this.pb_pdImage);
            this.Controls.Add(this.lb_loadImage);
            this.Controls.Add(this.tb_pdQty);
            this.Controls.Add(this.tb_pdPrice);
            this.Controls.Add(this.tb_pdDetail);
            this.Controls.Add(this.tb_pdName);
            this.Controls.Add(this.btn_pdSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_Product";
            this.Text = "IMPORT GOODS";
            ((System.ComponentModel.ISupportInitialize)(this.pb_pdImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_pdSave;
        private System.Windows.Forms.TextBox tb_pdName;
        private System.Windows.Forms.TextBox tb_pdDetail;
        private System.Windows.Forms.TextBox tb_pdPrice;
        private System.Windows.Forms.TextBox tb_pdQty;
        private System.Windows.Forms.Label lb_loadImage;
        private System.Windows.Forms.PictureBox pb_pdImage;
        private System.Windows.Forms.Button btn_chooseAgain;
        private System.Windows.Forms.TextBox tb_imagePath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}
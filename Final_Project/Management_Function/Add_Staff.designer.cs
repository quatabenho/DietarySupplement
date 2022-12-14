
namespace Final_Project.Management_Function
{
    partial class Add_Staff
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
            this.dtp_userBirth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.tb_userEmail = new System.Windows.Forms.TextBox();
            this.tb_userPhone = new System.Windows.Forms.TextBox();
            this.combobox_userRole = new System.Windows.Forms.ComboBox();
            this.combobox_userGender = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM NHÂN VIÊN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhân Viên";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email Nhân Viên";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "SĐT Nhân Viên";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dtp_userBirth
            // 
            this.dtp_userBirth.Location = new System.Drawing.Point(453, 276);
            this.dtp_userBirth.Name = "dtp_userBirth";
            this.dtp_userBirth.Size = new System.Drawing.Size(246, 27);
            this.dtp_userBirth.TabIndex = 5;
            this.dtp_userBirth.ValueChanged += new System.EventHandler(this.dtp_userBirth_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày Sinh Nhân Viên";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Chức Vụ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(354, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Giới Tính";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(453, 130);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(246, 27);
            this.tb_userName.TabIndex = 10;
            this.tb_userName.TextChanged += new System.EventHandler(this.tb_userName_TextChanged);
            // 
            // tb_userEmail
            // 
            this.tb_userEmail.Location = new System.Drawing.Point(453, 178);
            this.tb_userEmail.Name = "tb_userEmail";
            this.tb_userEmail.Size = new System.Drawing.Size(246, 27);
            this.tb_userEmail.TabIndex = 11;
            this.tb_userEmail.TextChanged += new System.EventHandler(this.tb_userEmail_TextChanged);
            // 
            // tb_userPhone
            // 
            this.tb_userPhone.Location = new System.Drawing.Point(453, 227);
            this.tb_userPhone.Name = "tb_userPhone";
            this.tb_userPhone.Size = new System.Drawing.Size(246, 27);
            this.tb_userPhone.TabIndex = 12;
            this.tb_userPhone.TextChanged += new System.EventHandler(this.tb_userPhone_TextChanged);
            // 
            // combobox_userRole
            // 
            this.combobox_userRole.FormattingEnabled = true;
            this.combobox_userRole.Location = new System.Drawing.Point(453, 323);
            this.combobox_userRole.Name = "combobox_userRole";
            this.combobox_userRole.Size = new System.Drawing.Size(246, 28);
            this.combobox_userRole.TabIndex = 13;
            this.combobox_userRole.SelectedIndexChanged += new System.EventHandler(this.combobox_userRole_SelectedIndexChanged);
            // 
            // combobox_userGender
            // 
            this.combobox_userGender.FormattingEnabled = true;
            this.combobox_userGender.Location = new System.Drawing.Point(453, 369);
            this.combobox_userGender.Name = "combobox_userGender";
            this.combobox_userGender.Size = new System.Drawing.Size(246, 28);
            this.combobox_userGender.TabIndex = 14;
            this.combobox_userGender.SelectedIndexChanged += new System.EventHandler(this.combobox_userGender_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "LƯU";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(749, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Designed by Tuan Anh Nguyen";
            // 
            // Add_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.combobox_userGender);
            this.Controls.Add(this.combobox_userRole);
            this.Controls.Add(this.tb_userPhone);
            this.Controls.Add(this.tb_userEmail);
            this.Controls.Add(this.tb_userName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_userBirth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_Staff";
            this.Text = "Add_Staff";
            this.Load += new System.EventHandler(this.Add_Staff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_userBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.TextBox tb_userEmail;
        private System.Windows.Forms.TextBox tb_userPhone;
        private System.Windows.Forms.ComboBox combobox_userRole;
        private System.Windows.Forms.ComboBox combobox_userGender;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}
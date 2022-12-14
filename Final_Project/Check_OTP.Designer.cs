
namespace Final_Project
{
    partial class Check_OTP
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
            this.tb_checkOTP = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_resend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER OTP";
            // 
            // tb_checkOTP
            // 
            this.tb_checkOTP.Location = new System.Drawing.Point(113, 177);
            this.tb_checkOTP.Margin = new System.Windows.Forms.Padding(4);
            this.tb_checkOTP.Name = "tb_checkOTP";
            this.tb_checkOTP.Size = new System.Drawing.Size(428, 27);
            this.tb_checkOTP.TabIndex = 1;
            this.tb_checkOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(188, 264);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(4);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(121, 52);
            this.btn_confirm.TabIndex = 2;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_resend
            // 
            this.btn_resend.Location = new System.Drawing.Point(333, 264);
            this.btn_resend.Margin = new System.Windows.Forms.Padding(4);
            this.btn_resend.Name = "btn_resend";
            this.btn_resend.Size = new System.Drawing.Size(120, 52);
            this.btn_resend.TabIndex = 3;
            this.btn_resend.Text = "Resend";
            this.btn_resend.UseVisualStyleBackColor = true;
            this.btn_resend.Click += new System.EventHandler(this.btn_resend_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dung - Nguyen Co., Ltd";
            // 
            // Check_OTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 443);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_resend);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.tb_checkOTP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Check_OTP";
            this.Text = "Check_OTP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_checkOTP;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_resend;
        private System.Windows.Forms.Label label5;
    }
}
namespace Exercise2
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.textBox_confirm = new System.Windows.Forms.TextBox();
            this.label_confirm = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.button_signup = new System.Windows.Forms.Button();
            this.labelError_username = new System.Windows.Forms.Label();
            this.labelError_password = new System.Windows.Forms.Label();
            this.labelError_confirm = new System.Windows.Forms.Label();
            this.labelError_email = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Orange;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(42, 9);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(141, 24);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Tên đăng nhập";
            this.label_username.Click += new System.EventHandler(this.label_username_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Orange;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(371, 9);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(86, 24);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Mật khẩu";
            this.label_password.Click += new System.EventHandler(this.label_password_Click);
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(42, 36);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(171, 20);
            this.textBox_username.TabIndex = 2;
            this.textBox_username.TextChanged += new System.EventHandler(this.textBox_username_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(371, 36);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(171, 20);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // textBox_confirm
            // 
            this.textBox_confirm.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_confirm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_confirm.Location = new System.Drawing.Point(42, 169);
            this.textBox_confirm.Name = "textBox_confirm";
            this.textBox_confirm.Size = new System.Drawing.Size(171, 20);
            this.textBox_confirm.TabIndex = 5;
            this.textBox_confirm.UseSystemPasswordChar = true;
            this.textBox_confirm.TextChanged += new System.EventHandler(this.textBox_confirm_TextChanged);
            // 
            // label_confirm
            // 
            this.label_confirm.AutoSize = true;
            this.label_confirm.BackColor = System.Drawing.Color.Orange;
            this.label_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_confirm.Location = new System.Drawing.Point(42, 142);
            this.label_confirm.Name = "label_confirm";
            this.label_confirm.Size = new System.Drawing.Size(173, 24);
            this.label_confirm.TabIndex = 4;
            this.label_confirm.Text = "Xác nhận mật khẩu";
            this.label_confirm.Click += new System.EventHandler(this.label_confirm_Click);
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(371, 169);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(171, 20);
            this.textBox_email.TabIndex = 7;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.BackColor = System.Drawing.Color.Orange;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(371, 142);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(57, 24);
            this.label_email.TabIndex = 6;
            this.label_email.Text = "Email";
            this.label_email.Click += new System.EventHandler(this.label_email_Click);
            // 
            // button_signup
            // 
            this.button_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signup.Location = new System.Drawing.Point(242, 258);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(112, 47);
            this.button_signup.TabIndex = 8;
            this.button_signup.Text = "Đăng ký";
            this.button_signup.UseVisualStyleBackColor = true;
            this.button_signup.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelError_username
            // 
            this.labelError_username.AutoSize = true;
            this.labelError_username.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelError_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError_username.ForeColor = System.Drawing.Color.Red;
            this.labelError_username.Location = new System.Drawing.Point(43, 59);
            this.labelError_username.Name = "labelError_username";
            this.labelError_username.Size = new System.Drawing.Size(96, 15);
            this.labelError_username.TabIndex = 9;
            this.labelError_username.Text = "error_username";
            this.labelError_username.Click += new System.EventHandler(this.labelError_username_Click);
            // 
            // labelError_password
            // 
            this.labelError_password.AutoSize = true;
            this.labelError_password.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelError_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError_password.ForeColor = System.Drawing.Color.Red;
            this.labelError_password.Location = new System.Drawing.Point(372, 59);
            this.labelError_password.Name = "labelError_password";
            this.labelError_password.Size = new System.Drawing.Size(93, 15);
            this.labelError_password.TabIndex = 10;
            this.labelError_password.Text = "error_password";
            this.labelError_password.Click += new System.EventHandler(this.labelError_password_Click);
            // 
            // labelError_confirm
            // 
            this.labelError_confirm.AutoSize = true;
            this.labelError_confirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelError_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError_confirm.ForeColor = System.Drawing.Color.Red;
            this.labelError_confirm.Location = new System.Drawing.Point(43, 192);
            this.labelError_confirm.Name = "labelError_confirm";
            this.labelError_confirm.Size = new System.Drawing.Size(81, 15);
            this.labelError_confirm.TabIndex = 11;
            this.labelError_confirm.Text = "error_confirm";
            this.labelError_confirm.Click += new System.EventHandler(this.labelError_confirm_Click);
            // 
            // labelError_email
            // 
            this.labelError_email.AutoSize = true;
            this.labelError_email.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelError_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError_email.ForeColor = System.Drawing.Color.Red;
            this.labelError_email.Location = new System.Drawing.Point(372, 192);
            this.labelError_email.Name = "labelError_email";
            this.labelError_email.Size = new System.Drawing.Size(71, 15);
            this.labelError_email.TabIndex = 12;
            this.labelError_email.Text = "error_email";
            this.labelError_email.Click += new System.EventHandler(this.labelError_email_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-116, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1171, 418);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 395);
            this.Controls.Add(this.labelError_email);
            this.Controls.Add(this.labelError_confirm);
            this.Controls.Add(this.labelError_password);
            this.Controls.Add(this.labelError_username);
            this.Controls.Add(this.button_signup);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textBox_confirm);
            this.Controls.Add(this.label_confirm);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DangKy";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DangKy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.TextBox textBox_confirm;
        private System.Windows.Forms.Label label_confirm;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.Label labelError_username;
        private System.Windows.Forms.Label labelError_password;
        private System.Windows.Forms.Label labelError_confirm;
        private System.Windows.Forms.Label labelError_email;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


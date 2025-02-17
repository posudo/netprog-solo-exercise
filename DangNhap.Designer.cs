namespace Exercise2
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.labelError_username = new System.Windows.Forms.Label();
            this.labelError_password = new System.Windows.Forms.Label();
            this.button_createAcc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.Color.Orange;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(70, 39);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(119, 20);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Tên đăng nhập";
            this.label_username.Click += new System.EventHandler(this.label_username_Click);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.BackColor = System.Drawing.Color.Orange;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(70, 115);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(77, 20);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "Mật khẩu";
            this.label_password.Click += new System.EventHandler(this.label_password_Click);
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(204, 41);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(171, 20);
            this.textBox_username.TabIndex = 2;
            this.textBox_username.TextChanged += new System.EventHandler(this.textBox_username_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(204, 115);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(171, 20);
            this.textBox_password.TabIndex = 3;
            this.textBox_password.UseSystemPasswordChar = true;
            this.textBox_password.TextChanged += new System.EventHandler(this.textBox_password_TextChanged);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.SystemColors.Control;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.Black;
            this.button_login.Location = new System.Drawing.Point(68, 167);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(121, 35);
            this.button_login.TabIndex = 4;
            this.button_login.Text = "Đăng nhập";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // labelError_username
            // 
            this.labelError_username.AutoSize = true;
            this.labelError_username.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelError_username.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelError_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError_username.ForeColor = System.Drawing.Color.Red;
            this.labelError_username.Location = new System.Drawing.Point(204, 64);
            this.labelError_username.Name = "labelError_username";
            this.labelError_username.Size = new System.Drawing.Size(96, 15);
            this.labelError_username.TabIndex = 5;
            this.labelError_username.Text = "error_username";
            this.labelError_username.Click += new System.EventHandler(this.labelError_username_Click);
            // 
            // labelError_password
            // 
            this.labelError_password.AutoSize = true;
            this.labelError_password.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelError_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError_password.ForeColor = System.Drawing.Color.Red;
            this.labelError_password.Location = new System.Drawing.Point(204, 138);
            this.labelError_password.Name = "labelError_password";
            this.labelError_password.Size = new System.Drawing.Size(93, 15);
            this.labelError_password.TabIndex = 6;
            this.labelError_password.Text = "error_password";
            this.labelError_password.Click += new System.EventHandler(this.labelError_password_Click);
            // 
            // button_createAcc
            // 
            this.button_createAcc.BackColor = System.Drawing.SystemColors.Control;
            this.button_createAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_createAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_createAcc.Location = new System.Drawing.Point(258, 167);
            this.button_createAcc.Name = "button_createAcc";
            this.button_createAcc.Size = new System.Drawing.Size(117, 35);
            this.button_createAcc.TabIndex = 8;
            this.button_createAcc.Text = "Tạo tài khoản";
            this.button_createAcc.UseVisualStyleBackColor = false;
            this.button_createAcc.Click += new System.EventHandler(this.button_createAcc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-40, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(711, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 405);
            this.Controls.Add(this.button_createAcc);
            this.Controls.Add(this.labelError_password);
            this.Controls.Add(this.labelError_username);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DangNhap";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label labelError_username;
        private System.Windows.Forms.Label labelError_password;
        private System.Windows.Forms.Button button_createAcc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


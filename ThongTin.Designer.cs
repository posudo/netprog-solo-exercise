namespace Exercise2
{
    partial class ThongTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTin));
            this.label_username = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_usernameOut = new System.Windows.Forms.Label();
            this.label_emailOut = new System.Windows.Forms.Label();
            this.label_successful = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.BackColor = System.Drawing.SystemColors.Control;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(45, 57);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(102, 24);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Username:";
            this.label_username.Click += new System.EventHandler(this.label_username_Click);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(45, 86);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(62, 24);
            this.label_email.TabIndex = 1;
            this.label_email.Text = "Email:";
            this.label_email.Click += new System.EventHandler(this.label_email_Click);
            // 
            // label_usernameOut
            // 
            this.label_usernameOut.AutoSize = true;
            this.label_usernameOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usernameOut.Location = new System.Drawing.Point(195, 57);
            this.label_usernameOut.Name = "label_usernameOut";
            this.label_usernameOut.Size = new System.Drawing.Size(131, 24);
            this.label_usernameOut.TabIndex = 2;
            this.label_usernameOut.Text = "username_out";
            this.label_usernameOut.Click += new System.EventHandler(this.label_usernameOut_Click);
            // 
            // label_emailOut
            // 
            this.label_emailOut.AutoSize = true;
            this.label_emailOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_emailOut.Location = new System.Drawing.Point(195, 86);
            this.label_emailOut.Name = "label_emailOut";
            this.label_emailOut.Size = new System.Drawing.Size(91, 24);
            this.label_emailOut.TabIndex = 3;
            this.label_emailOut.Text = "email_out";
            this.label_emailOut.Click += new System.EventHandler(this.label_emailOut_Click);
            // 
            // label_successful
            // 
            this.label_successful.AutoSize = true;
            this.label_successful.BackColor = System.Drawing.Color.Orange;
            this.label_successful.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_successful.Location = new System.Drawing.Point(44, 9);
            this.label_successful.Name = "label_successful";
            this.label_successful.Size = new System.Drawing.Size(282, 25);
            this.label_successful.TabIndex = 4;
            this.label_successful.Text = "ĐĂNG NHẬP THÀNH CÔNG";
            this.label_successful.Click += new System.EventHandler(this.label_successful_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 373);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 337);
            this.Controls.Add(this.label_successful);
            this.Controls.Add(this.label_emailOut);
            this.Controls.Add(this.label_usernameOut);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ThongTin";
            this.Text = "ThongTin";
            this.Load += new System.EventHandler(this.ThongTin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_usernameOut;
        private System.Windows.Forms.Label label_emailOut;
        private System.Windows.Forms.Label label_successful;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
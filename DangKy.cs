using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace Exercise2
{

    public partial class DangKy : Form
    {
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }
        public DangKy()
        {
            InitializeComponent();
        }
       
        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {




        }

        private void label_username_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            bool kiem_tra = true;
            string username = textBox_username.Text.Trim();
            string password = textBox_password.Text.Trim();
            string hashedPassword = HashPassword(password);
            string confirm_pass = textBox_confirm.Text.Trim();
            string email = textBox_email.Text.Trim();


            if (username == "")
            {
                labelError_username.Text = "Nhập tên đăng nhập";
                kiem_tra=false;
            }
            else labelError_username.Text = "";
            
            if (password == "")
            {
                labelError_password.Text = "Nhập mật khẩu";
                kiem_tra=false;
            }
            else labelError_password.Text = "";
            
            if(password!=""&&confirm_pass!=password)
            {
                labelError_confirm.Text = "Mật khẩu không khớp";
                kiem_tra=false;
            }
            else labelError_confirm.Text="";
            if (email == "")
            {
                labelError_email.Text = "Nhập Email";
                kiem_tra = false;
            }
            else
            { labelError_email.Text = "";

                if (!Regex.IsMatch(email, @"^[\w.-]+@[\w.-]+\.[\w]{2,}(?:\.[\w]{2,})?$"))
                {
                    labelError_email.Text = "Email không hợp lệ";
                    kiem_tra = false;
                }
    
            }

            if (!kiem_tra) return;

            try
            {
                string connectionString = "Server=localhost;Database=MyDatabase;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    string query = "SELECT Username FROM Users WHERE Username = @Username";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        labelError_username.Text = "Tên đã tồn tại";
                        return;
                    }
                    else labelError_username.Text = "";
                    reader.Close();
                    
                    
                    query = "INSERT INTO Users (Username, Password, Email) VALUES (@Username, @Password, @Email)";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    command.Parameters.AddWithValue("@Email", email);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Đăng ký thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void textBox_confirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            labelError_username.Text = "";
            labelError_password.Text = "";
            labelError_confirm.Text = "";
            labelError_email.Text = "";
            
        }

        private void labelError_username_Click(object sender, EventArgs e)
        {

        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DangNhap form1 = new DangNhap();
            form1.Show();

        }

        private void label_confirm_Click(object sender, EventArgs e)
        {

        }

        private void label_password_Click(object sender, EventArgs e)
        {

        }

        private void labelError_password_Click(object sender, EventArgs e)
        {

        }

        private void labelError_confirm_Click(object sender, EventArgs e)
        {

        }

        private void label_email_Click(object sender, EventArgs e)
        {

        }

        private void labelError_email_Click(object sender, EventArgs e)
        {

        }
    }
}

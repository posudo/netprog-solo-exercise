using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Exercise2
{
    public partial class DangNhap : Form
    {
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }


        public DangNhap()
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

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text.Trim();
            string password = textBox_password.Text.Trim();
            string hashedInputPassword = HashPassword(password);

            if (username == "")
            {
                labelError_username.Text = "Nhập tên đăng nhập";
                return;
            }
            else labelError_username.Text = "";

            if (password == "")
            {
                labelError_password.Text = "Nhập mật khẩu";
                return;
            }
            else labelError_password.Text = "";


            try
            {
                string connectionString = "Server=localhost;Database=MyDatabase;Integrated Security=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    string query = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", hashedInputPassword);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                       
                        ThongTin form_ThongTin = new ThongTin();
                        form_ThongTin.username = reader["Username"].ToString();
                        form_ThongTin.email = reader["Email"].ToString();
                        form_ThongTin.ShowDialog();
                    }
                    else MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelError_username.Text = "";
            labelError_password.Text = ""; 
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_createAcc_Click(object sender, EventArgs e)
        {
            DangKy form_DangKy = new DangKy();
            form_DangKy.ShowDialog();
        }

        private void labelError_username_Click(object sender, EventArgs e)
        {

        }

        private void label_password_Click(object sender, EventArgs e)
        {

        }

        private void labelError_password_Click(object sender, EventArgs e)
        {

        }

        private void label_noAcc_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

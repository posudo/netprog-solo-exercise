using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise2
{
    public partial class ThongTin : Form
    {
        public string username { get; set; }
        public string email { get; set; }
        public ThongTin()
        {
            InitializeComponent();
        }

        private void ThongTin_Load(object sender, EventArgs e)
        {
            label_usernameOut.Text = username;
            label_emailOut.Text = email;
           
        }
        private void label_usernameOut_Click(object sender, EventArgs e)
        {

        }

       

        private void label_successful_Click(object sender, EventArgs e)
        {

        }

        private void label_emailOut_Click(object sender, EventArgs e)
        {

        }

        private void label_username_Click(object sender, EventArgs e)
        {

        }

        private void label_email_Click(object sender, EventArgs e)
        {

        }
    }
}

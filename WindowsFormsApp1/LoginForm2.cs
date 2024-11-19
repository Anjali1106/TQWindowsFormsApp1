using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm2 : Form
    {
        public LoginForm2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtUsername.Text == "admin123")
            {
                MessageBox.Show("Success");
            }
            else {
                MessageBox.Show("Login Fail");
            }
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            textPassword.Clear();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

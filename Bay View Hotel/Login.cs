using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bay_View_Hotel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //log in button
        //if username is Admin and password is Password123 show admin form and close the log in form

        private void button1_Click(object sender, EventArgs e)
        {
           if (textBox1.Text == "Admin" && textBox2.Text == "Password123")
            {
                this.Hide();
                var newForm = new Admin_View();
                newForm.Show();       
            }

            if (textBox1.Text == "Joe Bloggs" && textBox2.Text == "Password123")
            {
                this.Hide();
                var newForm = new Staff_View();
                newForm.Show();
            }
           else
            {
                MessageBox.Show("Invalid Log In");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

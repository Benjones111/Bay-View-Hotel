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
        //if username is Joe and password is Password123 hide the login form and show the staff view form

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Joe" && textBox2.Text == "Password123")
            {
                this.Hide();
                var newForm = new Staff_View();
                newForm.Show();
            }
            else
            {

         //otherwise if the username is Admin and the password is Password123 hide login form and show admin view form

                if (textBox1.Text == "Admin" && textBox2.Text == "Password123")
                {
                    this.Hide();
                    var newForm = new Admin_View();
                    newForm.Show();
                }
                //if what ever is typed out in the username and password box doesn't match one of the usernames and password stated above, show a message saying "Invalid Login"
                else
                {
                    MessageBox.Show("Invalid Log In");
                }
            }

        }
        // test changes
        //make sure that the password box is showing as the * character instead of text so the password is not visible when typed out

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        //when the exit button is clicked, exit out of the current form and all hidden forms

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

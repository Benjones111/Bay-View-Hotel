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
    public partial class Admin_View : Form
    {
        public Admin_View(string instring)
        {
            InitializeComponent();
            conString = instring;
        }
        string conString;

        //when the staff button is clicked, hide the admin view form and show staff form
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Staff(conString);
            newForm.Show();
        }
        //when the sign out button is clicked, hide the admin view form and show login form
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Login();
            newForm.Show();
        }

        private void Admin_View_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //when the report button is clicked, hide admin view form and show reports form
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Reports(conString);
            newForm.Show();
        }
    }
    }


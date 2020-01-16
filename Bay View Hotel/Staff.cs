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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        //when back button is clicked, hide staff form and show admin view form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Admin_View();
            newForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

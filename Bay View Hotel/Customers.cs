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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }
        //when back button is clicked, hide customers form and show staff view form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Staff_View();
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

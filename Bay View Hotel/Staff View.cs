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
    public partial class Staff_View : Form
    {
        public Staff_View(string instring)
        {
            InitializeComponent();
            conString = instring;
        }
        string conString;
        //when the sign out button is clicked, hide staff view form and show login form
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Login();
            newForm.Show();
        }
        //when the manage bookings button is clicked, hide staff view form and show bookings form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Bookings(conString);
            newForm.Show();
        }
        //when the guest button is clicked, hide staff view form and show customers form
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Customers(conString);
            newForm.Show();
        }
        //when the guest button is clicked, hide staff view form and show the guest form
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Rooms(conString);
            newForm.Show();
        }
    }
}

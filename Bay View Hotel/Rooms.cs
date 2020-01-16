﻿using System;
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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }
        //when the back button is clicked, hide rooms form and show staff view form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Staff_View();
            newForm.Show();
        }
    }
}

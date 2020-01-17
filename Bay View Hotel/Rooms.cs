using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;// import sqlite

namespace Bay_View_Hotel
{
    public partial class Rooms : Form
    {
        public Rooms(string instring)
        {
            InitializeComponent();
            conString = instring;
            // get data from db on load
            getRoomBookings();
        }
        string conString;
        //when the back button is clicked, hide rooms form and show staff view form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            // pass the constring to the next form 
            var newForm = new Staff_View(conString);
            newForm.Show();
        }

        private void getRoomBookings()
        {
            try
            {
                // make another connection to the database
                using (SQLiteConnection con = new SQLiteConnection(conString))
                {
                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        con.Open();
                        // select all data from table room
                        cmd.CommandText = @"select * from room";
                        cmd.ExecuteNonQuery();
                        // set the new datatable to fill the datagrid view
                        DataTable dt = new DataTable();
                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception er)
            {
                // error msg if the query fails
                MessageBox.Show("Error: " + er.Message);
            }
        }
    }
}

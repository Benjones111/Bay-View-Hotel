using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Bay_View_Hotel
{
    public partial class Rooms : Form
    {
        public Rooms(string instring)
        {
            InitializeComponent();
            conString = instring;
            getRoomBookings();
        }
        string conString;
        //when the back button is clicked, hide rooms form and show staff view form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Staff_View(conString);
            newForm.Show();
        }

        private void getRoomBookings()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(conString))
                {
                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        con.Open();

                        cmd.CommandText = @"select * from room";
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
        }
    }
}

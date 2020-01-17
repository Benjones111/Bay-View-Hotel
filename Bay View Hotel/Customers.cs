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
using System.Globalization;

namespace Bay_View_Hotel
{
    public partial class Customers : Form
    {
        public Customers(string instring)
        {
            InitializeComponent();
            // set constring
            conString = instring;
        }
        string conString;
        //when back button is clicked, hide customers form and show staff view form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            // pass the con string to next form
            var newForm = new Staff_View(conString);
            newForm.Show();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            // get customers from the db on load
            getCustomers();
        }

        private void getCustomers()
        {
            try
            {
                // open another connection with the constring
                using (SQLiteConnection con = new SQLiteConnection(conString))
                {
                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        con.Open();
                        // select all data from table guest
                        cmd.CommandText = @"select * from guest";
                        cmd.ExecuteNonQuery();
                        // create data table to fill the grid view with guest results
                        DataTable dt = new DataTable();
                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception er)
            {
                // error msg if query fails
                MessageBox.Show("Error: " + er.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // connect to db using con string
                using (SQLiteConnection con = new SQLiteConnection(conString))
                {

                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        con.Open();
                        // select relative fields from the guest table that are needed to create a new record
                        cmd.CommandText = @"Insert into guest(First_name_Guest, Last_name_Guest, DOB_Guest, Address_Guest, Email_Guest, Registration_Date_Guest) Values (@firstname, @lastname, @dob, @address, @email, @regDate)";
                        // set the values from each of the inout types
                        cmd.Parameters.AddWithValue("firstname", tbFirstName.Text);
                        cmd.Parameters.AddWithValue("lastname", tbLastName.Text);
                        cmd.Parameters.AddWithValue("dob", DOBpicker.Value);
                        cmd.Parameters.AddWithValue("address", tbAddress.Text);
                        cmd.Parameters.AddWithValue("email", tbEmail.Text);
                        cmd.Parameters.AddWithValue("regDate", DateTime.Now);
                        // if the record gets inserted show a success msg
                        int recordsChanged = cmd.ExecuteNonQuery();
                        tssLabel.Text = "Last action: insert new record ~ successful";
                        tssLabel.ForeColor = Color.Green;
                        getCustomers();
                    }
                }
            }
            catch (Exception)
            {
                // if the record gets inserted show a fail msg
                tssLabel.Text = "Last action: insert new record ~ failed!";
                tssLabel.ForeColor = Color.Red;
            }
        }
    }
}

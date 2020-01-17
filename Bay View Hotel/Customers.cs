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
using System.Globalization;

namespace Bay_View_Hotel
{
    public partial class Customers : Form
    {
        public Customers(string instring)
        {
            InitializeComponent();
            conString = instring;
        }
        string conString;
        //when back button is clicked, hide customers form and show staff view form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Staff_View(conString);
            newForm.Show();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            getCustomers();
        }

        private void getCustomers()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(conString))
                {
                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        con.Open();

                        cmd.CommandText = @"select * from guest";
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
                using (SQLiteConnection con = new SQLiteConnection(conString))
                {

                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        con.Open();

                        cmd.CommandText = @"Insert into guest(First_name_Guest, Last_name_Guest, DOB_Guest, Address_Guest, Email_Guest, Registration_Date_Guest) Values (@firstname, @lastname, @dob, @address, @email, @regDate)";

                        cmd.Parameters.AddWithValue("firstname", tbFirstName.Text);
                        cmd.Parameters.AddWithValue("lastname", tbLastName.Text);
                        cmd.Parameters.AddWithValue("dob", DOBpicker.Value);
                        cmd.Parameters.AddWithValue("address", tbAddress.Text);
                        cmd.Parameters.AddWithValue("email", tbEmail.Text);
                        cmd.Parameters.AddWithValue("regDate", DateTime.Now);

                        int recordsChanged = cmd.ExecuteNonQuery();
                        tssLabel.Text = "Last action: insert new record ~ successful";
                        tssLabel.ForeColor = Color.Green;
                        getCustomers();
                    }
                }
            }
            catch (Exception)
            {
                tssLabel.Text = "Last action: insert new record ~ failed!";
                tssLabel.ForeColor = Color.Red;
            }
        }
    }
}

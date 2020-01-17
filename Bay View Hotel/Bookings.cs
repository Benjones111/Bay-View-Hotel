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
    public partial class Bookings : Form
    {
        public Bookings(string instring)
        {
            InitializeComponent();
            // set constring
            conString = instring;
        }
        string conString;

        // create connection strings and new dateTable for table rooms
        SQLiteConnection dbCon;
        SQLiteDataAdapter daRoom;
        DataTable room = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            // pass the connection string into form so it can connect to the db
            var newForm = new Staff_View(conString);
            newForm.Show();
        }

        private void Bookings_Load(object sender, EventArgs e)
        {
            // on form load get all the data from both tables in the db
            getRooms();
            getRoomBookings();
        }

        private void getRoomBookings()
        {
            try
            {
                // use the connection string to open the connection to the db
                using (SQLiteConnection con = new SQLiteConnection(conString))
                {
                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        con.Open();
                        // select all from room booking and create new datatable to then fill the datagrid with the result
                        cmd.CommandText = @"select * from roombooking";
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
                // show error msg if the query fails
                MessageBox.Show("Error: " + er.Message);
            }
        }

        private void getRooms()
        {
            try
            {
                // clear any selections made in the combo box
                room.Clear();
                // use the connection string to open the connection to the db
                using (dbCon = new SQLiteConnection(conString))
                {
                    // select Room_ID from the table room so that the result can be used to fill the combo box and a selection of what room is being used can be made.
                    string sqlcommand = @"Select Room_ID from room";
                    daRoom = new SQLiteDataAdapter(sqlcommand, dbCon);
                    daRoom.Fill(room);
                    cbRoom.DataSource = room;
                    cbRoom.ValueMember = "Room_ID";
                    cbRoom.DisplayMember = "Room_ID";
                    cbRoom.SelectedIndex = 0;
             
                }
            }
            catch (Exception ex)
            {
                // show error msg if query fails
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // when the submit btn is clicked make another connection to the db
                using (SQLiteConnection con = new SQLiteConnection(conString))
                {

                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        con.Open();
                        // select relative fields from the roombooking table that are needed to create a new record
                        cmd.CommandText = @"Insert into roombooking(Room_ID, Start_date, End_Date) Values (@room, @start, @end)";
                        // set the values from each of the inout types
                        cmd.Parameters.AddWithValue("room", cbRoom.SelectedValue);
                        cmd.Parameters.AddWithValue("start", startDatePicker.Value);
                        cmd.Parameters.AddWithValue("end", endDatePicker.Value);

                        int recordsChanged = cmd.ExecuteNonQuery();
                        // if the record gets inserted show a success msg
                        tssLabel.Text = "Last action: insert new record ~ successful";
                        tssLabel.ForeColor = Color.Green;
                        getRoomBookings();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCust1_SelectedIndexChanged(object sender, EventArgs e)
        {

                
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void endDatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }


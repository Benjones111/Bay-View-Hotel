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
    public partial class Bookings : Form
    {
        public Bookings(string instring)
        {
            InitializeComponent();
            conString = instring;
        }
        string conString;

        SQLiteConnection dbCon;
        SQLiteDataAdapter daRoom;
        DataTable room = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Staff_View(conString);
            newForm.Show();
        }

        private void Bookings_Load(object sender, EventArgs e)
        {
            getRooms();
            getRoomBookings();
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
                MessageBox.Show("Error: " + er.Message);
            }
        }

        private void getRooms()
        {
            try
            {
                room.Clear();
                using (dbCon = new SQLiteConnection(conString))
                {
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
                MessageBox.Show("Error: " + ex.Message);
            }
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

                        cmd.CommandText = @"Insert into roombooking(Room_ID, Start_date, End_Date) Values (@room, @start, @end)";

                        cmd.Parameters.AddWithValue("room", cbRoom.SelectedValue);
                        cmd.Parameters.AddWithValue("start", startDatePicker.Value);
                        cmd.Parameters.AddWithValue("end", endDatePicker.Value);

                        int recordsChanged = cmd.ExecuteNonQuery();
                        tssLabel.Text = "Last action: insert new record ~ successful";
                        tssLabel.ForeColor = Color.Green;
                        getRoomBookings();
                    }
                }
            }
            catch (Exception)
            {
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


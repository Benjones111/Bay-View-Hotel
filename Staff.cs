using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace Bay_View_Hotel
{
    public partial class Staff : Form
    {
        readonly OleDbConnection Connstring = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C: \\Users\\m_hol\\Source\\Repos\\Bay - View - Hotel\\Bay View Hotel\\bay_view_hotel.mdb");
        OleDbCommand cmd;
        OleDbDataAdapter da;
        public Staff()
        {
            InitializeComponent();
            DisplayData();
        }
        private void DisplayData()
        {
            string Cmdtext = "SELECT * FROM staff";
            da = new OleDbDataAdapter(Cmdtext, Connstring);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Staff]");
            staffGrid.DataSource = ds.Tables[0].DefaultView;
        }
        //when back button is clicked, hide staff form and show admin view form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new Admin_View();
            newForm.Show();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bay_view_hotelDataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.bay_view_hotelDataSet.staff);

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (firstnametxt.Text != "" && lastnametxt.Text != "" && usernametxt.Text != "" & passwordtxt.Text != "" && usertypelbox.SelectedIndex != -1)
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                Byte[] hashedBytes;
                UTF8Encoding encoder = new UTF8Encoding();
                hashedBytes = md5.ComputeHash(encoder.GetBytes(passwordtxt.Text));

                using (Connstring)
                {
                    using (OleDbCommand comm = new OleDbCommand("UPDATE staff SET Firstname_Staff = @firstname, Lastname_Staff = @lastname, Username = @username, Start_Date_Staff = @startdate, End_Date_Staff = @enddate, Staff_Password = @password, User_type_Staff = @usertype WHERE Staff_ID = @staffID", Connstring))
                    try{
                        Connstring.Open();
                        cmd.Parameters.AddWithValue("@staffID", int.Parse(staffidtxt.Text));
                        cmd.Parameters.AddWithValue("@firstname", firstnametxt.Text);
                        cmd.Parameters.AddWithValue("@lastname", lastnametxt.Text);
                        cmd.Parameters.AddWithValue("@username", usernametxt.Text);
                        cmd.Parameters.Add("@startdate", OleDbType.Date).Value = startdatePicker.Value.Date;
                        cmd.Parameters.Add("@enddate", OleDbType.Date).Value = enddatePicker.Value.Date;
                        cmd.Parameters.AddWithValue("@password", encoder.GetString(hashedBytes));
                        string usrtype = "";
                        usrtype = (usertypelbox.SelectedItem).ToString();
                        cmd.Parameters.AddWithValue("@usertype", usrtype);
                        cmd.ExecuteNonQuery();
                        Connstring.Close();
                        MessageBox.Show("User Updated Successfully");
                        DisplayData();

                    }
                    catch(Exception ex)
                    {
                            MessageBox.Show(ex.Message, "An Error occured", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}

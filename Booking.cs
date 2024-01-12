using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace coffeeHeven
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        private void Booking_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-BL4D6G3;Initial Catalog=coffeeheven;Integrated Security=True");
        }

        private void btn_booking_Click(object sender, EventArgs e)
        {
            try
            {

                if (!Regex.IsMatch(txt_contact_number.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))

                {
                   
                    MetroFramework.MetroMessageBox.Show(this, "ENTER VALID PHONE NUMBER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_contact_number.Clear();
                }
            else 
                { 
                 con.Open();
                 cmd = new SqlCommand("insert into ReservationHallRealTable values ('" +txt_contact_number.Text+ "','" + DateTimePicker.Value + "') ", con);
                 int i = cmd.ExecuteNonQuery();
                 if (i == 1)
                 {
                     MetroFramework.MetroMessageBox.Show(this, "WE WILL CONTACT YOU SOON", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                  else
                 {
                     MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT BOOK! If you want to clarify please use help feature!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                  con.Close();
                  cmd.Dispose();
                 }
            }

            catch (SqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SOORY! COULD NOT BOOK! THIS DATE IS AREADY BOOKED!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }








        }

        private void link_need_help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help h3 = new Help();
            h3.Show();
        }
    }
}

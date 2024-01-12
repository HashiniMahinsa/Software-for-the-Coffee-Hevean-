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
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace coffeeHeven
{
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        private void ViewBook_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-BL4D6G3;Initial Catalog=coffeeheven;Integrated Security=True");
        }

        private void grid_view_hall_booking_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * From ReservationHallRealTable", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid_view_book.DataSource = dt;
                con.Close();
                
            }
            catch (SqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void btn_confirm_booking_Click(object sender, EventArgs e)
        {
            try
            {
                if(!Regex.IsMatch(txt_confirm_book.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                {
                    MetroFramework.MetroMessageBox.Show(this, "ENTER VALID PHONE NUMBER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_confirm_book.Clear();
                }
                else { 
                //WebClient client = new WebClient();
                //string to, message;
                //to = txt_confirm_book.Text;
                //message = "your reservation is confirmed. make your payment soon. contact us 0771477627";
                //string baseURL = "http://api.clickatell.com/http/sendmsg?user=lEhy16ZLRwy6rFSs2cKKEA==&password=Amm@Amm@1122&api_id=303e7e09b79a4bfe8e81705b6cb4078c'" + to + "'&text='" + message + "'";
                //client.OpenRead(baseURL);
                MetroFramework.MetroMessageBox.Show(this,"Successfully sent message", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
    }
}

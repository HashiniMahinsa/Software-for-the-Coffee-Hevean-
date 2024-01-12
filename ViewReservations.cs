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

namespace coffeeHeven
{
    public partial class ViewReservations : Form
    {
        public ViewReservations()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        private void ViewReservations_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-BL4D6G3;Initial Catalog=coffeeheven;Integrated Security=True");
        }

        private void real_btn_view_hall_reservation_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * From ReservationHallRealTable order by the_date", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                real_grid_hall_reservation.DataSource = dt;
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

        private void real_btn_view_outdoor_reservation_Click(object sender, EventArgs e)
        {
            try
            { 
                con.Open();
                da = new SqlDataAdapter("Select * From ReservationOutdoorRealTable order by the_date", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                real_grid_out_reservation.DataSource = dt;
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

            //private void grid_hall_reservation_CellContentClick(object sender, DataGridViewCellEventArgs e)
       

        
    }
}

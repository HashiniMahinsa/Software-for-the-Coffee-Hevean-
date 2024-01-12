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
    public partial class StaffMemberDetails : Form
    {
        public StaffMemberDetails()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;

        private void StaffMemberDetails_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-BL4D6G3;Initial Catalog=coffeeheven;Integrated Security=True");
        }

        private void btn_view_staff_details_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * From Employee", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid_view_staff_member.DataSource = dt;
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
    }
}

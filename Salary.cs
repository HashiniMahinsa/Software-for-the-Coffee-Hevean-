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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataAdapter da1;
        SqlDataAdapter da2;


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void Salary_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-BL4D6G3;Initial Catalog=coffeeheven;Integrated Security=True");
        }

        private void btn_pay_salary_Click(object sender, EventArgs e)
        {
            try
            {
                
                con.Open();
                cmd = new SqlCommand("Insert into Salary values('" + num_up_down_staff_id_for_salary.Value + "', '" + num_up_down_year.Value + "','" + num_up_down_month.Value + "', '" + num_up_down_salary.Value + "','" + DateTime.Now + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "SAVE SUCSSESSFULY!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT SAVE , TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                cmd.Dispose();
            }

            catch (SqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT SAVE, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT SAVE, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_view_salary_report_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * From Salary", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid_view.DataSource = dt;
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

        private void btn_view_staff_deatails_salary_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da1 = new SqlDataAdapter("Select * From Employee where staff_id = '"+ num_up_down_staff_id_for_grid + "'", con);
                DataTable dt = new DataTable();
                da1.Fill(dt);
                grid_view.DataSource = dt;
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

        private void btn_view_attendance_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da2 = new SqlDataAdapter("Select * From Attendance where staff_id = '" + num_up_down_staff_id_for_grid + "'", con);
                DataTable dt = new DataTable();
                da2.Fill(dt);
                grid_view.DataSource = dt;
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

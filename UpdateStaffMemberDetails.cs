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

namespace coffeeHeven
{
    public partial class UpdateStaffMemberDetails : Form
    {
        public UpdateStaffMemberDetails()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;

        private void UpdateStaffMemberDetails_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-BL4D6G3;Initial Catalog=coffeeheven;Integrated Security=True");
        }

        private void btn_view_employee_details_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * From Employee", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid_view_staff_for_update.DataSource = dt;
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

        private void btn_update_employee_details_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_update_employee_detail_Click(object sender, EventArgs e)
        {
            try
            {
                if (num_up_down_staff_id_for_update.Value == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "IT SEEMS YOU FOGGOT TO ENTER STAFF ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (txt_staff_name_for_update.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "IT SEEMS YOU FOGGOT TO ENTER EMPLOYEE NAME ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (txt_staff_name_for_update.Text.Any(char.IsDigit))
                {
                    
                    MetroFramework.MetroMessageBox.Show(this, "ENTER VALID NAME ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_staff_name_for_update.Clear();

                }

                if (!Regex.IsMatch(txt_staff_phone_for_update.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                {
                    MetroFramework.MetroMessageBox.Show(this, "ENTER VALID PHONE NUMBER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_staff_phone_for_update.Clear();

                }

                if (!Regex.IsMatch(txt_staff_emergency_phone_for_update.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                {
                    MetroFramework.MetroMessageBox.Show(this, "ENTER VALID PHONE NUMBER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_staff_emergency_phone_for_update.Clear();

                }

                if (combobox_position_for_update.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "IT SEEMS YOU FOGGOT TO ENTER POSITION ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (num_up_down_basic_salary_for_update.Value == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "IT SEEMS YOU FOGGOT TO ENTER BASIC SALARY ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    con.Open();
                    cmd = new SqlCommand("Insert into Employee values('" + num_up_down_staff_id_for_update.Value + "','" + txt_staff_name_for_update.Text + "', '" + txt_staff_phone_for_update.Text + "','" + txt_staff_emergency_phone_for_update.Text + "','" + combobox_position_for_update.Text + "', '" + num_up_down_basic_salary_for_update.Value + "')", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "EMPLOYEE DETAILS UPDATED SUCSSESSFULY!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT UPDATE EMPLOYEE DETAILS, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                    cmd.Dispose();
                }
            }

            catch (SqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT UPDATE EMPLOYEE DETAILS, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT UPDATE EMPLOYEE DETAILS, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

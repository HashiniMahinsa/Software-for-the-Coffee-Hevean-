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
    public partial class AddStaffMember : Form
    {
        public AddStaffMember()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;

        private void AddStaffMember_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-BL4D6G3;Initial Catalog=coffeeheven;Integrated Security=True");
        }

        private void btn_view_employee_details_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select Count(*) From Employee", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid_number_of_current_employees.DataSource = dt;
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

        private void btn_add_employee_Click(object sender, EventArgs e)
        {
            try
            {
                if (num_up_down_staff_id.Value == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "IT SEEMS YOU FOGGOT TO ENTER STAFF ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (txt_staff_name.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "IT SEEMS YOU FOGGOT TO ENTER EMPLOYEE NAME ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (txt_staff_name.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "ENTER VALID NAME ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_staff_name.Clear();

                }

                if (!Regex.IsMatch(txt_staff_phone.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                {
                    MetroFramework.MetroMessageBox.Show(this, "ENTER VALID PHONE NUMBER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_staff_phone.Clear();

                }

                if (!Regex.IsMatch(txt_staff_emergency_phone.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                {
                    MetroFramework.MetroMessageBox.Show(this, "ENTER VALID PHONE NUMBER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_staff_emergency_phone.Clear();

                }
                
                if (combobox_position.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "IT SEEMS YOU FOGGOT TO ENTER POSITION ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (num_up_down_basic_salary.Value == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "IT SEEMS YOU FOGGOT TO ENTER BASIC SALARY ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                con.Open();
                cmd = new SqlCommand("Insert into Employee values('" + num_up_down_staff_id.Value + "','" + txt_staff_name.Text + "', '" + txt_staff_phone.Text + "','" + txt_staff_emergency_phone.Text + "','" + combobox_position.Text + "', '" + num_up_down_basic_salary.Value + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "EMPLOYEE ADDED SUCSSESSFULY!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT ADD EMPLOYEE DETAILS, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                cmd.Dispose();
                }
            }

            catch (SqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT ADD EMPLOYEE DETAILS, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT ADD EMPLOYEE DETAILS, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;

        private void Attendance_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-BL4D6G3;Initial Catalog=coffeeheven;Integrated Security=True");
        }

        private void btn_enter_attendance_Click(object sender, EventArgs e)
        {  if(num_up_down_attendance.Value==0)
            {
                MetroFramework.MetroMessageBox.Show(this, "IT SEEMS LIKE YOU FOGGOT TO ENTER YOUR ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                if (redio_btn_start_shift.Checked)
                {
                    con.Open();
                    cmd = new SqlCommand("Insert into Attendance  values ('" + num_up_down_attendance.Value + "','" + DateTime.Now + "','" + DateTime.Now + "') ", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "YOUR SHIFT START NOW!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT ENTER, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                    cmd.Dispose();
                }
                else if (redio_btn_end_shift.Checked)
                {
                    con.Open();
                    cmd = new SqlCommand("Update Attendance set shift_end_time = '" + DateTime.Now + "' where staff_id ='"+num_up_down_attendance.Value+"'", con);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "YOUR SHIFT END NOW!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT ENTER, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                    cmd.Dispose();
                }

                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "IT SEEMS LIKE YOU FOGGOT TO ENTER YOU ARE GOING TO START THE SHIFT OR END THE SHIFT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (SqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT ENTER, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT ENTER, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
        }
    }
}

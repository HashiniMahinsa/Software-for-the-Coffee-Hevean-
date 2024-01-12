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
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;

        private void Cashier_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-BL4D6G3;Initial Catalog=coffeeheven;Integrated Security=True");
        }

        private void btn_view_bill_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * From Bill", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid_view_bill.DataSource = dt;
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

        private void btn_pay_bill_Click(object sender, EventArgs e)
        {
            try
            {
               
                con.Open();
                cmd = new SqlCommand("insert into Bill values ('"+ DateTime.Now + "','" + num_up_down_location_for_bill.Value + "','" + num_up_down_amount.Value + "','" + num_up_down_location_for_bill.Value + "','" + num_up_down_bill_id.Value + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "TRANSACTION SAVED SUCSSESSFULY!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT PAY, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                cmd.Dispose();
            }

            catch (SqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT PAY, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT PAY, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

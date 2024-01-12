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
    public partial class ChangePrice : Form
    {
        public ChangePrice()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        private void ChangePrice_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-BL4D6G3;Initial Catalog=coffeeheven;Integrated Security=True");
        }

        private void btn_view_current_price_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * From coffee", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid_view_current_price.DataSource = dt;
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

        private void btn_change_number_Click(object sender, EventArgs e)
        {
            if (num_up_down_coffee_price.Value == 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "IT SEEMS YOU FOGGOT TO CHANGE PRICE! OR YOU CHANGE PRICE TO 0! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                con.Open();
                cmd = new SqlCommand("Update coffee set coffeePrice = '" + num_up_down_coffee_price.Value + "' where coffeeName ='" + combobox_select_coffee.Text + "'", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "PRICE UPDATED SUCSSESSFULY!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT CHANGE PRICE, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                cmd.Dispose();
            }

            catch (SqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT CHANGE PRICE, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT CHANGE PRICE, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

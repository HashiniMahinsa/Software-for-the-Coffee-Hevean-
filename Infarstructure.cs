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
    public partial class Infarstructure : Form
    {
        public Infarstructure()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;

        private void Infarstructure_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-BL4D6G3;Initial Catalog=coffeeheven;Integrated Security=True");
        }

        private void btn_view_stock_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * From Ingredients", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid_view_stock.DataSource = dt;
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

        private void btn_enter_infarstructure_Click(object sender, EventArgs e)
        {
            try
            {
                if (combobox_item_name.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "IT SEEMS YOU FOGGOT TO ENTER ITEM NAME ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (num_up_down_item_quantity.Value == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "IT SEEMS YOU FOGGOT TO ENTER ITEM QUANTITY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (num_up_down_item_price.Value == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "IT SEEMS YOU FOGGOT TO ENTER PRICE ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (num_up_down_supplier_id.Value == 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "IT SEEMS YOU FOGGOT TO ENTER SUPLIER ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                { 
                con.Open();
                cmd = new SqlCommand("Insert into Ingredients values('" + DateTime.Now + "','" + combobox_item_name.Text + "','" + num_up_down_item_quantity.Value + "', '" + num_up_down_item_price.Value + "', '" + num_up_down_supplier_id.Value + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "STOCK UPDATED SUCSSESSFULY!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT UPDATE STOCK, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                cmd.Dispose();
                }
            }

            catch (SqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT UPDATE STOCK, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT UPDATE STOCK, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

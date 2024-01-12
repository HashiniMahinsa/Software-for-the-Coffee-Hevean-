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
    public partial class SupliersServises : Form
    {
        public SupliersServises()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;


        private void SupliersServises_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-BL4D6G3;Initial Catalog=coffeeheven;Integrated Security=True");
        }

        private void btn_view_suplier_add_update_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                da = new SqlDataAdapter("Select * From Suplier", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid_view_supplier.DataSource = dt;
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

        private void btn_add_suplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_supplier_name.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "IT SEEMS YOU FOGGOT TO ENTER SUPLIER NAME", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (txt_supplier_name.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "ENTER VALID NAME", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_supplier_name.Clear();
                }

                if (!Regex.IsMatch(txt_supplier_phone.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                {
                    MetroFramework.MetroMessageBox.Show(this, "ENTER VALID PHONE NUMBER", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_supplier_phone.Clear();

                }

                else
                { 
                con.Open();
                cmd = new SqlCommand("Insert into Suplier values('" + num_up_down_suplier_id.Value + "','" + txt_supplier_name.Text + "', '" + txt_supplier_phone.Text + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "SUPLIER SAVED SUCSSESSFULY!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT SAVE SUPLIER, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                cmd.Dispose();
                }
            }

            catch (SqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT SAVE SUPLIER, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT SAVE SUPLIER, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_suplier_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_supplier_name.Text == "")
                {
                    MetroFramework.MetroMessageBox.Show(this, "IT SEEMS YOU FOGGOT TO ENTER SUPLIER NAME", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (txt_supplier_name.Text.Any(char.IsDigit))
                {
                    MetroFramework.MetroMessageBox.Show(this, "ENTER VALID NAME", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_supplier_name.Clear();

                }

                if (!Regex.IsMatch(txt_supplier_phone.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                {
                    MetroFramework.MetroMessageBox.Show(this, "ENTER VALID PHONE NUMBER", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_supplier_phone.Clear();

                }

                else
                { 
                con.Open();
                cmd = new SqlCommand("Update Suplier set(suplier_name='" + txt_supplier_name.Text + "', suplier_phone='" + txt_supplier_phone.Text + "' Where suplier_id='" + num_up_down_suplier_id.Value + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "SUPLIER SAVED SUCSSESSFULY!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT SAVE SUPLIER, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                cmd.Dispose();
                }
            }

            catch (SqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT SAVE SUPLIER, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT SAVE SUPLIER, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

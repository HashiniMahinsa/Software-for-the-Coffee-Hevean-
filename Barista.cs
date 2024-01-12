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
    public partial class Barista : Form
    {
        public Barista()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        private void Barista_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-BL4D6G3;Initial Catalog=coffeeheven;Integrated Security=True");
        }

        private void btn_view_orders_Click(object sender, EventArgs e)
        {   try
            { 
            con.Open();
            da = new SqlDataAdapter("Select * From PlaceOrder",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grid_make_cofffee.DataSource = dt;
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            ChooseStaff h10 = new ChooseStaff();
            h10.Show();
        }
    }

    

        
    }


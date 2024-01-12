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
    public partial class RateUs : Form
    {
        public RateUs()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;

        private void btn_ignore_Click(object sender, EventArgs e)
        {
            Start x = new Start();
            x.Show();
        }

        private void btn_back_to_home_Click(object sender, EventArgs e)
        {
            HOME b1 = new HOME();
            b1.Show();
        }

        private void RateUs_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-BL4D6G3;Initial Catalog=coffeeheven;Integrated Security=True");
        }

        private void btn_rate_Click(object sender, EventArgs e)
        {
            try
            {  
                if(txt_rate.Text=="")
                    {
                    MetroFramework.MetroMessageBox.Show(this, "DID'NT CATCH! IT'S OK IF YOU DID'NT FEEL ENY. PRESS 'BACK TO HOME' THEN PRESS 'WAITING FOR YOUR COFFEE'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                else
                { 
                con.Open();
                cmd = new SqlCommand("insert into Comments values ('" + txt_rate.Text + "','" + DateTime.Now + "') ", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "THANK YOU FOR YOUR COMMENT! PRESS 'BACK TO HOME' THEN PRESS 'WAITING FOR YOUR COFFEE' ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT SAVE COMMENT, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
            }
            catch (SqlException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT SAVE COMMENT, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT SAVE COMMENT, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}

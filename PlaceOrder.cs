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
using System.Net;
using System.Net.Mail;

namespace coffeeHeven
{
    public partial class PlaceOrder : Form
    {
        public PlaceOrder()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;

       

        private void PlaceOrder_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-BL4D6G3;Initial Catalog=coffeeheven;Integrated Security=True");
        }

        private void btn_place_order_Click(object sender, EventArgs e)
        {
            try
            {
                if(num_up_down_table_number.Value==0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "IT SEEMS YOU FOGGET TO ENTER YOUR LOCATION! TRY AGAIN! IF YOU HAVE A QUESTION PLEASE CONTACT US ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if(num_up_down_espresso.Value==0 && num_up_down_latte.Value==0 && num_up_down_mocha.Value==0 && num_up_down_longblack.Value==0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "IT SEEMS YOU FOGGOT TO ORDER ENY! OR IF YOU HAVE A QUESTION! IF YOU HAVE A QUESTION PLEASE CONTACT US! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                { 
                con.Open();
                cmd = new SqlCommand("insert into PlaceOrder values ('" + num_up_down_table_number.Value + "','" + num_up_down_espresso.Value + "','" + num_up_down_latte.Value + "','" + num_up_down_mocha.Value + "','" + num_up_down_longblack.Value + "','" + DateTime.Now + "') ", con);
                int i = cmd.ExecuteNonQuery();
                if(i==1 )
                {
                    MetroFramework.MetroMessageBox.Show(this, "YOUR COFFEE WILL BE READY IN 10 MINUTES! OUR ROBO WAITER ALEXA WILL MEET YOU! TELL HER YOUR FURTHER NEEDS!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT PLACE ORDER, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
                cmd.Dispose();

                   
                    try
                    {
                        MailMessage msg = new MailMessage();
                        msg.From = new MailAddress("pharmacyatom@gmail.com");
                        msg.To.Add("hashini.mahinsa.fernando@gmail.com");
                        // msg.CC.Add(txt_cc.Text);
                        msg.Subject = "NEW ORDER";
                        msg.Body = "YOU HAVE GOT A NEW ORDER! CHECK IT OFF";

                        SmtpClient smt = new SmtpClient();
                        smt.Host = "smtp.gmail.com";
                        System.Net.NetworkCredential ntcd = new NetworkCredential();
                        ntcd.UserName = "rcar5295@gmail.com";
                        ntcd.Password = "qpayfyazrpadktwf";
                        smt.Credentials = ntcd;
                        smt.EnableSsl = true;
                        smt.Port = 587;
                        smt.Send(msg);


                        MessageBox.Show("Successfully sent E mail to barista", "info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Cannot send Email Try again", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cannot send Email Try again", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }



                RateUs y = new RateUs();
                    y.Show();

               


            
            }

            catch(SqlException ex)
            {
               MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT PLACE ORDER, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "SORRY, SOMTHING WENT WRONG, COULD NOT PLACE ORDER, TRY AGAIN LATER ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            
            
        }

        private void link_need_help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help x1 = new Help();
            x1.Show();
        }

        private void btn_see_price_Click(object sender, EventArgs e)
        {
             try
            {
                con.Open();
                da = new SqlDataAdapter("Select * From coffee", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid_see_price.DataSource = dt;
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

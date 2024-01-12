using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeHeven
{
    public partial class DeliverRiderLogin : Form
    {
        public DeliverRiderLogin()
        {
            InitializeComponent();

        }

        private void btn_staff_deliver_enter_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            if (txt_staff_deliver_password.Text == "Happy")
            {
                CoffeeDelivary l = new CoffeeDelivary();
                l.Show();
            }

            else if (txt_staff_deliver_password.Text == "")
            { 
                MessageBox.Show("IT SEEMS YOU MAY FORGET TO ENTER PASSWORD. PLEASE ENTER PASSWORD TO LOG IN  ", "ERROR");
            }
            else
            {
                MessageBox.Show("PASSWORD IS INCORRECT. IF YOU ARE A CUSTERMER PLEASE LOG IN AS A CUSTERMER. IF NOT PLASE ENTER CORRECT PASSWORD TO LOG IN AS A STAFF MEMBER", "ERROR");
                txt_staff_deliver_password.Clear();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(10);

        }
    }
}

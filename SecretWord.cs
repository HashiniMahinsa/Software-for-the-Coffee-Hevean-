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
    public partial class SecretWord : Form
    {
        public SecretWord()
        {
            InitializeComponent();

        }

        private void btn_staff_enter_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            if (txt_staff_password.Text == "Happy" )
            {
                Cashier c10 = new Cashier();
                c10.Show();
            }
            else if (txt_staff_password.Text == "" )
            {
                MetroFramework.MetroMessageBox.Show(this,"IT SEEMS YOU MAY FORGET TO ENTER PASSWORD. PLEASE ENTER PASSWORD TO LOG IN  ", "ERROR");
            }


            else
            {
                MetroFramework.MetroMessageBox.Show(this,"PASSWORD IS INCORRECT. IF YOU ARE A CUSTERMER PLEASE LOG IN AS A CUSTERMER. IF NOT PLASE ENTER CORRECT PASSWORD TO LOG IN AS A STAFF MEMBER", "ERROR");
                txt_staff_password.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(10);
        }

        private void SecretWord_Load(object sender, EventArgs e)
        {

        }
    }



}

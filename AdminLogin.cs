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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btn_adminLogin_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            if (txt_password.Text == "Coff((H(v(0")
            { 
            AdminEnter d = new AdminEnter();
            d.Show();
            }
            else if (txt_password.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this,"IT SEEMS YOU MAY FORGET TO ENTER PASSWORD. PLEASE ENTER PASSWORD TO LOG IN  ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this,"PASSWORD IS INCORRECT. IF YOU ARE A CUSTERMER PLEASE LOG IN AS A CUSTERMER. IF NOT PLASE ENTER CORRECT PASSWORD TO LOG IN AS A ADMIN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_password.Clear();
            }
        }

        private void txt_userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(10);
         
        }
    }
}

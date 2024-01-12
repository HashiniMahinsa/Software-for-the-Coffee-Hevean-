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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_custermer_Click(object sender, EventArgs e)
        {
            Welcome a = new Welcome();
            a.Show();
           
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            AdminWelcome a = new AdminWelcome();
            a.Show();
           
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            ChooseStaff i = new ChooseStaff();
            i.Show();
        }
    }
}

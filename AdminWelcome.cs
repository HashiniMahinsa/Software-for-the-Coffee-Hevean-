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
    public partial class AdminWelcome : Form
    {
        public AdminWelcome()
        {
            InitializeComponent();
        }

        private void btn_welcome_Click(object sender, EventArgs e)
        {
            AdminLogin c = new AdminLogin();
            c.Show();
        }

        private void btn_view_reservations_Click(object sender, EventArgs e)
        {
            ViewBook b1 = new ViewBook();
            b1.Show();
        }
    }
}

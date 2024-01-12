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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            Product t = new Product();
            t.Show();
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            Staff_member s = new Staff_member();
            s.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e) //my mistake
        {

        }

        private void btn_Manage_money_Click(object sender, EventArgs e)
        {
            Money x = new Money();
            x.Show();
        }

        private void btn_manage_custermer_Click(object sender, EventArgs e)
        {
            ManageCustermer m1 = new ManageCustermer();
            m1.Show();
        }
    }
}

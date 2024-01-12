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
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void btn_explore_coffee_world_Click(object sender, EventArgs e)
        {
            ExploreCoffeeWorld m = new ExploreCoffeeWorld();
            m.Show();
        }

        private void btn_order_from_coffee_heven_Click(object sender, EventArgs e)
        {
            OrderFromCoffeeHeven n = new OrderFromCoffeeHeven();
            n.Show();
        }

        private void btn_order_from_enywhere_Click(object sender, EventArgs e)
        {
            OrderFromHome o = new OrderFromHome();
            o.Show();
        }

        private void link_need_help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help x = new Help();
            x.Show();
        }

       
    }
}

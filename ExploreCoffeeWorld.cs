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
    public partial class ExploreCoffeeWorld : Form
    {
        public ExploreCoffeeWorld()
        {
            InitializeComponent();
        }

        private void btn_explore_coffee_Click(object sender, EventArgs e)
        {
            AboutCoffee o = new AboutCoffee();
            o.Show();
        }

        private void btn_explore_coffee_heven_Click(object sender, EventArgs e)
        {
            AboutCoffeeHeven p = new AboutCoffeeHeven();
            p.Show();
        }

        private void ExploreCoffeeWorld_Load(object sender, EventArgs e)
        {

        }
    }
}

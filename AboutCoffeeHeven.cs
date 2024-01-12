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
    public partial class AboutCoffeeHeven : Form
    {
        public AboutCoffeeHeven()
        {
            InitializeComponent();
        }

        private void AboutCoffeeHeven_Load(object sender, EventArgs e)
        {
            howWeMakeCoffee1.Hide();
            typesOfCoffee1.Hide();
            lifeWithCoffeeHeven1.Hide();
            pic_how_we_make_coffee.Visible=false;
        }

        private void btn_how_we_make_coffee_Click(object sender, EventArgs e)
        {
            howWeMakeCoffee1.Show();
            typesOfCoffee1.Hide();
            lifeWithCoffeeHeven1.Hide();
            pic_how_we_make_coffee.Visible=true;
        }

        private void btn_types_of_coffee_Click(object sender, EventArgs e)
        {
            howWeMakeCoffee1.Hide();
            typesOfCoffee1.Show();
            lifeWithCoffeeHeven1.Hide();
            pic_how_we_make_coffee.Visible=false;

        }

        private void btn_life_with_coffee_heven_Click(object sender, EventArgs e)
        {
            howWeMakeCoffee1.Hide();
            typesOfCoffee1.Hide();
            lifeWithCoffeeHeven1.Show();
            pic_how_we_make_coffee.Visible=false;

        }
    }
}

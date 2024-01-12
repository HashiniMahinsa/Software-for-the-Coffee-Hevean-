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
    public partial class OrderFromCoffeeHeven : Form
    {
        public OrderFromCoffeeHeven()
        {
            InitializeComponent();
        }

        private void btn_tap_to_place_order_Click(object sender, EventArgs e)
        {
            PlaceOrder p1 = new PlaceOrder();
            p1.Show();
        }
    }
}

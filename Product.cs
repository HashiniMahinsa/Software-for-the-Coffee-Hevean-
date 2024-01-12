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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void btn_item_Click(object sender, EventArgs e)
        {
            Products w = new Products();
            w.Show();

        }

        private void btn_ingrediants_machinnes_Click(object sender, EventArgs e)
        {
            Ingreadiants v = new Ingreadiants();
            v.Show();

        }

        private void btn_supplier_Click(object sender, EventArgs e)
        {
            Supliers u = new Supliers();
            u.Show();

        }
    }
}

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
    public partial class Ingreadiants : Form
    {
        public Ingreadiants()
        {
            InitializeComponent();
        }

        private void btn_update_current_stock_Click(object sender, EventArgs e)
        {
            Infarstructure i10 = new Infarstructure();
            i10.Show();
        }

        private void btn_view_current_stock_Click(object sender, EventArgs e)
        {
            Infarstructure i10 = new Infarstructure();
            i10.Show();
        }
    }
}

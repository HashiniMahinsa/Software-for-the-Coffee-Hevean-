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
    public partial class Supliers : Form
    {
        public Supliers()
        {
            InitializeComponent();
        }

        private void btn_add_new_suplier_Click(object sender, EventArgs e)
        {
            SupliersServises s20 = new SupliersServises();
            s20.Show();
        }

        private void btn_update_current_suplier_deatails_Click(object sender, EventArgs e)
        {
            SupliersServises s20 = new SupliersServises();
            s20.Show();
        }

        private void btn_remove_supplier_Click(object sender, EventArgs e)
        {
            SuplierService s21 = new SuplierService();
            s21.Show();
        }

        private void btn_get_suppliers_deatails_Click(object sender, EventArgs e)
        {
            SuplierService s21 = new SuplierService();
            s21.Show();
        }
    }
}

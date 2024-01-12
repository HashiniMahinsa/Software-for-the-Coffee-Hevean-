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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_welcome_Click(object sender, EventArgs e)
        {
            HOME b = new HOME();
            b.Show();
            this.Hide();

        }

        private void btn_reservations_Click(object sender, EventArgs e)
        {
            Reservations y = new Reservations();
            y.Show();
        }
    }
}

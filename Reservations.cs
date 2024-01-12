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
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();
        }
        private void btn_first_floor_Click(object sender, EventArgs e)
        {
            Booking h1 = new Booking();
            h1.Show();
        }

        private void btn_outdoor_area_Click(object sender, EventArgs e)
        {
            Booking h2 = new Booking();
            h2.Show();
        }
      
        private void Reservations_Load(object sender, EventArgs e)
        {

        }
    }
}
       

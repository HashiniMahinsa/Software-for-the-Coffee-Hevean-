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
    public partial class ChooseStaff : Form
    {
        public ChooseStaff()
        {
            InitializeComponent();
        }

        private void btn_staff_order_Click(object sender, EventArgs e)
        {
            SecretWord s30 = new SecretWord();
            s30.Show();
        }

        private void btn_deivary_Click(object sender, EventArgs e)
        {
            Barista w1 = new Barista();
            w1.Show();

        }

        private void btn_make_coffee_Click(object sender, EventArgs e)
        {
            Barista w2 = new Barista();
            w2.Show();
        }

        private void btn_attendance_Click(object sender, EventArgs e)
        {
            Attendance a1 = new Attendance();
            a1.Show();
        }

        private void ChooseStaff_Load(object sender, EventArgs e)
        {

        }
    }
}

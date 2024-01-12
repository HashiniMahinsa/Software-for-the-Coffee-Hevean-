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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_next_reports_Click(object sender, EventArgs e)
        {
            Reports r30 = new Reports();
            r30.Show();
        }
    }
}

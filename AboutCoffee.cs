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
    public partial class AboutCoffee : Form
    {
        public AboutCoffee()
        {
            InitializeComponent();
        }

        private void AboutCoffee_Load(object sender, EventArgs e)
        {
            lifeCycleOfCoffee1.Hide();
            benifitsOfCoffee1.Hide();
            moreAboutCoffee1.Hide();

        }

        private void button1_Click(object sender, EventArgs e) //btn_life_Cycle_Of_Coffee
        {
            lifeCycleOfCoffee1.Show();
            benifitsOfCoffee1.Hide();
            moreAboutCoffee1.Hide();

        }

        private void button2_Click(object sender, EventArgs e)//btn_benifits_of_coffee
        {
            lifeCycleOfCoffee1.Hide();
            benifitsOfCoffee1.Show();
            moreAboutCoffee1.Hide();

        }

        private void button3_Click(object sender, EventArgs e)//btn_more_about_coffee
        {
            lifeCycleOfCoffee1.Hide();
            benifitsOfCoffee1.Hide();
            moreAboutCoffee1.Show();

        }
    }
}

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
    public partial class TypesOfCoffee : UserControl
    {
        public TypesOfCoffee()
        {
            InitializeComponent();
        }

        private void btn_espresso_Click(object sender, EventArgs e)
        {
            pic_cafelatte.Visible = false;
            pic_cappuccino.Visible = false;
            pic_espresso.Visible = true;
            pic_macchiato.Visible = false;
            pic_mocha.Visible = false;
            pic_ristretto.Visible = false;

                
        }

        private void btn_mocchiato_Click(object sender, EventArgs e)
        {
            pic_cafelatte.Visible = false;
            pic_cappuccino.Visible = false;
            pic_espresso.Visible = false;
            pic_macchiato.Visible = true;
            pic_mocha.Visible = false;
            pic_ristretto.Visible = false;

        }

        private void btn_cafelatte_Click(object sender, EventArgs e)
        {
            pic_cafelatte.Visible = true;
            pic_cappuccino.Visible = false;
            pic_espresso.Visible = false;
            pic_macchiato.Visible = false;
            pic_mocha.Visible = false;
            pic_ristretto.Visible = false;

        }

        private void btn_cappachino_Click(object sender, EventArgs e)
        {
            pic_cafelatte.Visible = false;
            pic_cappuccino.Visible = true;
            pic_espresso.Visible = false;
            pic_macchiato.Visible = false;
            pic_mocha.Visible = false;
            pic_ristretto.Visible = false;

        }

        private void btn_mocha_Click(object sender, EventArgs e)
        {
            pic_cafelatte.Visible = false;
            pic_cappuccino.Visible = false;
            pic_espresso.Visible = false;
            pic_macchiato.Visible = false;
            pic_mocha.Visible = true;
            pic_ristretto.Visible = false;

        }

        private void btn_ristretto_Click(object sender, EventArgs e)
        {
            pic_cafelatte.Visible = false;
            pic_cappuccino.Visible = false;
            pic_espresso.Visible = false;
            pic_macchiato.Visible = false;
            pic_mocha.Visible = false;
            pic_ristretto.Visible = true;

        }

        private void TypesOfCoffee_Load(object sender, EventArgs e)
        {
            pic_cafelatte.Visible = false;
            pic_cappuccino.Visible = false;
            pic_espresso.Visible = false;
            pic_macchiato.Visible = false;
            pic_mocha.Visible = false;
            pic_ristretto.Visible = false;

        }
    }
}

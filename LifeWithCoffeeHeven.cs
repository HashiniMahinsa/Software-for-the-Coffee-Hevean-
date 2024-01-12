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
    public partial class LifeWithCoffeeHeven : UserControl
    {
        public LifeWithCoffeeHeven()
        {
            InitializeComponent();
        }

        private void btn_facebook_Click(object sender, EventArgs e)
        {
            pic_facebook.Visible = true;
            pic_instergram.Visible = false;
            pic_ticktok.Visible = false;
            label_facebook.Visible = true;
            label_instergramm.Visible = false;
            label_ticktok.Visible = false;

        }

        private void btn_instergram_Click(object sender, EventArgs e)
        {
            pic_facebook.Visible = false;
            pic_instergram.Visible = true;
            pic_ticktok.Visible = false;
            label_facebook.Visible = false;
            label_instergramm.Visible = true;
            label_ticktok.Visible = false;

        }

        private void btn_ticktok_Click(object sender, EventArgs e)
        {
            pic_facebook.Visible = false;
            pic_instergram.Visible = false;
            pic_ticktok.Visible = true;
            label_facebook.Visible = false;
            label_instergramm.Visible = false;
            label_ticktok.Visible = true;

        }

        private void LifeWithCoffeeHeven_Load(object sender, EventArgs e)
        {
            pic_facebook.Visible = false;
            pic_instergram.Visible = false;
            pic_ticktok.Visible = false;
            label_facebook.Visible = false;
            label_instergramm.Visible = false;
            label_ticktok.Visible = false;
        }

        
    }
}

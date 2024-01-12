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
    public partial class AdminEnter : Form
    {
        public AdminEnter()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            AdminLogin d = new AdminLogin();
            d.Show();

        }

        private void AdminEnter_Load(object sender, EventArgs e)
        {

        }

        private void btn_plan_Click(object sender, EventArgs e)
        {
            Plan s = new Plan();
            s.Show();
        }

        private void btn_manage_Click(object sender, EventArgs e)
        {
            Manage r = new Manage();
            r.Show();
        }
    }
}

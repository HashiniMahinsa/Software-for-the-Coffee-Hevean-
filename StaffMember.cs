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
    public partial class Staff_member : Form
    {
        public Staff_member()
        {
            InitializeComponent();
        }

        private void StaffMember_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_view_staff_member_deatails_Click(object sender, EventArgs e)
        {
            StaffMemberDetails s10 = new StaffMemberDetails();
            s10.Show();
        }

        private void btn_salary_Click(object sender, EventArgs e)
        {
            Salary s11 = new Salary();
            s11.Show();

        }

        private void btn_add_new_staff_member_Click(object sender, EventArgs e)
        {
            AddStaffMember s12 = new AddStaffMember();
            s12.Show();
        }

        private void btn_edit_current_staff_member_details_Click(object sender, EventArgs e)
        {
            UpdateStaffMemberDetails s13 = new UpdateStaffMemberDetails();
            s13.Show();
        }

        private void btn_resignations_and_terminations_Click(object sender, EventArgs e)
        {
            ResignationTermination s14 = new ResignationTermination();
            s14.Show();
        }
    }
}

using Group03_MilkTeaShop.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group03_MilkTeaShop
{
    public partial class StaffManagement : Form
    {
        public StaffManagement()
        {
            InitializeComponent();
            //buttonAdd.BackColor = Color.Red;
            UC_AddStaff ap = new UC_AddStaff();
            addUserControl(ap);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            UC_Container_SM.Controls.Clear();
            UC_Container_SM.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonView_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

        }

        private void UC_Container_SM_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

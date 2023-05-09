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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            MenuBtn.BackColor = Color.Red;
            UC_Menu uc = new UC_Menu();
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            UC_Container_Home.Controls.Clear();
            UC_Container_Home.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            MenuBtn.BackColor = Color.Red;
            OrderBtn.BackColor = Color.White;
            StatisticBtn.BackColor = Color.White;
            ProductMngBtn.BackColor = Color.White;
            OrderBtn.BackColor = Color.White;
            UC_Menu uc = new UC_Menu();
            addUserControl(uc);
        }

        private void StatisticBtn_Click(object sender, EventArgs e)
        {
            StatisticBtn.BackColor = Color.Red;
            MenuBtn.BackColor = Color.White;
            OrderBtn.BackColor = Color.White;
            OrderBtn.BackColor = Color.White;
            ProductMngBtn.BackColor = Color.White;
            UC_Statistic uc = new UC_Statistic();
            addUserControl(uc);
        }

        private void ProductMngBtn_Click(object sender, EventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            productManagement.Show();
            ProductMngBtn.BackColor = Color.Red;
            StatisticBtn.BackColor = Color.White;
            MenuBtn.BackColor = Color.White;
            OrderBtn.BackColor = Color.White;
            OrderBtn.BackColor = Color.White;
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
            OrderBtn.BackColor = Color.Red;
            ProductMngBtn.BackColor = Color.White;
            StatisticBtn.BackColor = Color.White;
            MenuBtn.BackColor = Color.White;
            OrderBtn.BackColor = Color.White;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void StaffMngBtn_Click(object sender, EventArgs e)
        {
            StaffManagement staffManagement = new StaffManagement();
            staffManagement.Show();
            StaffMngBtn.BackColor = Color.Red;
            StatisticBtn.BackColor = Color.White;
            MenuBtn.BackColor = Color.White;
            OrderBtn.BackColor = Color.White;
            ProductMngBtn.BackColor = Color.White;
        }

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            BtnAccount.BackColor = Color.Red;
            StatisticBtn.BackColor = Color.White;
            MenuBtn.BackColor = Color.White;
            OrderBtn.BackColor = Color.White;
            StaffMngBtn.BackColor = Color.White;
            ProductMngBtn.BackColor = Color.White;
            UC_AddAccount uc = new UC_AddAccount();
            addUserControl(uc);
        }
    }
}

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
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
            buttonAdd.BackColor = Color.Red;
            UC_AddProduct ap = new UC_AddProduct();
            addUserControl(ap);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            UC_Container_PM.Controls.Clear();
            UC_Container_PM.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            buttonAdd.BackColor = Color.Red;
            UC_AddProduct ap = new UC_AddProduct();
            addUserControl(ap);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            buttonEdit.BackColor = Color.Red;
            UC_EditProduct ep = new UC_EditProduct();
            addUserControl(ep);
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            buttonView.BackColor = Color.Red;
            UC_ViewProduct vp = new UC_ViewProduct();
            addUserControl(vp);
        }
    }
}

using Group03_MilkTeaShop.BS_Layer;
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
    public partial class Order : Form
    {
        BillDAO BillDAO = null;
        public Order()
        {
            InitializeComponent();
            BillDAO = new BillDAO();
        }

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            int id = Login.id;
            int result = BillDAO.CreateBill(id);
            if (result > 0)
            {
                MessageBox.Show("Create successful");
            }
            else
            {
                MessageBox.Show("Create fail");
            }
        }
    }
}

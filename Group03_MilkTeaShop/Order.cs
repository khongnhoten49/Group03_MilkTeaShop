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
        BillDAO billDAO = null;
        public Order()
        {
            InitializeComponent();
            billDAO = new BillDAO();
        }

        private void BtnNewOrder_Click(object sender, EventArgs e)
        {
            int id = Login.id;
            int result = billDAO.CreateBill(id);
            if (result > 0)
            {
                MessageBox.Show("Create successful");
            }
            else
            {
                MessageBox.Show("Create fail");
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {
            comboBoxListBillOrder.DataSource = billDAO.LoadUnCkeckedBill();
            comboBoxListBillOrder.DisplayMember = "ID";
        }
        private void LoadBillDetail()
        {
            DataRowView selectedRow = (DataRowView)comboBoxListBillOrder.SelectedItem;
            int id = Convert.ToInt32(selectedRow["ID"].ToString());
            dataGridViewBillOrder.DataSource = billDAO.GetBillDetail(id);
        }

        private void comboBoxListBillOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBillDetail();
        }
    }
}

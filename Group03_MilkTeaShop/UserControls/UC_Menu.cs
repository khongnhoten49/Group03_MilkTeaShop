using Group03_MilkTeaShop.BS_Layer;
using Group03_MilkTeaShop.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Group03_MilkTeaShop.UserControls
{
    public partial class UC_Menu : UserControl
    {
        ProductDAO productDAO = null;
        BillDAO billDAO = null;
        public UC_Menu()
        {
            InitializeComponent();
        }

        private void UC_Menu_Load(object sender, EventArgs e)
        {
            productDAO = new ProductDAO();
            billDAO = new BillDAO();
            LoadMenu();
            LoadCategory();
        }

        private void LoadCategory()
        {
            cbSelectCategory.DataSource = productDAO.LoadCategory();
            cbSelectCategory.DisplayMember = "name";
            cbSelectCategory.ValueMember = "id";
        }
        private void LoadMenu()
        {
            dataGridViewMenu.DataSource = productDAO.LoadMenu();
        }

        private void cbSelectCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)cbSelectCategory.SelectedItem;
            string name = selectedRow["name"].ToString();
            dataGridViewMenu.DataSource = productDAO.ListProductByCategory(name);
        }

        private void btnSearchInMenu_Click(object sender, EventArgs e)
        {
            string name = txtSearchInMenu.Text;
            if (name.Equals(""))
            {
                LoadMenu();
            }
            else
            {
                dataGridViewMenu.DataSource = productDAO.SearchProductByName(name);
            }
        }

        private void BtnViewAll_Click(object sender, EventArgs e)
        {
            LoadMenu();
        }

        private void txtSearchInMenu_TextChanged(object sender, EventArgs e)
        {
            string name = txtSearchInMenu.Text;
            if (name.Equals(""))
            {
                LoadMenu();
            }
            else
            {
                dataGridViewMenu.DataSource = productDAO.SearchProductByName(name);
            }
        }

        private void dataGridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idValue = Convert.ToInt32(dataGridViewMenu.CurrentRow.Cells["ID"].Value.ToString());
            string name = dataGridViewMenu.CurrentRow.Cells["Name"].Value.ToString();
            int quantity = 1;
            int price = Convert.ToInt32(dataGridViewMenu.CurrentRow.Cells["Price"].Value.ToString());
            string category = dataGridViewMenu.CurrentRow.Cells["Category"].Value.ToString();

            lblPName.Text = name;
            lblCategory.Text = category;
            numericUpDownPrice.Value = price;
            numericUpDownQuantity.Value = quantity;

            comboBoxListBill.DataSource = billDAO.LoadUnCkeckedBill();
            comboBoxListBill.DisplayMember = "ID";
        }

        private void BtnAddToOrder_Click(object sender, EventArgs e)
        {
            int idProduct = Convert.ToInt32(dataGridViewMenu.CurrentRow.Cells["ID"].Value.ToString());
            DataRowView selectedRow = (DataRowView)comboBoxListBill.SelectedItem;
            int idBill = Convert.ToInt32(selectedRow["ID"].ToString());
            
            int quantity = Convert.ToInt32(numericUpDownQuantity.Value);

            int result = billDAO.AddToOrder(idBill, idProduct, quantity);
            if(result > 0)
            {
                MessageBox.Show("Add to order successful");
            }
            else
            {
                MessageBox.Show("order fail");
            }
        }
    }
}

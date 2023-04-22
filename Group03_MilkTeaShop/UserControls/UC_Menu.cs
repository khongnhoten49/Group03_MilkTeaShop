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
        public UC_Menu()
        {
            InitializeComponent();
        }

        private void UC_Menu_Load(object sender, EventArgs e)
        {
            productDAO = new ProductDAO();
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
    }
}

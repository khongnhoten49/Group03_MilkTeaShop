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

namespace Group03_MilkTeaShop.UserControls
{
    public partial class UC_AddProduct : UserControl
    {
        ProductDAO productDAO = null;

        public UC_AddProduct()
        {
            InitializeComponent();
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void LoadMenu()
        {
            try
            {
                dataGVAddProduct.DataSource = productDAO.LoadMenu();
            }
            catch
            {
                MessageBox.Show("Lỗi truy vấn cơ sở dữ liệu: " + ProductDAO.sqlException.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadAllCategories()
        {
            try
            {
                comboBoxCategory.DataSource = productDAO.LoadCategory();
                comboBoxCategory.DisplayMember = "name"; //tên cột chứa dữ liệu để hiển thị lên ComboBox
                comboBoxCategory.ValueMember = "id"; //tên cột chứa dữ liệu để lưu trữ giá trị được chọn trong ComboBox
            }
            catch
            {
                MessageBox.Show("Lỗi truy vấn cơ sở dữ liệu: " + ProductDAO.sqlException.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void UC_AddProduct_Load(object sender, EventArgs e)
        {
            productDAO = new ProductDAO();
            LoadMenu();
            //LoadCategory();
            LoadAllCategories();

        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            int idcategory = comboBoxCategory.SelectedIndex + 1;
            string name = textBoxName.Text;
            int quantity = int.Parse(textBoxQuantity.Text);
            int price = int.Parse(textBoxPrice.Text);
            try
            {
                if (productDAO.AddProduct(name, idcategory, quantity, price) > 0)
                {
                    MessageBox.Show("Thêm sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMenu();
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi truy vấn cơ sở dữ liệu: " + ProductDAO.sqlException.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dataGVAddProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

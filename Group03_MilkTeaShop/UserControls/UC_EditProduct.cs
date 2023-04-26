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

    public partial class UC_EditProduct : UserControl
    {
        ProductDAO productDAO = null;
        public UC_EditProduct()
        {
            InitializeComponent();
        }
        private void LoadMenuWithId()
        {
            try
            {
                dataGVEditProduct.DataSource = productDAO.LoadMenuWithId();
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
        private void UC_EditProduct_Load(object sender, EventArgs e)
        {
            productDAO = new ProductDAO();
            LoadMenuWithId();
            //LoadCategory();
            LoadAllCategories();
            EditFoodDataBinding();
        }

        void EditFoodDataBinding()
        {
            textBoxId.DataBindings.Add(new Binding("Text", dataGVEditProduct.DataSource, "id"));
            textBoxName.DataBindings.Add(new Binding("Text", dataGVEditProduct.DataSource, "name"));
            textBoxQuantity.DataBindings.Add(new Binding("Text", dataGVEditProduct.DataSource, "quantity"));
            textBoxPrice.DataBindings.Add(new Binding("Text", dataGVEditProduct.DataSource, "price"));
            comboBoxCategory.DataBindings.Add(new Binding("Text", dataGVEditProduct.DataSource, "Category"));
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxId.Text);
            int idCategory = comboBoxCategory.SelectedIndex + 1;
            string name = textBoxName.Text;
            int quantity = int.Parse(textBoxQuantity.Text);
            int price = int.Parse(textBoxPrice.Text);
            try
            {
                if (productDAO.UpdateProduct(id, name, idCategory, quantity, price) > 0)
                {
                    MessageBox.Show("SỬa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMenuWithId();
                }
                else
                {
                    MessageBox.Show("Sửa sản phẩm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi truy vấn cơ sở dữ liệu: " + ProductDAO.sqlException.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            try
            {
                if (productDAO.DeleteProduct(name) > 0)
                {
                    MessageBox.Show("Xóa sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMenuWithId();
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi truy vấn cơ sở dữ liệu: " + ProductDAO.sqlException.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}

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
    public partial class UC_AddStaff : UserControl
    {
        EmployeeDAO EmployeeDAO = null;

        public UC_AddStaff()
        {
            InitializeComponent();
        }

        private void UC_AddStaff_Load(object sender, EventArgs e)
        {
            EmployeeDAO = new EmployeeDAO();
            LoadAllStaffInfo();
            EditStaffDataBinding();
        }
        void EditStaffDataBinding()
        {
            textBoxID.DataBindings.Add(new Binding("Text", dataGVAddStaff.DataSource, "id", true, DataSourceUpdateMode.Never));
            textBoxAID.DataBindings.Add(new Binding("Text", dataGVAddStaff.DataSource, "aid", true, DataSourceUpdateMode.Never));
            textBoxFName.DataBindings.Add(new Binding("Text", dataGVAddStaff.DataSource, "Fname", true, DataSourceUpdateMode.Never));
            textBoxLName.DataBindings.Add(new Binding("Text", dataGVAddStaff.DataSource, "Lname", true, DataSourceUpdateMode.Never));
            textBoxAddress.DataBindings.Add(new Binding("Text", dataGVAddStaff.DataSource, "addr", true, DataSourceUpdateMode.Never));
            textBoxGender.DataBindings.Add(new Binding("Text", dataGVAddStaff.DataSource, "gender", true, DataSourceUpdateMode.Never));
            textBoxPhone.DataBindings.Add(new Binding("Text", dataGVAddStaff.DataSource, "phone", true, DataSourceUpdateMode.Never));
            textBoxSalary.DataBindings.Add(new Binding("Text", dataGVAddStaff.DataSource, "salary", true, DataSourceUpdateMode.Never));
            textBoxPosition.DataBindings.Add(new Binding("Text", dataGVAddStaff.DataSource, "position", true, DataSourceUpdateMode.Never));
            dateTimeBirth.DataBindings.Add(new Binding("Text", dataGVAddStaff.DataSource, "birthday", true, DataSourceUpdateMode.Never));
        }
        private void LoadAllStaffInfo()
        {
            try
            {
                dataGVAddStaff.DataSource = EmployeeDAO.LoadAllStaffInfo();
            }
            catch
            {
                MessageBox.Show("Lỗi truy vấn cơ sở dữ liệu: " + ProductDAO.sqlException.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnAddStaff_Click(object sender, EventArgs e)
        {
            int aid = int.Parse(textBoxAID.Text);
            string Fname = textBoxFName.Text;
            string Lname = textBoxLName.Text;
            string phone = textBoxPhone.Text;
            string address = textBoxAddress.Text;
            int salary = int.Parse(textBoxSalary.Text);
            string gender = textBoxGender.Text;
            string position = textBoxPosition.Text;
            DateTime birthday = dateTimeBirth.Value;
            try
            {
                if (EmployeeDAO.AddStaff(aid, Fname, Lname, phone, address, salary, gender, birthday, position) > 0)
                {
                    MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllStaffInfo();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi truy vấn cơ sở dữ liệu: " + ProductDAO.sqlException.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdateStaff_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);
            int aid = int.Parse(textBoxAID.Text);
            string Fname = textBoxFName.Text;
            string Lname = textBoxLName.Text;
            string phone = textBoxPhone.Text;
            string address = textBoxAddress.Text;
            int salary = int.Parse(textBoxSalary.Text);
            string gender = textBoxGender.Text;
            string position = textBoxPosition.Text;
            DateTime birthday = dateTimeBirth.Value;
            try
            {
                if (EmployeeDAO.UpdateStaff(id, aid, Fname, Lname, phone, address, salary, gender, birthday, position) > 0)
                {
                    MessageBox.Show("SỬa thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllStaffInfo();
                }
                else
                {
                    MessageBox.Show("Sửa sản thông tin không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi truy vấn cơ sở dữ liệu: " + ProductDAO.sqlException.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ClearInfo()
        {
            textBoxID.Text = "";
            textBoxAID.Text = "";
            textBoxFName.Text = "";
            textBoxLName.Text = "";
            textBoxAddress.Text = "";
            textBoxGender.Text = "";
            textBoxPhone.Text = "";
            textBoxSalary.Text = "";
            textBoxPosition.Text = "";
            dateTimeBirth.Text = "";
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearInfo();
        }

        private void BtnDeleteStaff_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);
            try
            {
                if (EmployeeDAO.DeleteStaff(id) > 0)
                {
                    MessageBox.Show("Xóa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllStaffInfo();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi truy vấn cơ sở dữ liệu: " + ProductDAO.sqlException.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

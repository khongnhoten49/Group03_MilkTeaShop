using Group03_MilkTeaShop.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Group03_MilkTeaShop.UserControls
{
    public partial class UC_AddAccount : UserControl
    {
        AccountDAO accountDAO = null;
        public UC_AddAccount()
        {
            InitializeComponent();
        }

        private void UC_AddAccount_Load(object sender, EventArgs e)
        {
            accountDAO = new AccountDAO();
            LoadAllStaffInfo();
            EditStaffDataBinding();
        }
        private void LoadAllStaffInfo()
        {
            try
            {
                dataGVAddAccount.DataSource = accountDAO.LoadAllAccount();
            }
            catch
            {
                MessageBox.Show("Lỗi truy vấn cơ sở dữ liệu: " + AccountDAO.sqlException.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void EditStaffDataBinding()
        {
            try
            {
                textBoxUsername.DataBindings.Add(new Binding("Text", dataGVAddAccount.DataSource, "Username", true, DataSourceUpdateMode.Never));
                textBoxPassword.DataBindings.Add(new Binding("Text", dataGVAddAccount.DataSource, "Password", true, DataSourceUpdateMode.Never));
                textBoxRoleName.DataBindings.Add(new Binding("Text", dataGVAddAccount.DataSource, "RoleName", true, DataSourceUpdateMode.Never));
            }
            catch
            {
                MessageBox.Show("Lỗi truy vấn cơ sở dữ liệu: " + AccountDAO.sqlException.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxRoleName.Text = "";
        }

        private void BtnAddAccount_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string rolename = textBoxRoleName.Text;
            if(username.Equals("") || username == null)
                MessageBox.Show("Chưa nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(password.Equals("") || password == null)
                MessageBox.Show("Chưa nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            int role = 1;
            if(rolename.Equals("Manager"))
                role = 0;

            try
            {
                if (accountDAO.AddAccount(username, password, role) > 0)
                {
                    MessageBox.Show("Thêm account thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllStaffInfo();
                }
                else
                {
                    MessageBox.Show("Thêm account không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi truy vấn cơ sở dữ liệu: " + AccountDAO.sqlException.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

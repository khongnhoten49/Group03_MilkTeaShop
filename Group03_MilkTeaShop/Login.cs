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

namespace Group03_MilkTeaShop
{
    public partial class Login : Form
    {
        AccountDAO accountDAO = null;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            accountDAO = new AccountDAO();
            radioButtonStaff.Checked = true;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            int role;
            if(radioButtonAdmin.Checked ) { role = 0; }
            else { role = 1; }
            if(accountDAO.Login(username, password, role).Rows.Count > 0) 
            {
                Home home = new Home();
                home.Show();

                Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is incorrect!!!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPass.Checked ) 
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}

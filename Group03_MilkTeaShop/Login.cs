using Group03_MilkTeaShop.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group03_MilkTeaShop
{
    public partial class Login : Form
    {
        AccountDAO accountDAO = null;
        public static int id = 0;
        public static int role;
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

            if(radioButtonAdmin.Checked ) { role = 0; }
            else { role = 1; }
            try
            {
                DB_Connect connect = new DB_Connect(username, password);
                if (accountDAO.Login(username, password, role).Rows.Count > 0)
                {
                    id = Convert.ToInt32(accountDAO.Login(username, password, role).Rows[0]["ID"]);
                    Home home = new Home();
                    home.Show();

                    Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect!!!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch
            {
                MessageBox.Show("Lỗi truy vấn cơ sở dữ liệu: " + AccountDAO.sqlException.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void GetIdAccount()
        {

        }
    }
}

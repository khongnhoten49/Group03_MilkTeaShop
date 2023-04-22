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

namespace Group03_MilkTeaShop.UserControls
{
    public partial class UC_Statistic : UserControl
    {
        EmployeeDAO employeeDAO;
        BillDAO billDAO;
        public UC_Statistic()
        {
            InitializeComponent();
            employeeDAO = new EmployeeDAO();
            billDAO = new BillDAO();
        }

        private void UC_Statistic_Load(object sender, EventArgs e)
        {
            LoadCashierName();
            LoadAllBill();
            checkBoxFindByName.Checked = true;
        }
        private void LoadCashierName()
        {
            cbCashierName.DataSource = employeeDAO.LoadCashierName();
            cbCashierName.DisplayMember = "Name";
            cbCashierName.ValueMember = "Id";
        }
        private void LoadAllBill()
        {
            dataGridViewBill.DataSource = billDAO.LoadAllBill();
        }

        private void cbCashierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string StartDate = startDate.Value.ToString("yyyy-MM-dd");
            string EndDate = endDate.Value.ToString("yyyy-MM-dd");

            DataRowView selectedRow = (DataRowView)cbCashierName.SelectedItem;
            int id = Convert.ToInt32(selectedRow["Id"]);

            dataGridViewBill.DataSource = billDAO.GetBillByDate(StartDate, EndDate, id);            
        }
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            LoadAllBill();
        }

        private void BtnSearchBill_Click(object sender, EventArgs e)
        {
            string StartDate = startDate.Value.ToString("yyyy-MM-dd");
            string EndDate = endDate.Value.ToString("yyyy-MM-dd");

            DataRowView selectedRow = (DataRowView)cbCashierName.SelectedItem;
            int id = Convert.ToInt32(selectedRow["Id"]);

            dataGridViewBill.DataSource = billDAO.GetBillByDate(StartDate, EndDate, id);
        }

        private void checkBoxFindByName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFindByName.Checked == true)
            {
                cbCashierName.Enabled = true;
            }
            else
            {
                cbCashierName.Enabled = false;
            }
        }
    }
}

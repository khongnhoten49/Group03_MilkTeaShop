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
            try
            {
                cbCashierName.DataSource = employeeDAO.LoadCashierName();
                cbCashierName.DisplayMember = "Name";
                cbCashierName.ValueMember = "Id";
            }
            catch
            {
                MessageBox.Show("Lỗi truy vấn cơ sở dữ liệu: " + EmployeeDAO.sqlException.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadAllBill()
        {
            try
            {
                dataGridViewBill.DataSource = billDAO.LoadAllBill();
            }
            catch
            {
                MessageBox.Show("Lỗi truy vấn cơ sở dữ liệu: " + BillDAO.sqlException.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCashierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string StartDate = startDate.Value.ToString("yyyy-MM-dd");
            string EndDate = endDate.Value.ToString("yyyy-MM-dd");

            DataRowView selectedRow = (DataRowView)cbCashierName.SelectedItem;
            int id = Convert.ToInt32(selectedRow["Id"]);

            try
            {
                dataGridViewBill.DataSource = billDAO.GetBillByDate(StartDate, EndDate, id);
            }
            catch
            {
                MessageBox.Show("Lỗi truy vấn cơ sở dữ liệu: " + BillDAO.sqlException.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnViewAll_Click(object sender, EventArgs e)
        {
            LoadAllBill();
        }

        private void BtnSearchBill_Click(object sender, EventArgs e)
        {
            string StartDate = startDate.Value.ToString("yyyy-MM-dd");
            string EndDate = endDate.Value.ToString("yyyy-MM-dd");

            try
            {
                if (checkBoxFindByName.Checked)
                {
                    DataRowView selectedRow = (DataRowView)cbCashierName.SelectedItem;
                    int id = Convert.ToInt32(selectedRow["Id"]);

                    dataGridViewBill.DataSource = billDAO.GetBillByDate(StartDate, EndDate, id);
                }
                else
                {
                    dataGridViewBill.DataSource = billDAO.GetBillOnlyByDate(StartDate, EndDate);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi truy vấn cơ sở dữ liệu: " + BillDAO.sqlException.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void dataGridViewBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewBill.CurrentRow != null)
                {
                    int idValue = Convert.ToInt32(dataGridViewBill.CurrentRow.Cells["ID"].Value.ToString());
                    dataGridViewOrderDetail.DataSource = billDAO.GetBillDetail(idValue);
                }
                else
                {

                }
            }
            catch
            {
                MessageBox.Show("Lỗi truy vấn cơ sở dữ liệu: " + BillDAO.sqlException.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

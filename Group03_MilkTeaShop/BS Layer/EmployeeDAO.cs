using Group03_MilkTeaShop.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group03_MilkTeaShop.BS_Layer
{
    internal class EmployeeDAO
    {
        public static SqlException sqlException;
        public DataTable LoadCashierName()
        {
            try
            {
                using (SqlConnection connection = DB_Connect.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM GetCashierName", connection);
                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (SqlException ex)
            {
                sqlException = ex;
                return null;
            }
        }
    }
}

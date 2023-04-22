using Group03_MilkTeaShop.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Group03_MilkTeaShop.BS_Layer
{
    internal class BillDAO
    {
        public DataTable GetBillByDate(DateTime start, DateTime end, int id)
        {
            try
            {
                using (SqlConnection connection = DB_Connect.GetConnection())
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM UF_GetBillByDate(@StartDate, @EndDate, @Id)", connection);

                    command.Parameters.AddWithValue("@StartDate", start);
                    command.Parameters.AddWithValue("@EndDate", end);
                    command.Parameters.AddWithValue("@Id", id);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
                throw ex;
            }
        }
        public DataTable LoadAllBill()
        {
            try
            {
                using (SqlConnection connection = DB_Connect.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM LoadCheckedBill", connection);
                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
    }
}

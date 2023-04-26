using Group03_MilkTeaShop.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Group03_MilkTeaShop.BS_Layer
{
    internal class BillDAO
    {
        public static SqlException sqlException;
        public DataTable GetBillByDate(string start, string end, int id)
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
                sqlException = ex;
                return null;
            }
        }
        public DataTable GetBillOnlyByDate(string start, string end)
        {
            try
            {
                using (SqlConnection connection = DB_Connect.GetConnection())
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM UF_GetBillOnlyByDate(@StartDate, @EndDate)", connection);

                    command.Parameters.AddWithValue("@StartDate", start);
                    command.Parameters.AddWithValue("@EndDate", end);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
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
            catch (SqlException ex)
            {
                sqlException = ex;
                return null;
            }
        }
        public DataTable LoadUnCkeckedBill()
        {
            try
            {
                using (SqlConnection connection = DB_Connect.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM LoadUnCheckedBill", connection);
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
        public DataTable GetBillDetail(int id)
        {
            try
            {
                using (SqlConnection connection = DB_Connect.GetConnection())
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM UF_GetBillDetail(@BillId)", connection);

                    command.Parameters.AddWithValue("@BillId", id);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
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
        public int CreateBill(int id)
        {
            try
            {
                using (SqlConnection connection = DB_Connect.GetConnection())
                {
                    SqlCommand command = new SqlCommand("UP_InsertBill", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idAccount", id);
                    connection.Open();
                    int returnValue = command.ExecuteNonQuery();
                    return returnValue;
                }
            }
            catch (SqlException ex)
            {
                sqlException = ex;
                return 0;
            }
        }
        public int AddToOrder(int idBill, int idProduct, int quantity)
        {
            try
            {
                using (SqlConnection connection = DB_Connect.GetConnection())
                {
                    SqlCommand command = new SqlCommand("UP_InsertBillInfo", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@idBill", idBill);
                    command.Parameters.AddWithValue("@idProduct", idProduct);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    connection.Open();
                    int returnValue = command.ExecuteNonQuery();
                    return returnValue;
                }
            }
            catch (SqlException ex)
            {
                sqlException = ex;
                return 0;
            }
        }
    }
}

using Group03_MilkTeaShop.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group03_MilkTeaShop.DAO
{
    internal class AccountDAO
    {
        public static SqlException sqlException;
        public AccountDAO() 
        { 

        }
        public DataTable Login(string username, string password, int role)
        {
            try
            {
                using (SqlConnection connection = DB_Connect.GetConnection())
                {
                    SqlCommand command = new SqlCommand("UP_Login", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@userName", username);
                    command.Parameters.AddWithValue("@passWord", password);
                    command.Parameters.AddWithValue("@roleEmployee", role);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }catch (SqlException ex)
            {
                sqlException = ex;
                return null;
            }   
        }
        public int AddAccount(string username, string password, int role)
        {
            try
            {
                using (SqlConnection connection = DB_Connect.GetConnection())
                {
                    SqlCommand command = new SqlCommand("UP_AddAccount", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@userName", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@RoleID", role);

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
        public DataTable LoadAllAccount()
        {
            try
            {
                using (SqlConnection connection = DB_Connect.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM LoadAccount", connection);
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

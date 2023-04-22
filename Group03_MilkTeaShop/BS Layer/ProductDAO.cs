using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Group03_MilkTeaShop.DAO
{
    internal class ProductDAO
    {
        public ProductDAO() { }
        public DataTable LoadMenu()
        {
            try
            {
                using (SqlConnection connection = DB_Connect.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM LoadStorage", connection);
                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }
        public DataTable LoadCategory()
        {
            try
            {
                using (SqlConnection connection = DB_Connect.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM AllCategory", connection);
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
        public DataTable ListProductByCategory(string name)
        {
            try
            {
                using (SqlConnection connection = DB_Connect.GetConnection())
                {
                    Console.WriteLine(name);
                    SqlCommand command = new SqlCommand("SELECT * FROM UF_GetProductByCategoryName(@categoryName)", connection);

                    command.Parameters.AddWithValue("@categoryName", name);

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
        public DataTable SearchProductByName(string name)
        {
            try
            {
                using (SqlConnection connection = DB_Connect.GetConnection())
                {
                    Console.WriteLine(name);
                    SqlCommand command = new SqlCommand("SELECT * FROM UF_SearchProduct(@name)", connection);
                    command.Parameters.AddWithValue("@name", name);

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
    }
}

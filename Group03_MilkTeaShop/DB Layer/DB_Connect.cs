using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Group03_MilkTeaShop.DAO
{
    internal class DB_Connect
    {
        private static string username;
        private static string password;
        private static readonly string connectionString = @"Data Source=MSI;Initial Catalog=MilkTeaShop;Integrated Security=True;User ID="+username+";Password="+password+"";
        public DB_Connect(string username, string password)
        {

            DB_Connect.username = username;
            DB_Connect.password = password;
        }
        public static SqlConnection GetConnection()
        {
            try
            {
                return new SqlConnection(connectionString);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}

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
        private static readonly string connectionString = @"Data Source=DESKTOP-42L3GL9;Initial Catalog=MilkTeaShop;Integrated Security=True";

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

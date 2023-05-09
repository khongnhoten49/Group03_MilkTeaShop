﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Group03_MilkTeaShop.DAO
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
        public DataTable LoadAllStaffInfo()
        {
            try
            {
                using (SqlConnection connection = DB_Connect.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM loadAllStaff", connection);
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
        public int AddStaff( int aid, string Fname, string Lname, string phone, string address, int salary, string gender, 
             DateTime birthday, string position)
        {
            try
            {
                using (SqlConnection connection = DB_Connect.GetConnection())
                {
                    SqlCommand command = new SqlCommand("UP_AddStaff", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@aid", aid);
                    command.Parameters.AddWithValue("@Fname", Fname);
                    command.Parameters.AddWithValue("@Lname", Lname);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Birthday", birthday);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Salary", salary);
                    command.Parameters.AddWithValue("@Position", position);


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
        public int UpdateStaff(int id, int aid, string Fname, string Lname, string phone, string address, int salary, string gender,
             DateTime birthday, string position)
        {
            try
            {
                using (SqlConnection connection = DB_Connect.GetConnection())
                {
                    SqlCommand command = new SqlCommand("UP_UpdateStaff", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@aid", aid);
                    command.Parameters.AddWithValue("@Fname", Fname);
                    command.Parameters.AddWithValue("@Lname", Lname);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@Birthday", birthday);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Salary", salary);
                    command.Parameters.AddWithValue("@Position", position);


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
        public int DeleteStaff(int id)
        {
            try
            {
                using (SqlConnection connection = DB_Connect.GetConnection())
                {
                    SqlCommand command = new SqlCommand("UP_DeleteStaff", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@id", id);
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

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DAL
{
    public class DBConnection
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;

        public DBConnection()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            adapter = new SqlDataAdapter();
        }

        public SqlConnection openConnection()
        {
            try
            {
                if(connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
                {
                    connection.Open();
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "Thông báo");
            }

            return connection;
        }

        public DataTable ExecuteSelectQuery(string query, SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            DataSet dataSet = new DataSet();
            using (command = new SqlCommand())
            {
                command.Connection = openConnection();
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            return dataTable;
        }

        public void ExecuteInsertQuery(string query, SqlParameter[] parameters)
        {
            using (command = new SqlCommand())
            {
                command.Connection = openConnection();
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                command.ExecuteNonQuery();
                adapter.InsertCommand = command;
            }
        }

        public void ExecuteUpdateQuery(string query, SqlParameter[] parameters)
        {
            using (command = new SqlCommand())
            {
                command.Connection = openConnection();
                command.CommandText = query;
                command.Parameters.AddRange(parameters);
                command.ExecuteNonQuery();
                adapter.UpdateCommand = command;
            }
        }
    }
}

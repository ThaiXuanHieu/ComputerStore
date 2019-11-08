using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class UsersDAL
    {
        private DBConnection dbConnection;
        private static UsersDAL instance;

        public UsersDAL()
        {
            dbConnection = new DBConnection();
        }

        public static UsersDAL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new UsersDAL();
                }
                return instance;
            }
        }


        public DataTable Select()
        {
            string query = "SELECT * FROM Users";

            return dbConnection.ExecuteSelectQuery(query);
        }

        public DataTable Select(string _userName, string _password)
        {
            string query = "SELECT * FROM Users WHERE UserName = @userName AND Password = @password";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@userName", SqlDbType.VarChar);
            parameters[0].Value = _userName;
            parameters[1] = new SqlParameter("@password", SqlDbType.VarChar);
            parameters[1].Value = _password;

            return dbConnection.ExecuteSelectQuery(query, parameters);
        }


        public void Insert(string _fullName, string _userName, string _password)
        {
            string query = "INSERT INTO Users(FullName, UserName, Password) VALUES (@fullName, @userName, @password)";
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@fullName", SqlDbType.NVarChar);
            parameters[0].Value = _fullName;
            parameters[1] = new SqlParameter("@userName", SqlDbType.VarChar);
            parameters[1].Value = _userName;
            parameters[2] = new SqlParameter("@password", SqlDbType.VarChar);
            parameters[2].Value = _password;

            dbConnection.ExecuteInsertQuery(query, parameters);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class ProductsDAL
    {
        private DBConnection dbConnection;
        private static ProductsDAL instance;

        public ProductsDAL()
        {
            dbConnection = new DBConnection();
        }

        public static ProductsDAL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new ProductsDAL();
                }
                return instance;
            }
        }

        public DataTable Select()
        {
            string query = "SELECT * FROM Products WHERE CategoryID = @CategoryID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@CategoryID", SqlDbType.VarChar);
            parameters[0].Value = 1;
            return dbConnection.ExecuteSelectQuery(query, parameters);
        }
    }
}

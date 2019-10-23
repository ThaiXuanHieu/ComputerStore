using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoriesDAL
    {
        private static CategoriesDAL instance;
        private DBConnection dbConnection;

        public CategoriesDAL()
        {
            dbConnection = new DBConnection();
        }

        public static CategoriesDAL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new CategoriesDAL();
                }
                return instance;
            }
        }

        public DataTable Select()
        {
            string query = "SELECT * FROM Categories";
            return dbConnection.ExecuteSelectQuery(query);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SuppliersDAL
    {
        private static SuppliersDAL instance;
        private DBConnection dbConnection;

        public SuppliersDAL()
        {
            dbConnection = new DBConnection();
        }

        public static SuppliersDAL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SuppliersDAL();
                }
                return instance;
            }
        }

        public DataTable Select()
        {
            string query = "SELECT * FROM Suppliers";
            return dbConnection.ExecuteSelectQuery(query);
        }
    }
}

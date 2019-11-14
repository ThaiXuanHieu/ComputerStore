using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WarehouseDAL
    {
        private static WarehouseDAL instance;
        private DBConnection dbConnection;

        public WarehouseDAL()
        {
            dbConnection = new DBConnection();
        }

        public static WarehouseDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WarehouseDAL();
                }
                return instance;
            }
        }

        public DataTable SelectAll()
        {
            string query = "SELECT p.ProductName, p.Price, w.Inventory FROM Products AS p INNER JOIN Warehouse AS w" +
                " ON p.ProductID = w.ProductID";
            return dbConnection.ExecuteSelectQuery(query);
        }
    }
}

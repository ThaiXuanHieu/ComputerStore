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
            string query = "SELECT s.CompanyName, p.ProductName, p.Price, w.Stock FROM Products AS p INNER JOIN Warehouse AS w" +
                " ON p.ProductID = w.ProductID INNER JOIN Suppliers AS s ON s.SupplierID = p.SupplierID";
            return dbConnection.ExecuteSelectQuery(query);
        }

        public DataTable SelectBySupplierID(int _supplierID)
        {
            string query = "SELECT s.CompanyName, p.ProductName, p.Price, w.Stock FROM Products AS p INNER JOIN Warehouse AS w" +
                " ON p.ProductID = w.ProductID INNER JOIN Suppliers AS s ON s.SupplierID = p.SupplierID" +
                " WHERE s.SupplierID = @SupplierID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@SupplierID", SqlDbType.Int);
            parameters[0].Value = _supplierID;

            return dbConnection.ExecuteSelectQuery(query, parameters);
        }

        public DataTable SelectProductBySearchString(string _searchString)
        {
            string query = "SELECT s.CompanyName, p.ProductName, p.Price, w.Stock FROM Products AS p INNER JOIN Warehouse AS w" +
                " ON p.ProductID = w.ProductID INNER JOIN Suppliers AS s ON s.SupplierID = p.SupplierID" +
                " WHERE p.ProductName LIKE N'%" + _searchString + "%'";
            return dbConnection.ExecuteSelectQuery(query);
        }
    }
}

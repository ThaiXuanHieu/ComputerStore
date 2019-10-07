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

        public static ProductsDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductsDAL();
                }
                return instance;
            }
        }

        public ProductsDAL()
        {
            dbConnection = new DBConnection();
        }

        

        public DataTable Select()
        {
            string query = "SELECT p.ProductID, p.ProductName, c.CategoryName, s.CompanyName, p.Unit, p.Price " +
                "FROM Products AS p INNER JOIN Categories AS c" 
                + " ON p.CategoryID = c.CategoryID INNER JOIN Suppliers AS s ON p.SupplierID = s.SupplierID";
            return dbConnection.ExecuteSelectQuery(query);
        }
    }
}

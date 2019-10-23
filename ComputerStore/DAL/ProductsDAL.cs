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

        public void Insert(int _categoryID, int _supplierID, int _productID, string _productName, string _productImage, string _unit, string _price)
        {
            string query = "INSERT INTO Products VALUES (@CategoryID, @SupplierID, @ProductID, @ProductName, @ProductImage, @Unit, @Price)";

            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@CategoryID", SqlDbType.VarChar);
            parameters[0].Value = _categoryID;
            parameters[1] = new SqlParameter("@SupplierID", SqlDbType.VarChar);
            parameters[1].Value = _supplierID;
            parameters[2] = new SqlParameter("@ProductID", SqlDbType.VarChar);
            parameters[2].Value = _productID;
            parameters[3] = new SqlParameter("@ProductName", SqlDbType.VarChar);
            parameters[3].Value = _productName;
            parameters[4] = new SqlParameter("@ProductImage", SqlDbType.VarChar);
            parameters[4].Value = _productImage;
            parameters[5] = new SqlParameter("@Unit", SqlDbType.VarChar);
            parameters[5].Value = _unit;
            parameters[6] = new SqlParameter("@Price", SqlDbType.VarChar);
            parameters[6].Value = _price;
            dbConnection.ExecuteInsertQuery(query, parameters);

        }
    }
}

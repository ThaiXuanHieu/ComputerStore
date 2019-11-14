using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReceiptsDAL
    {
        private static ReceiptsDAL instance;
        private DBConnection dbConnection;

        public ReceiptsDAL()
        {
            dbConnection = new DBConnection();
        }

        public static ReceiptsDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReceiptsDAL();
                }
                return instance;
            }
        }

        public DataTable SelectFirstReceipts()
        {
            string query = "SELECT TOP 1 * FROM Receipts ORDER BY ReceiptID DESC";
            return dbConnection.ExecuteSelectQuery(query);
        }

        public void Insert(int _supplierID, DateTime _receiptDate, double _totalAmount)
        {
            string query = "INSERT INTO Receipts VALUES(@SupplierID, @ReceiptDate, @TotalAmount)";
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@SupplierID", SqlDbType.Int);
            parameters[0].Value = _supplierID;
            parameters[1] = new SqlParameter("@ReceiptDate", SqlDbType.DateTime);
            parameters[1].Value = _receiptDate;
            parameters[2] = new SqlParameter("@TotalAmount", SqlDbType.Money);
            parameters[2].Value = _totalAmount;

            dbConnection.ExecuteInsertQuery(query, parameters);
        }
    }
}

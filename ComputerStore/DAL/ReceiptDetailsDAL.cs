using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReceiptDetailsDAL
    {
        private ReceiptDetailsDAL instance;
        private DBConnection dbConnection;

        public ReceiptDetailsDAL()
        {
            dbConnection = new DBConnection();
        }

        public ReceiptDetailsDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReceiptDetailsDAL();
                }
                return instance;
            }
        }
    }
}

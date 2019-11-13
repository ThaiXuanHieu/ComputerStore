using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ReceiptDetailsBLL
    {
        private ReceiptDetailsBLL instance;
        private DBConnection dbConnection;

        public ReceiptDetailsBLL()
        {
            dbConnection = new DBConnection();
        }

        public ReceiptDetailsBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReceiptDetailsBLL();
                }
                return instance;
            }
        }
    }
}

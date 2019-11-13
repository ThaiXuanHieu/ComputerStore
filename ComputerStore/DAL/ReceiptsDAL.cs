using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReceiptsDAL
    {
        private ReceiptsDAL instance;
        private DBConnection dbConnection;

        public ReceiptsDAL()
        {
            dbConnection = new DBConnection();
        }

        public ReceiptsDAL Instance
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
    }
}

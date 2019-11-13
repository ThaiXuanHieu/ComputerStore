using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WarehouseDAL
    {
        private WarehouseDAL instance;
        private DBConnection dbConnection;

        public WarehouseDAL()
        {
            dbConnection = new DBConnection();
        }

        public WarehouseDAL Instance
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
    }
}

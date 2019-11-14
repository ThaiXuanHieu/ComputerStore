using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class WarehouseBLL
    {
        private static WarehouseBLL instance;

        public WarehouseBLL()
        {

        }

        public static WarehouseBLL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new WarehouseBLL();
                }
                return instance;
            }
        }

        public DataTable GetAll()
        {
            return WarehouseDAL.Instance.SelectAll();
        }

    }
}

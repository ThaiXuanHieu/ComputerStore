using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SuppliersBLL
    {
        private static SuppliersBLL instance;

        public SuppliersBLL()
        {

        }

        public static SuppliersBLL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SuppliersBLL();
                }
                return instance;
            }
        }

        public DataTable Select()
        {
            return SuppliersDAL.Instance.Select();
        }
    }
}

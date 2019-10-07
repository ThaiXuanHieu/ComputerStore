using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DAL;
namespace BLL
{
    public class ProductsBLL
    {
        private static ProductsBLL instance;

        public static ProductsBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ProductsBLL();
                }
                return instance;
            }
        }

        public ProductsBLL()
        {

        }

        

        public DataTable Select()
        {
            return ProductsDAL.Instance.Select();
        }
    }
}

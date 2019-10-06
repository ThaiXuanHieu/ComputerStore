using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsersDAL
    {
        private DBConnection dbConnection;
        private static UsersDAL instance;

        public UsersDAL()
        {
            dbConnection = new DBConnection();
        }

        public static UsersDAL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new UsersDAL();
                }
                return instance;
            }
        }
    }
}

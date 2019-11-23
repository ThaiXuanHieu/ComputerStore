using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RolesDAL
    {
        private static RolesDAL instance;
        private DBConnection dbConnection;

        public RolesDAL()
        {
            dbConnection = new DBConnection();
        }

        public static RolesDAL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new RolesDAL();
                }
                return instance;
            }
        }

        public DataTable SelectRoles()
        {
            string query = "SELECT * FROM Roles";
            return dbConnection.ExecuteSelectQuery(query);
        }
    }
}

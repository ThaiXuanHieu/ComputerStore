using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRoleRelationshipDAL
    {
        private static UserRoleRelationshipDAL instance;
        private DBConnection dbConnection;

        public UserRoleRelationshipDAL()
        {
            dbConnection = new DBConnection();
        }

        public static UserRoleRelationshipDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserRoleRelationshipDAL();
                }
                return instance;
            }
        }

        public DataTable Select()
        {
            string query = "SELECT u.UserName, r.RoleName FROM Users AS u INNER JOIN UserRoleRelationship AS ur ON ur.UserID = u.UserID" +
                " LEFT JOIN Roles AS r ON r.RoleID = ur.RoleID";
            return dbConnection.ExecuteSelectQuery(query);
        }
    }
}

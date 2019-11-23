using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RolesBLL
    {
        private static RolesBLL instance;

        public RolesBLL()
        {

        }

        public static RolesBLL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new RolesBLL();
                }
                return instance;
            }
        }

        public DataTable GetRoles()
        {
            return RolesDAL.Instance.SelectRoles();
        }
    }
}

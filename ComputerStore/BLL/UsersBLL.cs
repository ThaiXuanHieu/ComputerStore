using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsersBLL
    {
        private static UsersBLL instance;

        public UsersBLL()
        {

        }

        public static UsersBLL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new UsersBLL();
                }
                return instance;
            }
        }
    }
}

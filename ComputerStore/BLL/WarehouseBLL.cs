using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class WarehouseBLL
    {
        private WarehouseBLL instance;

        public WarehouseBLL()
        {

        }

        public WarehouseBLL Instance
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
    }
}

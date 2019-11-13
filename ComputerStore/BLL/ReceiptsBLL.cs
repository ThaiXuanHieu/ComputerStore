using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ReceiptsBLL
    {
        private ReceiptsBLL instance;

        public ReceiptsBLL()
        {

        }

        public ReceiptsBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReceiptsBLL();
                }
                return instance;
            }
        }
    }
}

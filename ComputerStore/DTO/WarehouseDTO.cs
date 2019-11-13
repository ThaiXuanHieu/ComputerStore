using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WarehouseDTO
    {
        private int productID;
        private int inventory;

        public int ProductID { get => productID; set => productID = value; }
        public int Inventory { get => inventory; set => inventory = value; }
    }
}

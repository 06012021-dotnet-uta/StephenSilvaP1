using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class Order
    {
        //[key]  // if you use CategoryID that will also denot that this column is primary key
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public int CustomerID { get; set; }
        public int StoreID { get; set; }
    }
    
        // now go add it to DBContext
}

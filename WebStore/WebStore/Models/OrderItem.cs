using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class OrderItem
    {
        //[key]  // if you use CategoryID that will also denot that this column is primary key
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductID { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
    }
    
        // now go add it to DBContext
}

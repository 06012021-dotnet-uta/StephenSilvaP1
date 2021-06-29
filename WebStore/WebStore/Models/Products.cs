using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class Product
    {
        //[key]  // if you use CategoryID that will also denot that this column is primary key
        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public String ProductDesc { get; set; }
        public float Price { get; set; }
    }
    
        // now go add it to DBContext
}

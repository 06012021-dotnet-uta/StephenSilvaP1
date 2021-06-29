using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class Customer
    {
        //[key]  // if you use CategoryID that will also denot that this column is primary key
        public int CustomerId { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }
        public int Age { get; set; }
        public int PreferredStore { get; set; }
    }
    
        // now go add it to DBContext
}

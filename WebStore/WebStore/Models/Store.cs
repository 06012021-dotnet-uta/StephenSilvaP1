using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class Store
    {
        //[key]  // if you use CategoryID that will also denot that this column is primary key
        public int StoreId { get; set; }
        public String StoreName { get; set; }
        public String StoreAddr1 { get; set; }
        public String StoreAddr2{ get; set; }
        public String StoreCity { get; set; }
        public String StoreState { get; set; }
        public String StoreZip { get; set; }
    }
    
        // now go add it to DBContext
}

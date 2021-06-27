using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Models
{
    public class Category
    {
        //[key]  // if you use CategoryID that will also denot that this column is primary key
        public int CategoryId { get; set; }
        public String Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}

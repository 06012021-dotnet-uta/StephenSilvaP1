using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebStore.Models;

namespace WebStore.Data
{
    public class P1DBContext : DbContext
    {
        public P1DBContext(DbContextOptions<P1DBContext> options) : base(options)
        {
                
        }

        public DbSet<Category> Category { get; set; }
    }
}

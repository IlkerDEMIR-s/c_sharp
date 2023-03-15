using RecaptProject1.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecaptProject1
{
    public class NordwindContext: DbContext
    {
       public DbSet<Product> Products { get; set; }
       public DbSet<Category> Categories { get; set; }
            
    }
}

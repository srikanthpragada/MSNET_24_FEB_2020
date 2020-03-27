using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class InventoryContext : DbContext 
    {
        public InventoryContext()
            : base(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=msdb;Integrated Security=True")
        {
            //Disable initializer
            Database.SetInitializer<InventoryContext>(null);
        }

        public DbSet<Category> Categories { get; set; }
    }
}

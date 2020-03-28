using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo.CF
{
    class CRMContext : DbContext 
    {
        public CRMContext()
            : base(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=msdb;Integrated Security=True")
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}

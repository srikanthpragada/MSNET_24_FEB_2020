using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo.CF
{
    class AddCustomer
    {
        static void Main(string[] args)
        {
            var ctx = new CRMContext();
            var cust = new Customer { Name = "Xyz", Mobile = "988765555" };

            ctx.Customers.Add(cust);
            ctx.SaveChanges();

        }
    }
}

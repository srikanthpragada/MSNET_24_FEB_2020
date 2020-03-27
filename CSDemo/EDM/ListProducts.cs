using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo.EDM
{
    class ListProducts
    {
        static void Main(string[] args)
        {
            InventoryEntities ctx = new InventoryEntities();
            ctx.Database.Log = Console.WriteLine;

            // Eager load - bring all from products and categories 
            foreach(product p in ctx.products.Include("category"))
            {
                Console.WriteLine( $"{p.prodname}  - {p.category.catdesc}");
            }
        }
    }
}

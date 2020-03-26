using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class CacheDemo
    {
        static void Main(string[] args)
        {
            using (var ctx = new InventoryContext())
            {
                ctx.Database.Log = Console.WriteLine;
                var cat1 = ctx.Categories.Find("pr");
                Console.WriteLine(cat1.GetHashCode());
                // Database is not acceesed as object is already in memory (ctx)
                var cat2 = ctx.Categories.Find("pr");
                Console.WriteLine(cat2.GetHashCode());
                Console.WriteLine(cat1 == cat2);
                ctx.Dispose();
            }
        }
    }
}

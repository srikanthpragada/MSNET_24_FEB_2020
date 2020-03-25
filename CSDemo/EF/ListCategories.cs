using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo.EF
{
    class ListCategories
    {
        static void Main(string[] args)
        {
            var ctx = new InventoryContext();
            ctx.Database.Log = Console.WriteLine;  // Redirect EF log to console

            foreach (var c in ctx.Categories)
                Console.WriteLine(c.Description);

            // Linq Query Operator 
            var selcats = ctx.Categories.Where(c => c.Description.Length > 8);


            selcats = from c in ctx.Categories
                      where c.Description.Length > 8
                      select c;

            foreach (var c in selcats)
                Console.WriteLine(c.Description);


        }
    }
}

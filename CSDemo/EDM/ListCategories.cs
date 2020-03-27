using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo.EDM
{
    class ListCategories
    {
        static void Main(string[] args)
        {
            InventoryEntities ctx = new InventoryEntities();
            ctx.Database.Log = Console.WriteLine;

        }
    }
}

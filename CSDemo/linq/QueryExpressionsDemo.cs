using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo.linq
{
    class QueryExpressionsDemo
    {
        static void Main(string[] args)
        {
            var books = Book.GetBooks();

            /*
            var costlybooks = from b in books
                              where b.Price > 500
                              select b;

            foreach(var b in costlybooks)
                Console.WriteLine(b);

           */

            /*
            // All books with 20% discount and desc order of price 

            var disbooks = from b in books
                           orderby b.Price descending
                           select new { Title = b.Title, Price = b.Price * .80 };

            foreach (var b in disbooks)
                Console.WriteLine(b);

            */
            var maxprice = books.Max(b => b.Price);
            var costlybook = (from b in books
                              where b.Price == maxprice
                              select b).First();

            // 
            var aspbooks = from b in books
                           where b.Title.Contains("ASP")
                           select b;

            foreach (var b in aspbooks)
                Console.WriteLine(b);


            var bigtitles = from b in books
                            where b.Title.Length > 10
                            orderby b.Price
                            select b;










        }
    }
}

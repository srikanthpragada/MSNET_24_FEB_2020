using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo.linq
{
    class QueryOperatorsDemo
    {
        static void Main(string[] args)
        {
            var books = Book.GetBooks();
            /*
            // Costly books
            var costly_books = books.Where(b => b.Price > 500);
            foreach(var b in costly_books)
                Console.WriteLine(b);
            */

            /*
            // Costly books
            var dis_books = books.Where(b => b.Price > 500)      // selection - filtering
                                 .Select(b => new { b.Title, 
                                                    NetPrice = b.Price * 0.80 });  // Projection

            foreach (var b in dis_books)
                Console.WriteLine($"{b.Title.PadRight(20)} - {b.NetPrice}");
            */

            /*
            var sortedbooks = books.OrderBy(b => b.Price).Take(3);
            foreach(var b in sortedbooks)
                Console.WriteLine(b);
            */

            // Book with highest price 
            var maxprice = books.Max(b => b.Price);
            var book = books.Where(b => b.Price == maxprice).First();
            Console.WriteLine(book);

            Console.WriteLine( books.Where(b=> b.Title.Contains("C#"))
                                    .Sum(b => b.Price));

        }
    }
}

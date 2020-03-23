using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class Product
    {
        private String name;
        private int price;
        private static int taxrate = 14;

        public static void ChangeTaxrate(int newrate)
        {
            taxrate = newrate;
        }
        public Product(String name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public void Print()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.price);
        }

        public int GetNetPrice()
        {
            return price + price * taxrate / 100;
        }
    }
    class TestProduct
    {
        static void Main(string[] args)
        {
            Product.ChangeTaxrate(15);
            Product p1 = new Product("iPhone 11", 80000);
            p1.Print();
            Console.WriteLine(p1.GetNetPrice());

        }
    }
}

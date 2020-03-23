using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class DynamicDemo
    {
        static void Main(string[] args)
        {
            dynamic obj;

            obj = new Account(1, "Abc");
            obj.Print();
            obj = new Product("Abc", 1000);
            obj.Print();


        }
    }
}

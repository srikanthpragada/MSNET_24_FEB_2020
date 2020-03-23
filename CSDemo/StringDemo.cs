using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class StringDemo
    {
        static void Main(string[] args)
        {
            String names = "Java,C#,Python,JavaScript";

            foreach (String name in names.Split(','))
                Console.WriteLine(name);


            String n1  = "A", n2 = "a";
            Console.WriteLine(String.Compare(n1, n2,false));

        }
    }
}

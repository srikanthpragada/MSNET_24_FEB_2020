using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class SortNames
    {
        static void Main(string[] args)
        {
            var names = new List<String>();

            while(true)
            {
                Console.WriteLine("Enter name [end to stop] :");
                var name = Console.ReadLine();
                if (name == "end")
                    break;

                names.Add(name);
            }

            names.Sort();

            foreach(string n in names)
                Console.WriteLine(n);
        }
    }
}

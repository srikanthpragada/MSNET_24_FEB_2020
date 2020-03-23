using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class LargestName
    {
        static void Main(string[] args)
        {
            string largest = "";
            int total = 0, count = 0;
            while(true)
            {
                Console.Write("Enter name [end to stop] :");
                string name = Console.ReadLine();
                if (name == "end")
                    break;

                total += name.Length;
                count++;
                if (name.CompareTo(largest) > 0)
                    largest = name;
            }

            Console.WriteLine($"Largest name   : {largest}");
            Console.WriteLine($"Average Length : {total/count}");

        }
    }
}

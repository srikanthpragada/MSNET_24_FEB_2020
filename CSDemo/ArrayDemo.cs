using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];

            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(100) + 100;
                Console.Write(a[i] + " ");
            }

            Array.Sort(a);
            Console.WriteLine("\nSorted Array\n");

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}

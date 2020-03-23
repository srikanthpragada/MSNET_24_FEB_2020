using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class AverageOfNumbers
    {
        static void Main(string[] args)
        {
            int i = 1, sum = 0;

            while(i <= 5)
            {
                try
                {
                    Console.Write("Enter a number :");
                    int num = Int32.Parse(Console.ReadLine());
                    sum += num;
                    i++;
                }
                catch
                {
                    Console.WriteLine("Sorry! Invalid Number!");
                }
            }
            Console.WriteLine($"Average = {sum / 5}");

        }
    }
}

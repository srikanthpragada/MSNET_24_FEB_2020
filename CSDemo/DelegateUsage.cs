using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class DelegateUsage
    {
        static bool IsEven(int n)
        {
            return n % 2 == 0;       
        }
        static void Main(string[] args)
        {
            var nums = new[] { 10, 11, 14, 55, 6, 7, 8 };

            // var even_nums = Array.FindAll(nums, IsEven);
            var even_nums = Array.FindAll(nums, v => v % 2 == 0);

            foreach (int n in even_nums)
                Console.WriteLine(n);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class FunDemo
    {
        static void Main(string[] args)
        {
            int v = 100;

            Console.WriteLine(Add(10, 20));
            Zero(ref v);
            Console.WriteLine(v);

            Console.WriteLine(Max(10, 20, 15, 60));
            Console.WriteLine(Max(10, 20, 15, 5,6,70,90));
        }

        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        static void Zero(ref int n)
        {
            n = 0; 
        }

        static int Max(params int [] nums)
        {
            int max = nums[0];

            foreach(int n in nums)
            {
                if (n > max)
                    max = n;
            }
            return max;
        }
    }
}

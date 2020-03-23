using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class Square
    {
        public static void Main()
        {
            int num;

            Console.Write("Enter a number :");
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Square of {0} is {1}",num,num*num);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class Factorial
    {
        // Depends on command line argument  
        public static void Main(string [] args)
        {
            // convert string to int
            if(args.Length == 0)
            {
                Console.WriteLine("Missing number!");
                return; // stop Main() to stop program
            }

            int num = Int32.Parse( args[0] );
            int factorial = 1;
            for (int i = 1; i <= num; i++)
                factorial *= i;

            Console.WriteLine("Factorial of {0} is {1}", num, factorial);
        }
    }
}

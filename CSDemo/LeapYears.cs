using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class LeapYears
    {
        static void Main(string[] args)
        {

            for(int year = 2000; year <= 2050; year ++)
            {
                if (year % 4 == 0)
                    Console.WriteLine(year);
            }
        }
    }
}

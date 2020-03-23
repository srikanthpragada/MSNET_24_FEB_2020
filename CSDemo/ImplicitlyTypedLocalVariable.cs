using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class ImplicitlyTypedLocalVariable
    {
        static void Main(string[] args)
        {
            var v = new int[10];
            var t  = new { Hour = 10, Min = 20, Sec = 30 };
            Console.WriteLine(t.Hour);
        }
    }
}

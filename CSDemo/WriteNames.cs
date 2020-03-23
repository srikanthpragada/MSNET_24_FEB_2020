using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class WriteNames
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"e:\classroom\msnet\feb24\names.txt");
            while(true)
            {
                Console.Write("Enter name [end to stop] :");
                string name = Console.ReadLine();
                if (name == "end")
                    break;
                sw.WriteLine(name);
            }
            sw.Close(); 
        }
    }
}

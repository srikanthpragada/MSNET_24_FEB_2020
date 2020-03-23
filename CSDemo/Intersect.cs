using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class Intersect
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"e:\classroom\msnet\feb24\names1.txt");
            var names = new List<String>();
            var common = new HashSet<String>();
            while (true)
            {
                var line = sr.ReadLine();
                if (line == null)
                    break;
                names.Add(line);
            }
            sr.Close();

            sr = new StreamReader(@"e:\classroom\msnet\feb24\names2.txt");
            while (true)
            {
                var line = sr.ReadLine();
                if (line == null)
                    break;

                if (names.Contains(line)) // common name
                    common.Add(line);
            }
            sr.Close();

            foreach(String s in common)
                Console.WriteLine(s);
        } // Main
    } // Class
}

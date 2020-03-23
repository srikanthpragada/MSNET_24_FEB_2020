using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class ShowFileContent
    {
        static void Main(string[] args)
        {
            string filename;
            // string filename = @"e:\classroom\java\feb21\hello.java";

            Console.Write("Enter filename :");
            filename = Console.ReadLine();

            // open file
            StreamReader sr = new StreamReader(filename);
            int lineno = 1;

            while (true)
            {
                String line = sr.ReadLine();
                if (line == null)  // EOF
                    break;
                Console.WriteLine($"{lineno} : {line}");
                lineno++;
            }
            sr.Close();

        }
    }
}

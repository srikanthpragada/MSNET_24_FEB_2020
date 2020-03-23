using System;
using System.IO;
using System.Collections.Generic;

namespace CSDemo
{
    class SortNamesFromFile
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"e:\classroom\msnet\feb24\authors.txt");
            var authors = new SortedSet<String>();
            while(true)
            {
                var line = sr.ReadLine();
                if (line == null)
                    break;

                var names = line.Trim().Split(',');
                foreach (string name in names)
                    if (name.Trim().Length >  0)
                         authors.Add(name.Trim());

                // Console.WriteLine(words.Length);
            }
            sr.Close();

            foreach(string author in authors)
                Console.WriteLine(author);


        }
    }
}

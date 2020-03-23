using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class SortCustomers
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"e:\classroom\msnet\feb24\customers.txt");
            var cust = new SortedDictionary<String, String>();
            while (true)
            {
                var line = sr.ReadLine();
                if (line == null)
                    break;

                if (line.Trim().Length == 0)
                    continue;

                String[] parts = line.Split(',');
                if (parts.Length < 2)
                    continue;

                var name = parts[0];
                var phone = parts[1];

                if (cust.ContainsKey(name)) // customer found, so replace phone
                    cust[name] = phone;
                else
                    cust.Add(name,phone);  // new customer 
            }
            sr.Close();

            foreach(String name in cust.Keys)
                Console.WriteLine($"{name.PadRight(10)} - {cust[name]}");
        }
    }
}

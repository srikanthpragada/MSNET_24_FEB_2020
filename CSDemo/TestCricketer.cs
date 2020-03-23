using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class Cricketer
    {
        private String name, country;
        private int runs, wickets;

        public Cricketer(String name, String country, int runs, int wickets)
        {
            this.name = name;
            this.country = country;
            this.runs = runs;
            this.wickets = wickets;
        }

        public int GetPoints()
        {
            return this.runs / 100 + this.wickets / 5;
        }
    }
    class TestCricketer
    {
        static void Main(string[] args)
        {
            Cricketer c = new Cricketer("Abc", "India", 3500, 50);
            Console.WriteLine(c.GetPoints());
        }
    }
}

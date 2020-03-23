using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class CalculateAge
    {
        static void Main(string[] args)
        {
            DateTime dob;

            Console.Write("Enter date of birth (yyyymmdd) :");
            string sdob = Console.ReadLine();

            dob = DateTime.ParseExact(sdob,"yyyyMMdd",null);
            Console.WriteLine(dob.ToString());
            TimeSpan span = DateTime.Today.Subtract(dob);
            int days = span.Days;
            int years = days / 365;
            days %= 365; 
            int months = days / 30;
            days %= 30;

            Console.WriteLine($"Age is : {years} years, {months} months, {days} days");

        }
    }
}

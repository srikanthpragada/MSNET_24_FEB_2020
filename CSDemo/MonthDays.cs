using System;


namespace CSDemo
{
    class MonthDays
    {
        static void Main(string[] args)
        {
            int month;
            int[] nodays = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            Console.Write("Enter month number :");
            month = Int32.Parse(Console.ReadLine());

            if ( month == 2 )
            {
                Console.Write("Enter year  :");
                int year = Int32.Parse(Console.ReadLine());
                if (year % 4 == 0)
                    Console.WriteLine(29);
                else
                    Console.WriteLine(28);
            }
            else
               Console.WriteLine(nodays[month]);

        }
    }
}

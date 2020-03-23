using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class MyTime
    {
        private int h, m, s;

        public MyTime(int h, int m, int s)
        {
            this.h = h;
            this.m = m;
            this.s = s;
        }
        // Property
        public int Min
        {
            get
            {
                return this.m;
            }
            set
            {
                if (value < 0 || value > 59)
                    throw new ArgumentException("Invalid value for minute");
                this.m = value;
            }
        }

        public int Hour
        {
            get
            {
                return this.h;
            }
            set
            {
                if (value < 0 || value > 23)
                    throw new ArgumentException("Invalid value for hour");

                this.h = value;
            }
        }

        public int Sec
        {
            get
            {
                return this.s;
            }
            set
            {
                this.s = value;
            }
        }
    }

    class TestMyTime
    {
        static void Main(string[] args)
        {
            MyTime t1 = new MyTime(10,10,10);
            try
            {
                t1.Min = 60;
                t1.Sec = 50;
                t1.Hour = 30;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }

            Console.WriteLine("The End");

        }
    }
}

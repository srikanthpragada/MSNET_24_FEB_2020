using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class Stack<T>
    {
        private T[] data = new T[10];
        private int top = 0; 
        public void Push(T v)
        {
            data[top] = v;
            top++;
        }

        public T Pop()
        {
            top--;
            return data[top];
        }
    }


    class GenericsDemo
    {
        static public int Max(int a,int b)
        {
            return a > b ? a : b;
        }

        static public double Max(double a, double b)
        {
            return a > b ? a : b;
        }
       
        static public T Min<T> (T a, T b) where T : IComparable
        {
            return a.CompareTo(b) < 0 ? a : b;
        }
        static void Main(string[] args)
        {
            // Console.WriteLine(Min(10,20));  // Int32
            //MyTime t1 = new MyTime(10, 10, 10);
            //MyTime t2 = new MyTime(20, 20, 20);
            //Console.WriteLine( Min(t1,t2));
            // Console.WriteLine(Min("Abc", "Aaaa"));  // String 

            var s = new Stack<String>();
            s.Push("Abc");
            s.Push("Xyz");
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());

            var nums = new Stack<int>();
            nums.Push(10);
            Console.WriteLine(nums.Pop());
        }
    }
}

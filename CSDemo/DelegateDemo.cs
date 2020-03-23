using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class DelegateDemo
    {
        delegate void PrintDelegate(String msg);

        static void PrintMessage(String message)
        {
            Console.WriteLine("Message : " + message);
        }
        static void Main(string[] args)
        {
            PrintDelegate pd = new PrintDelegate(PrintMessage);

            PrintDelegate d = PrintMessage;
            d("Hello!");
        }
    }
}

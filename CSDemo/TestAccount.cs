using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    class Account
    {
        // Fields 
        private int acno;
        private String ahname;
        private double balance;
        private static int minbal = 5000;

        public static int MinimumBalance
        {
            get
            {
                return minbal;
            }
        }
        // Constructor 
        public Account(int ano, String name)
        {
            acno = ano;
            ahname = name;
        }
        public Account(int ano, String name, double bal)
        {
            acno = ano;
            ahname = name;
            balance = bal;
        }
        // Methods 
        public void Deposit(double amount)
        {
            balance += amount;
        }
        
        public void Withdraw(double amount)
        {
            if (this.balance - Account.minbal >= amount)
                this.balance -= amount;
            else
                Console.WriteLine("Sorry! Insufficient balance!");
        }

        public double GetBalance()
        {
            return balance;
        }

        public void Print()
        {
            // Console.WriteLine("{0} {1} {2}", acno, ahname, balance);
            Console.WriteLine($"{acno} {ahname} {balance}");
        }
    }
    class TestAccount
    {
        static void Main(string[] args)
        {
            Account a1;  // object reference 
            
            a1 = new Account(101, "Anders"); // Create object
            a1.Deposit(10000);
            a1.Deposit(20000);
            Console.WriteLine(a1.GetBalance());

            Account a2 = new Account(102, "Steve",10000);
            a2.Deposit(50000);
        }
    }
}

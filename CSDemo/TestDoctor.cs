using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDemo
{
    abstract class Doctor
    {
        private String name, dept;
        public Doctor(String name, String dept)
        {
            this.name = name;
            this.dept = dept;
        }
        public virtual void Print()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.dept);
        }
        public abstract int GetSalary();
    }

    class Resident : Doctor
    {
        private int salary;
        public Resident(String name, String dept, int salary)
            : base(name,dept)  // call base class constructor 
        {
            this.salary = salary;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(this.salary);
        }

        public override int GetSalary()
        {
            return this.salary;
        }
    }

    class Consultant : Doctor
    {
        private int visits,charge;
        public Consultant(String name, String dept, int visits, int charge)
            : base(name, dept)  // call base class constructor 
        {
            this.visits = visits;
            this.charge = charge;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(this.visits);
            Console.WriteLine(this.charge);
        }
        public override int GetSalary()
        {
            return this.visits * this.charge;
        }
    }

    class TestDoctor
    {
        static void Main(string[] args)
        {

            Doctor d =  new Resident("Dr. Steve", "Card", 300000);
            d.Print();  // Runtime Polymorphism
            Console.WriteLine(d.GetSalary());

            d = new Consultant("Dr.Joe", "Ped", 10, 1000);
            d.Print();  // Runtime Polymorphism
            Console.WriteLine(d.GetSalary());

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_ovrrid
{
    class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    
    class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " Nooris");
        }
    }

    class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " Full Time");
        }
    }

    class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " Temp");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] zain = new Employee[4];
            zain[0] = new Employee();
            zain[1] = new PartTimeEmployee();
            zain[2] = new FullTimeEmployee();
            zain[3] = new TemporaryEmployee();
            foreach (Employee nooris in zain)
            {
                nooris.PrintFullName();
            }
            Console.ReadKey();
        }
    }
}

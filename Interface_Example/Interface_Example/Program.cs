using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example
{
    interface ICustomer
    {
        void Print();
    }
    interface IZain
    {
        void Scan();
    }
    
    class Customer : ICustomer, IZain
    {
        public void Print()
        {
            Console.WriteLine("ICustomer Interface");
        }

        public void Scan()
        {
            Console.WriteLine("IZain Interface");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Customer C = new Customer();
            C.Print();
            C.Scan();
            Console.ReadKey();
        }
    }
}

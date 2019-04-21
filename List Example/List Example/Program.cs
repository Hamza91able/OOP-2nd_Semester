using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Example
{
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salaray { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer Customer1 = new Customer()
            {
                ID = 1000,
                Name = "Hamza",
                Salaray = 1000,
            };
            Customer Customer2 = new Customer() 
            {
                ID = 2000,
                Name = "Taha",
                Salaray = 2000,
            };
            Customer Customer3 = new Customer()
            {
                ID = 3000,
                Name = "Owais",
                Salaray = 3000,
            };

            List<Customer> Customers = new List<Customer>(2);
            Customers.Add(Customer1);
            Customers.Add(Customer2);
            Customers.Add(Customer3);
            Customers.Insert(0, Customer3);
            
            Customers.Remove(Customer3);

            foreach (Customer c in Customers)
            {
                Console.WriteLine("ID = {0}, \nName = {1}, \nSalary = {2}", c.ID, c.Name, c.Salaray);
                Console.WriteLine("Index = {0}", Customers.IndexOf(c));
                Console.WriteLine();
            }
            
        }
    }
}

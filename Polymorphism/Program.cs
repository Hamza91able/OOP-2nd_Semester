using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Broast
    {
        public Broast()
        {
            Console.WriteLine("Broast");
        }
        public virtual void Making()
        {
            Console.WriteLine("Chicken, Cornflour, Breadcrums, red chilli paper powder");
        }
    }
    class spicybroast:Broast
    {
        public spicybroast()
        {
            Console.WriteLine("Spicy Broast");
        }
        public override void Making()
        {
            Console.WriteLine("Chicken, breadcrums, cornflour, red chilli powder");
            Console.WriteLine("Crushed black pepper");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            spicybroast sp = new spicybroast();
            sp.Making();
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverridingExample
{
    class BC
    {
        public void Display()
        {
            Console.WriteLine("BC:Display");
        }
    }
    class DC : BC
    {
        new public void Display()
        {
            Console.WriteLine("DC:Display");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BC b;
            b = new BC();
            b.Display();
            Console.ReadKey();
        }
    }
}

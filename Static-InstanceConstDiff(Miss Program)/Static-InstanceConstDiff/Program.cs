using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_InstanceConstDiff
{
    class Program
    {
        static int A;
        int B;
        static void Main(string[] args)
        {
            Program P1 = new Program(20);
            Program P2 = new Program(30);

            P1.Display();
            P2.Display();
            Console.ReadKey();
        }
        static Program()
        {
            Console.WriteLine("Static Constructor is called");
            A = 16;
        }
        public Program(int b)
        {
            Console.WriteLine("Instance Constructor is called");
            B = b;
        }
        private void Display()
        {
            Console.WriteLine("A={0}", A);
            Console.WriteLine("B={0}", B);
        }
    }
}

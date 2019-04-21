using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingExample
{
    class Program
    {
        public static int Calculate(int A, int B)
        {
            return (A * B);
        }
        public static int Calculate(int A, int B, int C)
        {
            return (A * B * C);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1.Multiplication of Two Numbers\n2.Multiplication of Three Numbers");
            int d = int.Parse(Console.ReadLine());
            if (d == 1)
            {
                Console.WriteLine("Enter Two Numbers>");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int Ans = Program.Calculate(a, b);
                Console.Write(">");
                Console.WriteLine(Ans);
            }
            if (d == 2)
            {
                Console.WriteLine("Enter Three Numbers>");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                int Ans = Program.Calculate(a, b, c);
                Console.Write(">");
                Console.WriteLine(Ans);
            }
            Console.ReadKey();
        }
    }
}

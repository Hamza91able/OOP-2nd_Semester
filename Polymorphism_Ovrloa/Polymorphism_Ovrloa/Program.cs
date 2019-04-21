using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Ovrloa
{
    class Program
    {
        static void Main(string[] args)
        {
            Add()
            Console.ReadKey();
        }

        public static void Add(int FN, int SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }

        public static void Add(int FN, int SN, int TN)
        {
            Console.Write("Sum = {0}", FN + SN + TN);
        }

        public static void Add(float FN, float SN, float TN, int FrN, double FtN)
        {
            Console.Write("Sum = {0}", FN + SN + TN);
        }
    }
}

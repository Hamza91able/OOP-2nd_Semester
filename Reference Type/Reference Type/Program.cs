using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_Type
{
    class Program
    {
        public static void Operation(ref int Num)
        {
            Num = Num * Num * Num / Num;
        }
        static void Main(string[] args)
        {
            int originalNum = 20;
            Console.WriteLine("Original Value>{0}", originalNum);
            Program.Operation(ref originalNum);
            Console.WriteLine("Reference value>{0}", originalNum);
            Console.ReadLine();
        }
    }
}

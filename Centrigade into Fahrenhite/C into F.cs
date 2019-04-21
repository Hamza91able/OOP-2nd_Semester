using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centigrate_into_Fahrenhite
{
    class C_to_F
    {
        static void Main(string[] args)
        {
            float C, F;
            Console.Write("Enter Temprature in Centigrate>");
            C=float.Parse(Console.ReadLine());
            F = (C * 9) / 5 + 32;
            Console.WriteLine("Temperature in Fahrenhite>{0}", F);
            Console.ReadKey();
        }
    }
}

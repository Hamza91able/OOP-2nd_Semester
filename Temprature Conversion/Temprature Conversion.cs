using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Temprature Conversion. (Supports Centigrade and Fahrenhite.)
namespace Centigrade_into_Fahrenhite_and_VICE_VERSA
{
    class C_to_F_VICEVERSA
    {
        static void Main(string[] args)
        {
            float C, F;
            int a;
            Console.WriteLine("Use menu to navigate.");
            Console.WriteLine("1.Centigrade into Fahrenhite.");
            Console.WriteLine("2.Fahrenhite into Centigrade.");
            Console.Write(">");
            a = int.Parse(Console.ReadLine());
            if (a==1)
            {
                Console.WriteLine("Centigrade into Fahrenhite.");
                Console.Write("Enter temperature in Centigrade>");
                C = float.Parse(Console.ReadLine());
                F = (C * 9) / 5 + 32;
                Console.Write("Temprature in Fahrenhite>{0}", F);
            }
            else if (a==2)
            {
                Console.WriteLine("Fahrenhite into Centigrade");
                Console.Write("Enter temprature in Fahrenhite>");
                F = float.Parse(Console.ReadLine());
                C = (F - 32) * 5 / 9;
                Console.Write("Temprature in Centigrade>{0}", C);
            }
            else
            {
                Console.WriteLine("Invalid Selection.");
            }
            Console.ReadKey();
        }
    }
}

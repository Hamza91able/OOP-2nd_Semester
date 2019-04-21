using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percentage_and_Grade
{
    //Percentage and Grade calculator.
    class Program
    {
        static void Main(string[] args)
        {  
            Program m = new Program();
        }
        public Program()
        {
            float m1, m2, m3, m4, m5, p;
            string n;

            Console.Write("Enter your name>");
            n = Console.ReadLine();

            Console.Write("Enter Marks of Subject 1>");
            m1 = float.Parse(Console.ReadLine());
            Console.Write("Enter Marks of Subject 2>");
            m2 = float.Parse(Console.ReadLine());
            Console.Write("Enter Marks of Subject 3>");
            m3 = float.Parse(Console.ReadLine());
            Console.Write("Enter Marks of Subject 4>");
            m4 = float.Parse(Console.ReadLine());
            Console.Write("Enter Marks of Subject 5>");
            m5 = float.Parse(Console.ReadLine());
            p = (m1 + m2 + m3 + m4 + m5) / 5;

            Console.WriteLine("\n\n");
            Console.WriteLine("Name>{0}", n);
            Console.WriteLine("Percentage>{0}%", p);
            if (p >= 0 && p <= 39)
                Console.WriteLine("Grade>F  Fail");
            if (p >= 40 && p <= 49)
                Console.WriteLine("Grade>E  Satisfactory");
            if (p >= 50 && p <= 59)
                Console.WriteLine("Grade>D  Fair");
            if (p >= 60 && p <= 69)
                Console.WriteLine("Grade>C  Good");
            if (p >= 70 && p <= 79)
                Console.Write("Grade>B  Very Good");
            if (p >= 80 && p <= 89)
                Console.WriteLine("Grade>A  Excellent");
            if (p >= 90 && p <= 100)
                Console.WriteLine("Grade>A+    Exceptional");
            Console.ReadKey();   
        }
    }
}

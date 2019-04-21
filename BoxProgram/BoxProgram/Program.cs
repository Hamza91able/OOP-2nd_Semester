using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxProgram
{
    class Box
    {
        public double l, h, b;
        public double Volume(double l,double h, double b)
        {
            return (l * b * h);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            //box1.l = 47;
            //box1.h = 50;
            //box1.b = 45;
            Console.WriteLine("Enter 3 values");
            box1.l = double.Parse(Console.ReadLine());
            box1.h = double.Parse(Console.ReadLine());
            box1.b = double.Parse(Console.ReadLine());
            Console.WriteLine("Volume of box is {0}",box1.Volume(box1.l,box1.h,box1.b));
            Console.ReadKey();
        }
    }
}

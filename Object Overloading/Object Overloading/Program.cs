using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            OverloadingOfObject obj1 = new OverloadingOfObject();
            obj1.Num1 = 50;
            obj1.Str1 = "Hamza";

            OverloadingOfObject obj2 = new OverloadingOfObject();
            obj2.Num1 = 20;
            obj2.Str1 = "Khan";

            OverloadingOfObject obj3 = new OverloadingOfObject();
            obj3 = obj1 + obj2;
            Console.WriteLine(obj3);
            Console.ReadKey();
        }
    }
    class OverloadingOfObject
    {
        public int Num1 = 0;
        public string Str1 = "";
        
        public static OverloadingOfObject operator +(OverloadingOfObject obj1, OverloadingOfObject obj2)
        {
            OverloadingOfObject obj3 = new OverloadingOfObject();
            obj3.Num1 = obj1.Num1 + obj2.Num1;
            obj3.Str1 = obj1.Str1 + obj2.Str1;
            return obj3;
        }
    }
}

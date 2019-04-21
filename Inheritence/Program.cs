using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class food
    {
        public void fastfood()
        {
            Console.WriteLine("FastFood Type");
        }
        public void fastfoodtype()
        {
            Console.WriteLine("FastFood: Burger : Wings : Broast");
        }
    }
    class Burger : food
    {
        public int No_of_pattie;
        public Burger()
        {
            Console.WriteLine("Burger");
        }
        public void Brand()
        {
            Console.WriteLine("McDonalds");
        }
        public void Price()
        {
            Console.WriteLine("Price = 1000");
        }
    }
    class BigMac : Burger
    {
        public void BigMac1()
        {
            Console.WriteLine("Big Mac");
        }
        public void Making()
        {
            Console.WriteLine("Big Mac burger includes");
            Console.WriteLine("No. of Pattie = {0}", No_of_pattie);
            Console.WriteLine("Latice and sauce");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BigMac bm = new BigMac();
            
            bm.fastfoodtype();
            bm.BigMac1();
            bm.No_of_pattie = 2;
            bm.Brand();
            bm.Making();
            bm.Price();
            Console.ReadKey();
        }
    }
}

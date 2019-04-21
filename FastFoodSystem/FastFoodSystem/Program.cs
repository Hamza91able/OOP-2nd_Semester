using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodSystem
{
    class Food
    {
        public void FastFood()
        {
            Console.WriteLine("FastFood Type");
        }
        public void FastFoodType()
        {
            Console.WriteLine("FastFood: Burger: Wings: Broast");
        }
    }
    class Burger:Food
    {
        public int NoofPattie;
        public int NoofChickenPiece;
        public void Brand()
        {
            Console.WriteLine("\tMcDonalds");
        }
        public Burger()
        {
            Console.WriteLine("Burger:");
        }
        public void Price()
        {
            int price;
            Console.Write("Enter Price>");
            price = int.Parse(Console.ReadLine());
        }
        public virtual void Making()
        {
            Console.WriteLine("\tBurger Includes");
            Console.WriteLine("\tNo of Pattie = {0}", NoofPattie);
            Console.WriteLine("\tChicken Pices = {0}", NoofChickenPiece);
            Console.WriteLine("\tLatice and Sauce");
        }
    }
    class BigMac:Burger
    {
        public BigMac()
        {
            Console.WriteLine("----Big Mac");
        }
        public override void Making()
        {
            Console.WriteLine("\tBig Mac Burger Includes");
            Console.WriteLine("\tNo of Pattie = {0}", NoofPattie);
            Console.WriteLine("\tLatice and Sauce");
        }
    }
    class ChickenMac : Burger
    {
        public ChickenMac()
        {
            Console.WriteLine("----Chicken Mac");
        }
        public override void Making()
        {
            Console.WriteLine("\tChickenMac Includes");
            Console.WriteLine("\tNo of Pattie = {0}", NoofPattie);
            Console.WriteLine("\tNo of chicken Pieces = {0}", NoofChickenPiece);
            Console.WriteLine("\tLatice and Sauce");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BigMac bm = new BigMac();
            bm.Brand();
            bm.FastFoodType();
            bm.NoofPattie = 2;
            Console.WriteLine("");
            bm.Making();
            bm.Price();

            Console.WriteLine("");

            ChickenMac mc = new ChickenMac();
            mc.Brand();
            mc.FastFoodType();
            mc.NoofPattie = 2;
            mc.NoofChickenPiece = 2;
            Console.WriteLine("");
            mc.Making();
            mc.Price();

            Console.Write("\nOperation Successfully Completed.");
            Console.ReadKey();
        }
    }
}

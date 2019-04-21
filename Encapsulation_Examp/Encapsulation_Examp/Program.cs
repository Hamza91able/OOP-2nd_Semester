using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Examp
{
    abstract class phone
    {
        public abstract void call();
        public abstract void camera();
        public abstract void storage();
    }
    class repair_shop
    {
        public void repair(phone p)
        {
            Console.WriteLine("\n**********REPAIR SHOP*************");
            p.camera();
        }
    }
    class samsungphone : phone
    {
        public override void call()
        {
            Console.WriteLine("\nSamsung Galaxy S6 Edge Call");
        }
        public override void camera()
        {
            Console.WriteLine("Samsung S6 Edge Camera\n 1)  16MP Rear\n 2)  5MP Front");
        }
        public override void storage()
        {
            Console.WriteLine("Samsung S6 Edge Storage = 32GB");
        }
    }
    class applephone : phone
    {
        public override void call()
        {
            Console.WriteLine("Apple iPhone 8 Plus call function");
        }
        public override void camera()
        {
            Console.WriteLine("Apple iPhone 8 Plus\n 1)     12MP Bck\n 2)     7MP Front");
        }
        public override void storage()
        {
            Console.WriteLine("Apple iPhone 8 Plus storage:  256GB");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            applephone I8 = new applephone();
            I8.call();
            I8.storage();
            I8.camera();

            samsungphone A9 = new samsungphone();
            A9.call();
            A9.storage();

            repair_shop r = new repair_shop();
            r.repair(A9);

            Console.ReadKey();
        }
    }
}

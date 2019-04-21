using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instance_StaticDiff
{
    class RandomNumberClass
    {
        private static Random RandomKey;
        static RandomNumberClass()
        {
            RandomKey = new Random();
        }
        public int GetRandomNumber()
        {
            return RandomKey.Next();
        }
    }
    class Program
    {
        static void Main()
        {
            RandomNumberClass a = new RandomNumberClass();
            RandomNumberClass b = new RandomNumberClass();
            Console.WriteLine("Next Random>{0}", a.GetRandomNumber());
            Console.WriteLine("Next Random>{0}", b.GetRandomNumber());
            Console.ReadKey();
        }
    }
}


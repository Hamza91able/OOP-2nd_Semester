using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Example
{
    abstract class animal
    {
        public abstract void eat();
        public void sound()
        {
            Console.WriteLine("dog can sound");
        }
    }
    class dog : animal
    {
        public override void eat()
        {
            Console.WriteLine("dog can also eat");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            dog mydog = new dog();
            mydog.sound();
            mydog.eat();
            Console.ReadKey();
        }
    }
}

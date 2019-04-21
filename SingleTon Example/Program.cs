using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleTon_Exampe
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton SingletonObject = Singleton.GetObject();
            SingletonObject.Print("This is print method called from main method.");
            SingletonObject.Print("\nMuhammad Hamza Khan.");
            Console.ReadKey();
        }
    }

    public class Singleton
    {
        protected static Singleton _obj;
        private Singleton()
        {
            Console.WriteLine("This is Private Signleton method.");
        }
        public static Singleton GetObject()
        {
            if (_obj == null)
            {
                _obj = new Singleton();
            }
            return _obj;
        }
        public void Print(string s)
        {
            Console.Write(s);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            child ch = new child();
            ch.message();
            Console.ReadKey();
        }
    }
    public interface Ibase1
    {
        void message();
    }
    public interface Ibase2
    {
        void message();
    }
    public class child : Ibase1, Ibase2
    {
        public void message()
        {
            Console.WriteLine("Hello Multiple Inheritance");
        }
    }
}

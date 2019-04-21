using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace This_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Hamza exe = new Hamza();
            exe.Example();
        }
    }
    public class Hamza
    {
        public string name;
        public int rad_num;

        public void Example()
        {
            this.name = "Hamza";
            this.rad_num = 54;
            Console.WriteLine (name);
            Console.WriteLine (rad_num);
            Console.ReadKey();
        }
    }
}

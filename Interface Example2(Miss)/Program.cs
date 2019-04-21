using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example2_Miss_
{
    public interface Jewller
    {
        string MakingPendent();
    }

    public class Star : Jewller
    {
        public string MakingPendent()
        {
            return "Star Shaped Pendent.";
        }
    }

    public class Square : Jewller
    {
        public string MakingPendent()
        {
            return "Square Shaped Pendent.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Star St = new Star();
            //St.MakingPendent();
            Square Sq = new Square();
            //Sq.MakingPendent();
            //S1 = S2;
            string S1;
            string S2;
            S1 = St.MakingPendent();
            S2 = Sq.MakingPendent();
            Console.WriteLine("Calling star included " +S1);
            Console.WriteLine("Calling Square included " +S2);
            Console.ReadKey();
        }
    }
}

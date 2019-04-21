using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueType = 30;
            valueType = valueType + DateTime.Today.Day;
            Console.WriteLine(valueType);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> Default_Stack = new Stack<int>();

            Default_Stack.Push(0);
            Default_Stack.Push(5);
            Default_Stack.Push(10);
            int topOfStack = Default_Stack.Pop();
            Console.WriteLine(topOfStack);
            Default_Stack.Push(15);
            Default_Stack.Push(20);
            Console.WriteLine("============");
            foreach (int stackPrint in Default_Stack)
            {
                Console.WriteLine(stackPrint);
            }
            Console.WriteLine("============");
            Console.ReadKey();
        }
    }
}

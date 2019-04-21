using System;

namespace Array__Loop_and_Selective
{
    class Array_Loop_Selective
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[5];
            int i;
            Console.WriteLine("Welcome to the menu.");
            Console.WriteLine("press m to continue the program.");
            string a = Console.ReadLine();
            if (a == "m" || a == "M")
            {
                Console.Write("Enter numbers to fill in array>");
                //Scan loop.
                for (i = 0; i < 5; i++)
                {
                    Arr[i] = int.Parse(Console.ReadLine());
                }
                //Print Loop.
                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine("Values are> {0}", Arr[i]);
                }
            }
            else
            {
                Console.WriteLine("Invalid selection.");
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalcPrivateConstructor
{

    public class Calculator
    {
        public double total;
        private Calculator()
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();

            Console.SetCursorPosition(50, 0);

            Console.WriteLine("This Program is Written By S.M.Zaman Mehdi");

            Console.WriteLine();

            Console.SetCursorPosition(0, 2);

            Console.WriteLine("Calculator");

            Console.WriteLine();

            Console.WriteLine("Enter Two number");

            Console.WriteLine();

            Console.Write("Enter 1st Number = ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter 2nd Number = ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Press Key for Accordance to Reference Below");
            Console.WriteLine("1. Menu");
            Console.WriteLine("2. Exit");
            Console.Write("Choice = ");
            Console.WriteLine();

            double option;
            option = double.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine();
                START : Console.WriteLine("Select Operation From Menu Accordance to Reference Below");
                Console.WriteLine("1. Sum");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.Write("Choice = ");

                int choice;
                choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1 :
                        {
                            Console.Write("Sum of Given Two Numbers = ", total = num1 + num2);
                           
                            break;
                        }

                    case 2 :
                        {
                            Console.Write("Difference of Given Two Numbers = ", total = num1 - num2);
                           
                            break;
                        }

                    case 3 :
                        {
                            Console.Write("Product of Two Given Numbers = ", total = num1 * num2);
                            
                            break;
                        }

                    case 4 :
                        {
                            
                            if (num2 != 0)
                            {
                                Console.Write("Division of Two Given Number = ", total = num1 / num2);
                            }
                    
                            else
                            {
                                Console.Write("Number2 can't be equal to ");
                            }
                            
                            break;
                        }
                
                    default :
                        {
                            Console.WriteLine("Wrong selection. \nTry Again.");
                            goto START;
                        }
                        
                }
            }
            
            else if (option >= 2 || option <= 0)
            {
                Console.WriteLine("Exiting...");
                Console.ReadKey();
                Environment.Exit(1);
            }
        }

        public static Calculator Zaman = new Calculator();
    }
}
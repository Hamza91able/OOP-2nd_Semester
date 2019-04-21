using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceInheritenceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CCalculator Calc = new CCalculator();
            Calc.Calculator();
        }
    }
    public interface IMultiplication
    {
        void Multiplication(double num1, double num2);
    }
    public interface IDivision
    {
        void Division(double num1, double num2);
    }
    public interface IAddition
    {
        void Addition(double num1, double num2);
    }
    public interface ISubtraction
    {
        void Subtraction(double num1, double num2);
    }
    public interface ICalculator : IMultiplication, IDivision, IAddition, ISubtraction
    {
        void Calculator();
    }
    public class CCalculator : ICalculator
    {
        public void ClearScreen()
        {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Calculator();
        }
        public void Calculator()
        {
            int choice;
            double num1 = 0, num2 = 0;
            Console.WriteLine("\t\t\tCalculator");
            Console.WriteLine("Enter two numbers");
            Console.Write("Number1>");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Number2>");
            num2 = double.Parse(Console.ReadLine());
            Console.Write("\n");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("5.Exit");
            Console.Write(">");
            choice = int.Parse(Console.ReadLine());
            Console.Write("\n");
            if (choice == 1)
            {
                Console.WriteLine("Addition");
                Addition(num1, num2);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Subtraction");
                Subtraction(num1, num2);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Multiplication");
                Multiplication(num1, num2);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Division");
                Division(num1, num2);
            }
            else if (choice == 5)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid Selection.\nTry Again.");
                Console.ReadKey();
                ClearScreen();
            }
        }
        public void Multiplication(double num1, double num2)
        {
            Console.WriteLine(">{0} * {1} = {2}", num1, num2, num1 * num2);
            ClearScreen();
        }
        public void Division(double num1, double num2)
        {
            if (num2 != 0)
            {
                Console.WriteLine(">{0} / {1} = {2}", num1, num2, num1 / num2);
                ClearScreen();
            }
            else
            {
                Console.WriteLine("Number 2 can't be 0\n");
                ClearScreen();
            }
        }
        public void Addition(double num1, double num2)
        {
            Console.WriteLine(">{0} + {1} = {2}", num1, num2, num1 + num2);
            ClearScreen();
        }
        public void Subtraction(double num1, double num2)
        {
            Console.WriteLine(">{0} - {1} = {2}", num1, num2, num1 - num2);
            ClearScreen();
        }
    }
}

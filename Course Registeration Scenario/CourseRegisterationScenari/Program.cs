using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegisterationScenario
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt;
        START: Console.WriteLine("Who are ycou? \n1.Student \n2.Teaher");
            Console.Write(">");
            opt = int.Parse(Console.ReadLine());
            if (opt == 1)
            {
                Student S = new Student();
            }
            else if (opt == 2)
            {
                Teacher T = new Teacher();
            }
            else
            {
                Console.WriteLine("Invalid Selection. \nTry Again.\n");
                goto START;
            }
            Console.ReadKey();
        }
    }

    class Student
    {
        public Student()
        {
            string Stu_Name;
            int Roll_No;
            Console.Write("Enter Student Name>");
            Stu_Name = Console.ReadLine();
            Console.Write("Enter RollNo.>");
            Roll_No = int.Parse(Console.ReadLine());
            Console.Write("\n");
        MID: Console.WriteLine("Select any Three(3) Courses from the following.\n");
            int s1 = 0, s2 = 0, s3 = 0;
            Console.WriteLine("1.Object Oriented Programming");
            Console.WriteLine("2.Calculus and Analytical Geometry");
            Console.WriteLine("3.Computer Logic Design");
            Console.WriteLine("4.Introduction to C-Language");
            Console.WriteLine("5.Linear Algebra");
            Console.WriteLine("6.Introduction to Software Engineering\n");
            Console.Write("Couse 1>");
            s1 = int.Parse(Console.ReadLine());
            Console.Write("Couse 2>");
            s2 = int.Parse(Console.ReadLine());
            Console.Write("Couse 3>");
            s3 = int.Parse(Console.ReadLine());
            if (s1 <= 6 && s2 <= 6 && s3 <= 6 && s1 != 0 && s2 != 0 && s3 != 0)
            {
                Console.Clear();
                Console.WriteLine("Student Name>{0}", Stu_Name);
                Console.WriteLine("Roll#>{0}", Roll_No);
                Console.WriteLine("\nRegistered Courses are.");
                Console.Write("1.");
                if (s1 == 1)
                    Console.WriteLine("Object Oriented Programming");
                else if (s1 == 2)
                    Console.WriteLine("Calculus and Analytical Geometry");
                else if (s1 == 3)
                    Console.WriteLine("Computer Logic Design");
                else if (s1 == 4)
                    Console.WriteLine("Introduction to C-Language");
                else if (s1 == 5)
                    Console.WriteLine("Linear Algebra");
                else if (s1 == 6)
                    Console.WriteLine("Introduction to Software Engineering");

                Console.Write("2.");
                if (s2 == 1)
                    Console.WriteLine("Object Oriented Programming");
                else if (s2 == 2)
                    Console.WriteLine("Calculus and Analytical Geometry");
                else if (s2 == 3)
                    Console.WriteLine("Computer Logic Design");
                else if (s2 == 4)
                    Console.WriteLine("Introduction to C-Language");
                else if (s2 == 5)
                    Console.WriteLine("Linear Algebra");
                else if (s2 == 6)
                    Console.WriteLine("Introduction to Software Engineering");

                Console.Write("3.");
                if (s3 == 1)
                    Console.WriteLine("Object Oriented Programming");
                else if (s3 == 2)
                    Console.WriteLine("Calculus and Analytical Geometry");
                else if (s3 == 3)
                    Console.WriteLine("Computer Logic Design");
                else if (s3 == 4)
                    Console.WriteLine("Introduction to C-Language");
                else if (s3 == 5)
                    Console.WriteLine("Linear Algebra");
                else if (s3 == 6)
                    Console.WriteLine("Introduction to Software Engineering");
            }
            else
            {
                Console.WriteLine("Invalid Selection. \nTry Again.\n");
                goto MID;
            }
        }
    }

    class Teacher
    {
        public Teacher()
        {
            string Tea_Name;
            Console.Write("Enter Teacher Name>");
            Tea_Name = Console.ReadLine();
            Console.Write("\n");
        END: Console.WriteLine("Select any Two(2) Courses from the following.\n");
            int t1 = 0, t2 = 0;
            Console.WriteLine("1.Object Oriented Programming");
            Console.WriteLine("2.Calculus and Analytical Geometry");
            Console.WriteLine("3.Computer Logic Design");
            Console.WriteLine("4.Introduction to C-Language");
            Console.WriteLine("5.Linear Algebra");
            Console.WriteLine("6.Introduction to Software Engineering\n");
            Console.Write("Couse 1>");
            t1 = int.Parse(Console.ReadLine());
            Console.Write("Couse 2>");
            t2 = int.Parse(Console.ReadLine());
            if (t1 <= 6 && t2 <= 6 && t1 != 0 && t2 != 0)
            {
                Console.Clear();
                Console.WriteLine("Teacher Name>{0}", Tea_Name);
                Console.WriteLine("\nRegistered Courses are.");
                Console.Write("1.");
                if (t1 == 1)
                    Console.WriteLine("Object Oriented Programming");
                else if (t1 == 2)
                    Console.WriteLine("Calculus and Analytical Geometry");
                else if (t1 == 3)
                    Console.WriteLine("Computer Logic Design");
                else if (t1 == 4)
                    Console.WriteLine("Introduction to C-Language");
                else if (t1 == 5)
                    Console.WriteLine("Linear Algebra");
                else if (t1 == 6)
                    Console.WriteLine("Introduction to Software Engineering");

                Console.Write("2.");
                if (t2 == 1)
                    Console.WriteLine("Object Oriented Programming");
                else if (t2 == 2)
                    Console.WriteLine("Calculus and Analytical Geometry");
                else if (t2 == 3)
                    Console.WriteLine("Computer Logic Design");
                else if (t2 == 4)
                    Console.WriteLine("Introduction to C-Language");
                else if (t2 == 5)
                    Console.WriteLine("Linear Algebra");
                else if (t2 == 6)
                    Console.WriteLine("Introduction to Software Engineering");
            }
            else
            {
                Console.WriteLine("Invalid Selection. \nTry Again.\n");
                goto END;
            }
        }
    }
}
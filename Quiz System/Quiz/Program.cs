using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class QuizProgram
    {
        static void Main(string[] args)
        {
            QuizSystem Quiz = new QuizSystem();
            Console.ReadKey();
        }
    }
    class QuizSystem
    {
        public QuizSystem()
        {
            string name;
            string q1, q2, q3, q4, q5, q6, q7, q8, q9, q10;
            int RollNo, Marks = 0;

            Console.WriteLine("\t\tWelcome To General Knowledge Quiz\n\n");
            Console.Write("Enter Your Name>");
            name = Console.ReadLine();
            Console.Write("Enter Your Roll No.>");
            RollNo = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("\t\tGeneral Knowledge Quiz\n\n");
            Console.WriteLine("\nEnter A,B,C or D for answers.");
            Console.WriteLine("Every Question is of 2 Marks.\n\n");

            /*Multiple Choice Questions.*/
            //Q1.
            Console.WriteLine("1.What falling object is said to have inspired Isaac Newton's theories about gravity?");
            Console.WriteLine("A.Pineapple");
            Console.WriteLine("B.Plum");
            Console.WriteLine("C.Orange");
            Console.WriteLine("D.Apple");
            Console.Write("Answer>");
            q1 = Console.ReadLine();
            Console.Clear();

            //Q2.
            Console.WriteLine("\t\tGeneral Knowledge Quiz\n\n");
            Console.WriteLine("\n2.What color is a NYC taxi?");
            Console.WriteLine("A.Black");
            Console.WriteLine("B.Green");
            Console.WriteLine("C.Yellow");
            Console.WriteLine("D.Red");
            Console.Write("Answer>");
            q2 = Console.ReadLine();
            Console.Clear();

            //Q3.
            Console.WriteLine("\t\tGeneral Knowledge Quiz\n\n");
            Console.WriteLine("\n3.Where in the world does the largest tropical rainforest grow?");
            Console.WriteLine("A.Nak Pulau");
            Console.WriteLine("B.Amazon");
            Console.WriteLine("C.Taman Negara");
            Console.WriteLine("D.India");
            Console.Write("Answer>");
            q3 = Console.ReadLine();
            Console.Clear();

            //Q4.
            Console.WriteLine("\t\tGeneral Knowledge Quiz\n\n");
            Console.WriteLine("\n4.In which country do the famous pyramids of Giza stand?");
            Console.WriteLine("A.Egypt");
            Console.WriteLine("B.Syria");
            Console.WriteLine("C.Libya");
            Console.WriteLine("D.Lebanon");
            Console.Write("Answer>");
            q4 = Console.ReadLine();
            Console.Clear();

            //Q5.
            Console.WriteLine("\t\tGeneral Knowledge Quiz\n\n");
            Console.WriteLine("\n5.What kind of reptile is the chameleon?");
            Console.WriteLine("A.Tuatara");
            Console.WriteLine("B.Lizard");
            Console.WriteLine("C.Snake");
            Console.WriteLine("D.Turtle");
            Console.Write("Answer>");
            q5 = Console.ReadLine();
            Console.Clear();

            //Q6.
            Console.WriteLine("\t\tGeneral Knowledge Quiz\n\n");
            Console.WriteLine("\n6.What used to advertise its products as 'Fingerlickin good'?");
            Console.WriteLine("A.KFC");
            Console.WriteLine("B.McDonals");
            Console.WriteLine("C.Pizza Hut");
            Console.WriteLine("D.Burger King");
            Console.Write("Answer>");
            q6 = Console.ReadLine();
            Console.Clear();

            //Q7.
            Console.WriteLine("\t\tGeneral Knowledge Quiz\n\n");
            Console.WriteLine("\n7.In the Arabian Nights, who met with 40 thieves?");
            Console.WriteLine("A.Morgiana");
            Console.WriteLine("B.Baba Mustafa");
            Console.WriteLine("C.Ali Baba");
            Console.WriteLine("D.Cassim");
            Console.Write("Answer>");
            q7 = Console.ReadLine();
            Console.Clear();

            //Q8.
            Console.WriteLine("\t\tGeneral Knowledge Quiz\n\n");
            Console.WriteLine("\n8.According to the fairy tale, who had to leave the ball before midnight");
            Console.WriteLine("A.Red Riding Hood");
            Console.WriteLine("B.Snow White");
            Console.WriteLine("C.Cinderella");
            Console.WriteLine("D.Sleeping Beauty");
            Console.Write("Answer>");
            q8 = Console.ReadLine();
            Console.Clear();

            //Q9.
            Console.WriteLine("\t\tGeneral Knowledge Quiz\n\n");
            Console.WriteLine("\n9.Which is the highest mountain in the world");
            Console.WriteLine("A.Mount Everest");
            Console.WriteLine("B.K2");
            Console.WriteLine("C.Cho Oyu");
            Console.WriteLine("D.Manaslu");
            Console.Write("Answer>");
            q9 = Console.ReadLine();
            Console.Clear();

            //Q10.
            Console.WriteLine("\t\tGeneral Knowledge Quiz\n\n");
            Console.WriteLine("\n10.Which logo on a flag identifies a ship's crew as pirates?");
            Console.WriteLine("A.Hammer and Sickle");
            Console.WriteLine("B.Bull");
            Console.WriteLine("C.Lion");
            Console.WriteLine("D.Skull and Crossbones");
            Console.Write("Answer>");
            q10 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\t\tGeneral Knowledge Quiz\n\n");
            Console.Write("\nQuiz Completed.\nPress any key to procede to result calculation.");
            Console.ReadKey();
            Console.Clear();


            /*Result*/
            Console.WriteLine("\t\tGeneral Knowledge Quiz\n\n");
            Console.WriteLine("Question 1.");
            if (q1 == "D" || q1 == "d")
            {
                Console.WriteLine("Your Answer>{0}",q1);
                Console.WriteLine("Question 1 = Correct");
                Marks++;
            }
            else
            {
                Console.WriteLine("Your Answer>{0}",q1);
                Console.WriteLine("Correct Answer>D");
                Console.WriteLine("Question 1 = Wrong");
            }

            Console.WriteLine("\nQuestion 2.");
            if (q2 == "C" || q2 == "c")
            {
                Console.WriteLine("Your Answer>{0}", q2);
                Console.WriteLine("Question 2 = Correct");
                Marks++;
            }
            else
            {
                Console.WriteLine("Your Answer>{0}", q2);
                Console.WriteLine("Correct Answer>C");
                Console.WriteLine("Question 2 = Wrong");
            }

            Console.WriteLine("\nQuestion 3.");
            if (q3 == "B" || q3 == "b")
            {
                Console.WriteLine("Your Answer>{0}", q3);
                Console.WriteLine("Question 3 = Correct");
                Marks++;
            }
            else
            {
                Console.WriteLine("Your Answer>{0}", q3);
                Console.WriteLine("Correct Answer>B");
                Console.WriteLine("Question 3 = Wrong");
            }

            Console.WriteLine("\nQuestion 4.");
            if (q4 == "A" || q4 == "a")
            {
                Console.WriteLine("Your Answer>{0}", q4);
                Console.WriteLine("Question 4 = Correct");
                Marks++;
            }
            else
            {
                Console.WriteLine("Your Answer>{0}", q4);
                Console.WriteLine("Correct Answer>A");
                Console.WriteLine("Question 4 = Wrong");
            }

            Console.WriteLine("\nQuestion 5.");
            if (q5 == "B" || q5 == "b")
            {
                Console.WriteLine("Your Answer>{0}", q5);
                Console.WriteLine("Question 5 = Correct");
                Marks++;
            }
            else
            {
                Console.WriteLine("Your Answer>{0}", q5);
                Console.WriteLine("Correct Answer>B");
                Console.WriteLine("Question 5 = Wrong");
            }

            Console.WriteLine("\nQuestion 6.");
            if (q6 == "A" || q6 == "a")
            {
                Console.WriteLine("Your Answer>{0}", q6);
                Console.WriteLine("Question 6 = Correct");
                Marks++;
            }
            else
            {
                Console.WriteLine("Your Answer>{0}", q6);
                Console.WriteLine("Correct Answer>A");
                Console.WriteLine("Question 6 = Wrong");
            }

            Console.WriteLine("\nQuestion 7.");
            if (q7 == "C" || q7 == "c")
            {
                Console.WriteLine("Your Answer>{0}", q7);
                Console.WriteLine("Question 7 = Correct");
                Marks++;
            }
            else
            {
                Console.WriteLine("Your Answer>{0}", q7);
                Console.WriteLine("Correct Answer>C");
                Console.WriteLine("Question 7 = Wrong");
            }

            Console.WriteLine("\nQuestion 8.");
            if (q8 == "C" || q8 == "c")
            {
                Console.WriteLine("Your Answer>{0}", q8);
                Console.WriteLine("Question 8 = Correct");
                Marks++;
            }
            else
            {
                Console.WriteLine("Your Answer>{0}", q8);
                Console.WriteLine("Correct Answer>C");
                Console.WriteLine("Question 8 = Wrong");
            }

            Console.WriteLine("\nQuestion 9.");
            if (q9 == "A" || q9 == "a")
            {
                Console.WriteLine("Your Answer>{0}", q9);
                Console.WriteLine("Question 9 = Correct");
                Marks++;
            }
            else
            {
                Console.WriteLine("\nYour Answer>{0}", q9);
                Console.WriteLine("Correct Answer>A");
                Console.WriteLine("Question 9 = Wrong");
            }

            Console.WriteLine("\nQuestion 10.");
            if (q10 == "D" || q10 == "d")
            {
                Console.WriteLine("Your Answer>{0}", q10);
                Console.WriteLine("Question 10 = Correct");
                Marks++;
            }
            else
            {
                Console.WriteLine("Your Answer>{0}", q10);
                Console.WriteLine("Correct Answer>D");
                Console.WriteLine("Question 10 = Wrong");
            }
            Console.Write("\nPress any key to procede to summary...");
            Console.ReadKey();
            Console.Clear();



            /*Summary*/
            Console.WriteLine("\t\tGeneral Knowledge Quiz\n\n");
            Console.WriteLine("Student Name>{0}", name);
            Console.WriteLine("Roll No.>{0}", RollNo);
            Console.WriteLine("Correct Answers>{0}", Marks);
            Console.WriteLine("Marks>{0} out of 20.", Marks*2);
        }
    }
}

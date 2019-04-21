using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Linear Search.
namespace Linear_Search
{
    class Linear_Search
    {
        static void Main(string[] args)
        {
            int num2,i,j=0;
            string[] Arr = new[] {"10","20","30","40","50","60","70","80","90","100" };
            string num;
            Console.WriteLine("Hard Coded Arrays are 10, 20, 30, 40, 50, 60, 70, 80, 90 and 100.");
            Console.Write("Enter number to search in an array>");
            num = Console.ReadLine();
            num2 = int.Parse(num);
            for (i=0;i<10;i++)
            {
                if (Arr[i]==num)
                {
                    Console.WriteLine("Number is found at location>{0}", i+1);
                    break;
                }
                else
                {
                    j++;
                }
                if (j>=10)
                {
                    Console.WriteLine("Number not found in array.");
                }
            }
            Console.ReadKey();
        }
    }
}

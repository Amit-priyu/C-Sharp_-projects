using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1; int num2; int res;
            string answer;
            Console.WriteLine("cal program");
            Console.WriteLine("Enter 1st Num: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Num: ");
            num2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("what operation u like to do !");
            Console.WriteLine(" please enter a for addition, s for substration, m for multiplication or d for division");
            answer = Console.ReadLine();
            if (answer == "a")
            {
                res = num1 + num2;
            }
            else if (answer == "s")
            {
                res = num1 - num2;
            }
            else if (answer == "m")
            {
                res = num1 * num2;
            }
            else res = num1 / num2;
            Console.WriteLine("The Result is "+res);
            Console.WriteLine("thanks for using calculator for your program....");
            Console.ReadKey();
        }
    }
}

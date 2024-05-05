using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Shape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ans; float finaresult;
            Console.WriteLine("Enter the shape for which u  want to calculate the area: 'r' for reatangel , any other for the ciricle ");
            ans=Console.ReadLine();
            if (ans == "r")
            {
                Console.WriteLine("enter length of rectangle");
                float len=float.Parse(Console.ReadLine());
                Console.WriteLine("enter breadth of rectangle");
                float breadth = float.Parse(Console.ReadLine());
                finaresult = len * breadth;

            }
            else
            {
                Console.WriteLine("enter radius for radius");
                float rad=float.Parse(Console.ReadLine());
                finaresult = (float)Math.PI*rad * rad;
            }
            Console.WriteLine("Result : "+ finaresult);
            Console.ReadKey();
        }
    }
}

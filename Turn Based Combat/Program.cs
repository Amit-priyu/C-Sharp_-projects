using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turn_Based_Combat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player = 40; int enemy = 20;
            int playerattack = 5; int enemyattack = 7;
            int healamt = 5; 
            while(player > 0 && enemy > 0)
            {
                Console.WriteLine("Player turn");
                Console.WriteLine("enter 'a' for attack or 'h' for healing ");
                string choice = Console.ReadLine();
                if(choice == "a")
                {
                    enemy = enemy - playerattack;
                    Console.WriteLine("player attack enemy and deals "+playerattack +" damage");

                }
            } 
        }
    }
}

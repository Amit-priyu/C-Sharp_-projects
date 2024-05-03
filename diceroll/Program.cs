using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diceroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // generate two random number one for player and one for the enemy..
            int playrandomno; int enemeyrandomno;
            int playerpoint=0; int enemypoint=0;
            Random random=new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice");
                Console.ReadKey();
                playrandomno = random.Next(1, 7);
                Console.WriteLine("you rolled a " + playrandomno);

                Console.WriteLine("...");
                // make the system sleep for sometimes..
                System.Threading.Thread.Sleep(1000);
                enemeyrandomno = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + enemeyrandomno);

                if (playerpoint > enemypoint)
                {
                    playerpoint++;
                    Console.WriteLine("player wins.");
                }
                else if (playerpoint < enemypoint)
                {
                    enemypoint++;
                    Console.WriteLine("Enemy Wins...");
                }
                else
                {
                    Console.WriteLine("Draw.....");
                }
                Console.WriteLine("The Score is now -player: " + playerpoint + ". enemy : "+enemypoint);

            }
            if (playerpoint> enemypoint)
            {
                Console.WriteLine("You won");
            }
            else if (playerpoint < enemypoint)
            {
                Console.WriteLine("Lose");
            }
            else { Console.WriteLine("Draw"); }
            Console.ReadKey();

        }
    }
}

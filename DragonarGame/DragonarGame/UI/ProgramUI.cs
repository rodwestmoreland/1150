using DragonarGame.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonarGame.UI
{
    class ProgramUI
    {
        public void Run()
        {
            int points = 5000;
            int life = 3;
            int sum = 0;
            int count = 0;
            int hunterPoint = 0;
            int hunterSum = 0;

            string fileString = File.ReadAllText(@"gameFile.txt");
            string[] birds = fileString.Split(',');

            Dictionary<string, int> birdList = new Dictionary<string, int>
            {
                { "Bird",10 },
                { "EveningGrosbeak",1000 },
                { "GreaterPrairieChicken", 2000 },
                { "IcelandGull", 3000 },
                { "GreatKiskudee",300 },
                { "CrestedIbis", 100 },
                { "RedCrossbill",500 },
                { "RedneckedPhalarope",700 },
                { "OrangebelliedParrot", 5000 }
            };

            birdPlay(ref life, ref sum, ref count, ref hunterPoint, ref hunterSum, birds, birdList);

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Start points: {points}, Birds: {sum}, Hunters: {hunterSum}, Total {points + sum + hunterSum}");

            Console.ReadLine();
        }

        private static void birdPlay(ref int life, ref int sum, ref int count, ref int hunterPoint, ref int hunterSum, string[] birds, Dictionary<string, int> birdList)
        {
            foreach (var bird in birds)
            {
                if (bird == "VulnerableBirdHunter")
                {
                    count++;
                    for (int i = 0; i <= count; i++)
                    {
                        hunterPoint = ((int)Math.Pow(2, i)) * 100;
                    }
                    hunterSum = hunterPoint + hunterSum;
                    Console.WriteLine("\n-- Hunter capture " + hunterSum);
                    Console.WriteLine();
                }
                else if (bird == "InvincibleBirdHunter")
                {
                    life--;
                    Console.WriteLine("\n - Invincible Hunter! ");
                    Console.WriteLine("  - lives left: " + life);
                    Console.WriteLine();
                    if (life < 1) { Console.WriteLine(" ** GAME OVER **"); break; }
                }

                else
                {
                    sum += birdList[bird];
                    Console.WriteLine(bird + " caught");
                }
            }
        }//method birdPlay
    }//class
}

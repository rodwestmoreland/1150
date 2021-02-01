using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Classes
{
    class Greeter
    {
        Random _random = new Random();

        public void SaySomthing(string name)
        {
            Console.WriteLine($"{GetRandomGreeting()}, {name}");
        }


        public void SayHello(string name)
        {
            Console.WriteLine($"hi {name}");
        }

        private string GetRandomGreeting()
        {
            string[] greetings = new string[] { "hi", "What up", "How are you", "sup?", "what do you want?" };
            int randNum = _random.Next(0, greetings.Length);
            //string rGreeting = greetings.ElementAt(randNum);
            return greetings[randNum];
        }

        

    }
}

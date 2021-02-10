using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtLibs
{
    class NewtStory4
    {
        public static List<string> Story()
        {
            var setTitle = new Message("Story 4");
            setTitle.SetStoryTitle();

            List<string> words = new List<string>();

            Console.WriteLine("Enter an athlete's name");
            words.Add(Console.ReadLine()); //0
            Console.WriteLine("Enter a famous singer's name");
            words.Add(Console.ReadLine()); //1
            Console.WriteLine("Enter a adjective");
            words.Add(Console.ReadLine()); //2
            Console.WriteLine("Enter a noun");
            words.Add(Console.ReadLine()); //3
            Console.WriteLine("Enter an emotion");
            words.Add(Console.ReadLine()); //4
            Console.WriteLine("Enter a plural noun (living thing)");
            words.Add(Console.ReadLine()); //5
            Console.WriteLine("Enter a noun plural");
            words.Add(Console.ReadLine()); //6
            Console.WriteLine("Enter an emotion");
            words.Add(Console.ReadLine()); //7
            Console.WriteLine("Enter a place");
            words.Add(Console.ReadLine()); //8
            Console.WriteLine("Enter a liquid");
            words.Add(Console.ReadLine()); //9
            Console.WriteLine("Enter a year in the future");
            words.Add(Console.ReadLine()); //10
            return words;
        }

    }
}

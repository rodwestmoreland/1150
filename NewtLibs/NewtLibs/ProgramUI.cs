using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtLibs
{
    public class ProgramUI
    {
        
        public void RunMenu()
        {

            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine("Welcome to NewtLibs! The game where ___. Which NewtLib would you like? \n\n" +
                        "1. Story 1\n" +
                        "2. Story 2\n" +
                        "3. Story 3\n" +
                        "4. Story 4\n" +
                        "5. Story 5\n" +
                        "6. Story 6\n" +
                        "7. Random Story\n" +
                        "8. Exit");

                int userStory = Convert.ToInt32(Console.ReadLine());

                if (userStory == 8)
                { Environment.Exit(0); }
                else if(userStory > 0 && userStory < 8)
                {
                    CreateStory(userStory);
                } else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a number 1 - 8");
                    Console.WriteLine();
                }
                

            }// \while
        }// \Run Menu

        public void CreateStory(int select)
        {

            List<string> words = new List<string>();
            int selector = select;

            switch (selector) //Our questions
            {
                case 1:
                    words = NewtStory1.Story();
                    break;
                case 2:
                    words = NewtStory2.Story();
                    break;
                case 3:
                    words = NewtStory3.Story();
                    break;
                //case 4:
                //    words = NewtStory4.Story();
                //    break;
                //case 5:
                //    words = NewtStory5.Story();
                //    break;
                //case 6:
                //    words = NewtStory6.Story();
                //    break;
            }
            

            var storyComplete = new Dictionary<int, string>()
            {
                {
                   1, $"This morning {words[0]} woke up feeling {words[7]}. 'It is going to be a {words[2]} day!'\n" +
                $"Outside, a bunch of {words[5]} were protesting to keep {words[6]} in stores. They began to sway \n" +
                $"to the rhythm of the {words[3]}, which made all the {words[5]} very {words[4]}. Concerned, {words[0]} \n" +
                $"texted {words[1]}, who flew to {words[8]} and dropped {words[6]} in a puddle of frozen {words[9]}. \n" +
                $"{words[1]} woke up in the year {words[10]}, in a world where {words[5]} ruled the world."
                },
                {
                   2, $"YESTERDAY morning {words[0]} woke up feeling {words[7]}. 'It is going to be a {words[2]} day!'\n" +
                $"Outside, a bunch of {words[5]} were protesting to keep {words[6]} in stores. They began to sway \n" +
                $"to the rhythm of the {words[3]}, which made all the {words[5]} very {words[4]}. Concerned, {words[0]} \n" +
                $"texted {words[1]}, who flew to {words[8]} and dropped {words[6]} in a puddle of frozen {words[9]}. \n" +
                $"{words[1]} woke up in the year {words[10]}, in a world where {words[5]} ruled the world."
                }
            };

            Console.WriteLine(storyComplete[selector]);
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();

        }// \createStory






    }// \class
}

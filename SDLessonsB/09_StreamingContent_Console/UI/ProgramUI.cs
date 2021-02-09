using _07_RepoPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Console.UI
{
    public class ProgramUI
    {
        private readonly CT_Repo _repo = new CT_Repo();
        public void Run()
        {
            SeedContentList();
            RunMenu();
        }
        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            
            {
                Console.Clear();
                Console.WriteLine("Enter the number of the option you'd like to select:\n" +
                    "1. Show all streaming content\n" +
                    "2. Find streaming content by title\n" +
                    "3. Add new streaming content\n" +
                    "4. Update content by title\n" +
                    "5. Remove streaming content\n" +
                    "6. Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ShowAll();
                        break;
                    case "2":
                        ShowByTitle();
                        break;
                    case "3":
                        CreateContent();
                        break;
                    case "4":
                        UpdateContent();
                        break;
                    case "5":
                        DeleteContent();
                        break;
                    case "6":
                        continueToRun = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 1 and 5.");
                        Console.ReadKey();
                        break;
                }// \switch
            }// \while
        } // \RunMenu

// ***** Create 
        private void CreateContent()
        { 
            StreamingContent content = new StreamingContent();
            AddContentDetails(content);
            _repo.AddContentToDirectory(content);   
        }

// ***** Read
        private void ShowAll()
        {
            List<StreamingContent> listContent = _repo.GetContents();
            
            foreach (StreamingContent content in listContent)
            {
                DisplayContent(content);
            }
            Console.ReadKey();
        }

// ***** Read - filter title
        private void ShowByTitle(string title = "none")
        {
            title = SetTitle();

            StreamingContent content = _repo.GetContentByTitle(title);

            if (content != null)
            {
                DisplayContent(content);
            }
            else
            {
                Console.WriteLine("not found");
            }
            Console.ReadKey();
        }

// ***** Update
        private void UpdateContent(string title = "none")
        {
            title = SetTitle();
            Console.WriteLine(title);
            StreamingContent content = _repo.GetContentByTitle(title);
            DisplayContent(content);

            Console.WriteLine();
            Console.WriteLine("Make Changes");

            AddContentDetails(content);

            _repo.AddContentToDirectory(content);

        }

// ***** Delete
        private void DeleteContent()
        {
            string title = SetTitle();

            bool isGone = _repo.DeleteContent(title);
            Console.WriteLine(!isGone ? "Not found" : "Deleted");
        }

        
        

//  **** helper methods  ********************

        private void DisplayContent(StreamingContent content)
        {
            Console.WriteLine($"Title {content.Title}\n" +
                                $"Desc {content.Desc}\n" +
                                $"Genre {content.Genre}\n" +
                                $"Star rating {content.Stars}\n" +
                                $"Maturity {content.Maturity}\n");
        }

        private static string SetTitle()
        {
            Console.Clear();
            Console.WriteLine("Enter a title");
            string title = Console.ReadLine();
            return title;
        }


        private static void AddContentDetails(StreamingContent content)
        {
            Console.WriteLine("Enter a title");
            content.Title = Console.ReadLine();
            Console.WriteLine("Enter a description");
            content.Desc = Console.ReadLine();
            Console.WriteLine("Enter a star rating");
            content.Stars = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter a maturity rating");
            Console.WriteLine("\n" +
                                "1. G\n" +
                                "2. PG\n" +
                                "3. PG13\n" +
                                "4. NC17\n" +
                                "5. R\n");
            string maturityString = Console.ReadLine();
            int maturityId = int.Parse(maturityString);
            content.Maturity = (MaturityType)maturityId;

            Console.WriteLine("Enter a genre");
            Console.WriteLine("\n" +
                                "1. Kids\n" +
                                "2. Drama\n" +
                                "3. Suspense\n" +
                                "4. Western\n" +
                                "5. Horror\n" +
                                "6. Comedy\n" +
                                "7. SciFi");
            string genreString = Console.ReadLine();
            int genreId = int.Parse(genreString);
            content.Genre = (GenreType)genreId;
        }

        private void SeedContentList()
        {
            StreamingContent starwars = new StreamingContent("starwars", "space stuff", MaturityType.PG, 5, GenreType.SciFi);
            StreamingContent starwars2 = new StreamingContent("Star Wars II", "space stuff", MaturityType.PG, 5, GenreType.SciFi);
            _repo.AddContentToDirectory(starwars);
            _repo.AddContentToDirectory(starwars2);
        }

    } //class
}

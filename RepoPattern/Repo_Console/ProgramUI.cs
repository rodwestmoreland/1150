using RepoPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo_Console
{
    class ProgramUI
    {
        private readonly StreamingRepo          _repoContent = new StreamingRepo();
        private readonly StreamingContent       _streamContent = new StreamingContent();
        private List<StreamingContent>          _listContent = new List<StreamingContent>();

        public void Run()
        {
            SeedContent();
            Menu();
        }
        public void Menu()
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

        }// \Menu

        public void CreateContent()
        {
            AddContentDetails(_streamContent);

            _repoContent.AddContent(_streamContent);
        }

        public void ShowAll()
        {
            _listContent = _repoContent.GetContents();
                        
            foreach(StreamingContent item in _listContent)
            {

                Console.WriteLine($"Title {item.Title}\n" +
                                    $"Desc {item.Desc}\n" +
                                    $"Genre {item.Genre}\n" +
                                    $"Star rating {item.Stars}\n" +
                                    $"Maturity {item.MaturityRating}\n");
            }
            Console.ReadKey();
        }

        public void ShowByTitle()
        {
            Console.WriteLine("Enter a title");
            string getTitle = Console.ReadLine();
            var getContent = _repoContent.GetContentByTitle(getTitle);
            Console.WriteLine($"Title {getContent.Title}\n" +
                                $"Desc {getContent.Desc}\n" +
                                $"Genre {getContent.Genre}\n" +
                                $"Star rating {getContent.Stars}\n" +
                                $"Maturity {getContent.MaturityRating}\n");
            Console.WriteLine("work?");
            Console.ReadKey();
            
        }

        public void UpdateContent()
        {
            Console.WriteLine("enter title");
            string getTitle = Console.ReadLine();
            var updateContent = _repoContent.GetContentByTitle(getTitle);
            Console.WriteLine("Edit content: " + updateContent.Title);
            AddContentDetails(updateContent);
            _repoContent.UpdateContents(getTitle, _streamContent);
        }
        
        public void DeleteContent()
        {
            Console.WriteLine("Enter title to delete");
            string getTitle = Console.ReadLine();
            Console.WriteLine(_repoContent.DeleteContent(getTitle)
                                ? "content deleted"
                                : "something went wrong");
            Console.ReadKey();
        }


        private void AddContentDetails(StreamingContent content)
        {
            Console.WriteLine("Enter a title");
            _streamContent.Title = Console.ReadLine();
            Console.WriteLine("Enter a description");
            _streamContent.Desc = Console.ReadLine();
            Console.WriteLine("Enter a star rating");
            _streamContent.Stars = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a maturity rating");
            _streamContent.MaturityRating = Console.ReadLine();
            Console.WriteLine("Enter a genre");
            Console.WriteLine("\n" +
                                "1. Action\n" +
                                "2. Comedy\n" +
                                "3. Drama\n" +
                                "4. SciFi\n" +
                                "5. Western\n");
            string genreString = Console.ReadLine();
            int genreId = int.Parse(genreString);
            _streamContent.Genre = (GenreType)genreId;

            
        }

        public void SeedContent()
        {
            StreamingContent seedContent1 = new StreamingContent("Star Trek", "Space movie", "PG", 4, true, GenreType.SciFi);
            StreamingContent seedContent2 = new StreamingContent("un", "Dark Western", "R", 5, false, GenreType.Western);
            _repoContent.AddContent(seedContent2);
            _repoContent.AddContent(seedContent1);
        }
    }
}

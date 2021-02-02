using _07_RepoPattern;
using _07_RepoPattern.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _08_RepoPattern_Tests
{
    [TestClass]
    public class CRUDtests
    {
        StreamingContent_Repo _repo;
        StreamingContent _content;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContent_Repo();
            StreamingContent newMovie1 = new StreamingContent(
                                "Nerd Quest",
                                "Sci-fi movie - comedy",
                                MaturityType.PG13,
                                3,
                                GenreType.SciFi);

            _repo = new StreamingContent_Repo();
            StreamingContent newMovie2 = new StreamingContent(
                                "Hitchhikers Guide",
                                "Weird space comedy",
                                MaturityType.R,
                                5,
                                GenreType.Comedy);

            _repo = new StreamingContent_Repo();
            StreamingContent newMovie3 = new StreamingContent(
                                "Unforgiven",
                                "Dark western",
                                MaturityType.R,
                                5,
                                GenreType.Western);

            _repo.AddContentToDirectory(newMovie1);
            _repo.AddContentToDirectory(newMovie2);
            _repo.AddContentToDirectory(newMovie3);

            _content = new StreamingContent();

            StreamingContent newMovie4 = new StreamingContent(
                                "WTH",
                                "Mystery",
                                MaturityType.G,
                                2,
                                GenreType.Horror);
            _repo.AddContentToDirectory(_content);
            Console.WriteLine("Anything here now?");

            Console.WriteLine(_repo.ContentCount);
            Console.WriteLine("Titles : " + _repo.GetContents());
            List<StreamingContent> family = _repo.GetFamily();
            foreach (StreamingContent movie in family)
            {
                Assert.IsTrue(movie.IsFamilyFriendly);
            }
            Assert.AreEqual(2, family.Count);

            Show show = new Show();
            show.Title = "The New Show";
            show.SeasonCount = 4;

            Episode episode1 = new Episode();
            episode1.Title = "Roadwarrior";
            Episode episode2 = new Episode();
            episode2.Title = "Dingus";

            _repo.AddContentToDirectory(show);
        }

        [TestMethod]
        public void TestMethod1()
        {

            //StreamingContent    content = new StreamingContent(
            //                    "Galaxy Quest",
            //                    "Sci-fi movie - comedy",
            //                    MaturityType.PG13,
            //                    5,
            //                    GenreType.Comedy);

            //bool wasAdded = _repo.AddContentToDirectory(content);
            //Console.WriteLine(_repo.ContentCount) ;
            //Console.WriteLine(wasAdded);
            //Console.WriteLine(content.Title);
            
        }

        [TestMethod]
        public void TestGetTitle()
        {
            StreamingContent search = _repo.GetContentByTitle("WTH");

            
        }



        [TestMethod]
        public void UpdateContent()
        {
            StreamingContent updateMovie = new StreamingContent("Unforgiven","a new description",MaturityType.G,3,GenreType.Kids);
            bool wasUpdated = _repo.UpdateContent("Unforgiven", updateMovie);

            Assert.IsTrue(wasUpdated);
            StreamingContent updatedMovie = _repo.GetContentByTitle("Unforgiven");
            Console.WriteLine(updateMovie.Desc);
        }

        [TestMethod]
        public void DeleteContent()
        {
            bool wasDeleted = _repo.DeleteContent("Unforgiven");

            Assert.IsTrue(wasDeleted);
        }




    }
}

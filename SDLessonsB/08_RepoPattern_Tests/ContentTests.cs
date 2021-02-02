using _07_RepoPattern;
using _07_RepoPattern.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _08_RepoPattern_Tests
{
    
    [TestClass]
    public class ContentTests

    {
        private Show _testShow;
        [TestInitialize]
        public void Seed()
        {
            _testShow = new Show(

                );
            _testShow.Title = "Dragons";
            _testShow.Desc = "A show about flying lizards";
            Episode epiOne = new Episode();
            epiOne.Title = "Dread";
            epiOne.RunTime = 50.0;
            Episode epiTwo = new Episode();
            epiTwo.Title = "Doom. ep2";
            epiTwo.RunTime = 50.0;
            Episode epiThree = new Episode();
            epiThree.Title = "Dead. the end";
            epiThree.RunTime = 50.0;
            _testShow.Episodes.Add(epiThree);
            _testShow.Episodes.Add(epiOne);
            _testShow.Episodes.Add(epiTwo);

        }
        [TestMethod]
        public void IsFamily()
        {
            //arrange
            StreamingContent content = new StreamingContent();

            //act
            content.Maturity = MaturityType.R;
            //assert
            Assert.IsFalse(content.IsFamilyFriendly);

        }
        [TestMethod]
        public void SetTitle_ShoudGetCorrectString()
        {
            //arrange
            StreamingContent content = new StreamingContent();
            //act
            content.Title = "Toy Story";
            //assert
            string expected = "Toy Story";
            string actual = content.Title;
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(MaturityType.G,true)]
        [DataRow(MaturityType.NC17, false)]
        [DataRow(MaturityType.R, false)]
        public void SetMaturity_CheckFamilyFriendly(MaturityType rating, bool expectedFriendly)
        {
            StreamingContent    content = new StreamingContent();
            content.Maturity =  rating;
            bool actual =       content.IsFamilyFriendly;
            bool expected =     expectedFriendly;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void TestShows()
        {
            //Arrange (in seed method above)
            //Act       " "
            //Assert
            Assert.AreEqual(3, _testShow.EpisodeCount);
            Assert.AreEqual(50.0, _testShow.AvgRunTime);
        }
    }
}

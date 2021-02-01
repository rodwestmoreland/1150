using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool hungry = false;
            string feed = "not hungry";
            if (hungry)
            {
                feed = "feed me";
            }
            Console.WriteLine(feed);
            
        }
        [TestMethod]
        public void IfElseStatement()
        {
            bool hungry = false;
            string feed;
            if (hungry)
            {
                feed = "feed me";
            } else
            {
                feed = "not hungry";
            }
            Console.WriteLine(feed);

        }
    }
}

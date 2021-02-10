using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Repo_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HowOld(new DateTime(1970,10,10));
        }

        [TestMethod]
        public static void HowOld(DateTime date)
        {
            TimeSpan age = DateTime.Now - date;
            Console.WriteLine(age);
        }
    }
}

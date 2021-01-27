using _05_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Tests
{
    [TestClass]
    public class GreeterTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Greeter greeter = new Greeter();
            greeter.SayHello("Andy");

            greeter.SaySomthing("dude");
        }
    }
}

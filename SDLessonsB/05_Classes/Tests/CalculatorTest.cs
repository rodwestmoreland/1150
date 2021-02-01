using _05_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculator calcThis = new Calculator();
            var sum = calcThis.Add(2, 40);
            var sub = calcThis.Sub(4, 41);
            Console.WriteLine($"2 + 40 = {sum} and 4 - 41 = {sub}");
        }
    }
}

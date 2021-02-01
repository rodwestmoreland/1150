using _05_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_Classes.Tests
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void NameTest()
        {
            Person person = new Person("al","Yankovic",new DateTime(1959,11,1));
            var first = person.FirstName = "Doug";
            var last = person.LastName = "Adams";
            Console.WriteLine($"{first} - {last}");
            Console.WriteLine(person.LastName);
            Console.WriteLine( person.FullName + " " + person.DateOfBirth + ". He is " + person.Age);
        }
    }
}

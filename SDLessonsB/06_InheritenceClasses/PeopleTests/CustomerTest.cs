using _06_InheritenceClasses.People;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_InheritenceClasses.PeopleTests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            User user = new Customer("r@email.com");
            Customer customer = new Customer("customer@email.com");
            customer.setFirstName("rod");

            Console.WriteLine($"user id: {user.Id} email: {user.Email}");
            Console.WriteLine($"user id: {customer.Id} name: {customer.Name}");
        }
    }
}

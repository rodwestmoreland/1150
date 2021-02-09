

using _07_RepoPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _08_RepoPattern_Tests
{
    [TestClass]
    public class CT_CRUDtests
    {
        CustomerTracker_Repo _repoCustomer;
        CustomerTracker _contentCustomer;

        [TestInitialize]
        public void Seed()
        {
            _repoCustomer = new CustomerTracker_Repo();
            CustomerTracker cust1 = new CustomerTracker(
                                "Henry",
                                1,
                                33,
                                new DateTime(2006, 10, 10)
                                );

            _repoCustomer = new CustomerTracker_Repo();
            CustomerTracker cust2 = new CustomerTracker(
                                "Roberts",
                                2,
                                43,
                                new DateTime(2020, 10, 10)
                                );

            _repoCustomer = new CustomerTracker_Repo();
            CustomerTracker cust3 = new CustomerTracker(
                                "Phillips",
                                3,
                                53,
                                new DateTime(2021, 1, 10)
                                );

            _repoCustomer.AddCustomerToDirectory(cust1);
            _repoCustomer.AddCustomerToDirectory(cust2);
            _repoCustomer.AddCustomerToDirectory(cust3);

            _contentCustomer = new CustomerTracker();

            Console.WriteLine("Names : " + _repoCustomer.GetContents());
            
        }

       

        [TestMethod]
        public void TestGetTitle()
        {
            CustomerTracker search = _repoCustomer.GetContentById(1);            
        }

        [TestMethod]
        public void UpdateContent()
        {
            CustomerTracker updateCustomer = new CustomerTracker();
            bool wasUpdated = _repo.UpdateContent("Unforgiven", updateMovie);

            Assert.IsTrue(wasUpdated);
            CustomerTracker updatedMovie = _repo.GetContentByTitle("Unforgiven");
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

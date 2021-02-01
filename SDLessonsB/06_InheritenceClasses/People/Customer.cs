using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InheritenceClasses.People
{
    public class Customer:User
    {
        public int CustId { get; set; }

        public Customer(string email):base(email)
        {
            CustId = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepoPattern
{
    //id, name, age, enroll date, Num of years with Komodo
    //send message: if NoY < 5 => send thank you
    //send message: if NoY > 5 => send thanks for being Gold Member

    public class CustomerTracker
    {
       
        public string LastName { get; set; }
        public int Id { get;  }
        public int Age { get; set; }
        public DateTime DateEnrolled { get; set; }
        public int ClientLongevity 
        {
            get { return (int)((DateTime.Now - DateEnrolled).TotalDays / 365.255); }
        }
        public string Thanks
        {
            get { return ClientLongevity >= 5 ? "Thanks for being a Gold Member" : "Thanks for choosing Komodo";  }
        }

        public CustomerTracker(){}
        public CustomerTracker(string lastName, int id, int age, DateTime dateEnrolled)
        {
            LastName =      lastName;
            Id =            id;
            Age =           age;
            DateEnrolled =  dateEnrolled;
        }
    }
}

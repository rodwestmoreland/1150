using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes.Classes
{
    public class Person
    {
        public string   FirstName { get; set; }
        
        private string  _lastName;
        public string   LastName {
            get { return " set lastName? > " + _lastName ; }
            set { _lastName = value ; }
    }
        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.241;
                int yearsOfAge = Convert.ToInt32(totalAgeInYears);
                return yearsOfAge;
            }
        }

        public DateTime DateOfBirth { get; set; }

        public string FullName 
            { get { return $"{FirstName} {LastName}"; } }

        public Person(string firstName, string lastName, DateTime dob)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
        }


    }
}

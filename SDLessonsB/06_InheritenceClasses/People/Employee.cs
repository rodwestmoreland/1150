using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_InheritenceClasses.People
{
    public class Employee:User
    {
        public int EmployeeNumber { get; set; }
        public DateTime HireDate { get; set; }
        public int YearsAtCompany 
        {
            get { 
                double totalTime = (DateTime.Now - HireDate).TotalDays / 365.24;
                return Convert.ToInt32(Math.Floor(totalTime)) ;
            }
        }

        public Employee(string email):base(email)
        {

        }
    }//end Employee class

    public class HourlyEmployee : Employee
    {
        public decimal HourlyWage { get; set; }
        public double HoursWorked { get; set; }

        public HourlyEmployee(string email):base(email)
        {

        }
    }

    public class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }

        public SalaryEmployee(string email) : base(email)
        {

        }
    }
}

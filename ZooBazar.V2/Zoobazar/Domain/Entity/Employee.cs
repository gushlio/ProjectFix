using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Employee : User
    {
        public double Salary { get; set; }
        public DateTime HireDate { get; set; }
        public string JobTitle { get; set; }

        public Employee(int id, string firstName, string lastName, string emailAddress, string password,
                        double salary, DateTime hireDate, string jobTitle)
            : base(id, firstName, lastName, emailAddress, password)
        {
            Salary = salary;
            HireDate = hireDate;
            JobTitle = jobTitle;
        }
    }
}

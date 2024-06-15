using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Contract
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Salary { get; set; }
        public string JobTitle { get; set; }

        public Contract(int id, string title, DateTime startDate, DateTime endDate, double salary, string jobTitle)
        {
            Id = id;
            Title = title;
            StartDate = startDate;
            EndDate = endDate;
            Salary = salary;
            JobTitle = jobTitle;
        }
    }
}

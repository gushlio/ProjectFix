using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTOs
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public double Salary { get; set; }
        public DateTime HireDate { get; set; }
        public string JobTitle { get; set; }
    }
}

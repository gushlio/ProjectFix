using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Employee : User
    {
        public Contract Contract { get; set; }
        public DateTime Birthday { get; set; }
        public string ContactInfo { get; set; }

        public Employee(int id, string firstName, string lastName, string emailAddress, string password,
                    DateTime birthday, string contactInfo)
        : base(id, firstName, lastName, emailAddress, password)
        {
            Birthday = birthday;
            ContactInfo = contactInfo;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class ConcreteUser : User
    {
        public string Username { get; set; }
        public string PassWord {  get; set; }

        public ConcreteUser(string userName, string password) : base(userName, password)
        {
            Username = userName;
            PassWord = password;
        }
    }
}
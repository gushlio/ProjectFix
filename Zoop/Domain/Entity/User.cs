using System;

namespace Domain.Entity
{
    public abstract class User
    {
        public int Id { get; private set; }
        public string Username { get; set; } = string.Empty; // Initialize non-nullable property
        public string FirstName { get; set; } = string.Empty; // Initialize non-nullable property
        public string LastName { get; set; } = string.Empty; // Initialize non-nullable property
        public string EmailAddress { get; set; } = string.Empty; // Initialize non-nullable property
        public string Password { get; set; } = string.Empty; // Initialize non-nullable property

        protected User(int id, string firstName, string lastName, string username ,string emailAddress, string password)
        {
            Id = id;
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Password = password;
        }

        protected User(string userName, string password)
        {
            Username = userName;
            Password = password;
        }

        protected User(int id, string firstName, string lastName, string emailAddress, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Password = password;
        }
    }
}
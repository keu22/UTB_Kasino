using Kasino.Application.Abstraction;
using Kasino.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kasino.Application.Implementation
{
    public class UserService : IUserService
    {
        public List<User> GetAll()
        {
            return new List<User>
            {
                new User
                {
                    Id = 1,
                    FirstName = "Alice",
                    LastName = "Johnson",
                    Username = "alicej",
                    Password = "password123",
                    Email = "alice@example.com",
                    Balance = 500
                },
                new User
                {
                    Id = 2,
                    FirstName = "Bob",
                    LastName = "Smith",
                    Username = "bobsmith",
                    Password = "securepass",
                    Email = "bob@example.com",
                    Balance = 1200
                },
                new User
                {
                    Id = 3,
                    FirstName = "Charlie",
                    LastName = "Brown",
                    Username = "charlieb",
                    Password = "charliepass",
                    Email = "charlie@example.com",
                    Balance = 300
                },
                new User
                {
                    Id = 4,
                    FirstName = "Diana",
                    LastName = "Miller",
                    Username = "dianam",
                    Password = "diana123",
                    Email = "diana@example.com",
                    Balance = 950
                },
                new User
                {
                    Id = 5,
                    FirstName = "Ethan",
                    LastName = "Williams",
                    Username = "ethanw",
                    Password = "ethanpass",
                    Email = "ethan@example.com",
                    Balance = 780
                }
            };
        }
    }
}

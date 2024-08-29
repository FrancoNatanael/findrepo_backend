﻿namespace Findrepo.Domain.Entities.User
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string email, string password)
        {
            Id = new Random().Next(1,50);
            Email = email;
            Password = password;
        }
    }
}

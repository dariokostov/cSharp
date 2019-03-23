using System;
using System.Collections.Generic;
using System.Linq;
using Library.Enums;

namespace Library.Classes
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public Role Role { get; set; }
        public User(string username, string password, int age)
        {
            this.Username = username;
            this.Password = password;
            this.Age = age;
            this.Role = Role;
        }

       
    }
}

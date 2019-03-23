using System;
using Library.Enums;

namespace Library.Classes
{
    public class Trainer : User
    {
        public Trainer(string username, string password, int age) : base(username, password, age)
        {
            this.Role = Role.Trainer;
        }
    }
}

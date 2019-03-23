using System;
using System.Collections.Generic;
using Library.Enums;

namespace Library.Classes
{
    public class Admin : User
    {
        public List<User> Trainers { get; set; }
        public List<User> Students { get; set; }
        public Admin(string username, string password, int age, List<User> trainers, List<User> students) : base(username, password, age)
        {
            this.Role = Role.Admin;
            this.Trainers = trainers;
            this.Students = students;
        }

        public void Add()
        {
            Console.WriteLine("ADD method");
        }


        public void Remove()
        {

        }
    }

}

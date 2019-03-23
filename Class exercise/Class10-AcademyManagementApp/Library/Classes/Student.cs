using System;
using System.Collections.Generic;
using Library.Enums;

namespace Library.Classes
{
    public class Student : User
    {
        public Student(string username, string password, int age) : base(username, password, age)
        {
            this.Role = Role.Student;
        }
    }
}

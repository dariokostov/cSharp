using System;
namespace Library.Classes
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Human(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string GetPersonStats()
        {
            return $"{FirstName} {LastName} {Age}";
        }
    }
}

using System;
using Library.Enums;

namespace Library.AllClasses
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string PrintInfo()
        {
            return $"First Name: {FirstName} \nLast Name: {LastName} \nSalary: {Salary}";
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}

using System;
using Library.Enums;

namespace Library.AllClasses
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }

        public Manager(string firstName, string lastName) : base(firstName, lastName)
        {
            this.Role = Role.Manager;
            this.Salary = 500;
        }

        public void AddBonus()
        {
            this.Bonus = 2000;
        }

        public override double GetSalary()
        {
            return base.GetSalary() + this.Bonus;
        }
    }
}

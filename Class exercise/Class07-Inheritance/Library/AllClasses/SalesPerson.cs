using System;
using Library.Enums;
namespace Library.AllClasses
{
    public class SalesPerson : Employee
    {

        private double SuccessSaleRevenue { get; set; }

        public SalesPerson(string firstName, string lastName) : base(firstName, lastName)
        {
            this.Role = Role.Sales;
            this.Salary = 500;
        }

        public void AddSuccessRevenue(double revenue)
        {
            this.SuccessSaleRevenue = revenue;
        }

        public override double GetSalary()
        {
            return base.GetSalary() + CalculateBonus();
        }

        private double CalculateBonus()
        {
            if (SuccessSaleRevenue <= 2000)
            {
                return 500;
            }
            else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                return 1000;
            }
            return 1500;
        }
    }
}

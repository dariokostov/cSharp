using System;

namespace Exercise05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Make a method called AgeCalculator
            //The method will have one input parameter, your birthday date
            //The method should return your age
            //Show the age of a user after he inputs a date
            //Note: take into consideration if the birthday is today, after or before today
            Console.Write("Enter day of birth: ");
            int InputDay = int.Parse(Console.ReadLine());
            Console.Write("Enter month of birth: ");
            int InputMonth = int.Parse(Console.ReadLine());
            Console.Write("Enter year of birth: ");
            int InputYear = int.Parse(Console.ReadLine());

            DateTime Birthday = new DateTime(InputYear, InputMonth, InputDay);

            Console.WriteLine($"You are {AgeCalculator(Birthday)} years old.");             Console.ReadLine();
        }

        public static int AgeCalculator(DateTime birthday)
        {
            DateTime Today = DateTime.Now;

            if (birthday.Month > Today.Month)
            {
                return Today.Year - (birthday.Year + 1);
            } 
            else if(birthday.Month == Today.Month)
            {
                if(birthday.Day > Today.Day)
                {
                    return Today.Year - (birthday.Year + 1);
                } 
                else if(birthday.Day == Today.Day)
                {
                    Console.WriteLine("Happy birthday!!!");
                }
            }
            return Today.Year - birthday.Year;
        }
    }
}

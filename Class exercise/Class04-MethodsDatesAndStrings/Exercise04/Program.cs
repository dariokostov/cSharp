using System;

namespace Exercise04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Print the date that is 3 days from now
            //Print the date that is one month from now
            //Print the date that is one month and 3 days from now
            //Print 1 year and 2 months ago from today
            //Print only the current month with words
            //Print only the current year

            DateTime Today = DateTime.Now;

            Console.WriteLine(Today.AddDays(3));
            Console.WriteLine(Today.AddMonths(1));
            Console.WriteLine(Today.AddMonths(1).AddDays(3));
            Console.WriteLine(Today.AddYears(1).AddMonths(2));
            Console.WriteLine(Today.ToString("MMMM"));
            Console.WriteLine(Today.Year);

            Console.ReadLine();
        }
    }
}

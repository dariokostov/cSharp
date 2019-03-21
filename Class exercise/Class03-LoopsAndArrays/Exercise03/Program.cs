using System;

namespace Exercise03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Get an input from the console
            //Print all numbers from 1 to that number
            //Don’t print numbers that can be divided by 3 or 7
            //If the number gets to 100 print a message: The limit is reached and stop counting

            int input = int.Parse(Console.ReadLine());
            if(input > 100)
            {
                input = 100;
            }

            for (int i = 1; i <= input; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace Exercise01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Get an input number from the console
            //Print all numbers from 1 to that number
            //Get another input number from the console
            //Print all numbers from that number to 1

            int inputNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= inputNumber; i++)
            {
                Console.WriteLine(i);
            }

            int SecondInputNumber = int.Parse(Console.ReadLine());
            for (int i = SecondInputNumber; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

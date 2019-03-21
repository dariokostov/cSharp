using System;

namespace Exercise02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Get an input number from the console
            //Print all even numbers starting from 2
            //Get another input number from the console
            //Print all odd numbers starting from 1

            int inputNumber = int.Parse(Console.ReadLine());
            for (int i = 2; i <= inputNumber; i+=2)
            {
                Console.WriteLine(i);
            }

            int secondInputNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= secondInputNumber; i+=2)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

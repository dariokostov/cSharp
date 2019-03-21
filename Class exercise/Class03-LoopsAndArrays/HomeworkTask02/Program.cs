using System;

namespace HomeworkTask02andTask03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Create an array of integers with length of 20 and fill the array from user's input.
            //Print all numbers of the array, in case a number is 0 it should print "Skipped" and in case a number 
            //is a 3-digit number it should stop the printing.

            int[] Integers = new int[6];

            Console.WriteLine("Enter numbers:");
            for (int i = 0; i < Integers.Length; i++)
            {
                Integers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Print:");

            foreach (var item in Integers)
            {
                if(item == 0)
                {
                    Console.WriteLine("Skipped");
                    continue;
                } else if (item > 99 && item < 1000)
                {
                    break;
                }
                Console.WriteLine(item);
            }
        }
    }
}

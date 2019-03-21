using System;

namespace Exercise05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declare a new array of integers with 5 elements
            //Initialize the array elements with values from input
            //Sum all the values and print the result in the console

            int[] IntArray = new int[5];
            int sum = 0;
            for (int i = 0; i < IntArray.Length; i++)
            {
                IntArray[i] = int.Parse(Console.ReadLine());
                sum += IntArray[i];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}

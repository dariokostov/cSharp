using System;

namespace Exercise04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Declare 5 arrays with 5 elements in them:
            //With words
            //With decimal values
            //With characters from keyboard
            //With true / false values
            //With arrays, each holding 2 whole numbers

            string[] Animals = new string[] { "dog", "cat", "mouse", "eagle", "horse" };
            double[] Decimal = new double[] { 4.4, 12.4, 123.5, 11.2, 14.09 };
            char[] Character = new char[] { 'z', 'a', 'e', 'r', 'g' };
            bool[] Booleans = new bool[] { true, false, true, true, false };
            int[] Array = new int[] { 3, 5 };
            int[] Array1 = new int[] { 2, 9 };
            int[] Array2 = new int[] { 43, 6 };
            int[] Array3 = new int[] { 7, 3 };
            int[] Array4 = new int[] { 5, 11 };
            int[][] Arrays = new int[][] { Array, Array1, Array2, Array3, Array4 };

            Console.WriteLine(Animals.Length);
            Console.WriteLine(Decimal.Length);
            Console.WriteLine(Character.Length); 
            Console.WriteLine(Booleans.Length);
            Console.WriteLine(Arrays.Length);

            Console.ReadLine();
        }
    }
}

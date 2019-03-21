using System;

namespace Exercise03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //In the existing Console Application create a new method called Substrings
            //In that method enter the following string :
            //"Hello from SEDC Codecademy v7.0"
            //Ask the user to enter a number n.
            //Print the first n characters from that string and print the length of the new string.
            //Try to handle all the scenarios.

            Substrings();
            Console.ReadLine();
        }

        public static void Substrings()
        {
            string Text = "Hello from SEDC Codecademy v7.0";

            Console.Write("Enter number: ");
            int inputNumber = int.Parse(Console.ReadLine());

            if(inputNumber > Text.Length)
            {
                inputNumber = Text.Length;
            }
            string TextSubstring = Text.Substring(0, inputNumber);
            Console.WriteLine(TextSubstring);
            Console.WriteLine(TextSubstring.Length);
        }
    }
}

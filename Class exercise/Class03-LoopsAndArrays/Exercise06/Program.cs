using System;

namespace Exercise06
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Create an array with names
            //Give an option to the user to enter a name from the keyboard
            //After entering the name put it in the array and print all the names
            //Ask the user if they want to enter another name(Y / N)
            //Do the same process over and over until the user enters N

            string[] Names = new string[0];
            string inputAnswer;
            do
            {
                Console.Write("Enter name: ");
                string inputName = Console.ReadLine();
                Array.Resize(ref Names, Names.Length + 1);
                Names[Names.Length - 1] = inputName;
                Console.WriteLine("Do you want to enter another name? (y / n)");
                inputAnswer = Console.ReadLine();

            } while (inputAnswer.ToLower() == "y");

            Console.WriteLine("All names:");
            foreach (var name in Names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}

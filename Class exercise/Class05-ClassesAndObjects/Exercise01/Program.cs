using System;
using Library.Classes;

namespace Exercise01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Create a class Human
            //Add properties: FirstName, LastName, Age
            //Create a method called GetPersonStats that returns the full name of the human as well as their age
            //Create an object human by asking the user to fill the required information
            //Call the GetPersonStats method and print the result in the console after the object is created
            Console.WriteLine("Enter your first name, last name and age!");
            Human InputHuman = new Human(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine()));

            Console.WriteLine(InputHuman.GetPersonStats());
            Console.ReadLine();
        }
    }
}

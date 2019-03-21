using System;
using System.Collections.Generic;

namespace Exercise01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Create a PhoneBook Dictionary with 5 names and phone numbers. 
            //Through the console ask the person to enter a name.
            //Try and find that names phone number in your PhoneBook
            //If you can find it, print it in the console
            //If you can’t, print an error message

            Dictionary<string, string> PhoneBook = new Dictionary<string, string>() { { "Dario", "071223489" }, { "Martin", "071223029" }, { "Petar", "075234819" }, { "Goran", "078345121" }, { "Viktor", "075212111" } };
            Console.Write("Enter name: ");
            string Name = Console.ReadLine();

            Console.WriteLine(PhoneBookResearch(PhoneBook, Name));
            Console.ReadLine();
        }

        private static string PhoneBookResearch(Dictionary<string, string> PhoneBook, string Name)
        {
            foreach (var person in PhoneBook)
            {
                if (Name.ToLower() == person.Key.ToLower())
                {
                    return person.Value;
                }
            }
            return "Name does not exist.";
        }
    }
}

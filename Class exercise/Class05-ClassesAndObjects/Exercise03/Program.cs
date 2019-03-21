using System;
using Library.Classes;

namespace Exercise03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Create a class Student that has properties: Name, Academy and Group
            //Create an array with 5 new Students(objects )
            //The user should enter a name and the user information should be displayed in the console if a user by that name exists
            //If there is no such user it should show an error message

            Student[] Students = new Student[] { new Student("Dario", "SEDC", "G2"), new Student("Martin", "Java", "G1"), new Student("Petar", "CSS", "G8"), new Student("Viktor", "HTML", "G3"), new Student("Goran", "C#", "G4") };

            Console.Write("Enter a name: ");
            string Name = Console.ReadLine();

            Console.WriteLine(NewMethod(Students, Name));
            Console.ReadLine();
        }

        public static string NewMethod(Student[] Students, string Name)
        {
            foreach (var student in Students)
            {
                if (Name.ToLower() == student.Name.ToLower())
                {
                    return student.GetInfo();
                }

            }
            return $"The name \"{Name}\" doesn't exists.";
        }
    }
}

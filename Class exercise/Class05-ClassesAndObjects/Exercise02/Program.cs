using System;
using Library.Classes;

namespace Exercise02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Create a class Dog
            //Add properties: Name, race, color
            //The dog needs to have an Eat method that returns message: The dog is now eating.A Play method returning a message : The dog is now playing. and a ChaseTail method that returns a message: Dog is now chasing its tail.
            //The user needs to create the dog object by inputs and then given an option to choose one of the actions mentioned above. 
            Console.Write("Enter dog name: ");
            string DogName = Console.ReadLine();
            Console.Write("Enter dog race: ");
            string DogRace = Console.ReadLine();
            Console.Write("Enter dog color: ");
            string DogColor = Console.ReadLine();

            Dog InputDog = new Dog(DogName, DogRace, DogColor);

            Console.WriteLine($"Choose one: \n1) Eat \n2) Play \n3) ChaseTail ");
            string MethodChoose = Console.ReadLine();

            if (MethodChoose == "1")
            {
                Console.WriteLine(InputDog.Eat());
            } 
            else if(MethodChoose == "2")
            {
                Console.WriteLine(InputDog.Play());
            } 
            else if(MethodChoose == "3")
            {
                Console.WriteLine(InputDog.ChaseTail());
            }
            else
            {
                Console.WriteLine("Error!");
            }

            Console.ReadLine();
        }
    }
}

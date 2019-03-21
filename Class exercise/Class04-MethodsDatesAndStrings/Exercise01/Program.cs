using System;

namespace Exercise01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Create 2 methods called Sum and Subtract
            //Sum will accept two numbers as parameters and return a result from summing the two numbers
            //Subtract will accept two numbers as parameters and return a result from subtracting the two numbers
            //Ask a person from the console to enter -or +
            //Then ask the person to enter two numbers
            //Call the corresponding method(sum or subtract) and return the result to the console

            Console.Write("Enter first number: ");
            int FirstNum = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int SecondNum = int.Parse(Console.ReadLine());

            Console.Write("Enter operation (+ / -): ");
            string InputAnswer = Console.ReadLine();

            InputMethod(FirstNum, SecondNum, InputAnswer);

            Console.ReadLine();

        }

        public static void InputMethod(int FirstNum, int SecondNum, string InputAnswer)
        {
            if (InputAnswer == "+")
            {
                Console.WriteLine(Sum(FirstNum, SecondNum));
            }
            else if (InputAnswer == "-")
            {
                Console.WriteLine(Subtract(FirstNum, SecondNum));
            }
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}

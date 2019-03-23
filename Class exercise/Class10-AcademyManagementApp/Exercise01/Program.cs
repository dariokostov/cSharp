using System;
using System.Collections.Generic;
using System.Linq;
using Library.Classes;
using Library.Enums;

namespace Exercise01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Create an Academy Management app

            //The app will have users that can login and perform some actions.
            //The user can choose one of the 3 roles and login:
            //  Admin
            //  Trainer
            //  Student(has a current Subject, and Grades)
            //After logging in there should be different options for different roles:
            //Admins can add / remove Teachers, Students and other Admins(can't remove it self )
            //Trainer can choose between seeing all students and all subjects
            //When choosing Students, all student names should appear
            //When chosen a name, it should print all the subjects
            //When choosing Subjects, all Subject names appear with how many students attend it next to it
            //Student are shown the name of the subject that they are listening and a list of their grades
            //Try and handle all scenarios with exception handling.Handle expected exceptions with special messages.

            Student Dario = new Student("Dario", "012", 25);
            Student Martin = new Student("Martin", "123", 24);
            Student Petar = new Student("Petar", "234", 32);
            Student Goran = new Student("Goran", "345", 27);
            List<User> Students = new List<User> { Dario, Martin, Petar, Goran };

            Trainer Dejan = new Trainer("Dejan", "999", 22);
            Trainer Igor = new Trainer("Igor", "666", 28);
            List<User> Trainers = new List<User> { Dejan, Igor };

            Admin Bojan = new Admin("Bojan", "444", 34, Trainers, Students);
            Admin Ivan = new Admin("Ivan", "222", 35, Trainers, Students);
            List<User> Admins = new List<User> { Bojan, Ivan };





            Console.WriteLine("Enter your role:\n1) Admin\n2) Trainer\n3) Student");
            string InputRole = Console.ReadLine();
            if(InputRole == "1")
            {
                Console.WriteLine("Admin page");
                if (LogIn(Admins))
                {
                   
                }
            }
            else if(InputRole == "2")
            {
                Console.WriteLine("Trainer page");
                if (LogIn(Trainers))
                {

                }
            }
            else if(InputRole == "3")
            {
                Console.WriteLine("Student page");
                if (LogIn(Students))
                {

                }
            }
            else
            {
                Console.WriteLine("Enter number form 1 to 3!");
            }



        }

        public static bool LogIn(List<User> users)
        {
            Console.Write("Enter username:");
            string InputUsername = Console.ReadLine();
            Console.Write("Enter password:");
            string InputPassword = Console.ReadLine();

            foreach (User user in users)
            {
                if(InputUsername == user.Username)
                {
                    if(InputPassword == user.Password)
                    {
                        Console.WriteLine($"{InputUsername} you are logged in");

                        Console.WriteLine("Remove or add?");
                        string InputRemoveOrAdd = Console.ReadLine();
                        if (InputRemoveOrAdd.ToLower() == "remove")
                        {
                            foreach (var item in users)
                            {
                                Console.WriteLine($" {item.Role}: {item.Username}");
                            }
                        }
                        return true;
                    }
                }
            }

            Console.WriteLine("Incorrect username or password!");
            return false;
        }
    }
}

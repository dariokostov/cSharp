using System;
namespace Library.Classes
{
    public class Student
    {
        public string Name { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }

        public Student(string name, string academy, string group)
        {
            this.Name = name;
            this.Academy = academy;
            this.Group = group;
        }

        public string GetInfo()
        {
            return $"Name: {Name} \nAcademy: {Academy} \nGroup: {Group}";
        }
    }
}

using System;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public void Display()
        {
            Console.WriteLine($"ID: {Id} | Name: {Name} | Age: {Age} | Course: {Course}");
        }
    }
}

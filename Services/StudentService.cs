using System;
using System.Collections.Generic;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Services
{
    public class StudentService
    {
        private List<Student> students = new List<Student>();

        public void AddStudent()
        {
            Student student = new Student();

            Console.Write("Enter ID: ");
            student.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            student.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Course: ");
            student.Course = Console.ReadLine();

            students.Add(student);

            Console.WriteLine("Student Added Successfully!\n");
        }

        public void ViewStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students found.\n");
                return;
            }

            foreach (var student in students)
            {
                student.Display();
            }
        }

        public void SearchStudent()
        {
            Console.Write("Enter Student ID to search: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var student = students.Find(s => s.Id == id);

            if (student != null)
                student.Display();
            else
                Console.WriteLine("Student not found.");
        }

        public void DeleteStudent()
        {
            Console.Write("Enter Student ID to delete: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var student = students.Find(s => s.Id == id);

            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student Deleted Successfully!");
            }
            else
                Console.WriteLine("Student not found.");
        }
    }
}

using System;
using StudentManagementSystem.Services;

namespace StudentManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentService service = new StudentService();
            int choice;

            do
            {
                Console.WriteLine("\n--- Student Management System ---");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        service.AddStudent();
                        break;

                    case 2:
                        service.ViewStudents();
                        break;

                    case 3:
                        service.SearchStudent();
                        break;

                    case 4:
                        service.DeleteStudent();
                        break;

                    case 5:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            } while (choice != 5);
        }
    }
}

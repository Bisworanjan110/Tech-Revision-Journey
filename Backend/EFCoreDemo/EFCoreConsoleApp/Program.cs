using EFCorePractice;
using EFCorePractice.DAL.Models;

namespace EFCoreConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== EF Core Demo Started ===");

            using var context = new AppDbContext();

            var repo = new Repository(context);

            var newStudent = new Student
            {
                Name = "John Doe",
                Age = 21,
                EnrollmentDate = DateTime.Now
            };

            string result = repo.AddStudent(newStudent);
            Console.WriteLine(result);

            // ✅ Step 4: Retrieve and display all students
            var students = repo.GetAllStudents();
            if (students != null && students.Count > 0)
            {
                Console.WriteLine("\n--- All Students ---");
                foreach (var s in students)
                {
                    Console.WriteLine($"ID: {s.Id} | Name: {s.Name} | Age: {s.Age} | EnrollmentDate: {s.EnrollmentDate}");
                }
            }
            else
            {
                Console.WriteLine("No students found.");
            }

            Console.WriteLine("\n=== EF Core Demo Completed ===");
        }
    }
}

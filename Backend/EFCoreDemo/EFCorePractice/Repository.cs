using EFCorePractice.DAL.Models;

namespace EFCorePractice
{
    public class Repository
    {
        AppDbContext Context { get; set; }
        public Repository(AppDbContext context)
        {
            this.Context = context;
        }

        public List<Student> GetAllStudents()
        {
            var students = new List<Student>();
            try
            {
                students = Context.students.ToList();
            }
            catch (Exception)
            {
                students = null;
            }
            return students;
        }

        public string AddStudent(Student student)
        {
            string message = string.Empty;
            try
            {
                Context.students.Add(student);
                Context.SaveChanges();
                message = "Student Added Successfully!";
            }
            catch (Exception)
            {
                message = "Some error occured!";
            }
            return message;
        }
    }
}

using WebApplication6.Models;

namespace WebApplication6.StudentData
{
    public class Data
    {
        public List<Student> students { get; set; }
        public bool AddStudent(Student student)
        {
            students.Add(student);
            return true;
        }

        public List<Student> GetStudents()
        {
            return students;
        }
    }
}

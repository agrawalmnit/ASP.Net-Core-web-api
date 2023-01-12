using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private List<Student> StudentList = new List<Student>
        { new Student {Id = 1,Name = "Ishansi agrawal", Description = "hello" },
        new Student{Id = 2,Name = "niharika agrawal", Description = "hello"},
            new Student{Id = 3, Name = "", Description = "hello" }, 

            };
        

        [HttpGet]
        [Route("get")]
        public Student GetStudentById(int id)
        {
            Student student = new Student();
            try
            {
                if (id < 0)
                {
                    throw new Exception("invalid");
                }
                else
                {
                    student = (from s in StudentList
                               where s.Id == id
                               select s).FirstOrDefault();
                }    
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return student;
        }

        [HttpGet]
        [Route("getall")]

        public List<Student> GetStudents()
        {
            var studentList = (from s4 in StudentList
                               select new StudentListDto
                               {
                                   Id = s4.Id,
                                   Name = s4.Name,
                                   Description = s4.Description
                               }).ToList();

            return StudentList;

        }
        [HttpPost]
        [Route("post")]
        public bool CreateStudent(Student student)
        {
            try
            {
                StudentList.Add(student); 
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        [HttpPut]
        [Route("Put")]

        public bool UpdateStudent(Student student, int id)
        {
            try
            {
                
                for(int i = 0; i< StudentList.Count; i++ )
                {
                    if(StudentList[i].Id == id)
                    {
                        
                        StudentList[i].Name = student.Name;
                        StudentList[i].Id = student.Id;
                        StudentList[i].Description = student.Description;
                    }
                    else
                    {
                        return false;
                    }
                    
                }
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        


        [HttpDelete]
        [Route("delete")]

        public bool DeleteStudent(int id, Student student)
        {
            try
            {
                var studentToBeDeleted = (from s3 in StudentList
                                          where s3.Id == id
                                          select s3).FirstOrDefault();
                StudentList.Remove(studentToBeDeleted);
            }

            catch(Exception ex)
            {
                throw ex;
            }
            return true;
        }
    }
}

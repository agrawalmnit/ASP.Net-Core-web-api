using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Models;
using WebApplication6.StudentData;

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost]
        [Route("post")]
        public async Task<string> Post(Student student)
        {
            var obj = new Data();
           var res =  obj.AddStudent(student);
            var result =  "";
            return result;
        }

        [HttpGet]
        [Route("get")]
        public async Task<int> Get(int id)
        {
            var res = 1;
            return res; 
        }

        [HttpDelete]
        [Route("delete")]

        public async Task<bool> Delete(int id)
        {
            List<int> ints= new List<int>() { 2, 3, 4};
            var result = ints.Remove(2);
            
            return result;
        }
    }
}

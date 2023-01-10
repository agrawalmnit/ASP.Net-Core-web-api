using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment Environment;
        public HomeController(Microsoft.Extensions.Hosting.IHostingEnvironment env)
        {
            Environment = (Microsoft.AspNetCore.Hosting.IHostingEnvironment?)env;
        }

        public IActionResult Index()
        {
            string wwwPath = this.Environment.WebRootPath;
            string contentPath = this.Environment.ContentRootPath;

            return View(wwwPath, contentPath);
        }
       
    }
}

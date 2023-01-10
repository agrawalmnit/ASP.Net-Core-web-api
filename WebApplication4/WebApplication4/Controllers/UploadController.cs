using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;

namespace WebApplication4.Controllers
{
    public class UploadController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult UploadFile() 
        {
            return View();
        
        }

        [HttpPost]

        public ActionResult UploadFile(HttpPostedFileBase file) 
        {
            try
            {
                if(file.ContentLength > 0) 
                {
                    string _FileName = Path.GetFileName(file.FileName);

                    string _path = Path.Combine(ServerSideBlazorBuilderExtensions.MapPath("~/UploadedFiles"), _FileName);
                    
                    file.SaveAs(_path);
                }

                ViewBag.Message = "Fileuploaded successfully";
                return View();

            }

            catch
            {
                ViewBag.Message = "file upload failed";
                return View();
            }
        }
    }
}

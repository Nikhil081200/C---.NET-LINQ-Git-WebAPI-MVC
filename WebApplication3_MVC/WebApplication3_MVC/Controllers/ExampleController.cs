using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApplication3_MVC.Models;

namespace WebApplication3_MVC.Controllers
{
    public class ExampleController : Controller
    {
        /*
        public ViewResult Index()
        {
            return View();
        }

        public ContentResult printdata()
        {
            return Content("<h3>This is Content-Result</h3>", "text/html");
        }

        public PartialViewResult display()
        {
            return PartialView("_PartialView1");
        }

        public EmptyResult dispdata()
        {
            return new EmptyResult();
        }

        public JsonResult studet()
        {
            List<Student> slist = new List<Student>()
            {
                new Student(){regno=1,stname="Nikhil",smailid="nikhilprasad@gmail.com"},
                new Student(){regno=2,stname="Vinit",smailid="vinitwankhede@gmail.com"},
                new Student(){regno=3,stname="Kunal",smailid="kunalzade#gmail.com"}
        };

            return Json(slist);
        }

        public FileContentResult getfile()
        {
            string path = "C:\\Users\\Nilesh H. Prasad\\Downloads\\Left Shift Schedule.pdf";
            byte[] file = System.IO.File.ReadAllBytes(path);
            return new FileContentResult(file, "application/pdf");
        }
        */

        public IActionResult getdetails()
        {
            return View();
        }
        [HttpPost]
        public IActionResult getdetails(Empdet obj)
        {
            return View();
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApplication3_MVC.Models;

namespace WebApplication3_MVC.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            student2Context cnt = new student2Context();
            var sql = cnt.School;

            return View(sql.ToList());
        }
    }
}

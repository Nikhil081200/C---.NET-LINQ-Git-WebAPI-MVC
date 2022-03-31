using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3_MVC.Models;
using WebApplication3_MVC.ViewModel;

namespace WebApplication3_MVC.Controllers
{
    public class DemoController : Controller
    {
        //example 1

        public IActionResult Index()
        {
            return View();
        }

        //example 2

        public IActionResult print()
        {
            ViewData["info1"] = "Nikhi Prasad,003,Electrical Engineering";
            ViewData["info2"] = System.DateTime.Now.ToLongDateString();
            return View();
        }

        //example 3

        public IActionResult dispcus()
        {
            Customer obj = new Customer();
            obj.cid = 1;
            obj.cname = "Nikhil Prasaad";
            obj.caddr = "Mhada Colony";
            return View(obj);
        }


        //example 4

        public IActionResult getcustdet()
        {
            return View();
        }

        public IActionResult printcust()
        {
            Customer obj = new Customer();
            obj.cid = int.Parse(Request.Form["t1"].ToString());
            obj.cname = (Request.Form["t2"].ToString());
            obj.caddr = (Request.Form["t3"].ToString());
            return View(obj);
        }

        //example 5
        public IActionResult dismembers()
        {
            List<string> mlist = new List<string>();
            mlist.Add("Nikhil");
            mlist.Add("Vinit");
            mlist.Add("Kunal");
            mlist.AddRange(new string[] { "Samir", "Shubhum", "Dhaval", "Aditya"});
            ViewData["List1"] = mlist;
            return View();
        }

        //example 6
        //nested class:-

        public IActionResult printemp()
        {
            Employee obj = new Employee();
            obj.eid = 10;
            obj.ename = "Nickion";
            obj.edesig = "Junior Analyst";
            obj.dobj.dname = "Capgemini";
            obj.dobj.noofemp = 100;

            return View(obj);
        }

        //example 7
        // wrapper class:-

        public IActionResult disresult()
        {
            Student obj1 = new Student() { regno = 10, stname = "Kunal", smailid = "kunalzade86@gmail.com" };
            Marks obj2 = new Marks() { total = 85, percentage = 88.64, grade = "A" };
            Final resobj = new Final() { stuobj = obj1, msobj = obj2 };
            return View(resobj);
        }

        //example 8
        //login page:-

        public IActionResult login()
        {
            return View();
        }
        public IActionResult validate()
        {
            Login obj = new Login();
            obj.username = Request.Form["t1"].ToString();
            obj.password = Request.Form["t2"].ToString();
            if (obj.username == "Nickion" && obj.password == "55555")
                return View("Index");
            else
                ViewData["result"] = "Login Failed";
            return View("login");
        }

        //example 9
        //Addition of 2 numbers:-

        public IActionResult inputnos()
        {
            return View();
        }

        public IActionResult addnos()
        {
            int n1 = int.Parse(Request.Form["t1"].ToString());
            int n2 = int.Parse(Request.Form["t2"].ToString());
            int res = n1 + n2;

            ViewData["sum"] = res;
            ViewData["Number 1"] = n1;
            ViewData["Number 2"] = n2;

            return View("inputnos");
        }
    }
}

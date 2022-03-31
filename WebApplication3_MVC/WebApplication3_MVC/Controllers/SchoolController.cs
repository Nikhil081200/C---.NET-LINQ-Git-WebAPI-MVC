using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApplication3_MVC.Models;

namespace WebApplication3_MVC.Controllers
{
    public class SchoolController : Controller
    {
        // GET: SchoolController
        public ActionResult Index()
        {
            student2Context cnt = new student2Context();
            var sql = cnt.School;
            return View(sql.ToList());
        }

        // GET: SchoolController/Details/5
        public ActionResult Details(int id)
        {
            student2Context cnt = new student2Context();
            var schooldet = (from i in cnt.School where i.Rollno == id select i).FirstOrDefault();
            School st = new School();
            if(schooldet!=null)
            {
                st.Rollno = schooldet.Rollno;
                st.Stname = schooldet.Stname;
                st.Sublikes = schooldet.Sublikes;
                st.Stmailid = schooldet.Stmailid;
            }
            return View(st);
        }

        // GET: SchoolController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SchoolController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                student2Context cnt = new student2Context();
                School schobj = new School();
                schobj.Rollno = int.Parse(collection["RollNo"].ToString());
                schobj.Stname = collection["Stname"].ToString();
                schobj.Sublikes = collection["Stname"].ToString();
                schobj.Stmailid = collection["Stmailid"].ToString();
                cnt.School.Add(schobj);
                cnt.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SchoolController/Edit/5
        public ActionResult Edit(int id)
        {
            student2Context cnt = new student2Context();
            var schooldet = (from i in cnt.School where i.Rollno == id select i).FirstOrDefault();
            School st = new School();
            if (schooldet != null)
            {
                st.Rollno = schooldet.Rollno;
                st.Stname = schooldet.Stname;
                st.Sublikes = schooldet.Sublikes;
                st.Stmailid = schooldet.Stmailid;
            }
            return View(st);
        }

        // POST: SchoolController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                student2Context cnt = new student2Context();
                var schooldet = (from i in cnt.School where i.Rollno == id select i).FirstOrDefault();
                School st = new School();
                if (schooldet != null)
                {
                    schooldet.Rollno=int.Parse(collection["Rollno"].ToString());
                    schooldet.Stname= collection["Stname"].ToString();
                    schooldet.Sublikes= collection["Sublikes"].ToString();
                    schooldet.Stmailid= collection["Stmailid"].ToString();
                    cnt.SaveChanges();
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SchoolController/Delete/5
        public ActionResult Delete(int id)
        {
            student2Context cnt = new student2Context();
            var schooldet = (from i in cnt.School where i.Rollno == id select i).FirstOrDefault();
            School st = new School();
            if (schooldet != null)
            {
                st.Rollno = schooldet.Rollno;
                st.Stname = schooldet.Stname;
                st.Sublikes = schooldet.Sublikes;
                st.Stmailid = schooldet.Stmailid;
            }
            return View(st);
        }

        // POST: SchoolController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                student2Context cnt = new student2Context();
                var schooldet = (from i in cnt.School where i.Rollno == id select i).FirstOrDefault();
                if (schooldet != null)
                {
                    cnt.School.Remove(schooldet);
                    cnt.SaveChanges();
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

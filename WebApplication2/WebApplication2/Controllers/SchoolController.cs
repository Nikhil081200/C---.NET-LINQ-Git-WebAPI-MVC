using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApplication2.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolController : ControllerBase
    {
        // GET: api/<SchoolController>
        [HttpGet]
        public IEnumerable<School> Get()
        {
            student2Context cnt = new student2Context();
            return cnt.School;
        }

        // GET api/<SchoolController>/5
        [HttpGet("{Rollno}")]
        public IEnumerable<School> Get(int Rollno)
        {
            student2Context cnt = new student2Context();
            var sql = from i in cnt.School where i.Rollno == Rollno select i;
            return sql;
        }

        // POST api/<SchoolController>
        [HttpPost]
        public void Post([FromBody] School value)
        {
            student2Context cnt = new student2Context();
            cnt.School.Add(value);
            cnt.SaveChanges();
        }

        // PUT api/<SchoolController>/5
        [HttpPut("{Rollno}")]
        public void Put(int Rollno, [FromBody] School value)
        {
            student2Context cnt = new student2Context();
            var stdet = cnt.School.Find(Rollno);
            if(stdet != null)
            {
                cnt.Entry(value).State = EntityState.Modified;
                cnt.SaveChanges();
            }
        }

        // DELETE api/<SchoolController>/5
        [HttpDelete("{Rollno}")]
        public void Delete(int Rollno)
        {
            student2Context cnt = new student2Context();
            var obj = cnt.School.Find(Rollno);
            cnt.School.Remove(obj);
            cnt.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3_MVC.Models
{
    public class Employee
    {
        public Employee()
        {
            dobj = new Dept();
        }
        public int eid { get; set; }
        public string ename { get; set; }
        public string edesig { get; set; }
        public Dept dobj { get; set; }
        public class Dept
        {
            public string dname { get; set; }
            public int noofemp { get; set; }
        }
    }
}

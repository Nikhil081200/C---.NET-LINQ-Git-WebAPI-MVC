using System;
using System.Collections.Generic;
using WebApplication2.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication2.Models
{
    public partial class School
    {
        public int Rollno { get; set; }
        public string Stname { get; set; }
        public string Sublikes { get; set; }
        public string Stmailid { get; set; }
    }
}

using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp3.Models
{
    public partial class Category
    {
        public int? Cid { get; set; }
        public string Cname { get; set; }
        public string Cdesc { get; set; }
    }
}

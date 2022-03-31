using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp3.Models
{
    public partial class College
    {
        public int Strollno { get; set; }
        public string Stname { get; set; }
        public decimal? Feeamount { get; set; }
        public string Stmailid { get; set; }
    }
}

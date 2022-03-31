using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp3.Models
{
    public partial class Accdet
    {
        public int Accno { get; set; }
        public int Regno { get; set; }
        public string Ahname { get; set; }
        public decimal? Damount { get; set; }
    }
}

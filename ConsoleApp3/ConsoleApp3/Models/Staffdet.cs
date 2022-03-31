﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ConsoleApp3.Models
{
    public partial class Staffdet
    {
        public int Stid { get; set; }
        public string Sname { get; set; }
        public string Smailid { get; set; }
        public int? Scontactno { get; set; }
    }
}
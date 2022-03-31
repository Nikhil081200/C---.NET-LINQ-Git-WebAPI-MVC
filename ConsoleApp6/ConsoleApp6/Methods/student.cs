using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp6.Methods
{
    public class student
    {
        [Key]
        public int regno { get; set; }
        public string sname { get; set; }
        public string smailid { get; set; }
    }
}

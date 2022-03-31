using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp5.Models
{
    public class student
    {
        [Key]
        public int regno { get; set; }
        public string sname { get; set; }
        public string smailid { get; set; }
    }
}

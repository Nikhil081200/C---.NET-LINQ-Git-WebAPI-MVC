using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp5.Models
{
    public class staff
    {
        [Key]
        public int sid { get;set; }
        public string sname { get; set; }
        public int exp { get; set; }
    }
}

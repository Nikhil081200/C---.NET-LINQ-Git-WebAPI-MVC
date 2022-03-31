using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp6.Methods
{
    public class staff
    {
        [Key]
        public int sid { get; set; }
        public string sname { get; set; }
        public int exp { get; set; }
    }
}

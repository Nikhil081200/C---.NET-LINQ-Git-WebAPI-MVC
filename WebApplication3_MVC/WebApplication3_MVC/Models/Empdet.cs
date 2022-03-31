using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace WebApplication3_MVC.Models
{
    public class Empdet
    {
        [Required(ErrorMessage = "Please enter employee name")]
        public string ename { get; set; }

        [Required(ErrorMessage = "Please enter employee role")]
        public string role { get; set; }

        [Required(ErrorMessage = "Please enter employee location")]
        public string address { get; set; }

        [Required(ErrorMessage ="Please enter your age")]
        [Range(18,100,ErrorMessage ="Invalid age, please enter age between [18-100]")]
        public int age { get; set; }

        [Required(ErrorMessage = "Please enter valid Email-id")]
        [EmailAddress(ErrorMessage ="Invalid Email-Id")]
        public string emailid { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace u24580717_Prac2_luyandaStudyGroup_.Models
{
    public class Student
    {
        [Display(Name = "STUDENT NUMBER")]
        [Required(ErrorMessage = "Student number is mandetory")]
        public string StudentNumber { get; set; }

        [Display(Name = "NAME")]
        public string FirstName { get; set; }

        [Display(Name = "SURNAME")]
        public string LastName { get; set; }

        [Display(Name = "EMAIL ADDRESS")]
        public string EmailAddress { get; set; }

        [Display(Name = "Link to Personal Page")]
        public string myLink { get; set; }
    }
}
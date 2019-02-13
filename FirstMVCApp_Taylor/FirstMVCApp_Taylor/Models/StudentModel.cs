using FirstApp.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstMVCApp_Taylor.Models
{
    public class StudentModel
    {
        [Display(Name = "First Name: ")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name: ")]
        public string LastName { get; set; }
        [Display(Name = "Gender: ")]
        public GenderEnum Gender { get; set; }
        public string GenderName => Gender.ToString();
        [Display(Name = "Age: ")]
        public int Age { get; set; }
        [Display(Name = "Major: ")]
        public string Major { get; set; }
    }
}
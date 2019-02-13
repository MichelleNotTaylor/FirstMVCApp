using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Week2.Shared.Enums;
using Week2.Shared.ViewModels;

namespace FirstMVCApp.Models
{
    public class SemesterModel
    {
        [Display(Name = "Year: ")]
        public int Year { get; set; }
        public SemesterEnum Semester { get; set; }
        [Display(Name = "Semester Name: ")]
        public string SemesterName => Semester.ToString();
        public List<CourseViewModel> Courses { get; set; }
    }
}
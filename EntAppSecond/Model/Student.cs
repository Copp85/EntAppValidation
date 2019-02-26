using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntAppSecond.Pages.Model
{


    public class Student
    {
        [Required (ErrorMessage ="Please enter a valid Student ID")]
        [Display(Name ="Student ID")]
        [RegularExpression(@"(s|S)\d{7}")]
        public string StudentID { get; set; } = "";

        [Required]
        [Display(Name = "First name")]
        [RegularExpression(@"\w{2,50}")]
        public string FirstName { get; set; } = "";

        [Required]
        [Display(Name = "Second name")]
        [RegularExpression (@"[\\w’-]{2,}")]
        public string LastName { get; set; } = "";


        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }

        [Required]
        [Display(Name = "Number of Modules")]
        public int NoOfModules { get; set; }

        [Required]
        [Display(Name = "Height")]
        public decimal Height { get; set; }

        [EmailAddress]
        [Required]
        [RegularExpression(@"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}\b")]
        public string Email { get; set; }

        [EmailAddress]
        [Required]
        [RegularExpression(@"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}\b")]
        public string EmailConfirmation { get; set; }

    }
}

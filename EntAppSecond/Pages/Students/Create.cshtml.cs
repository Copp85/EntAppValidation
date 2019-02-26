using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EntAppSecond.Models;
using EntAppSecond.Pages.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.InMemory;

namespace EntAppSecond.Pages.Students
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Student Student { get; set; }
        private readonly CollegeContext _db;

        public CreateModel(CollegeContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            //if (Student.Email != Student.EmailConfirmation)
            //    ModelState.AddModelError("Student.Email", "emails don't match");

            if (!ModelState.IsValid)
                return Page();

            _db.Students.Add(Student);
            await _db.SaveChangesAsync();
            return RedirectToPage("ListStudents");
        }
    }
}
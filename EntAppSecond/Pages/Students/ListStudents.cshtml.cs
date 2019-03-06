using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntAppSecond.Model;
using EntAppSecond.Models;
using EntAppSecond.Pages.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace EntAppSecond.Pages.Students
{
    public class ListStudentsModel : PageModel
    {
        private readonly CollegeContext _db;

        public ListStudentsModel(CollegeContext db)
        {
            _db = db;
        }

        public IList<Student> Students { get; private set; }

        public async Task OnGetAsync()
        {
            Students = await _db.Students.AsNoTracking().ToListAsync();
        }

        //public void OnGet()
        //{

        //}
    }


}
using EntAppSecond.Pages.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntAppSecond.Models
{
    public class CollegeContext : DbContext
    {
        //private readonly CollegeContext _db;

        public CollegeContext(DbContextOptions<CollegeContext> options)
            : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}

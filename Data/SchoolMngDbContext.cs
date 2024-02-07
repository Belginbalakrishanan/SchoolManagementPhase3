using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolManagemet.Models;

namespace SchoolManagemet.Data
{
    public class SchoolMngDbContext : DbContext
    {
        public SchoolMngDbContext (DbContextOptions<SchoolMngDbContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolManagemet.Models.Student> Student { get; set; } = default!;
    }
}

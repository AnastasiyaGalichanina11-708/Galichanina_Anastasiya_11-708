using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exam.Models;

namespace Exam.Data
{
    public class MyDBContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<File> Files { get; set; }
        public DbSet<Post> Posts { get; set; }

        public MyDBContext(DbContextOptions<MyDBContext> options)
            : base(options)
        { }
    }
}

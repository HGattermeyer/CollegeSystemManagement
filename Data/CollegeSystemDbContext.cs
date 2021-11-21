using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CollegeSystemSystem.Models;

namespace CollegeSystemSystem.Data
{
    public class CollegeSystemDbContext : DbContext
    {
        public CollegeSystemDbContext(DbContextOptions<CollegeSystemDbContext> options)
            : base(options)
        {
        }

        public DbSet<CollegeSystemSystem.Models.Course> Course { get; set; }
        public DbSet<CollegeSystemSystem.Models.Student> Student { get; set; }
        //public DbSet<CollegeSystemSystem.Models.Grade> Grade { get; set; }
        //public DbSet<CollegeSystemSystem.Models.Subject> Subject { get; set; }
        //public DbSet<CollegeSystemSystem.Models.Teacher> Teacher { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Student>().HasMany<Grade>(g => g.Grades).WithOne(s => s.Student).OnDelete(DeleteBehavior.ClientNoAction);
            //modelBuilder.Entity<Grade>().HasOne<Student>(s => s.Student).WithMany(g => g.Grades).OnDelete(DeleteBehavior.ClientNoAction);
            modelBuilder.Entity<Course>().HasMany<Student>(s => s.Students).WithOne(c => c.Course).OnDelete(DeleteBehavior.ClientNoAction);

        }
    }
}

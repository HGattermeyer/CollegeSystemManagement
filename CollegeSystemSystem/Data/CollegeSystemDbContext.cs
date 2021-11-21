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
        public DbSet<CollegeSystemSystem.Models.Subject> Subject { get; set; }
        public DbSet<CollegeSystemSystem.Models.Grade> Grade { get; set; }
        public DbSet<CollegeSystemSystem.Models.Teacher> Teacher { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Course>().HasMany<Student>(s => s.Students).WithOne(c => c.Course).OnDelete(DeleteBehavior.ClientNoAction);
            modelBuilder.Entity<Course>().HasMany<Subject>(s => s.Subjects).WithOne(c => c.Course).OnDelete(DeleteBehavior.ClientNoAction);
            modelBuilder.Entity<Teacher>().HasMany<Subject>(s => s.Subjects).WithOne(t => t.Teacher).OnDelete(DeleteBehavior.ClientNoAction);
            modelBuilder.Entity<Student>().HasMany<Grade>(s => s.Grades).WithOne(g => g.Student).OnDelete(DeleteBehavior.ClientNoAction);
            modelBuilder.Entity<Subject>().HasMany<Grade>(s => s.Grades).WithOne(g => g.Subject).OnDelete(DeleteBehavior.ClientNoAction);


        }
    }
}

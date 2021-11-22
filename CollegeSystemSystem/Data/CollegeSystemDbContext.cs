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
            this.Database.EnsureCreated();
        }

        private readonly CollegeSystemDbContext _context;

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

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, CourseName = "Administration" },
                new Course { Id = 2, CourseName = "Mechanical Engineer" },
                new Course { Id = 3, CourseName = "Finance" },
                new Course { Id = 4, CourseName = "Technology" }
                );

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { Id = 1, Wage = 3000, Name = "Rodrigo Marques", BirthDate = new DateTime(1997, 10, 25) },
                new Teacher { Id = 2, Wage = 6000, Name = "Beatriz Almeida", BirthDate = new DateTime(1984, 3, 10) },
                new Teacher { Id = 3, Wage = 4000, Name = "Tomás Gonçalves", BirthDate = new DateTime(1990, 7, 05) },
                new Teacher { Id = 4, Wage = 3340, Name = "Francisco Correia", BirthDate = new DateTime(1989, 1, 3) },
                new Teacher { Id = 5, Wage = 5010, Name = "Catarina Carvalho", BirthDate = new DateTime(2001, 12, 12) },
                new Teacher { Id = 6, Wage = 6800, Name = "Mariana Ferreira", BirthDate = new DateTime(2004, 5, 14) }
                );

            modelBuilder.Entity<Subject>().HasData(
                new Subject { Id = 1, SubjectName = "Project Management", CourseId = 1, TeacherId = 1 },
                new Subject { Id = 2, SubjectName = "Negotiation", CourseId = 1, TeacherId = 2 },
                new Subject { Id = 3, SubjectName = "International Relashionship", CourseId = 1, TeacherId = 3 },
                new Subject { Id = 4, SubjectName = "Physics", CourseId = 2, TeacherId = 4 },
                new Subject { Id = 5, SubjectName = "Vibrations", CourseId = 2, TeacherId = 5 },
                new Subject { Id = 6, SubjectName = "Rigid Body Mechanics", CourseId = 2, TeacherId = 6 },
                new Subject { Id = 7, SubjectName = "Taxes", CourseId = 3, TeacherId = 1 },
                new Subject { Id = 8, SubjectName = "Mutual Funds", CourseId = 3, TeacherId = 5 },
                new Subject { Id = 9, SubjectName = "Basic Finances", CourseId = 3, TeacherId = 3 },
                new Subject { Id = 10, SubjectName = "Database Design", CourseId = 4, TeacherId = 3 },
                new Subject { Id = 11, SubjectName = "Functional Code", CourseId = 4, TeacherId = 1 },
                new Subject { Id = 12, SubjectName = "JavaScript Code", CourseId = 4, TeacherId = 6 }
                );

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1, BirthDate = new DateTime(2001, 6, 3), CourseId = 4, Name = "Rolf Ellsworth" },
                new Student { Id = 2, BirthDate = new DateTime(1970, 3, 6), CourseId = 1, Name = "Dominique Bunker" },
                new Student { Id = 3, BirthDate = new DateTime(1956, 11, 17), CourseId = 1, Name = "Glenda Connealy" },
                new Student { Id = 4, BirthDate = new DateTime(2003, 9, 15), CourseId = 3, Name = "Pamela Volkert" },
                new Student { Id = 5, BirthDate = new DateTime(1964, 8, 11), CourseId = 3, Name = "Michael Goodyear" },
                new Student { Id = 6, BirthDate = new DateTime(1957, 1, 20), CourseId = 4, Name = "Mark Latshaw" },
                new Student { Id = 7, BirthDate = new DateTime(1957, 10, 10), CourseId = 3, Name = "Ella Watson" },
                new Student { Id = 8, BirthDate = new DateTime(1957, 8, 10), CourseId = 2, Name = "Gracie Johnson" },
                new Student { Id = 9, BirthDate = new DateTime(2003, 11, 3), CourseId = 2, Name = "Monty Brace" },
                new Student { Id = 10, BirthDate = new DateTime(1956, 3, 13), CourseId = 4, Name = "Ronald Robinson" },
                new Student { Id = 11, BirthDate = new DateTime(1991, 4, 25), CourseId = 4, Name = "Matthew Ruscio" },
                new Student { Id = 12, BirthDate = new DateTime(1995, 3, 1), CourseId = 2, Name = "Linda Grove" },
                new Student { Id = 13, BirthDate = new DateTime(1984, 3, 1), CourseId = 2, Name = "Jaimee Barnhart" },
                new Student { Id = 14, BirthDate = new DateTime(2002, 8, 12), CourseId = 2, Name = "Michell Crout" },
                new Student { Id = 15, BirthDate = new DateTime(1986, 4, 2), CourseId = 2, Name = "Linda Rowe" },
                new Student { Id = 16, BirthDate = new DateTime(1983, 8, 3), CourseId = 1, Name = "Thomas Dolan" },
                new Student { Id = 17, BirthDate = new DateTime(1993, 2, 21), CourseId = 2, Name = "Johanna Sobina" },
                new Student { Id = 18, BirthDate = new DateTime(1956, 2, 23), CourseId = 2, Name = "Hazel Obrien" },
                new Student { Id = 19, BirthDate = new DateTime(1976, 2, 2), CourseId = 4, Name = "Elicia Weaver" },
                new Student { Id = 20, BirthDate = new DateTime(1969, 9, 27), CourseId = 2, Name = "David Munoz" },
                new Student { Id = 21, BirthDate = new DateTime(1991, 11, 14), CourseId = 2, Name = "Tara Ebner" },
                new Student { Id = 22, BirthDate = new DateTime(1969, 8, 1), CourseId = 3, Name = "Lana Lofty" },
                new Student { Id = 23, BirthDate = new DateTime(1977, 12, 26), CourseId = 1, Name = "Anna Johnson" },
                new Student { Id = 24, BirthDate = new DateTime(1974, 4, 27), CourseId = 4, Name = "Pamela Mitchell" },
                new Student { Id = 25, BirthDate = new DateTime(1993, 2, 16), CourseId = 2, Name = "Katrina Curtis" },
                new Student { Id = 26, BirthDate = new DateTime(1971, 7, 12), CourseId = 1, Name = "Theodore Fitts" },
                new Student { Id = 27, BirthDate = new DateTime(1977, 9, 4), CourseId = 4, Name = "Kristen Cantu" },
                new Student { Id = 28, BirthDate = new DateTime(2002, 1, 25), CourseId = 4, Name = "Matthew Welch" },
                new Student { Id = 29, BirthDate = new DateTime(1988, 9, 25), CourseId = 4, Name = "Tiffany Phelps" },
                new Student { Id = 30, BirthDate = new DateTime(1971, 1, 19), CourseId = 4, Name = "Gloria Hernandez" },
                new Student { Id = 31, BirthDate = new DateTime(1979, 9, 18), CourseId = 2, Name = "Paul Dixon" },
                new Student { Id = 32, BirthDate = new DateTime(1991, 2, 2), CourseId = 4, Name = "Jose Jiggetts" },
                new Student { Id = 33, BirthDate = new DateTime(1983, 4, 8), CourseId = 1, Name = "John Conner" },
                new Student { Id = 34, BirthDate = new DateTime(1966, 1, 22), CourseId = 4, Name = "Nolan Mixon" },
                new Student { Id = 35, BirthDate = new DateTime(1953, 6, 7), CourseId = 4, Name = "Gregg Otto" },
                new Student { Id = 36, BirthDate = new DateTime(1973, 10, 12), CourseId = 4, Name = "Anne Mceachern" },
                new Student { Id = 37, BirthDate = new DateTime(1995, 4, 14), CourseId = 3, Name = "Jeffrey Steiner" },
                new Student { Id = 38, BirthDate = new DateTime(1997, 5, 4), CourseId = 2, Name = "Alice Poulin" },
                new Student { Id = 39, BirthDate = new DateTime(1969, 8, 9), CourseId = 1, Name = "Kellie Luttrell" },
                new Student { Id = 40, BirthDate = new DateTime(1992, 3, 17), CourseId = 4, Name = "Ethel Riseden" },
                new Student { Id = 41, BirthDate = new DateTime(1966, 1, 24), CourseId = 2, Name = "Lily Kiser" },
                new Student { Id = 42, BirthDate = new DateTime(1950, 12, 19), CourseId = 2, Name = "Cynthia Berry" },
                new Student { Id = 43, BirthDate = new DateTime(1988, 11, 5), CourseId = 4, Name = "Irene Gardner" },
                new Student { Id = 44, BirthDate = new DateTime(1979, 1, 27), CourseId = 4, Name = "Fred Caison" },
                new Student { Id = 45, BirthDate = new DateTime(1977, 9, 13), CourseId = 2, Name = "Daniel Chin" },
                new Student { Id = 46, BirthDate = new DateTime(2000, 3, 22), CourseId = 4, Name = "Rubye Debord" },
                new Student { Id = 47, BirthDate = new DateTime(1955, 4, 1), CourseId = 3, Name = "Raymond Becerra" },
                new Student { Id = 48, BirthDate = new DateTime(1992, 6, 18), CourseId = 4, Name = "Susan Campos" },
                new Student { Id = 49, BirthDate = new DateTime(1951, 12, 26), CourseId = 3, Name = "Kathy Smith" },
                new Student { Id = 50, BirthDate = new DateTime(1969, 9, 24), CourseId = 4, Name = "Marylyn Reine" }
                );

            modelBuilder.Entity<Grade>().HasData(
                new Grade { Id = 1, StudentId = 1, SubjectId = 10, GradeNumber = 1 },
                new Grade { Id = 2, StudentId = 1, SubjectId = 11, GradeNumber = 6 },
                new Grade { Id = 3, StudentId = 1, SubjectId = 12, GradeNumber = 9 },
                new Grade { Id = 4, StudentId = 2, SubjectId = 1, GradeNumber = 5 },
                new Grade { Id = 5, StudentId = 2, SubjectId = 2, GradeNumber = 3 },
                new Grade { Id = 6, StudentId = 2, SubjectId = 3, GradeNumber = 0 },
                new Grade { Id = 7, StudentId = 3, SubjectId = 1, GradeNumber = 9 },
                new Grade { Id = 8, StudentId = 3, SubjectId = 2, GradeNumber = 10 },
                new Grade { Id = 9, StudentId = 3, SubjectId = 3, GradeNumber = 8 },
                new Grade { Id = 10, StudentId = 4, SubjectId = 7, GradeNumber = 7 },
                new Grade { Id = 11, StudentId = 4, SubjectId = 8, GradeNumber = 3 },
                new Grade { Id = 12, StudentId = 4, SubjectId = 9, GradeNumber = 6 },
                new Grade { Id = 13, StudentId = 5, SubjectId = 7, GradeNumber = 1 },
                new Grade { Id = 14, StudentId = 5, SubjectId = 8, GradeNumber = 2 },
                new Grade { Id = 15, StudentId = 5, SubjectId = 9, GradeNumber = 1 },
                new Grade { Id = 16, StudentId = 6, SubjectId = 10, GradeNumber = 4 },
                new Grade { Id = 17, StudentId = 6, SubjectId = 11, GradeNumber = 10 },
                new Grade { Id = 18, StudentId = 6, SubjectId = 12, GradeNumber = 8 },
                new Grade { Id = 19, StudentId = 7, SubjectId = 7, GradeNumber = 2 },
                new Grade { Id = 20, StudentId = 7, SubjectId = 8, GradeNumber = 1 },
                new Grade { Id = 21, StudentId = 7, SubjectId = 9, GradeNumber = 4 },
                new Grade { Id = 22, StudentId = 8, SubjectId = 4, GradeNumber = 4 },
                new Grade { Id = 23, StudentId = 8, SubjectId = 5, GradeNumber = 6 },
                new Grade { Id = 24, StudentId = 8, SubjectId = 6, GradeNumber = 0 },
                new Grade { Id = 25, StudentId = 9, SubjectId = 4, GradeNumber = 8 },
                new Grade { Id = 26, StudentId = 9, SubjectId = 5, GradeNumber = 2 },
                new Grade { Id = 27, StudentId = 9, SubjectId = 6, GradeNumber = 0 },
                new Grade { Id = 28, StudentId = 10, SubjectId = 10, GradeNumber = 9 },
                new Grade { Id = 29, StudentId = 10, SubjectId = 11, GradeNumber = 5 },
                new Grade { Id = 30, StudentId = 10, SubjectId = 12, GradeNumber = 9 },
                new Grade { Id = 31, StudentId = 11, SubjectId = 10, GradeNumber = 0 },
                new Grade { Id = 32, StudentId = 11, SubjectId = 11, GradeNumber = 8 },
                new Grade { Id = 33, StudentId = 11, SubjectId = 12, GradeNumber = 1 },
                new Grade { Id = 34, StudentId = 12, SubjectId = 4, GradeNumber = 4 },
                new Grade { Id = 35, StudentId = 12, SubjectId = 5, GradeNumber = 9 },
                new Grade { Id = 36, StudentId = 12, SubjectId = 6, GradeNumber = 0 },
                new Grade { Id = 37, StudentId = 13, SubjectId = 4, GradeNumber = 3 },
                new Grade { Id = 38, StudentId = 13, SubjectId = 5, GradeNumber = 7 },
                new Grade { Id = 39, StudentId = 13, SubjectId = 6, GradeNumber = 5 },
                new Grade { Id = 40, StudentId = 14, SubjectId = 4, GradeNumber = 5 },
                new Grade { Id = 41, StudentId = 14, SubjectId = 5, GradeNumber = 7 },
                new Grade { Id = 42, StudentId = 14, SubjectId = 6, GradeNumber = 4 },
                new Grade { Id = 43, StudentId = 15, SubjectId = 4, GradeNumber = 5 },
                new Grade { Id = 44, StudentId = 15, SubjectId = 5, GradeNumber = 1 },
                new Grade { Id = 45, StudentId = 15, SubjectId = 6, GradeNumber = 0 },
                new Grade { Id = 46, StudentId = 16, SubjectId = 1, GradeNumber = 4 },
                new Grade { Id = 47, StudentId = 16, SubjectId = 2, GradeNumber = 1 },
                new Grade { Id = 48, StudentId = 16, SubjectId = 3, GradeNumber = 3 },
                new Grade { Id = 49, StudentId = 17, SubjectId = 4, GradeNumber = 10 },
                new Grade { Id = 50, StudentId = 17, SubjectId = 5, GradeNumber = 9 },
                new Grade { Id = 51, StudentId = 17, SubjectId = 6, GradeNumber = 2 },
                new Grade { Id = 52, StudentId = 18, SubjectId = 4, GradeNumber = 5 },
                new Grade { Id = 53, StudentId = 18, SubjectId = 5, GradeNumber = 10 },
                new Grade { Id = 54, StudentId = 18, SubjectId = 6, GradeNumber = 2 },
                new Grade { Id = 55, StudentId = 19, SubjectId = 10, GradeNumber = 9 },
                new Grade { Id = 56, StudentId = 19, SubjectId = 11, GradeNumber = 10 },
                new Grade { Id = 57, StudentId = 19, SubjectId = 12, GradeNumber = 10 },
                new Grade { Id = 58, StudentId = 20, SubjectId = 4, GradeNumber = 2 },
                new Grade { Id = 59, StudentId = 20, SubjectId = 5, GradeNumber = 1 },
                new Grade { Id = 60, StudentId = 20, SubjectId = 6, GradeNumber = 6 },
                new Grade { Id = 61, StudentId = 21, SubjectId = 4, GradeNumber = 10 },
                new Grade { Id = 62, StudentId = 21, SubjectId = 5, GradeNumber = 4 },
                new Grade { Id = 63, StudentId = 21, SubjectId = 6, GradeNumber = 1 },
                new Grade { Id = 64, StudentId = 22, SubjectId = 7, GradeNumber = 6 },
                new Grade { Id = 65, StudentId = 22, SubjectId = 8, GradeNumber = 9 },
                new Grade { Id = 66, StudentId = 22, SubjectId = 9, GradeNumber = 0 },
                new Grade { Id = 67, StudentId = 23, SubjectId = 1, GradeNumber = 8 },
                new Grade { Id = 68, StudentId = 23, SubjectId = 2, GradeNumber = 6 },
                new Grade { Id = 69, StudentId = 23, SubjectId = 3, GradeNumber = 1 },
                new Grade { Id = 70, StudentId = 24, SubjectId = 10, GradeNumber = 5 },
                new Grade { Id = 71, StudentId = 24, SubjectId = 11, GradeNumber = 0 },
                new Grade { Id = 72, StudentId = 24, SubjectId = 12, GradeNumber = 1 },
                new Grade { Id = 73, StudentId = 25, SubjectId = 4, GradeNumber = 3 },
                new Grade { Id = 74, StudentId = 25, SubjectId = 5, GradeNumber = 6 },
                new Grade { Id = 75, StudentId = 25, SubjectId = 6, GradeNumber = 2 },
                new Grade { Id = 76, StudentId = 26, SubjectId = 1, GradeNumber = 5 },
                new Grade { Id = 77, StudentId = 26, SubjectId = 2, GradeNumber = 10 },
                new Grade { Id = 78, StudentId = 26, SubjectId = 3, GradeNumber = 5 },
                new Grade { Id = 79, StudentId = 27, SubjectId = 10, GradeNumber = 1 },
                new Grade { Id = 80, StudentId = 27, SubjectId = 11, GradeNumber = 2 },
                new Grade { Id = 81, StudentId = 27, SubjectId = 12, GradeNumber = 3 },
                new Grade { Id = 82, StudentId = 28, SubjectId = 10, GradeNumber = 4 },
                new Grade { Id = 83, StudentId = 28, SubjectId = 11, GradeNumber = 10 },
                new Grade { Id = 84, StudentId = 28, SubjectId = 12, GradeNumber = 0 },
                new Grade { Id = 85, StudentId = 29, SubjectId = 10, GradeNumber = 2 },
                new Grade { Id = 86, StudentId = 29, SubjectId = 11, GradeNumber = 6 },
                new Grade { Id = 87, StudentId = 29, SubjectId = 12, GradeNumber = 0 },
                new Grade { Id = 88, StudentId = 30, SubjectId = 10, GradeNumber = 8 },
                new Grade { Id = 89, StudentId = 30, SubjectId = 11, GradeNumber = 9 },
                new Grade { Id = 90, StudentId = 30, SubjectId = 12, GradeNumber = 5 },
                new Grade { Id = 91, StudentId = 31, SubjectId = 4, GradeNumber = 1 },
                new Grade { Id = 92, StudentId = 31, SubjectId = 5, GradeNumber = 8 },
                new Grade { Id = 93, StudentId = 31, SubjectId = 6, GradeNumber = 5 },
                new Grade { Id = 94, StudentId = 32, SubjectId = 10, GradeNumber = 7 },
                new Grade { Id = 95, StudentId = 32, SubjectId = 11, GradeNumber = 2 },
                new Grade { Id = 96, StudentId = 32, SubjectId = 12, GradeNumber = 1 },
                new Grade { Id = 97, StudentId = 33, SubjectId = 1, GradeNumber = 10 },
                new Grade { Id = 98, StudentId = 33, SubjectId = 2, GradeNumber = 9 },
                new Grade { Id = 99, StudentId = 33, SubjectId = 3, GradeNumber = 8 },
                new Grade { Id = 100, StudentId = 34, SubjectId = 10, GradeNumber = 0 },
                new Grade { Id = 101, StudentId = 34, SubjectId = 11, GradeNumber = 6 },
                new Grade { Id = 102, StudentId = 34, SubjectId = 12, GradeNumber = 4 },
                new Grade { Id = 103, StudentId = 35, SubjectId = 10, GradeNumber = 0 },
                new Grade { Id = 104, StudentId = 35, SubjectId = 11, GradeNumber = 0 },
                new Grade { Id = 105, StudentId = 35, SubjectId = 12, GradeNumber = 2 },
                new Grade { Id = 106, StudentId = 36, SubjectId = 10, GradeNumber = 4 },
                new Grade { Id = 107, StudentId = 36, SubjectId = 11, GradeNumber = 2 },
                new Grade { Id = 108, StudentId = 36, SubjectId = 12, GradeNumber = 6 },
                new Grade { Id = 109, StudentId = 37, SubjectId = 7, GradeNumber = 8 },
                new Grade { Id = 110, StudentId = 37, SubjectId = 8, GradeNumber = 3 },
                new Grade { Id = 111, StudentId = 37, SubjectId = 9, GradeNumber = 3 },
                new Grade { Id = 112, StudentId = 38, SubjectId = 4, GradeNumber = 5 },
                new Grade { Id = 113, StudentId = 38, SubjectId = 5, GradeNumber = 6 },
                new Grade { Id = 114, StudentId = 38, SubjectId = 6, GradeNumber = 8 },
                new Grade { Id = 115, StudentId = 39, SubjectId = 1, GradeNumber = 0 },
                new Grade { Id = 116, StudentId = 39, SubjectId = 2, GradeNumber = 1 },
                new Grade { Id = 117, StudentId = 39, SubjectId = 3, GradeNumber = 6 },
                new Grade { Id = 118, StudentId = 40, SubjectId = 10, GradeNumber = 5 },
                new Grade { Id = 119, StudentId = 40, SubjectId = 11, GradeNumber = 10 },
                new Grade { Id = 120, StudentId = 40, SubjectId = 12, GradeNumber = 8 },
                new Grade { Id = 121, StudentId = 41, SubjectId = 4, GradeNumber = 5 },
                new Grade { Id = 122, StudentId = 41, SubjectId = 5, GradeNumber = 9 },
                new Grade { Id = 123, StudentId = 41, SubjectId = 6, GradeNumber = 1 },
                new Grade { Id = 124, StudentId = 42, SubjectId = 4, GradeNumber = 8 },
                new Grade { Id = 125, StudentId = 42, SubjectId = 5, GradeNumber = 6 },
                new Grade { Id = 126, StudentId = 42, SubjectId = 6, GradeNumber = 3 },
                new Grade { Id = 127, StudentId = 43, SubjectId = 10, GradeNumber = 7 },
                new Grade { Id = 128, StudentId = 43, SubjectId = 11, GradeNumber = 10 },
                new Grade { Id = 129, StudentId = 43, SubjectId = 12, GradeNumber = 0 },
                new Grade { Id = 130, StudentId = 44, SubjectId = 10, GradeNumber = 6 },
                new Grade { Id = 131, StudentId = 44, SubjectId = 11, GradeNumber = 1 },
                new Grade { Id = 132, StudentId = 44, SubjectId = 12, GradeNumber = 8 },
                new Grade { Id = 133, StudentId = 45, SubjectId = 4, GradeNumber = 8 },
                new Grade { Id = 134, StudentId = 45, SubjectId = 5, GradeNumber = 1 },
                new Grade { Id = 135, StudentId = 45, SubjectId = 6, GradeNumber = 3 },
                new Grade { Id = 136, StudentId = 46, SubjectId = 10, GradeNumber = 0 },
                new Grade { Id = 137, StudentId = 46, SubjectId = 11, GradeNumber = 6 },
                new Grade { Id = 138, StudentId = 46, SubjectId = 12, GradeNumber = 5 },
                new Grade { Id = 139, StudentId = 47, SubjectId = 7, GradeNumber = 7 },
                new Grade { Id = 140, StudentId = 47, SubjectId = 8, GradeNumber = 4 },
                new Grade { Id = 141, StudentId = 47, SubjectId = 9, GradeNumber = 10 },
                new Grade { Id = 142, StudentId = 48, SubjectId = 10, GradeNumber = 3 },
                new Grade { Id = 143, StudentId = 48, SubjectId = 11, GradeNumber = 2 },
                new Grade { Id = 144, StudentId = 48, SubjectId = 12, GradeNumber = 7 },
                new Grade { Id = 145, StudentId = 49, SubjectId = 7, GradeNumber = 9 },
                new Grade { Id = 146, StudentId = 49, SubjectId = 8, GradeNumber = 10 },
                new Grade { Id = 147, StudentId = 49, SubjectId = 9, GradeNumber = 6 },
                new Grade { Id = 148, StudentId = 50, SubjectId = 10, GradeNumber = 10 },
                new Grade { Id = 149, StudentId = 50, SubjectId = 11, GradeNumber = 9 },
                new Grade { Id = 150, StudentId = 50, SubjectId = 12, GradeNumber = 5 }
                );


        }
    }
}

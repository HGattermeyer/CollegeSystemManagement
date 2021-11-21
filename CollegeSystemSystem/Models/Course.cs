﻿namespace CollegeSystemSystem.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string CourseName { get; set; }
        public IEnumerable<Student> Students { get; set; } = new List<Student>();
        public IEnumerable<Subject> Subjects { get; set; } = new List<Subject>();

        public Course()
        {

        }

        public Course(int id, string courseName)
        {
            Id = id;
            CourseName = courseName;
        }
    }
}
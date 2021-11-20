﻿namespace CollegeSystemSystem.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public double GradeNumber { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public Subject Subject { get; set; }
        public int SubjectId { get; set; }

        public Grade()
        {

        }

    }
}

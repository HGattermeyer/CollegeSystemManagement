namespace CollegeSystemSystem.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public Double? GradeNumber { get; set; }
        public Student Student { get; set; }
        public int StudentId { get; set; }
        public Subject Subject { get; set; }
        public int SubjectId { get; set; }

        public Grade()
        {

        }

        public Grade(int id, double gradeNumber, Student student, Subject subject)
        {
            Id = id;
            GradeNumber = gradeNumber;
            Student = student;
            Subject = subject;

            SubjectId = Subject.Id;
            StudentId = Student.Id;
        }

        public Grade(int id, Student student, Subject subject)
        {
            Id = id;
            Student = student;
            Subject = subject;

            SubjectId = Subject.Id;
            StudentId = Student.Id;
        }
    }
}

namespace CollegeSystemSystem.Models
{
    public class Student : Person
    {
        public DateTime BirthDate { get; set; }
        public Course? Course { get; set; }
        public int CourseId { get; set; }

        public Student()
        {

        }

        public Student(int id, string name, DateTime birthDate, Course course)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            Course = course;
        }
    }
}

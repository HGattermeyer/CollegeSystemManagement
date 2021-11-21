namespace CollegeSystemSystem.Models
{
    public class Student : Person
    {        
        public Course? Course { get; set; }
        public int CourseId { get; set; }
        public IEnumerable<Grade> Grades { get; set; } = new List<Grade>();

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

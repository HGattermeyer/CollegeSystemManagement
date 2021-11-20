namespace CollegeSystemSystem.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; } 
        public IEnumerable<Grade> Grades { get; set; } = new List<Grade>();
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }

        public Subject()
        {
        }

        public Subject(int id, string subjectName, Teacher teacher, Course course)
        {
            Id = id;
            SubjectName = subjectName;
            Teacher = teacher;
            Course = course;
        }
    }
}

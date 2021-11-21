namespace CollegeSystemSystem.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public Course? Course { get; set; }
        public int CourseId { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
        public IEnumerable<Grade> Grades { get; set; } = new List<Grade>();

        public Subject()
        {

        }

        public Subject(int id, string subjectName, Course course, Teacher teacher)
        {
            Id = id;
            SubjectName = subjectName;
            Course = course;
            Teacher = teacher;
        }
    }
}

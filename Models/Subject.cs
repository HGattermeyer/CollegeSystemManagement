namespace CollegeSystemSystem.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public Course? Course { get; set; }
        public int CourseId { get; set; }

        public Subject()
        {

        }

        public Subject(int id, string subjectName, Course course)
        {
            Id = id;
            SubjectName = subjectName;
            Course = course;
        }
    }
}

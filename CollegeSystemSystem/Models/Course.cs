using System.ComponentModel.DataAnnotations;

namespace CollegeSystemSystem.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Display(Name="Course")]
        [Required(ErrorMessage="{0} is required.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}.")]
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
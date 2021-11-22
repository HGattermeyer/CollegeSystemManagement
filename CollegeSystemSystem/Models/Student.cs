using System.ComponentModel.DataAnnotations;

namespace CollegeSystemSystem.Models
{
    public class Student
    {
        [Display(Name = "Student ID")]

        public int Id { get; set; }
        [Display(Name = "Student Name")]
        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}.")]

        public string Name { get; set; }

        [Required(ErrorMessage = "{0} required.")]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }
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

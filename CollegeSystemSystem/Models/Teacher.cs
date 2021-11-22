using System.ComponentModel.DataAnnotations;

namespace CollegeSystemSystem.Models
{
    public class Teacher : Person
    {
        
        public int Id { get; set; }

        [Display(Name = "Teacher Name")]
        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} required.")]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} required.")]
        [Display(Name = "Wage")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} should be between {2} and {1}")]

        public double Wage { get; set; }
        public IEnumerable<Subject> Subjects { get; set; } = new List<Subject>();

        public Teacher()
        {

        }

        public Teacher(int id, string name, double wage)
        {
            Id = id;
            Name = name;
            Wage = wage;
        }
    }
}

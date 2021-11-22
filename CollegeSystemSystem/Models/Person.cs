using System.ComponentModel.DataAnnotations;

namespace CollegeSystemSystem.Models
{
    public class Person
    {

        public int Id { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "{0} is required.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}.")]
        public string Name { get; set; }
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }
    }
}

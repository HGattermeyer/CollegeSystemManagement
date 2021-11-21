namespace CollegeSystemSystem.Models.ViewModels
{
    public class StudentFormViewModel
    {
        public Student Student { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}

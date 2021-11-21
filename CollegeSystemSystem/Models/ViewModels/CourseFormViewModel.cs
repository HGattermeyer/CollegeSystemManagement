namespace CollegeSystemSystem.Models.ViewModels
{
    public class CourseFormViewModel
    {
        public Course Course { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}

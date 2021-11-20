namespace CollegeSystemSystem.Models
{
    public class Teacher : Person
    {
        public Double Wage { get; set; }
        public IEnumerable<Subject> Subjects { get; set; } = new List<Subject>();

        public Teacher()
        {

        }

        public Teacher(int id, int name, Double wage, Subject subject)
        {
            Id = id;
            Name = Name;
            Wage = wage;
        }


    }


}

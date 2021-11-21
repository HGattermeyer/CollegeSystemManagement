namespace CollegeSystemSystem.Models
{
    public class Teacher : Person
    {
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

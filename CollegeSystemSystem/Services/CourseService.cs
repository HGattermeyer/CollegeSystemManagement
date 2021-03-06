using CollegeSystemSystem.Data;
using CollegeSystemSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CollegeSystemSystem.Services
{
    public class CourseService
    {
        private readonly CollegeSystemDbContext _context;

        public CourseService(CollegeSystemDbContext context)
        {
            _context = context;
        }

        public async Task<List<Course>> FindAllAsync()
        {
            return await _context.Course.ToListAsync();

        }

        public async Task<Course> FindByIdAsync(int id) => await _context.Course.
                Include(s => s.Students).ThenInclude(g => g.Grades).
                Include(u => u.Subjects).ThenInclude(t => t.Teacher).
                Where(x => x.Id == id).SingleOrDefaultAsync();

        //public async Task<Course> FindByIdAsync(int id) => await _context.Course.
        //Include(s => s.Students).ThenInclude(g => g.Grades).
        //Include(u => u.Subjects).ThenInclude(x => x.Id).
        //FirstOrDefaultAsync(obj => obj.Id == id);


        public Course FindById(int id)
        {
            return _context.Course.FirstOrDefault(obj => obj.Id == id);
        }

    }
}

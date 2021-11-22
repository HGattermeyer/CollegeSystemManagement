using CollegeSystemSystem.Data;
using CollegeSystemSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CollegeSystemSystem.Services
{
    public class StudentService
    {
        private readonly CollegeSystemDbContext _context;

        public StudentService(CollegeSystemDbContext context)
        {
            _context = context;
        }

        public async Task<List<Student>> FindAllAsync()
        {
            return await _context.Student.ToListAsync();
        }

        public async Task<List<Student>> FindAllByCourseIdAsync(int id)
        {
            return await _context.Student.Where(obj => obj.CourseId == id).Include(g => g.Grades).ToListAsync();
        }

        public async Task<Student> FindByIdAsync(int id)
        {
            return await _context.Student.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}

using CollegeSystemSystem.Data;
using CollegeSystemSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CollegeSystemSystem.Services
{
    public class TeacherService
    {
        private readonly CollegeSystemDbContext _context;

        public TeacherService(CollegeSystemDbContext context)
        {
            _context = context;
        }

        public async Task<List<Teacher>> FindAllAsync() { return await _context.Teacher.ToListAsync(); }

        public async Task<Teacher> FindByIdAsync(int id)
        {
            return await _context.Teacher.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public Teacher FindById(int id)
        {
            return _context.Teacher.FirstOrDefault(obj => obj.Id == id);
        }
    }
}

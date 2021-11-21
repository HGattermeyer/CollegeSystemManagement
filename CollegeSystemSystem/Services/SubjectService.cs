using CollegeSystemSystem.Data;
using CollegeSystemSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CollegeSystemSystem.Services
{
    public class SubjectService
    {
        private readonly CollegeSystemDbContext _context;

        public SubjectService(CollegeSystemDbContext context)
        {
            _context = context;
        }

        public async Task<List<Subject>> FindAllAsync()
        {
            return await _context.Subject.ToListAsync();
        }

        public async Task<Subject> FindByIdAsync(int id)
        {
            return await _context.Subject.FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task<List<Subject>> FindByCourseIdAsync(int id)
        {
            return await _context.Subject.Where(obj => obj.CourseId == id).ToListAsync();
        }


    }
}

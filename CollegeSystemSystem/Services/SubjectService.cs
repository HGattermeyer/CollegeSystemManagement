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
    }
}

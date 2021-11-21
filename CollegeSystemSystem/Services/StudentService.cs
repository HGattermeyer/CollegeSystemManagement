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
    }
}

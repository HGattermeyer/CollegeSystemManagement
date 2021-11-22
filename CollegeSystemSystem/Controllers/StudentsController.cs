using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CollegeSystemSystem.Data;
using CollegeSystemSystem.Models;
using CollegeSystemSystem.Services;
using CollegeSystemSystem.Models.ViewModels;
using System.Diagnostics;

namespace CollegeSystemSystem.Controllers
{
    public class StudentsController : Controller
    {
        private readonly CollegeSystemDbContext _context;
        private readonly CourseService _courseService;
        private readonly StudentService _studentService;
        private readonly GradeService _gradeService;

        public StudentsController(CollegeSystemDbContext context, CourseService courseService, StudentService studentService, GradeService gradeService)
        {
            _context = context;
            _courseService = courseService;
            _studentService = studentService;
            _gradeService = gradeService;
        }

        // GET: Students
        public async Task<IActionResult> Index()
        {
            var students = await _studentService.FindAllAsync();

            students.ForEach(student => student.Course = _courseService.FindById(student.CourseId));
            return View(students);
        }

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student student = await _context.Student
                .Include(c => c.Course)
                .Include(g => g.Grades)
                .ThenInclude(s => s.Subject)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public async Task<IActionResult> Create()
        {
            var courses = await _courseService.FindAllAsync();
            var viewModel = new StudentFormViewModel { Courses = courses };
            return View(viewModel);
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BirthDate,Id,Name,CourseId")] Student student)
        {
            student.Course = await _courseService.FindByIdAsync(student.CourseId);
                        
            ModelState.Clear();
            TryValidateModel(student);

            if (!ModelState.IsValid)
            {
                return View(nameof(Index));
            }

            _context.Add(student);
            await _context.SaveChangesAsync();

            // Bind the Student with subjects and grades (empty at beginning)
            await _gradeService.InsertGradeByCourse(student);

            return RedirectToAction(nameof(Index));
            
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FindAsync(id);
            student.Course = await _courseService.FindByIdAsync(student.CourseId);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BirthDate,Id,Name,CourseId")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try { 
            var student = await _context.Student.FindAsync(id);
            _context.Student.Remove(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            }

            catch (DbUpdateException e)
            {
                return RedirectToAction(nameof(Error), new { message = "The student is binded to the courses and grade, please delete them first." });
            }
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier

            };

            return View(viewModel);
        }
        private bool StudentExists(int id)
        {
            return _context.Student.Any(e => e.Id == id);
        }
    }
}

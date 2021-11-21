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

namespace CollegeSystemSystem.Controllers
{
    public class GradesController : Controller
    {
        private readonly CollegeSystemDbContext _context;
        private readonly StudentService _studentService;
        private readonly SubjectService _subjectService;
        private readonly TeacherService _teacherService;

        public GradesController(CollegeSystemDbContext context, StudentService studentService, SubjectService subjectService, TeacherService teacherService)
        {
            _context = context;
            _studentService = studentService;
            _subjectService = subjectService;
            _teacherService = teacherService;
        }

        // GET: Grades
        public async Task<IActionResult> Index()
        {
            var collegeSystemDbContext = _context.Grade.Include(g => g.Student).Include(g => g.Subject);
            return View(await collegeSystemDbContext.ToListAsync());
        }

        // GET: Grades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grade = await _context.Grade
                .Include(g => g.Student)
                .Include(g => g.Subject)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grade == null)
            {
                return NotFound();
            }

            return View(grade);
        }

        // GET: Grades/Create
        public IActionResult Create()
        {
            ViewData["StudentId"] = new SelectList(_context.Student, "Id", "Id");
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Id");
            return View();
        }

        // POST: Grades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GradeNumber,StudentId,SubjectId")] Grade grade)
        {
            grade.Student = await _studentService.FindByIdAsync(grade.StudentId);
            List<Subject> subjects = await _subjectService.FindByCourseIdAsync(grade.Student.CourseId);



            foreach (Subject subject in subjects)
            {
                grade.Id = 0;
                grade.SubjectId = subject.Id;
                grade.Subject = await _subjectService.FindByIdAsync(grade.SubjectId);
                grade.Subject.Teacher = await _teacherService.FindByIdAsync(grade.Subject.TeacherId);
                ModelState.Clear();
                TryValidateModel(grade);

                if (!ModelState.IsValid)
                {
                    ViewData["StudentId"] = new SelectList(_context.Student, "Id", "Id", grade.StudentId);
                    ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Id", grade.SubjectId);
                    return View(grade);

                }

                _context.Add(grade);
                await _context.SaveChangesAsync();
            }


            return RedirectToAction(nameof(Index));

        }

        // GET: Grades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grade = await _context.Grade.FindAsync(id);
            grade.Student = await _studentService.FindByIdAsync(grade.StudentId);
            grade.Subject = await _subjectService.FindByIdAsync(grade.SubjectId);
            if (grade == null)
            {
                return NotFound();
            }

            return View(grade);
        }

        // POST: Grades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,GradeNumber,StudentId,SubjectId")] Grade grade)
        {
            if (id != grade.Id)
            {
                return NotFound();
            }

            grade.Student = await _studentService.FindByIdAsync(grade.StudentId);
            grade.Subject = await _subjectService.FindByIdAsync(grade.SubjectId);
            grade.Subject.Teacher = await _teacherService.FindByIdAsync(grade.Subject.TeacherId);

            grade.StudentId = grade.Student.Id;
            grade.SubjectId = grade.Subject.Id;

            ModelState.Clear();
            TryValidateModel(grade);

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(grade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GradeExists(grade.Id))
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
            ViewData["StudentId"] = new SelectList(_context.Student, "Id", "Id", grade.StudentId);
            ViewData["SubjectId"] = new SelectList(_context.Subject, "Id", "Id", grade.SubjectId);
            return View(grade);
        }

        // GET: Grades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var grade = await _context.Grade
                .Include(g => g.Student)
                .Include(g => g.Subject)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (grade == null)
            {
                return NotFound();
            }

            return View(grade);
        }

        // POST: Grades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var grade = await _context.Grade.FindAsync(id);
            _context.Grade.Remove(grade);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GradeExists(int id)
        {
            return _context.Grade.Any(e => e.Id == id);
        }
    }
}

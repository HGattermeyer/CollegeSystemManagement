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
    public class SubjectsController : Controller
    {
        private readonly CollegeSystemDbContext _context;
        private readonly SubjectService _subjectService;
        private readonly CourseService _courseService;
        private readonly TeacherService _teacherService;

        public SubjectsController(CollegeSystemDbContext context, SubjectService subjectService, CourseService courseSubject, TeacherService teacherSubject)
        {
            _context = context;
            _subjectService = subjectService;
            _courseService = courseSubject;
            _teacherService = teacherSubject;
        }

        // GET: Subjects
        public async Task<IActionResult> Index()
        {
            var collegeSystemDbContext = _context.Subject.Include(s => s.Course).Include(t => t.Teacher);
            return View(await collegeSystemDbContext.ToListAsync());
        }

        // GET: Subjects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subject = await _context.Subject
                .Include(s => s.Course)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subject == null)
            {
                return NotFound();
            }

            return View(subject);
        }

        // GET: Subjects/Create
        public IActionResult Create()
        {
            ViewData["CourseName"] = new SelectList(_context.Course, "Id", "CourseName");
            ViewData["TeacherName"] = new SelectList(_context.Teacher, "Id", "Name");
            return View();
        }

        // POST: Subjects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SubjectName,CourseId,TeacherId")] Subject subject)
        {
            subject.Course = _courseService.FindById(subject.CourseId); ;
            subject.Teacher = _teacherService.FindById(subject.TeacherId); ; ;

            ModelState.Clear();
            TryValidateModel(subject);

            if (ModelState.IsValid)
            {
                _context.Add(subject);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Course, "Id", "Id", subject.CourseId);
            ViewData["TeacherId"] = new SelectList(_context.Teacher, "Id", "Id", subject.TeacherId);
            return View(subject);
        }

        // GET: Subjects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subject = await _context.Subject.FindAsync(id);
            if (subject == null)
            {
                return NotFound();
            }
            ViewData["CourseName"] = new SelectList(_context.Course, "Id", "CourseName", subject.CourseId);
            ViewData["TeacherName"] = new SelectList(_context.Teacher, "Id", "Name", subject.TeacherId);

            return View(subject);
        }

        // POST: Subjects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SubjectName,CourseId,TeacherId")] Subject subject)
        {
            if (id != subject.Id)
            {
                return NotFound();
            }

            subject.Course = _courseService.FindById(subject.CourseId); ;
            subject.Teacher = _teacherService.FindById(subject.TeacherId); ; ;

            ModelState.Clear();
            TryValidateModel(subject);

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subject);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubjectExists(subject.Id))
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
            ViewData["CourseId"] = new SelectList(_context.Course, "Id", "Id", subject.CourseId);
            ViewData["TeacherName"] = new SelectList(_context.Teacher, "Id", "Name", subject.TeacherId);
            return View(subject);
        }

        // GET: Subjects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subject = await _context.Subject
                .Include(s => s.Course)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subject == null)
            {
                return NotFound();
            }

            return View(subject);
        }

        // POST: Subjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subject = await _context.Subject.FindAsync(id);
            _context.Subject.Remove(subject);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubjectExists(int id)
        {
            return _context.Subject.Any(e => e.Id == id);
        }
    }
}

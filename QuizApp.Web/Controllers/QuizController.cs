using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizAppCore.Entities;
using QuizAppDataAccess.Context;
using QuizAppDataAccess.Services.Interfaces;

namespace QuizApp.Web.Controllers
{
    public class QuizController : Controller
    {
        private readonly IRepository<Quiz> _QuizRepository;
        private readonly ApplicationDbContext _context;

        public QuizController(IRepository<Quiz> QuizRepository, ApplicationDbContext context)
        {
            _QuizRepository = QuizRepository;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Subject> Subjects = await _context.Subjects.ToListAsync();
            ViewData["Subjects"] = Subjects;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Quiz quiz)
        {
            if (ModelState.IsValid)
            {
                await _QuizRepository.AddAsync(quiz);
                return RedirectToAction("Index");
            }
            return View(quiz);
        }


    }
}

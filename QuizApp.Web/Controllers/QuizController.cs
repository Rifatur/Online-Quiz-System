using Microsoft.AspNetCore.Mvc;
using QuizAppCore.Entities;
using QuizAppDataAccess.Services.Interfaces;

namespace QuizApp.Web.Controllers
{
    public class QuizController : Controller
    {
        private readonly IRepository<Quiz> _QuizRepository;

        public QuizController(IRepository<Quiz> QuizRepository)
        {
            _QuizRepository = QuizRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Quiz quiz)
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

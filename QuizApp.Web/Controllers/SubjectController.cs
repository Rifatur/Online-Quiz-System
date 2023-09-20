using Microsoft.AspNetCore.Mvc;
using QuizAppCore.Entities;
using QuizAppDataAccess.Services.Interfaces;

namespace QuizApp.Web.Controllers
{
    public class SubjectController : Controller
    {
        private readonly IRepository<Subject> _SubjectRepository;

        public SubjectController(IRepository<Subject> SubjectRepository)
        {
            _SubjectRepository = SubjectRepository;
        }
        public async Task<IActionResult> Index()
        {
            var Subject = await _SubjectRepository.GetAllAsync();
            return View(Subject);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Subject subject)
        {
            if (ModelState.IsValid)
            {
                await _SubjectRepository.AddAsync(subject);
                return RedirectToAction("Index");
            }
            return View(subject);
        }


    }
}

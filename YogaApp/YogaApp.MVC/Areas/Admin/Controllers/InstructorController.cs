using Microsoft.AspNetCore.Mvc;
using YogaApp.Business.Abstract;
using YogaApp.Entity.Concrete;

namespace YogaApp.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class InstructorController : Controller
    {
        private readonly IInstructorService _ınstructorManager;

        public InstructorController(IInstructorService ınstructorManager)
        {
            _ınstructorManager = ınstructorManager;
        }

        public async Task<IActionResult> Index()
        {
            List<Instructor> instructorList = await _ınstructorManager.GetAllAsync();
            return View(instructorList);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            Instructor ınstructor = await _ınstructorManager.GetByIdAsync(id);
            if (ınstructor == null)
            {
                return NotFound();
            }
            ınstructor.IsActive = !ınstructor.IsActive;
            ınstructor.ModifiedDate = DateTime.Now;
            _ınstructorManager.Update(ınstructor);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}

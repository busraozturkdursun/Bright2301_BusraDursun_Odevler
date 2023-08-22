using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using YogaApp.Business.Abstract;


namespace YogaApp.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInstructorService _ınstructorManager;

        public HomeController(IInstructorService ınstructorManager)
        {
            _ınstructorManager = ınstructorManager;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _ınstructorManager.GetInstructorCategoryAllAsync();
            return View(result);
        }
        public  async Task<IActionResult> Detail(int id)
        {
            var model = await _ınstructorManager.GetByIdAsync(id);
            return View(model);
        }

        public IActionResult Yoga()
        {
            return View();
        }


    }
}
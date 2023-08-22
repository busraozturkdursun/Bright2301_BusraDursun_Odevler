using Microsoft.AspNetCore.Mvc;
using YogaApp.Business.Abstract;
using YogaApp.Business.Concrete;
using YogaApp.Entity.Concrete;

namespace YogaApp.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryManager;
        private readonly IInstructorService _ınstructorManager;

        public CategoryController(ICategoryService categoryManager, IInstructorService ınstructorManager)
        {
            _categoryManager = categoryManager;
            _ınstructorManager = ınstructorManager;
        }


        public async Task<IActionResult> InstructorList(string categoryurl = null)
        {
            List<Instructor> instructorList = await _ınstructorManager.GetAllActiveCategoriesAsync(categoryurl);
            return View(instructorList);
        }
    }
}

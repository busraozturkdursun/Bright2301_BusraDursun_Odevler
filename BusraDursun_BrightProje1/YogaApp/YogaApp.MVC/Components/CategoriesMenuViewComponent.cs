using Microsoft.AspNetCore.Mvc;
using YogaApp.Business.Abstract;

namespace YogaApp.MVC.Components
{
    public class CategoriesMenuViewComponent :ViewComponent
    {
        private readonly ICategoryService _categoryManager;

        public CategoriesMenuViewComponent(ICategoryService categoryManager)
        {
            _categoryManager = categoryManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await _categoryManager.GetAllAsync();
            return View(categories);
        }
    }
}

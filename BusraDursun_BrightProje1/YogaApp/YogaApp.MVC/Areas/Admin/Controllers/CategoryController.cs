using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using YogaApp.Business.Abstract;
using YogaApp.Business.Concrete;
using YogaApp.Core;
using YogaApp.Entity.Concrete;
using YogaApp.MVC.Areas.Admin.Models;

namespace YogaApp.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryManager;
        private readonly INotyfService _notyf;

        public CategoryController(ICategoryService categoryManager, INotyfService notyf)
        {
            _categoryManager = categoryManager;
            _notyf = notyf;
        }

        #region AllList
        public async Task<IActionResult> Index()
        {
            List<Category> categories = await _categoryManager.GetAllCategoryAsync(false);
            return View(categories);
        }

        #endregion
        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryAddViewModel categoryAddViewModel)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category
                {
                    Name = categoryAddViewModel.Name,
                    Url = Jobs.GetUrl(categoryAddViewModel.Name)
                };
                await _categoryManager.CreateAsync(category);
                _notyf.Success("Yeni kategori başarıyla eklendi.");
                return RedirectToAction("Index");
            }
            return View(categoryAddViewModel);
        }
        #endregion
        #region Update
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var result = await _categoryManager.GetByIdAsync(id);
            return View(result);
        }

        [HttpPost]

        [HttpPost]
        public async Task<IActionResult> Update(Category category)
        {
            Category _category = await _categoryManager.GetByIdAsync(category.Id);
            _category.Name = category.Name;
            category.Url = Jobs.GetUrl(category.Name) ;
            _category.Url = category.Url;
            _category.IsActive = category.IsActive;
            _category.ModifiedDate = DateTime.Now;
            _categoryManager.Update(_category);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> UpdateIsActive(int id)
        {
            Category category = await _categoryManager.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            category.IsActive = !category.IsActive;
            category.ModifiedDate = DateTime.Now;
            _categoryManager.Update(category);
            return RedirectToAction("Index");
        }
        #endregion
        #region Delete
        [HttpGet]
        public async Task<IActionResult> SoftDelete(int id)
        {
            Category category = await _categoryManager.GetByIdAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            category.IsDeleted = !category.IsDeleted;
            category.ModifiedDate = DateTime.Now;
            _categoryManager.Update(category);
            _notyf.Success("Kayıt veritabanından geçici olarak silindi.");
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> HardDelete(int id)
        {
            Category category = await _categoryManager.GetByIdAsync(id);
            if (category == null) return NotFound();
            _categoryManager.Delete(category);
            _notyf.Success("Kayıt veritabanından kalıcı olarak silindi.");
            return RedirectToAction("Index");
        }

        #endregion
      



    }

}

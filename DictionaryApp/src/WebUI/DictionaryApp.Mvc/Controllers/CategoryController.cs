using DictionaryApp.DataTransferObjects.Requests;
using DictionaryApp.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace DictionaryApp.Mvc.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var categories =await _categoryService.GetCategoryDisplayResponseAsync();
            return View(categories);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateNewCategoryRequest newCategoryRequest)
        {
            if (ModelState.IsValid )
            {
                await _categoryService.CreateNewCategoryAsync(newCategoryRequest);
                return RedirectToAction("Index","Category");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var category = _categoryService.GetCategoryForUpdateAsync(id);
            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,UpdateCategoryRequest updateCategoryRequest)
        {
            if (await _categoryService.CategoryIsExistAsync(id))
            {
                if (ModelState.IsValid)
                {
                    await _categoryService.UpdateCategoryAsync(updateCategoryRequest);
                    return RedirectToAction("Index");
                }
                return View();
            }
            return NotFound();
        }
    }
}

using DictionaryApp.DataTransferObjects.Requests;
using DictionaryApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DictionaryApp.Mvc.Controllers
{
    public class ContentController : Controller
    {
        private readonly IContentService _contentService;
        private readonly ICategoryService _categoryService;
        private readonly IAuthorService _authorService;

        public ContentController(IContentService contentService, ICategoryService categoryService, IAuthorService authorService)
        {
            _contentService = contentService;
            _categoryService = categoryService;
            _authorService = authorService;
        }

        public async Task<IActionResult> Index()
        {
            var contents = await _contentService.GetContentDisplayResponseAsync();
            return View(contents);
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = GetCategoriesForSelectList();
            ViewBag.Authors = GetAuthorsForSelectList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateNewContentRequest newContentRequest)
        {
            if (ModelState.IsValid)
            {
                await _contentService.CreateNewContentAsync(newContentRequest);
                return RedirectToAction("Index", "Content");
            }
            ViewBag.Categories = GetCategoriesForSelectList();
            ViewBag.Authors = GetAuthorsForSelectList();
            return View();
        }

        private IEnumerable<SelectListItem> GetAuthorsForSelectList()
        {
            var authors = _authorService.GetAuthorDisplayResponses().Select(author => new SelectListItem
            {
                Text = author.FullName,
                Value = author.Id.ToString()
            });
            return authors;
        }

        private IEnumerable<SelectListItem> GetCategoriesForSelectList()
        {
            var categories = _categoryService.GetCategoryDisplayResponses().Select(category => new SelectListItem
            {
                Text = category.CategoryName,
                Value = category.Id.ToString()
            });
            return categories;
        }
    }
}

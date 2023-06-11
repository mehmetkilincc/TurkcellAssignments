using DictionaryApp.DataTransferObjects.Requests;
using DictionaryApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DictionaryApp.Mvc.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public async Task<IActionResult> Index()
        {
            var authors = await _authorService.GetAuthorDisplayResponseAsync();
            return View(authors);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateNewAuthorRequest newAuthorRequest)
        {
            if (ModelState.IsValid)
            {
                await _authorService.CreateNewAuthorAsync(newAuthorRequest);
                return RedirectToAction("Index", "Author");
            }
            return View();
        }
    }
}

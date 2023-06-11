using DictionaryApp.Mvc.Models;
using DictionaryApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DictionaryApp.Mvc.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string? targetPage)
        {
            ViewBag.ReturnUrl = targetPage;
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserLoginViewModel userLogin,string targetPage)
        {
            //if(ModelState.IsValid)
            //{
            //    var user = _userService.ValidateUser(userLogin.UserName, userLogin.Password);
            //    if (user != null)
            //    {
            //        return 0;
            //    }
            //    ModelState.AddModelError("login", "Kullanıcı Adı veya Şifre Hatalı!");
            //}
            //return View();
            return View();
        }
    }
}

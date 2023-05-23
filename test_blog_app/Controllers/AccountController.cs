using Microsoft.AspNetCore.Mvc;
using test_blog_app.Models;

namespace test_blog_app.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(UserRegistrationModel userModel)
        {
            return View();
        }
    }
}

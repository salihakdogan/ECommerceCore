using ECommerceCore.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class LoginController : Controller
    {
        private readonly SignInManager<User> _signInManager;

        public LoginController(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel user)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Account", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid password or e-mail");
                }
            }
            return View();
        }
    }
}

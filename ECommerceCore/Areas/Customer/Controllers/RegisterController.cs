using ECommerceCore.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class RegisterController : Controller
    {
        private readonly UserManager<User> _userManager;
        public RegisterController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel prm)
        {
            if (ModelState.IsValid)
            {
                User newuser = new User()
                {
                    Email = prm.Email,
                    Name = prm.Name,
                    LastName = prm.LastName,
                    UserName = prm.Email
                    
                };

                if (prm.Password == prm.ConfirmPassword)
                {
                    var result = await _userManager.CreateAsync(newuser, prm.Password);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Login");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }     
            }
            return View();
        }
    }
}
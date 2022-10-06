using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

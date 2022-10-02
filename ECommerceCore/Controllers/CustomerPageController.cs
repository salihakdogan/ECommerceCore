using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.Controllers
{
    public class CustomerPageController : Controller
    {
        public IActionResult HomePage()
        {
            return View();
        }
    }
}
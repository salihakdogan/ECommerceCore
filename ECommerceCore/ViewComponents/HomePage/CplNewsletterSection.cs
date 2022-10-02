using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.CustomerPage
{
    public class CplNewsletterSection : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

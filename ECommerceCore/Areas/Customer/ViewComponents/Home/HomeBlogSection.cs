using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.CustomerPage.HomePage
{
    public class HomeBlogSection : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

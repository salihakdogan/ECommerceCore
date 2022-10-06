using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.CustomerPage.HomePage
{
    public class HomeShippingSection : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

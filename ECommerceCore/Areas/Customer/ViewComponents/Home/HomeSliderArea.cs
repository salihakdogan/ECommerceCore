using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.CustomerPage.HomePage
{
    public class HomeSliderArea : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

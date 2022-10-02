using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.CustomerPage
{
    public class HpShippingSection : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

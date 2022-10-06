using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.CustomerPage.CustomerPageLayout
{
    public class LayoutNewsletterSection : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

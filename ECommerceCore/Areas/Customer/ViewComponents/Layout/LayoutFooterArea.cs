using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.CustomerPage.CustomerPageLayout
{
    public class LayoutFooterArea : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

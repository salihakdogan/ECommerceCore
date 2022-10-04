using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.CustomerPage.ProductDetails.ProductDetailsTab
{
    public class PdTabTags : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
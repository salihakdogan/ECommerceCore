using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.CustomerPage.ProductDetails.ProductDetailsTab
{
    public class PdTabDescription : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
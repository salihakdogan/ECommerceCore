using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.Areas.Customer.ViewComponents.Product
{
    public class ProductTabTags : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
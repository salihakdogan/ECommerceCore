using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.Areas.Customer.ViewComponents.Product
{
    public class ProductTabReviews : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
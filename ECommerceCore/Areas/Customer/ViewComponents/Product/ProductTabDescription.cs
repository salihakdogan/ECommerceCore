using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.Areas.Customer.ViewComponents.Product
{
    public class ProductTabDescription : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
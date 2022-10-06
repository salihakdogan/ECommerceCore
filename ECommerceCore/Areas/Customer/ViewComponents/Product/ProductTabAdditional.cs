using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.Areas.Customer.ViewComponents.Product
{
    public class ProductTabAdditional : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
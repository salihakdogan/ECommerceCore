using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.Areas.Customer.ViewComponents.Product
{
    public class ProductTabQuestions : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.CustomerPage.ProductDetails.ProductDetailsTab
{
    public class PdTabQuestions : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
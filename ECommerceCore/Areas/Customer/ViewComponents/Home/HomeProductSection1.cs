using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.CustomerPage.HomePage
{
    public class HomeProductSection1 : ViewComponent
    {
        ProductManager pmanager = new ProductManager(new EfProductDal());
        public IViewComponentResult Invoke()
        {
            var values = pmanager.TGetList();
            return View(values);
        }
    }
}

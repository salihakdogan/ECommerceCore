using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.CustomerPage.ProductDetails
{
    public class ProductBreadcrumbsArea : ViewComponent
    {
        public IViewComponentResult Invoke(int id)
        {
            ProductManager pmanager = new ProductManager(new EfProductDal());
            var values = pmanager.TGetListByID(id);
            return View(values);
        }
    }
}
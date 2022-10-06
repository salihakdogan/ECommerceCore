using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ProductController : Controller
    {
        ProductManager pmanager = new ProductManager(new EfProductDal());
        public IActionResult Index(int id)
        {
            ViewBag.productid = id;
            var values = pmanager.TGetListByID(id);
            return View(values);
        }
    }
}

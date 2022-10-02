using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.ViewComponents.CustomerPage.HomePage
{
    public class HpProductSection1CategoryName : ViewComponent
    {
        CategoryManager cmanager = new CategoryManager(new EfCategoryDal());
        public IViewComponentResult Invoke()
        {
            var values = cmanager.TGetList().OrderBy(x => x.CtgName);
            return View(values);
        }
    }
}

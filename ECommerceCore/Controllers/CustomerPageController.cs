﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceCore.Controllers
{
    public class CustomerPageController : Controller
    {
        ProductManager pmanager = new ProductManager(new EfProductDal());
        public IActionResult HomePage()
        {
            return View();
        }

        public IActionResult ProductDetails(int id)
        {
            ViewBag.productname = id;
            var values = pmanager.TGetListByID(id);
            return View(values);
        }
    }
}
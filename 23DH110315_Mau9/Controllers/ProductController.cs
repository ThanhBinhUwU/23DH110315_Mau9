﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _23DH110315_Mau9.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult ProductDetail()
        {
            return View();
        }
        public ActionResult ShoppingCart()
        {
            return View();
        }
    }
}
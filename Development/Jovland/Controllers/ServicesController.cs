﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jovland.Controllers
{
    public class ServicesController : Controller
    {
        //
        // GET: /Services/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Team()
        {
            return View();
        }
        public ActionResult Faq()
        {
            return View();
        }

    }
}

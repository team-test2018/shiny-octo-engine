﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace team_test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var a = 123;
            a += a;
            var b = 123;
            b = b + 1;
            var c = 123;
            c = c * 2;
            var d = 123;
            var e = 123;

            var f = 123;

            var g = 123;

            //sfasfasfa

            return View();
        }
    }
}
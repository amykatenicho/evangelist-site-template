﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace evangelist_site.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return RedirectToAction("Index", "ResourceGroups");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}

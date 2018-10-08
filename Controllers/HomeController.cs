﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CesarWeb.Models;

namespace CesarWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Encriptar()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Desencriptar()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

   
    }
}

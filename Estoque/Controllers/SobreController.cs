﻿using Microsoft.AspNetCore.Mvc;

namespace Estoque.Controllers
{
    public class SobreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

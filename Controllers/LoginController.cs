﻿using Microsoft.AspNetCore.Mvc;

namespace LogWorkWebSite.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
